﻿using IssueTrackingSystem.AMS.View;
using IssueTrackingSystem.PMS.View;
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

namespace IssueTrackingSystem.View
{
    public partial class BaseView : Form
    {
        private UserModel userModel;
        private IssueModel issueModel;
        private ProjectModel projectModel;
        private ProjectMemberModel projectMemberModel;

        public BaseView()
        {
            InitializeComponent();
        }

        public BaseView(UserModel userModel, IssueModel issueModel, ProjectModel projectModel, ProjectMemberModel projectMemberModel)
        {
            InitializeComponent();
            this.userModel = userModel;
            this.issueModel = issueModel;
            this.projectModel = projectModel;
            this.projectMemberModel = projectMemberModel;
        }

        private void userListToolStripButtonClicked(object sender, EventArgs e)
        {
            UserListView userListView = new UserListView(userModel, issueModel, projectModel, projectMemberModel);
            userListView.Show();
        }

        private void createProjectButtonClicked(object sender, EventArgs e)
        {
            CreateUpdateProject createProject = new CreateUpdateProject(Project.CREATE, -1, userModel, issueModel, projectModel, projectMemberModel);
            createProject.Show();
        }
    }
}
