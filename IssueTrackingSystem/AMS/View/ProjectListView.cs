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
        private List<Project> allProjectList;
        private User user;
        private UserModel userModel;
        private IssueModel issueModel;
        private ProjectModel projectModel;
        private ProjectInfoController projectInfoController;
        private ProjectMemberController projectMemberController;

        public ProjectListView(UserModel userModel, IssueModel issueModel, ProjectModel projectModel)
            : base(userModel, issueModel, projectModel)
        {
            InitializeComponent();
            this.userModel = userModel;
            this.issueModel = issueModel;
            this.projectModel = projectModel;
            projectInfoController = new ProjectInfoController();
            projectMemberController = new ProjectMemberController();

            user = SecurityModel.getInstance().AuthenticatedUser;
            int userId = user.UserId;
            allProjectList = projectInfoController.getAllProjectList(userId);

            systemManagerTableLayoutPanel.Enabled = true;
            systemManagerTableLayoutPanel.Visible = true;
            generalUserTableLayoutPanel.Enabled = false;
            generalUserTableLayoutPanel.Visible = false;
        }

        public ProjectListView(int tabIndex, UserModel userModel, IssueModel issueModel, ProjectModel projectModel)
            : base(userModel, issueModel, projectModel)
        {
            InitializeComponent();
            this.userModel = userModel;
            this.issueModel = issueModel;
            this.projectModel = projectModel;
            projectInfoController = new ProjectInfoController();
            projectMemberController = new ProjectMemberController();

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
                {
                    project.Members = projectMemberController.getMemberByProjectId(project.ProjectId, "1");
                    allProjectsDataGridView.Rows.Add(new Object[] { project.ProjectId, project.ProjectName, project.Description, project.Manager, project.Members.Count });
                }
            }
        }
    }
}
