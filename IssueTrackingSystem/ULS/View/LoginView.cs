using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssueTrackingSystem.ULS.View
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void registerButtonClicked(object sender, EventArgs e)
        {
            RegisterView registerView = new RegisterView();
            registerView.Show(this);
            this.Hide();
        }

        private void loginButtonClicked(object sender, EventArgs e)
        {
            UserInfoView userInfoView = new UserInfoView();
            userInfoView.Show(this);
            this.Hide();
        }
    }
}
