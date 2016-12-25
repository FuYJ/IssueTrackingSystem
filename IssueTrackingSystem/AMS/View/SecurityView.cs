using IssueTrackingSystem.AMS.Controller;
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
        private UserController userController;
        private ErrorProvider errorProvider;

        public SecurityView()
        {
            InitializeComponent();
            userModel = new UserModel();
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
    }
}
