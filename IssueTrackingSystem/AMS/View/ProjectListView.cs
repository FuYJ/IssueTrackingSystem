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
    public partial class ProjectListView : IssueTrackingSystem.View.BaseView
    {
        private List<Project> joinedProjectList;
        private List<Project> invitedProjectList;

        public ProjectListView()
        {
            InitializeComponent();
            joinedProjectList = SecurityModel.getInstance().AuthenticatedUser.JoinedProjects;
            invitedProjectList = SecurityModel.getInstance().AuthenticatedUser.InvitedProjects;
        }

        public ProjectListView(int tabIndex)
        {
            InitializeComponent();
            joinedProjectList = SecurityModel.getInstance().AuthenticatedUser.JoinedProjects;
            invitedProjectList = SecurityModel.getInstance().AuthenticatedUser.InvitedProjects;
            projectTabControl.SelectTab(tabIndex);
        }

        private void ProjectListViewLoad(object sender, EventArgs e)
        {
            foreach (Project project in joinedProjectList)
            {
                joinedProjectsDataGridView.Rows.Add(new Object[] { project.ProjectId, project.ProjectName, project.Description, project.Manager, "檢視" });
            }
            foreach (Project project in invitedProjectList)
            {
                invitedProjectsDataGridView.Rows.Add(new Object[] { project.ProjectId, project.ProjectName, project.Description, project.Manager, "接受", "拒絕" });
            }
        }
    }
}
