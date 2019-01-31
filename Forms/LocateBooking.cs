
using System;
using System.Windows.Forms;
using System.IO;

namespace SailSafe___1413042
{
    public partial class LocateBooking : Form
    {
        #region Instance/Static Members
        public static string exMessage;

        // Cite: (MSDN, 2015, Environment.GetFolderPath Method (Environment.SpecialFolder))
        // Output Stream - Specify Path
        // Static as to not create ""A field initializer cannot reference the nonstatic field, method, or property..." error.
        // Caused by attempting to assign non-static instance variable to another non-static instance variable.
        static string destPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string destFile = Path.Combine(destPath, "SailSafeLog.txt");
        #endregion

        public LocateBooking()
        {
            InitializeComponent();
        }

        #region Event Methods
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
            SearchForBooking();
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
                SearchForBooking();
            }
        }
        #endregion

        #region Sarch Stream Method
        public void SearchForBooking()
        {
            string line;
            string[] words = new string[5];
            char[] seperator = { ',' };
            bool found = false;
            StreamReader inputStream;

            if (txtNameLocate.Text == "" || txtPlateLocate.Text == "")
            {
                MessageBox.Show("Error: Missing Guest Criteria.");
            }
            else
            {
                try
                {
                    inputStream = File.OpenText(destFile);
                    line = inputStream.ReadToEnd();

                    while (line != null && found == false)
                    {
                        // KNOWN BUG: Due to use of array, search only works on first guest data line in txt.
                        // SOLOUTION (?): Use of generics list? use of Stack?
                        words = line.Split(seperator);
                        if (words[1].Trim().ToUpper() == txtNameLocate.Text.ToUpper()
                            && words[2].Trim().ToUpper() == txtPlateLocate.Text.ToUpper())
                        {
                            txtDisplayDate.Text = words[0].Trim();
                            txtDisplayName.Text = words[1].Trim();
                            txtDisplayPlate.Text = words[2].Trim();
                            txtDisplaySailing.Text = words[3].Trim();
                            txtDisplayVehicle.Text = words[4].Trim();
                            found = true;
                            inputStream.Close();
                        }
                        else
                        {
                            line = inputStream.ReadToEnd();
                        }
                    }

                    if (found == false)
                    {
                        MessageBox.Show("No record matching" + txtNameLocate + "or" + txtPlateLocate + "found. Try again.");
                    }
                    inputStream.Close();
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

        #endregion
    }
}
