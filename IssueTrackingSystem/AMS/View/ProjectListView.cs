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
        private UserModel userModel;
        private ProjectModel projectModel;
        private ProjectInfoController projectController = new ProjectInfoController();

        public ProjectListView(UserModel userModel, ProjectModel projectModel, int tabIndex)
        {
            InitializeComponent();
            this.userModel = userModel;
            this.projectModel = projectModel;

            int userId = SecurityModel.getInstance().AuthenticatedUser.UserId;
            joinedProjectList = projectController.getProjectListByUserId(userId);
            invitedProjectList = projectController.getInvitedProjectListByUserId(userId);
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
