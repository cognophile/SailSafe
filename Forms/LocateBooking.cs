
using System;
using System.Windows.Forms;
using System.IO;

using SailSafe.Intermediaries;
using System.Linq;
using System.Collections.Generic;

namespace SailSafe
{
    public partial class LocateBooking : Form
    {
        private static string exMessage;
        private BookingManager manager;

        public LocateBooking()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Button to return user to the main menu
        /// </summary>
        /// <param name="sender">btnLocateHome</param>
        /// <param name="e"></param>
        private void btnLocateHome_Click(object sender, EventArgs e)
        {
            SailSafeMenu returnHome = new SailSafeMenu();
            returnHome.Show();
            this.Hide();
        }

        /// <summary>
        /// Button to fire txt file Search operation 
        /// Cite: (Bell and Parr, 2009, Ch. 18 - Files)
        /// </summary>
        /// <param name="sender">btnLocateSearch</param>
        /// <param name="e"></param>
        private void btnLocateSearch_Click(object sender, EventArgs e)
        {
            this.DoSearch();
        }

        /// <summary>
        /// Button to reset all fields to empty - for good user experience and program cleanliness
        /// </summary>
        /// <param name="sender">btnResetSearch</param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            txtNameLocate.Clear();
            txtPlateLocate.Clear();
            txtDisplayDate.Clear();
            txtDisplayName.Clear();
            txtDisplayPlate.Clear();
            txtDisplaySailing.Clear();
            txtDisplayVehicle.Clear();
        }

        /// <summary>
        /// Method to run SearchForBooking when user presses enter key when license plate field has focus.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPlateLocate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)ConsoleKey.Enter)
            {
                this.DoSearch();
            }
        }

        private void DoSearch()
        {
            if (txtNameLocate.Text == "" || txtPlateLocate.Text == "")
            {
                MessageBox.Show("Error: Missing Guest Criteria.");
            }
            else
            {
                try
                {
                    this.manager = new BookingManager(txtNameLocate.Text, txtPlateLocate.Text);
                    var booking = this.manager.DoSearch();

                    if (booking.Any())
                    {
                        List<string> details = booking[0].Split(',').ToList<string>();

                        txtDisplayDate.Text = details[0].Trim();
                        txtDisplayName.Text = details[1].Trim();
                        txtDisplayPlate.Text = details[2].Trim();
                        txtDisplaySailing.Text = details[3].Trim();
                        txtDisplayVehicle.Text = details[4].Trim();
                    }
                    else
                    {
                        MessageBox.Show("No record matching " + txtNameLocate + " or " + txtPlateLocate + " found. Try again.");
                    }
                }
                catch (IndexOutOfRangeException outRange)
                {
                    exMessage = outRange.Message;
                    MessageBox.Show("Unable to complete operation. \n\n" + exMessage + "\n\n" +
                        "Did you mis-enter information? (eg. name into license field?) \n" +
                        "Please dismiss this message and try again.", "An Error Occurred!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    exMessage = ex.Message;
                    MessageBox.Show("Unable to complete operation. \n\n" + exMessage +
                        "\n\n Please contact your System Admin for assistance.", "An Error Occurred!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    txtNameLocate.Text = "";
                    txtPlateLocate.Text = "";
                }
            }
        }
    }
}
