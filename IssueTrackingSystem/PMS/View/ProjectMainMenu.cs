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
using IssueTrackingSystem.ITS.View;

namespace IssueTrackingSystem.PMS.View
{
    public partial class ProjectMainMenu : Form
    {
        private Project project = new Project();
        private UserModel userModel;
        private IssueModel issueModel;
        private ProjectModel projectModel;
        private ProjectMemberModel projectMemberModel;
        private ProjectInfoController infoController;

        public ProjectMainMenu(Project project, UserModel userModel, IssueModel issueModel, ProjectModel projectModel, ProjectMemberModel projectMemberModel)
        {
            InitializeComponent();
            this.userModel = userModel;
            this.issueModel = issueModel;
            this.projectModel = projectModel;
            this.projectMemberModel = projectMemberModel;
            this.project = project;
            this.projectModel.projectDataChanged += UpdateView;
            infoController = new ProjectInfoController(projectModel);
            SetProjectContext();
        }

        public ProjectMainMenu(int projectId, UserModel userModel, IssueModel issueModel, ProjectModel projectModel, ProjectMemberModel projectMemberModel)
        {
            InitializeComponent();
            this.userModel = userModel;
            this.issueModel = issueModel;
            this.projectModel = projectModel;
            this.projectMemberModel = projectMemberModel;
            this.projectModel.projectDataChanged += UpdateView;
            infoController = new ProjectInfoController(projectModel);
            project = infoController.getProjectInfo(SecurityModel.getInstance().AuthenticatedUser.UserId, projectId);
            SetProjectContext();
        }

        private void SetProjectContext()
        {
            _projectName.Text = project.ProjectName;
            if(project != null && project.Manager != null)
            {
                if (!SecurityModel.getInstance().AuthenticatedUser.UserName.Equals(project.Manager))
                {
                    _deleteButton.Visible = false;
                    _deleteButton.Enabled = false;
                }
            }
        }

        private void DescriptionButtonClicked(object sender, EventArgs e)
        {
            CreateUpdateProject view = new CreateUpdateProject(Project.UPDATE, project.ProjectId, userModel, issueModel, projectModel, projectMemberModel);
            view.ShowDialog();
        }

        private void MemberListClicked(object sender, EventArgs e)
        {
            Member member = new Member(userModel, issueModel, projectModel, project, projectMemberModel);
            member.ShowDialog();
        }

        public void UpdateView()
        {
            project = projectModel.getProjectInfo(SecurityModel.getInstance().AuthenticatedUser.UserId, project.ProjectId);
            _projectName.Text = project.ProjectName;
            _errorMessage.Text = "";
        }

        private void DeleteButtonClicked(object sender, EventArgs e)
        {
            int state = infoController.deleteProject(SecurityModel.getInstance().AuthenticatedUser.UserId, project.ProjectId);
            this.Close();
        }

        private void IssueButtonClicked(object sender, EventArgs e)
        {
            IssueList view = new IssueList(userModel, issueModel, projectModel, projectMemberModel, project);
            view.ShowDialog();
        }

        private void ShowErrorMessage(int state)
        {
            _errorMessage.Text = ((ErrorManager.ErrorCode)state).ToString();
        }

        private void LeaveButtonClicked(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
