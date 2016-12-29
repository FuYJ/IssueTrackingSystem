using IssueTrackingSystem.Model;
using IssueTrackingSystem.Model.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IssueTrackingSystem.PMS.Controller;

namespace IssueTrackingSystem.AMS.View
{
    public partial class ProjectListView : IssueTrackingSystem.View.BaseView
    {
        private List<Project> joinedProjectList;
        private List<Project> invitedProjectList;
        private ProjectModel projectModel;
        private ProjectInfoController projectController = new ProjectInfoController();

        public ProjectListView()
        {
            InitializeComponent();
            joinedProjectList = projectController.getProjectListByUserId(SecurityModel.getInstance().AuthenticatedUser.UserId);
            invitedProjectList = SecurityModel.getInstance().AuthenticatedUser.JoinedProjects;
        }

        public ProjectListView(int tabIndex)
        {
            InitializeComponent();
            int userId = SecurityModel.getInstance().AuthenticatedUser.UserId;
            joinedProjectList = projectController.getProjectListByUserId(userId);
            invitedProjectList = SecurityModel.getInstance().AuthenticatedUser.JoinedProjects;
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
