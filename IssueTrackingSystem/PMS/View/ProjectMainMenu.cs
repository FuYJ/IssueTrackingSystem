using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IssueTrackingSystem.Model.DataModel;

namespace IssueTrackingSystem.PMS.View
{
    public partial class ProjectMainMenu : IssueTrackingSystem.View.BaseView
    {
        Project project = new Project();

        public ProjectMainMenu(Project project)
        {
            InitializeComponent();
            this.project = project;
            SetProjectContext();
        }

        public ProjectMainMenu(int projectId)
        {
            InitializeComponent();
        }

        private void SetProjectContext()
        {
            _projectName.Text = project.ProjectName;
        }
    }
}
