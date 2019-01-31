
using System;
using System.Windows.Forms;

namespace SailSafe___1413042
{
    public partial class SailSafeMenu : Form
    {
        public SailSafeMenu()
        {
            InitializeComponent();
        }

        #region Event Methods
        
        private void button1_Click(object sender, EventArgs e)
        {
            NewBookingForm newGuest = new NewBookingForm();
            newGuest.Show();
            this.Hide();
        }

        private void btnMenuLogOut_Click(object sender, EventArgs e)
        {
            SignIn signOut = new SignIn();
            signOut.Show();
            this.Hide();
        }

        private void btnLocateBooking_Click(object sender, EventArgs e)
        {
            LocateBooking loadLocate = new LocateBooking();
            loadLocate.Show();
            this.Hide();
        }

        private void btnViewSailings_Click(object sender, EventArgs e)
        {
            ViewSailings openSailings = new ViewSailings();
            openSailings.Show();
            this.Hide();
        }

        private void btnEditBooking_Click(object sender, EventArgs e)
        {
            CancelBooking openEdit = new CancelBooking();
            openEdit.Show();
            this.Hide();
        }
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
