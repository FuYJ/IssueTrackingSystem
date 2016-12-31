﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IssueTrackingSystem.Model.ApiModel;
using IssueTrackingSystem.Model.DataModel;
using IssueTrackingSystem.Model;
using IssueTrackingSystem.PMS.Controller;

namespace IssueTrackingSystem.PMS.View
{
    public partial class CreateUpdateProject : IssueTrackingSystem.View.BaseView
    {
        private UserModel userModel;
        private IssueModel issueModel;
        private ProjectModel projectModel;
        private ProjectMemberModel projectMemberModel;
        private CreateUpdateProjectController controller = new CreateUpdateProjectController();
        private ProjectInfoController infoController = new ProjectInfoController();
        ProjectApiModel model = new ProjectApiModel();
        Project project = new Project();

        public CreateUpdateProject(String purpose, int projectId, UserModel userModel, IssueModel issueModel, ProjectModel projectModel, ProjectMemberModel projectMemberModel)
            : base(userModel, issueModel, projectModel, projectMemberModel)
        {
            InitializeComponent();
            this.userModel = userModel;
            this.issueModel = issueModel;
            this.projectModel = projectModel;
            this.projectMemberModel = projectMemberModel;
            Initialize(purpose, projectId);
        }

        private void ClickCreateUpdate(object sender, EventArgs e)
        {
            project.ProjectName = _projectNameInput.Text;
            project.Description = _descriptionInput.Text;
            model = controller.CreateUpdateProject(_createUpdate.Text, project);
            HandleErrorMessage(model);
        }

        private void HandleErrorMessage(ProjectApiModel model)
        {
            if(model.State == 0)
            {
                ProjectMainMenu main = new ProjectMainMenu(model.ProjectContext, userModel, issueModel, projectModel, projectMemberModel);
                main.Show();
                this.Close();
            }
            else
            {
                _errorMessage.Text = "建立失敗";
            }
        }

        private void Initialize(String purpose, int projectId)
        {
            if (purpose.Equals(Project.UPDATE))
            {
                project = infoController.getProjectInfo(SecurityModel.getInstance().AuthenticatedUser.UserId, projectId);
                _projectNameInput.Text = project.ProjectName;
                _descriptionInput.Text = project.Description;
            }
            _createUpdate.Text = purpose;
        }
    }
}
