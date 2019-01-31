
using System;
using System.Windows.Forms;
using System.IO;

namespace SailSafe___1413042
{
    public partial class ViewSailings : Form
    {
        public ViewSailings()
        {
            InitializeComponent();
            
        }

        #region Instance/Static Members
        // Cite: (MSDN, 2015, Environment.GetFolderPath Method (Environment.SpecialFolder))
        static string destPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        static string destFile = Path.Combine(destPath, "SailSafeLog.txt");
        #endregion

        #region Event Methods
        /// <summary>
        /// When the Menu button is clicked, it will close this form, and direct the user to a new instantiation of the menu form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMenuLogOut_Click(object sender, EventArgs e)
        {
            SailSafeMenu returnHome = new SailSafeMenu();
            returnHome.Show();
            this.Hide();
        }

        /// <summary>
        /// When Display button is clicked, this method Is run to display all listed bookings
        /// Cite: (Bell and Parr, 2009, Ch. 18 - Files)
        /// </summary>
        /// <param name="sender">btnDisplay</param>
        /// <param name="e"></param>
        private void btnViewList_Click(object sender, EventArgs e)
        {
            FileStream logReadFilePerms = new FileStream(destFile, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader inputStream = new StreamReader(logReadFilePerms);
            
            string lines = inputStream.ReadToEnd();

            while (lines != null)
            {
                txtListView.AppendText(lines + "\r\n");
                lines = inputStream.ReadLine();
            }

            inputStream.Close();
        }

        private void btnViewAddBook_Click(object sender, EventArgs e)
        {
            NewBookingForm addBooking = new NewBookingForm();
            addBooking.Show();
            this.Hide();
        }

        #endregion
    }
}
