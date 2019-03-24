
using System;
using System.Windows.Forms;

namespace SailSafe
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            CreateBooking newGuest = new CreateBooking();
            newGuest.Show();
            this.Hide();
        }

        private void btnMenuLogOut_Click(object sender, EventArgs e)
        {
            Login signOut = new Login();
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
            ListBookings openSailings = new ListBookings();
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
    }
}
