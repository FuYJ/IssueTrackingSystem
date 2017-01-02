using IssueTrackingSystem.AMS.Controller;
using IssueTrackingSystem.ITS.Controller;
using IssueTrackingSystem.ITS.View;
using IssueTrackingSystem.Model;
using IssueTrackingSystem.Model.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IssueTrackingSystem.AMS.View
{
    public partial class UserInfoView : IssueTrackingSystem.View.BaseView
    {
        private User user;
        private UserModel userModel;
        private IssueModel issueModel;
        private ProjectModel projectModel;
        private ProjectMemberModel projectMemberModel;
        private UserController userController;
        private IssueController issueController;
        private ErrorProvider errorProvider;

        public UserInfoView(UserModel userModel, IssueModel issueModel, ProjectModel projectModel, ProjectMemberModel projectMemberModel)
            : base(userModel, issueModel, projectModel, projectMemberModel)
        {
            InitializeComponent();
            this.userModel = userModel;
            this.issueModel = issueModel;
            this.projectModel = projectModel;
            this.projectMemberModel = projectMemberModel;
            userController = new UserController(userModel);
            issueController = new IssueController(userModel, issueModel, projectModel);

            user = SecurityModel.getInstance().AuthenticatedUser;

            userModel.userDataChanged += updateView;
            issueModel.issueDataChanged += updateView;
            projectModel.projectDataChanged += updateView;

            errorProvider = new ErrorProvider();
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            if (this.Owner == null)
            {
                base.logoutToolStripButton.Visible = true;
                base.logoutToolStripButton.Enabled = true;
            }
        }

        private void UserInfoViewLoad(object sender, EventArgs e)
        {
            updateView();
        }

        private void finishEditButtonClicked(object sender, EventArgs e)
        {
            if (editUsernameTextBox.Text == String.Empty)
                errorProvider.SetError(editUsernameTextBox, "名稱不得為空");
            if (editEmailAddressTextBox.Text == String.Empty)
                errorProvider.SetError(editEmailAddressTextBox, "郵件地址不得為空");
            if (errorProvider.GetError(editConfirmPasswordTextBox) != String.Empty)
                return;

            User user = SecurityModel.getInstance().AuthenticatedUser;
            user.UserName = (editUsernameTextBox.Text == user.UserName) ? "" : editUsernameTextBox.Text;
            user.Password = (editPasswordTextBox.Text == String.Empty) ? "" : editPasswordTextBox.Text;
            user.EmailAddress = (editEmailAddressTextBox.Text == user.EmailAddress) ? "" : editEmailAddressTextBox.Text;
            userController.updateUser(user);
            viewInfoTableLayoutPanel.Visible = true;
            editInfoTableLayoutPanel.Visible = false;
        }

        private void editButtonClicked(object sender, EventArgs e)
        {
            viewInfoTableLayoutPanel.Visible = false;
            editInfoTableLayoutPanel.Visible = true;
        }

        private void editConfirmPasswordTextBoxTextChanged(object sender, EventArgs e)
        {
            if (!editConfirmPasswordTextBox.Text.Equals(editPasswordTextBox.Text))
                errorProvider.SetError(editConfirmPasswordTextBox, "密碼不一致");
            else
                errorProvider.SetError(editConfirmPasswordTextBox, String.Empty);
        }

        private void viewJoinedProjectsButtonClicked(object sender, EventArgs e)
        {
            ProjectListView projectListView = new ProjectListView(0, userModel, issueModel, projectModel, projectMemberModel);
            Form form = FindForm("ProjectListView");
            if (form == null)
            {
                projectListView.Show(this);
            }
//            projectListView.Show(this);
        }

        private void viewInvitedProjectsButtonClicked(object sender, EventArgs e)
        {
            ProjectListView projectListView = new ProjectListView(1, userModel, issueModel, projectModel, projectMemberModel);
            Form form = FindForm("ProjectListView");
            if (form == null)
            {
                projectListView.Show(this);
            }
//            projectListView.Show(this);
        }

        private void viewIssuesButtonClicked(object sender, EventArgs e)
        {
            IssueListView issueListView = new IssueListView(userModel, issueModel, projectModel, projectMemberModel);
            Form form = FindForm("IssueListView");
            if (form == null)
            {
                issueListView.Show(this);
            }
            
        }

        private void updateView() {
            userModel.updateAuthenticatedUser(SecurityModel.getInstance().AuthenticatedUser.UserId);
            user = SecurityModel.getInstance().AuthenticatedUser;

            usernameLabel.Text = user.UserName;
            emailAddressLabel.Text = user.EmailAddress;
            editUsernameTextBox.Text = user.UserName;
            editEmailAddressTextBox.Text = user.EmailAddress;
            joinedProjectNumberLabel.Text = user.JoinedProjects.Count.ToString();
            invitedProjectNumberLabel.Text = user.InvitedProjects.Count.ToString();
            trackingIssueNumberLabel.Text = issueController.getIssueList().Count.ToString(); ;
        }

        private void UserInfoViewFormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner == null)
                SecurityModel.getInstance().AuthenticatedUser = null;
        }
    }
}
