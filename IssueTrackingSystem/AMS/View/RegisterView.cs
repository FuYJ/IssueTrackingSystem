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
        private ErrorProvider errorProvider;

        public RegisterView(){
            userModel = new UserModel();
            userController = new UserController(userModel);
            InitializeComponent();

            errorProvider = new ErrorProvider();
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void registerButtonClicked(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == String.Empty)
                errorProvider.SetError(usernameTextBox, "名稱不得為空");
            if (emailAddressTextBox.Text == String.Empty)
                errorProvider.SetError(emailAddressTextBox, "郵件地址不得為空");
            if (errorProvider.GetError(confirmPasswordTextBox) != String.Empty)
                return;

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

        private void confirmPasswordTextBoxTextChanged(object sender, EventArgs e)
        {
            if (!confirmPasswordTextBox.Text.Equals(passwordTextBox.Text))
            {
                errorProvider.SetError(confirmPasswordTextBox, "密碼不一致");
            }
            else
            {
                errorProvider.SetError(confirmPasswordTextBox, String.Empty);
            }
        }
    }
}
