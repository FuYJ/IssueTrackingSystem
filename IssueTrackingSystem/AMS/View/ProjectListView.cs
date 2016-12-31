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
using IssueTrackingSystem.AMS.Controller;
using IssueTrackingSystem.PMS.View;

namespace IssueTrackingSystem.AMS.View
{
    public partial class ProjectListView : IssueTrackingSystem.View.BaseView
    {
        private List<Project> joinedProjectList;
        private List<Project> invitedProjectList;
        private List<Project> allProjectList;
        private User user;
        private UserModel userModel;
        private IssueModel issueModel;
        private ProjectModel projectModel;
        private ProjectMemberModel projectMemberModel;
        private ProjectInfoController projectInfoController;
        private ProjectListController projectListController;

        public ProjectListView(UserModel userModel, IssueModel issueModel, ProjectModel projectModel, ProjectMemberModel projectMemberModel)
            : base(userModel, issueModel, projectModel, projectMemberModel)
        {
            InitializeComponent();
            this.userModel = userModel;
            this.issueModel = issueModel;
            this.projectModel = projectModel;
            this.projectMemberModel = projectMemberModel;
            projectInfoController = new ProjectInfoController();
            projectListController = new ProjectListController(projectModel, projectMemberModel);

            user = SecurityModel.getInstance().AuthenticatedUser;
            int userId = user.UserId;
            allProjectList = projectInfoController.getAllProjectList(userId);

            systemManagerTableLayoutPanel.Enabled = true;
            systemManagerTableLayoutPanel.Visible = true;
            generalUserTableLayoutPanel.Enabled = false;
            generalUserTableLayoutPanel.Visible = false;
        }

        public ProjectListView(int tabIndex, UserModel userModel, IssueModel issueModel, ProjectModel projectModel, ProjectMemberModel projectMemberModel)
            : base(userModel, issueModel, projectModel, projectMemberModel)
        {
            InitializeComponent();
            this.userModel = userModel;
            this.issueModel = issueModel;
            this.projectModel = projectModel;
            this.projectMemberModel = projectMemberModel;
            projectInfoController = new ProjectInfoController();

            user = SecurityModel.getInstance().AuthenticatedUser;
            int userId = user.UserId;
            joinedProjectList = projectInfoController.getProjectListByUserId(userId);
            invitedProjectList = projectInfoController.getInvitedProjectListByUserId(userId);
            projectTabControl.SelectTab(tabIndex);

            systemManagerTableLayoutPanel.Enabled = false;
            systemManagerTableLayoutPanel.Visible = false;
            generalUserTableLayoutPanel.Enabled = true;
            generalUserTableLayoutPanel.Visible = true;
        }

        private void projectListViewLoad(object sender, EventArgs e)
        {
            if (user.Authority == (int)User.AuthorityEnum.GeneralUser)
            {
                foreach (Project project in joinedProjectList)
                    joinedProjectsDataGridView.Rows.Add(new Object[] { project.ProjectId, project.ProjectName, project.Description, project.Manager, "檢視" });
                foreach (Project project in invitedProjectList)
                    invitedProjectsDataGridView.Rows.Add(new Object[] { project.ProjectId, project.ProjectName, project.Description, project.Manager, "接受", "拒絕" });
            }
            else {
                foreach (Project project in allProjectList)
                    allProjectsDataGridView.Rows.Add(new Object[] { project.ProjectId, project.ProjectName, project.Description, project.Manager});
            }
        }

        private void invitedProjectsDataGridViewCellContentClicked(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.RowIndex >= 0 && e.RowIndex < invitedProjectsDataGridView.RowCount) {
                projectListController.dealWithProjectInvitation((int)invitedProjectsDataGridView.Rows[e.RowIndex].Cells[0].Value, true);
            }
            else if (e.ColumnIndex == 5 && e.RowIndex >= 0 && e.RowIndex < invitedProjectsDataGridView.RowCount) {
                projectListController.dealWithProjectInvitation((int)invitedProjectsDataGridView.Rows[e.RowIndex].Cells[0].Value, false);
            }
        }

        private void joinedProjectsDataGridViewCellDoubleClicked(object sender, DataGridViewCellEventArgs e)
        {
            User user = SecurityModel.getInstance().AuthenticatedUser;
            if (e.RowIndex >= 0 && e.RowIndex < invitedProjectsDataGridView.RowCount)
            {
                projectInfoController.getProjectInfo(user.UserId, (int)invitedProjectsDataGridView.Rows[e.RowIndex].Cells[0].Value);
            }
        }

        private void joinedProjectsDataGridViewCellContentClicked(object sender, DataGridViewCellEventArgs e)
        {
            User user = SecurityModel.getInstance().AuthenticatedUser;
            if (e.ColumnIndex == 4 && e.RowIndex >= 0 && e.RowIndex < joinedProjectsDataGridView.RowCount)
            {
                ProjectMainMenu projectMainMenu = new ProjectMainMenu((int)joinedProjectsDataGridView.Rows[e.RowIndex].Cells[0].Value, userModel, issueModel, projectModel, projectMemberModel);
                projectMainMenu.Show(this);
            }
        }
    }
}
