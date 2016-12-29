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
    public partial class LoginView : Form
    {
        private UserController userController;
        private UserModel userModel;
        private IssueModel issueModel;
        private ProjectModel projectModel;

        public LoginView(UserModel userModel, IssueModel issueModel, ProjectModel projectModel)
        {
            InitializeComponent();
            this.userModel = userModel;
            this.issueModel = issueModel;
            this.projectModel = projectModel;
            userController = new UserController(userModel);
        }


        public ToolStripStatusLabel ToolStripStatusLabel
        {
            set { toolStripStatusLabel = value; }
            get { return toolStripStatusLabel; }
        }

        private void registerButtonClicked(object sender, EventArgs e)
        {
            RegisterView registerView = new RegisterView();
            registerView.Show(this);
            this.Hide();
        }

        private void loginButtonClicked(object sender, EventArgs e)
        {
            User user = new User();
            user.UserName = usernameTextBox.Text;
            user.Password = passwordTextBox.Text;
            user = userController.authenticateUser(user);
            if (user.UserId != 0)
            {
                if (user.Authority == (int)User.AuthorityEnum.GeneralUser)
                {
                    UserInfoView userInfoView = new UserInfoView(userModel, issueModel, projectModel);
                    userInfoView.Show(this);
                }
                else if (user.Authority == (int)User.AuthorityEnum.SystemManager)
                {
                    SecurityView securityView = new SecurityView(userModel, issueModel, projectModel);
                    securityView.Show(this);
                }
                this.Hide();
            }
            else
            {
                toolStripStatusLabel.Text = "認證錯誤";
            }
        }
    }
}
