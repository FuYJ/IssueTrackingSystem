using IssueTrackingSystem.AMS.Controller;
using IssueTrackingSystem.Model;
using IssueTrackingSystem.Model.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssueTrackingSystem.AMS.View
{
    public partial class RegisterView : Form
    {
        private UserModel userModel;
        private UserController userController;

        public RegisterView(){
            userModel = new UserModel();
            userController = new UserController(userModel);
            InitializeComponent();
        }

        private void registerButtonClicked(object sender, EventArgs e)
        {
            User user = new User();
            user.UserName = usernameTextBox.Text;
            user.Password = passwordTextBox.Text;
            user.EmailAddress = emailAddressTextBox.Text;
            user = userController.createUser(user);
            if (user.UserId != 0)
            {
                LoginView loginView = (LoginView)this.Owner;
                loginView.ToolStripStatusLabel.Text = "註冊成功";
                loginView.Show();
                this.Close();
            }
            else {
                toolStripStatusLabel.Text = "註冊失敗";
            }
        }

        private void cancelButtonClicked(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
