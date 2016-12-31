using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IssueTrackingSystem.Model;
using IssueTrackingSystem.Model.DataModel;
using IssueTrackingSystem.PMS.Controller;

namespace IssueTrackingSystem.PMS.View
{
    public partial class ProjectMainMenu : IssueTrackingSystem.View.BaseView
    {
        private Project project = new Project();
        private UserModel userModel;
        private IssueModel issueModel;
        private ProjectModel projectModel;
        private ProjectMemberModel projectMemberModel;
        private ProjectInfoController infoController = new ProjectInfoController();

        public ProjectMainMenu(Project project, UserModel userModel, IssueModel issueModel, ProjectModel projectModel, ProjectMemberModel projectMemberModel)
            : base(userModel, issueModel, projectModel, projectMemberModel)
        {
            InitializeComponent();
            this.userModel = userModel;
            this.issueModel = issueModel;
            this.projectModel = projectModel;
            this.projectMemberModel = projectMemberModel;
            this.project = project;
            SetProjectContext();
        }

        public ProjectMainMenu(int projectId, UserModel userModel, IssueModel issueModel, ProjectModel projectModel, ProjectMemberModel projectMemberModel)
            : base(userModel, issueModel, projectModel, projectMemberModel)
        {
            InitializeComponent();
            this.userModel = userModel;
            this.issueModel = issueModel;
            this.projectModel = projectModel;
            this.projectMemberModel = projectMemberModel;
            project = infoController.getProjectInfo(SecurityModel.getInstance().AuthenticatedUser.UserId, projectId);
        }

        private void SetProjectContext()
        {
            _projectName.Text = project.ProjectName;
        }

        private void DescriptionButtonClicked(object sender, EventArgs e)
        {
            CreateUpdateProject view = new CreateUpdateProject(Project.UPDATE, project.ProjectId, userModel, issueModel, projectModel, projectMemberModel);
            view.Show();
        }
    }
}
