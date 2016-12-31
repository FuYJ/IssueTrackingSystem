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
using IssueTrackingSystem.ITS.View;

namespace IssueTrackingSystem.View
{
    public partial class BaseView : Form
    {
        private UserModel userModel;
        private IssueModel issueModel;
        private ProjectModel projectModel;
        private ProjectMemberModel projectMemberModel;

        public BaseView()
        {
            InitializeComponent();
        }

        public BaseView(UserModel userModel, IssueModel issueModel, ProjectModel projectModel, ProjectMemberModel projectMemberModel)
        {
            InitializeComponent();
            this.userModel = userModel;
            this.issueModel = issueModel;
            this.projectModel = projectModel;
            this.projectMemberModel = projectMemberModel;
        }

        private void BaseViewLoad(object sender, EventArgs e)
        {
            if (SecurityModel.getInstance().AuthenticatedUser.Authority == (int)User.AuthorityEnum.GeneralUser)
            {
                userListToolStripButton.Visible = false;
                userListToolStripButton.Enabled = false;
                toolStripSeparator2.Visible = false;
            }
            else
            {
                createProjectButton.Visible = false;
                createProjectButton.Enabled = false;
                createIssueToolStripButton.Visible = false;
                createIssueToolStripButton.Visible = false;
                toolStripSeparator1.Visible = false;
            }
        }

        private void userListToolStripButtonClicked(object sender, EventArgs e)
        {
            UserListView userListView = new UserListView(userModel, issueModel, projectModel, projectMemberModel);
            userListView.Visible = true;
            userListView.Activate();
            this.Close();
        }

        private void createProjectButtonClicked(object sender, EventArgs e)
        {
            CreateUpdateProject createProject = new CreateUpdateProject(Project.CREATE, -1, userModel, issueModel, projectModel, projectMemberModel);
            createProject.Visible = true;
            createProject.Activate();
            this.Close();
        }

        private void addIssueToolStripButtonClicked(object sender, EventArgs e)
        {
            CreateIssueView createIssueView = new CreateIssueView(userModel, issueModel, projectModel, projectMemberModel);
            createIssueView.Visible = true;
            createIssueView.Activate();
            this.Close();
        }

        private void userInfoToolStripButtonClicked(object sender, EventArgs e)
        {
            UserInfoView userInfoView = new UserInfoView(userModel, issueModel, projectModel, projectMemberModel);
            userInfoView.Visible = true;
            userInfoView.Activate();
            this.Close();
        }

        private void issueListToolStripButtonClicked(object sender, EventArgs e)
        {
            IssueListView issueListView = new IssueListView(userModel, issueModel, projectModel, projectMemberModel);
            issueListView.Visible = true;
            issueListView.Activate();
            this.Close();
        }

        private void projectListToolStripButtonClicked(object sender, EventArgs e)
        {
            ProjectListView projectListView = null;
            if (SecurityModel.getInstance().AuthenticatedUser.Authority == (int)User.AuthorityEnum.GeneralUser)
                projectListView = new ProjectListView(0, userModel, issueModel, projectModel, projectMemberModel);
            else
                projectListView = new ProjectListView(userModel, issueModel, projectModel, projectMemberModel);
            projectListView.Visible = true;
            projectListView.Activate();
            this.Close();
        }

        private void viewReportToolStripButtonClicked(object sender, EventArgs e)
        {
            ReportView reportView = new ReportView(userModel, issueModel, projectModel, projectMemberModel);
            reportView.Visible = true;
            reportView.Activate();
            this.Close();
        }
    }
}
