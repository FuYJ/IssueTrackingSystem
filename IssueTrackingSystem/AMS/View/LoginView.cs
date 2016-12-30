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
        private ProjectMemberModel projectMemberModel;

        public LoginView(UserModel userModel, IssueModel issueModel, ProjectModel projectModel, ProjectMemberModel projectMemberModel)
        {
            InitializeComponent();
            this.userModel = userModel;
            this.issueModel = issueModel;
            this.projectModel = projectModel;
            this.projectMemberModel = projectMemberModel;

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
            if (user.UserId > 0)
            {
                if (user.Authority == (int)User.AuthorityEnum.GeneralUser)
                {
                    UserInfoView userInfoView = new UserInfoView(userModel, issueModel, projectModel, projectMemberModel);
                    userInfoView.Show(this.Owner);
                }
                else if (user.Authority == (int)User.AuthorityEnum.SystemManager)
                {
                    SecurityView securityView = new SecurityView(userModel, issueModel, projectModel, projectMemberModel);
                    securityView.Show(this.Owner);
                }
                this.Hide();
            }
            else
            {
                switch(user.UserId){
                    case -(int)ErrorManager.ErrorCode.UserAccountNotExist:
                        toolStripStatusLabel.Text = "該使用者不存在";
                        break;
                    case -(int)ErrorManager.ErrorCode.AuthenticateError:
                        toolStripStatusLabel.Text = "密碼錯誤";
                        break;
                }
                
            }
        }
    }
}
