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
        private ProjectMemberModel projectMemberModel;
        private IssueController issueController;
        private ProjectMemberController projectMemberController;
        private User user;
        private List<Project> projectList;


        public CreateIssueView(UserModel userModel, IssueModel issueModel, ProjectModel projectModel, ProjectMemberModel projectMemberModel)
            : base(userModel, issueModel, projectModel, projectMemberModel)
        {
            InitializeComponent();
            this.userModel = userModel;
            this.issueModel = issueModel;
            this.projectModel = projectModel;
            this.projectMemberModel = projectMemberModel;
            
            issueController = new IssueController(userModel, issueModel, projectModel);
            projectMemberController = new ProjectMemberController();
            user = SecurityModel.getInstance().AuthenticatedUser;
            projectList = user.JoinedProjects;
            foreach (Project project in projectList)
            {
                projectComboBox.Items.Add(project);
            }
            if (projectList.Count > 0)
            {
                projectComboBox.SelectedIndex = 0;
            }
            issuePriorityComboBox.SelectedIndex = 0;
            issueSeverityComboBox.SelectedIndex = 0;
        }

        public CreateIssueView(int projectId, UserModel userModel, IssueModel issueModel, ProjectModel projectModel, ProjectMemberModel projectMemberModel)
            : base(userModel, issueModel, projectModel, projectMemberModel)
        {
            InitializeComponent();
            this.userModel = userModel;
            this.issueModel = issueModel;
            this.projectModel = projectModel;
            this.projectMemberModel = projectMemberModel;
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
            ProjectMember projectMember = projectMemberController.getMemberByProjectId(((Project)projectComboBox.SelectedItem).ProjectId, true).Find(x => x.Role == "ProjectManager");
            issue.ProjectId = ((Project)projectComboBox.SelectedItem).ProjectId;
            issue.IssueName = issueNameTextBox.Text;
            issue.Priority = (String)issuePriorityComboBox.SelectedItem;
            issue.Serverity = (String)issueSeverityComboBox.SelectedItem;
            issue.Description = issueDescriptionRichTextBox.Text;
            issue.PersonInChargeId = projectMember.UserId;
            issue.State = "待審核";
            issue = issueController.createIssue(issue);

            this.Owner.Show();
            this.Close();
        }
    }
}
