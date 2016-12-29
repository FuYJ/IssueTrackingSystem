using IssueTrackingSystem.AMS.View;
using IssueTrackingSystem.PMS.View;
using IssueTrackingSystem.Model;
using IssueTrackingSystem.Model.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssueTrackingSystem.View
{
    public partial class BaseView : Form
    {
        private UserModel userModel;
        private IssueModel issueModel;
        private ProjectModel projectModel;

        public BaseView(UserModel userModel, IssueModel issueModel, ProjectModel projectModel)
        {
            InitializeComponent();
            this.userModel = userModel;
            this.issueModel = issueModel;
            this.projectModel = projectModel;
        }

        private void userListToolStripButtonClicked(object sender, EventArgs e)
        {
            UserListView accountListView = new UserListView(userModel, issueModel, projectModel);
            accountListView.Show();
        }

        private void createProjectButtonClicked(object sender, EventArgs e)
        {
            CreateUpdateProject createProject = new CreateUpdateProject(Project.CREATE, -1);
            createProject.Show();
        }
    }
}
