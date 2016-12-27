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
    public partial class UserInfoView : IssueTrackingSystem.View.BaseView
    {
        private User user;
        private UserModel userModel;
        private UserController userController;
        private ErrorProvider errorProvider;

        public UserInfoView()
        {
            InitializeComponent();
            userModel = new UserModel();
            userController = new UserController(userModel);
            user = SecurityModel.getInstance().AuthenticatedUser;

            errorProvider = new ErrorProvider();
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void UserInfoViewLoad(object sender, EventArgs e)
        {
            usernameLabel.Text = user.UserName;
            emailAddressLabel.Text = user.EmailAddress;
            editUsernameTextBox.Text = user.UserName;
            editEmailAddressTextBox.Text = user.EmailAddress;
            joinedProjectNumberLabel.Text = user.JoinedProjects.Count.ToString();
            invitedProjectNumberLabel.Text = user.InvitedProjects.Count.ToString();
            trackingIssueNumberLabel.Text = user.Issues.Count.ToString();
        }

        private void finishEditButtonClicked(object sender, EventArgs e)
        {
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
            ProjectListView projectListView = new ProjectListView(0);
            projectListView.Show();
        }

        private void viewInvitedProjectsButtonClicked(object sender, EventArgs e)
        {
            ProjectListView projectListView = new ProjectListView(1);
            projectListView.Show();
        }

        private void viewIssuesButtonClicked(object sender, EventArgs e)
        {
            IssueListView issueListView = new IssueListView();
            issueListView.Show();
        }
    }
}
