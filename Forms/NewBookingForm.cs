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
        private Booking booking;

        public NewBookingForm()
        {
            InitializeComponent();
        }

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

            if (txtBookName != null && txtLicenseBook != null)
            {
                this.booking = new Booking(txtBookName.Text.ToString(), txtLicenseBook.Text.ToString(), radTimeSelected, vehicleSelected);
                this.booking.Create();
            }
            else
            {
                MessageBox.Show("Please Enter Data in all Fields!", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
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
    }
}
    
        

  


