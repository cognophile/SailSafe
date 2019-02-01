
using System;
using System.Windows.Forms;
using System.IO;

namespace SailSafe
{
    public partial class CancelBooking : Form
    {
        public static string exMessage;

        // Cite: (MSDN, 2015, Environment.GetFolderPath Method (Environment.SpecialFolder))
        // Output Stream - Specify Path
        // Static as to not create ""A field initializer cannot reference the nonstatic field, method, or property..." error.
        // Caused by attempting to assign non-static instance variable to another non-static instance variable.
        static string destPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string destFile = Path.Combine(destPath, "SailSafeLog.txt");

        public CancelBooking()
        {
            InitializeComponent();
        }

        private void btnEditHome_Click(object sender, EventArgs e)
        {
            SailSafeMenu returnHome = new SailSafeMenu();
            returnHome.Show();
            this.Hide();
        }

        /// <summary>
        /// Remove an Entry from the .txt - Cite: (Bell and Parr, 2009, Ch. 18 - Files)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveBooking_Click(object sender, EventArgs e)
        {
            string line;
            string[] words = new string[5];
            char[] seperator = { ',' };
            bool found = false;
            StreamReader inputStream;

            if (txtNameRemove.Text == "" || txtPlateRemove.Text == "")
            {
                MessageBox.Show("Error: Missing Guest Criteria.", "Missing Criteria",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                        for (int n = 0; n < words.Length; n++)
                        {
                            if (words[n].Trim().ToUpper() == txtNameRemove.Text.ToUpper())
                            {
                                // Implementaion to remove entry goes here
                                // KNOWN BUG: This will not search the line variable holding the file info,
                                //             and remove only the entry found. This also only removes the 
                                //             elements from the string, not the file. 
                                // SOLOUTION: Using a List as the input method for this function will allow
                                //              proper searching and handling of the data. However, the Split method
                                //              requires an Array. Convert List to Array? Casting?
                                //            Re-Write the words array to the text file, after removing the elements?
                                words[n].Remove(n,4);

                                
                                // Implementing via Array will only allow the set number to be removed
                                found = true;
                                inputStream.Close();
                            }
                            else
                            {
                                line = inputStream.ReadToEnd();
                            }
                        }
                    }

                    if (found == false)
                    {
                        MessageBox.Show("No record matching" + txtNameRemove + "or" + txtPlateRemove + "found. Try again.");
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
                    txtNameRemove.Text = "";
                    txtPlateRemove.Text = "";
                }
            }
        }
    }
}
