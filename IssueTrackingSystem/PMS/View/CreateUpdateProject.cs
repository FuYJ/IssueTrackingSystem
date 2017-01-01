using System;
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
    public partial class CreateUpdateProject : Form
    {
        private UserModel userModel;
        private IssueModel issueModel;
        private ProjectModel projectModel;
        private ProjectMemberModel projectMemberModel;
        private CreateUpdateProjectController controller;
        private ProjectInfoController infoController;
        ProjectApiModel model = new ProjectApiModel();
        Project project = new Project();

        public CreateUpdateProject(String purpose, int projectId, UserModel userModel, IssueModel issueModel, ProjectModel projectModel, ProjectMemberModel projectMemberModel)
//            : base(userModel, issueModel, projectModel, projectMemberModel)
        {
            InitializeComponent();
            this.userModel = userModel;
            this.issueModel = issueModel;
            this.projectModel = projectModel;
            this.projectMemberModel = projectMemberModel;
            controller = new CreateUpdateProjectController(userModel, issueModel, projectModel);
            infoController = new ProjectInfoController(projectModel);
            this.projectModel.projectDataChanged += Update;
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
            if(model.State == 0 && _createUpdate.Text.Equals(Project.CREATE))
            {
                ProjectMainMenu main = new ProjectMainMenu(model.ProjectContext, userModel, issueModel, projectModel, projectMemberModel);
                main.Show();
                this.Close();
            }
            else if (model.State == 0 && _createUpdate.Text.Equals(Project.UPDATE))
            {
                this.Close();
            }
            else
            {
                _errorMessage.Text = ((ErrorManager.ErrorCode)model.State).ToString();
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

            if (project != null && project.Manager != null)
            {
                if (!SecurityModel.getInstance().AuthenticatedUser.UserName.Equals(project.Manager))
                {
                    _createUpdate.Visible = false;
                    _createUpdate.Enabled = false;
                    _descriptionInput.ReadOnly = true;
                    _projectNameInput.ReadOnly = true;
                }
            } 
        }

        private void Update()
        {
            project = infoController.getProjectInfo(SecurityModel.getInstance().AuthenticatedUser.UserId, project.ProjectId);
            _projectNameInput.Text = project.ProjectName;
            _descriptionInput.Text = project.Description;
            _errorMessage.Text = "";
        }
    }
}
