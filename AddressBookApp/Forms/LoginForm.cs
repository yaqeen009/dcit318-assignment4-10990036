using System;
using System.Windows.Forms;

namespace AddressBookApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            MessageBox.Show($"Username: {username}\nPassword: {password}", "Login Information");

            // If login is successful, set the dialog result to OK and close the form
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
