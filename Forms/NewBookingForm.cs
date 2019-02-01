/* 
 * Author: Alex Boggis
 * SiD:    1413042
 * Edited: 13/07/15
 */
using System;
using System.Windows.Forms;
using System.IO;

namespace SailSafe
{
    public partial class NewBookingForm : Form
    {
        public NewBookingForm()
        {
            InitializeComponent();   
        }

        // Cite: (MSDN, 2015, Environment.GetFolderPath Method (Environment.SpecialFolder))
        // Output Stream - Specify Path
        // Static as to not create ""A field initializer cannot reference the nonstatic field, method, or property..." error.
        // Caused by attempting to assign non-static instance variable to another non-static instance variable.
        static string destPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string destFile = Path.Combine(destPath, "SailSafeLog.txt");

        private void button4_Click(object sender, EventArgs e)
        {
            SailSafeMenu homeButton = new SailSafeMenu();
            homeButton.Show();
            this.Hide();
        }

        /// <summary>
        /// Output Stream set to 'Save' button.
        /// </summary>
        /// <param name="sender">Save Button</param>
        /// <param name="e"></param>
        private void btnWriteStream_Click(object sender, EventArgs e)
        {   
            if (!Directory.Exists(destFile) || new FileInfo(destFile).Length == 0)
            {
                this.AppendStream();               
            }
            else
            {
                this.CreateStream();              
            }
            
        }

        /// <summary>
        /// Button to reset all fields to empty - for good user experience and program cleanliness
        /// </summary>
        /// <param name="sender"> btnResetBook </param>
        /// <param name="e"></param>
        private void btnResetBook_Click(object sender, EventArgs e)
        {
            txtBookName.Clear();
            txtLicenseBook.Clear();
            rad9amBook.Checked = false;
            rad10amBook.Checked = false;
            rad4pmBook.Checked = false;
            rad5pmBook.Checked = false;
            radCar.Checked = false;
            radVan.Checked = false;
            radLargeVehicle.Checked = false;

        }
        
        /// <summary>
        /// This method will create and open the stream, then take and place the required info in the .txt file.
        /// Cite: (Bell and Parr, 2009, Ch. 18 - Files)
        /// </summary>
        private void CreateStream()
        {
            FileStream logWriteFilePerms = new FileStream(destFile, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter outputStream = new StreamWriter(logWriteFilePerms);

            string radTimeSelected = "";
            string vehicleSelected = "";

            if (rad9amBook.Checked)
            {
                radTimeSelected = rad9amBook.Text.ToString();
            }
            else if (rad10amBook.Checked)
            {
                radTimeSelected = rad10amBook.Text.ToString();
            }
            else if (rad4pmBook.Checked)
            {
                radTimeSelected = rad4pmBook.Text.ToString();
            }
            else if (rad5pmBook.Checked)
            {
                radTimeSelected = rad5pmBook.Text.ToString();
            }

            // Check to see which Vehicle radio button is selected
            if (radCar.Checked)
            {
                vehicleSelected = radCar.Text.ToString();
            }
            else if (radVan.Checked)
            {
                vehicleSelected = radVan.Text.ToString();
            }
            else if (radLargeVehicle.Checked)
            {
                vehicleSelected = radLargeVehicle.Text.ToString(); ;
            }

            if (txtBookName != null && txtLicenseBook != null)
            {
            outputStream.WriteLine(DateTime.Now.ToString() + ", " + (txtBookName.Text.ToString() + ", " + 
                (txtLicenseBook.Text.ToString() + ", " + (radTimeSelected) + ", " + (vehicleSelected))));
            }
            else 
            {
                MessageBox.Show("Please Enter Data in all Fields!", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            outputStream.Close();
        }

        /// <summary>
        /// This method will open a stream too, and append too the .txt file.
        /// </summary>
        private void AppendStream()
        {
            using (StreamWriter appendStream = File.AppendText(destFile))
            {
                string radTimeSelected = "";
                string vehicleSelected = "";
                 
                if (rad9amBook.Checked)
                {
                    radTimeSelected = rad9amBook.Text.ToString();
                }
                else if (rad10amBook.Checked)
                {
                    radTimeSelected = rad10amBook.Text.ToString();
                }
                else if (rad4pmBook.Checked)
                {
                    radTimeSelected = rad4pmBook.Text.ToString();
                }
                else if (rad5pmBook.Checked)
                {
                    radTimeSelected = rad5pmBook.Text.ToString();
                }

                 
                if (radCar.Checked)
                {
                    vehicleSelected = radCar.Text.ToString();
                }
                else if (radVan.Checked)
                {
                    vehicleSelected = radVan.Text.ToString();
                }
                else if (radLargeVehicle.Checked)
                {
                    vehicleSelected = radLargeVehicle.Text.ToString(); ;
                }

                 
                appendStream.WriteLine(DateTime.Now.ToString() + ", " + (txtBookName.Text.ToString() + ", " + 
                    (txtLicenseBook.Text.ToString() + ", " + (radTimeSelected) + ", " + (vehicleSelected))));
                 
                appendStream.Close();
            }
        }
    }
}
    
        

  


