
using System;
using System.Windows.Forms;
using System.IO;
using SailSafe.Intermediaries;

namespace SailSafe
{
    public partial class ViewSailings : Form
    {
        private BookingManager manager;

        public ViewSailings()
        {
            InitializeComponent();
        }

        private void btnMenuLogOut_Click(object sender, EventArgs e)
        {
            SailSafeMenu returnHome = new SailSafeMenu();
            returnHome.Show();
            this.Hide();
        }

        private void btnViewList_Click(object sender, EventArgs e)
        {
            this.manager = new BookingManager();
            var bookings = this.manager.GetAll();

            foreach (var booking in bookings)
            {
                txtListView.AppendText(booking + "\r\n");
            }
        }

        private void btnViewAddBook_Click(object sender, EventArgs e)
        {
            NewBookingForm addBooking = new NewBookingForm();
            addBooking.Show();
            this.Hide();
        }
    }
}
