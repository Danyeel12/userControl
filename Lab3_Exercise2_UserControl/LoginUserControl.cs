using System;
using System.Windows.Forms;

namespace Exercise2_UserControlLogin
{
    public partial class LoginUserControl : UserControl
    {
        public string UserName
        {
            get { return textBox1.Text; }
        }

        public string Password
        {
            get { return textBox2.Text; }
        }

        public LoginUserControl()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = UserName;
            string password = Password;
            MessageBox.Show($"Username: {username}\nPassword: {password}");
        }
    }
}
