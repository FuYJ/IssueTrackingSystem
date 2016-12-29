using IssueTrackingSystem.ITS.Controller;
using IssueTrackingSystem.Model;
using IssueTrackingSystem.Model.DataModel;
using IssueTrackingSystem.PMS.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IssueTrackingSystem.ITS.View
{
    public partial class CreateIssueView : IssueTrackingSystem.View.BaseView
    {
        private IssueModel issueModel;
        private UserModel userModel;
        private ProjectModel projectModel;
        private IssueController issueController;
        private User user;
        private List<Project> projectList;


        public CreateIssueView(UserModel userModel, IssueModel issueModel, ProjectModel projectModel)
            : base(userModel, issueModel, projectModel)
        {
            InitializeComponent();
            this.userModel = userModel;
            this.issueModel = issueModel;
            this.projectModel = projectModel;
            
            issueController = new IssueController(userModel, issueModel, projectModel);
            user = SecurityModel.getInstance().AuthenticatedUser;
            projectList = user.JoinedProjects;
            foreach (Project project in projectList)
            {
                projectComboBox.Items.Add(project);
            }

            projectComboBox.SelectedIndex = 0;
            issuePriorityComboBox.SelectedIndex = 0;
            issueSeverityComboBox.SelectedIndex = 0;
        }

        public CreateIssueView(int projectId, UserModel userModel, IssueModel issueModel, ProjectModel projectModel)
            : base(userModel, issueModel, projectModel)
        {
            InitializeComponent();
            this.userModel = userModel;
            this.issueModel = issueModel;
            this.projectModel = projectModel;
            issueController = new IssueController(userModel, issueModel, projectModel);
            projectList = user.JoinedProjects;
            Project nowProject = projectList.Find(x => x.ProjectId == projectId);
            projectComboBox.Items.Add(nowProject);
            projectComboBox.SelectedIndex = 0;
            projectComboBox.Enabled = false;
            issuePriorityComboBox.SelectedIndex = 0;
            issueSeverityComboBox.SelectedIndex = 0;
        }

        private void submitButtonClicked(object sender, EventArgs e)
        {
            Issue issue = new Issue();
            issue.ProjectId = ((Project)projectComboBox.SelectedItem).ProjectId;
            issue.IssueName = issueNameTextBox.Text;
            issue.Priority = (String)issuePriorityComboBox.SelectedItem;
            issue.Serverity = (String)issueSeverityComboBox.SelectedItem;
            issue.Description = issueDescriptionRichTextBox.Text;
            //issue.PersonInChargeId = ((Project)projectComboBox.SelectedItem).;
            issue.State = "待審核";
            issue = issueController.createIssue(issue);

            this.Owner.Show();
            this.Close();
        }
    }
}
