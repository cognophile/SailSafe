
using System;
using System.Windows.Forms;
using System.IO;
using SailSafe.Intermediaries;

namespace SailSafe
{
    public partial class CancelBooking : Form
    {
        private static string exMessage;
        private static BookingManager manager;

        public CancelBooking()
        {
            InitializeComponent();
        }

        private void btnEditHome_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        /// <summary>
        /// Remove an Entry from the .txt - Cite: (Bell and Parr, 2009, Ch. 18 - Files)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveBooking_Click(object sender, EventArgs e)
        {
            bool success = false;

            if (txtNameRemove.Text == "" || txtPlateRemove.Text == "")
            {
                MessageBox.Show("Error: Missing Guest Criteria.", "Missing Criteria",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    manager = new BookingManager(txtNameRemove.Text, txtPlateRemove.Text);
                    success = manager.DoDelete();

                    if (success == false)
                    {
                        MessageBox.Show("No record matching" + txtNameRemove + "or" + txtPlateRemove + "found. Try again.");
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
                    txtNameRemove.Text = "";
                    txtPlateRemove.Text = "";
                }
            }
        }
    }
}
