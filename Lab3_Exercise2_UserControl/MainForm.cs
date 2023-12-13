using System.Windows.Forms;

namespace Exercise2_UserControlLogin
{
    public partial class MainForm : Form
    {
        private LoginUserControl loginUserControl;

        public MainForm()
        {
            InitializeComponent();
            loginUserControl = new LoginUserControl();
            this.Controls.Add(loginUserControl);
            loginUserControl.Dock = DockStyle.Fill;
        }
    }
}
