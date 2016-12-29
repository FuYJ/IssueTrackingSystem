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
        Project project = new Project();
        ProjectInfoController infoController = new ProjectInfoController();

        public ProjectMainMenu(Project project)
        {
            InitializeComponent();
            this.project = project;
            SetProjectContext();
        }

        public ProjectMainMenu(int projectId)
        {
            InitializeComponent();
            project = infoController.getProjectInfo(SecurityModel.getInstance().AuthenticatedUser.UserId, projectId);
        }

        private void SetProjectContext()
        {
            _projectName.Text = project.ProjectName;
        }

        private void DescriptionButtonClicked(object sender, EventArgs e)
        {
            CreateUpdateProject view = new CreateUpdateProject(Project.UPDATE, project.ProjectId);
            view.Show();
        }
    }
}
