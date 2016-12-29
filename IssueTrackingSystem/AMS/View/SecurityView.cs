using IssueTrackingSystem.AMS.Controller;
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
    public partial class SecurityView : IssueTrackingSystem.View.BaseView
    {
        private UserModel userModel;
        private IssueModel issueModel;
        private ProjectModel projectModel;
        private ProjectMemberModel projectMemberModel;
        private UserController userController;
        private ErrorProvider errorProvider;

        public SecurityView(UserModel userModel, IssueModel issueModel, ProjectModel projectModel, ProjectMemberModel projectMemberModel)
            : base(userModel, issueModel, projectModel)
        {
            InitializeComponent();
            this.userModel = userModel;
            this.issueModel = issueModel;
            this.projectModel = projectModel;
            this.projectMemberModel = projectMemberModel;
            userController = new UserController(userModel);

            User user = SecurityModel.getInstance().AuthenticatedUser;
            usernameLabel.Text = user.UserName;
            emailAddressLabel.Text = user.EmailAddress;
            editUsernameTextBox.Text = user.UserName;
            editEmailAddressTextBox.Text = user.EmailAddress;

            errorProvider = new ErrorProvider();
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void editButtonClicked(object sender, EventArgs e)
        {
            viewInfoTableLayoutPanel.Visible = false;
            editInfoTableLayoutPanel.Visible = true;
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
            user.UserName = editUsernameTextBox.Text;
            user.Password = editPasswordTextBox.Text;
            user.EmailAddress = editEmailAddressTextBox.Text;
            userController.updateUser(user);
            viewInfoTableLayoutPanel.Visible = true;
            editInfoTableLayoutPanel.Visible = false;
        }

        private void editConfirmPasswordTextBoxTextChanged(object sender, EventArgs e)
        {
            if (!editConfirmPasswordTextBox.Text.Equals(editPasswordTextBox.Text))
            {
                errorProvider.SetError(editConfirmPasswordTextBox, "密碼不一致");
            }
            else {
                errorProvider.SetError(editConfirmPasswordTextBox, String.Empty);
            }
        }

        private void viewProjectsButtonClicked(object sender, EventArgs e)
        {
            ProjectListView projectListView = new ProjectListView(userModel, issueModel, projectModel, projectMemberModel);
            projectListView.Show();
        }

        private void viewIssuesButtonClicked(object sender, EventArgs e)
        {
            IssueListView issueListView = new IssueListView(userModel, issueModel, projectModel);
            issueListView.Show();
        }

        private void viewUsersButtonClicked(object sender, EventArgs e)
        {
            UserListView userListView = new UserListView(userModel, issueModel, projectModel);
            userListView.Show();
        }
    }
}
