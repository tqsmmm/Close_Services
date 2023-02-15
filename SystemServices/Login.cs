using System.Windows.Forms;

namespace SystemServices
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            if (txtPassword.Text == "root")
            {
                DialogResult = DialogResult.Yes;
                Close();
            }
        }
    }
}
