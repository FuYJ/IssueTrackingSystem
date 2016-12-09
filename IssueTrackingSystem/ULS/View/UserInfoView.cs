using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IssueTrackingSystem.ULS.View
{
    public partial class UserInfoView : IssueTrackingSystem.View.BaseView
    {
        public UserInfoView()
        {
            InitializeComponent();
        }

        private void finishEditButtonClicked(object sender, EventArgs e)
        {
            mainTableLayoutPanel1.Visible = true;
            maintableLayoutPanel2.Visible = false;
        }

        private void editButtonClicked(object sender, EventArgs e)
        {
            mainTableLayoutPanel1.Visible = false;
            maintableLayoutPanel2.Visible = true;
        }
    }
}
