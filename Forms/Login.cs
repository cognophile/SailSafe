
using System;
using System.Windows.Forms;

namespace SailSafe
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method to calculate whether a users input details are correct or not
        /// If not, runs Unauthorised Method (not allowing access to program)
        /// If correct, runs Authorised method (allowing access into program)
        /// </summary>
        public void Authorised()
        {
            // For educational assessment purposes, only.
            const string userID = "Admin";
            const string userPassword = "Pass";

            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("You must fill both fields!", "Missing Criteria", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();

                return;
            }

            if (userID.ToUpper() == txtUsername.Text.ToUpper() && userPassword == txtPassword.Text)
            {
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
                this.Hide();
            }
            else
            {
                Unauthorised();
            }
        }

        /// <summary>
        /// Tells the user they couldn't sign in
        /// Clears all fields anf re-focused for security
        /// </summary>
        public void Unauthorised()
        {
            MessageBox.Show("Incorrect Details - Try Again.", "Incorrect Details!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        /// <summary>
        /// When password field has focus, this restricts the available user input to 4 chars
        /// Also hides password typing for security
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.MaxLength = 4;
            txtPassword.PasswordChar = '*';
        }


        /// <summary>
        /// Button to reference Authorised Method when clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            Authorised();
        }

        /// <summary>
        /// Method allowing user to press 'Enter' on keyboard instead of button when Password field has focus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)ConsoleKey.Enter)
            {
                Authorised();
            }
        }

        /// <summary>
        /// Method allowing user to press 'Enter' on keyboard instead of button when Username field has focus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)ConsoleKey.Enter)
            {
                Authorised();
            }
        }

        /// <summary>
        /// Button to close App from log-in screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
