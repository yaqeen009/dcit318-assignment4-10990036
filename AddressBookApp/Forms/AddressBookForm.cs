using System;
using System.Windows.Forms;

namespace AddressBookApp
{
    public partial class AddressBookForm : Form
    {
        public AddressBookForm()
        {
            InitializeComponent();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string email = textBoxEmail.Text;
            string phoneNumber = textBoxPhoneNumber.Text;

            MessageBox.Show($"Name: {name}\nEmail: {email}\nPhone Number: {phoneNumber}", "Saved Information");
        }
    }
}
