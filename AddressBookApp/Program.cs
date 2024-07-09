using System;
using System.Windows.Forms;

namespace AddressBookApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Run the login form first
            var loginForm = new LoginForm();
            Application.Run(loginForm);

            // If login is successful, show the address book form
            if (loginForm.DialogResult == DialogResult.OK)
            {
                Application.Run(new AddressBookForm());
            }
        }
    }
}
