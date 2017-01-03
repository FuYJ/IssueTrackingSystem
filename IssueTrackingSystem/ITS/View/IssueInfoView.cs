using IssueTrackingSystem.AMS.Controller;
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
    public partial class IssueInfoView : IssueTrackingSystem.View.BaseView
    {
        private UserModel userModel;
        private IssueModel issueModel;
        private ProjectModel projectModel;
        private ProjectMemberModel projectMemberModel;
        private UserController userController;
        private ProjectMemberController projectMemberController;
        private IssueController issueController;
        private List<Issue> issueDetails;
        private List<User> projectMembers;
        private User reporter;
        private User assignee;

        public IssueInfoView(int issueId, UserModel userModel, IssueModel issueModel, ProjectModel projectModel, ProjectMemberModel projectMemberModel)
            : base(userModel, issueModel, projectModel, projectMemberModel)
        {
            InitializeComponent();
            this.userModel = userModel;
            this.issueModel = issueModel;
            this.projectModel = projectModel;
            this.projectMemberModel = projectMemberModel;
            userController = new UserController(userModel);
            issueController = new IssueController(userModel, issueModel, projectModel);
            projectMemberController = new ProjectMemberController(projectMemberModel, userModel);

            issueDetails = issueController.getIssueDetails(issueId);
            projectMembers = projectMemberController.getUserByProjectId(issueDetails[0].ProjectId, true);
        }

        private void IssueInfoViewLoad(object sender, EventArgs e)
        {
            foreach (User projectMember in projectMembers)
                issueAssigneeComboBox.Items.Add(projectMember);
            updateIssueInfoView();
        }

        private void submitButtonClicked(object sender, EventArgs e)
        {
            if (submitButton.Text.Equals("提交議題"))
            {
                submitButton.Text = "確認提交";
                enableEditIssueInfo(true);
            }
            else
            {
                enableEditIssueInfo(false);
                submitButton.Text = "提交議題";

                Issue issue = new Issue();
                issue.IssueId = issueDetails[0].IssueId;
                issue.IssueGroupId = issueDetails[0].IssueGroupId;
                issue.IssueName = issueNameLabel.Text;
                issue.Description = issueDescriptionRichTextBox.Text.Replace("\n", "<br>");
                issue.State = (String)issueStateComboBox.SelectedItem;
                issue.Priority = (String)issuePriorityComboBox.SelectedItem;
                issue.Serverity = (String)issueSeverityComboBox.SelectedItem;
                issue.PersonInChargeId = ((User)issueAssigneeComboBox.SelectedItem).UserId;
                
                issue.IssueId = issueController.updateIssue(issue);
                if (issue.IssueId > 0)
                {
                    issueDetails = issueController.getIssueDetails(issue.IssueId);
                    updateIssueInfoView();
                }
            }
        }

        private void enableEditIssueInfo(bool isEnabled)
        {
            issueStateComboBox.Enabled = isEnabled;
            issuePriorityComboBox.Enabled = isEnabled;
            issueSeverityComboBox.Enabled = isEnabled;
            issueAssigneeComboBox.Enabled = isEnabled;
            issueDescriptionRichTextBox.Enabled = isEnabled;
            issueDescriptionRichTextBox.ReadOnly = !isEnabled;
        }

        private void updateIssueInfoView()
        {
            this.Text = issueDetails[0].IssueName;

            reporter = userController.getUser(issueDetails[0].ReporterId);
            assignee = userController.getUser(issueDetails[0].PersonInChargeId);

            issueNameLabel.Text = issueDetails[0].IssueName;
            issueStateComboBox.SelectedIndex = issueStateComboBox.FindStringExact(issueDetails[0].State);
            issuePriorityComboBox.SelectedIndex = issuePriorityComboBox.FindStringExact(issueDetails[0].Priority);
            issueSeverityComboBox.SelectedIndex = issueSeverityComboBox.FindStringExact(issueDetails[0].Serverity);
            issueReporterLabel.Text = reporter.UserName;
            issueReportDateLabel.Text = issueDetails[0].ReportDate.ToString();
            issueAssigneeComboBox.Text = assignee.UserName;
            issueDescriptionRichTextBox.Text = issueDetails[0].Description.Replace("<br>", "\n");

            issueHistoryFlowLayoutPanel.Controls.Clear();
            foreach (Issue issue in issueDetails) {
                if (issue.IssueId != issueDetails[0].IssueId)
                {
                    issueHistoryBlock block = new issueHistoryBlock();
                    reporter = userController.getUser(issue.ReporterId);
                    assignee = userController.getUser(issue.PersonInChargeId);
                    block.Width = issueHistoryFlowLayoutPanel.Width - 80;
                    block.Margin = new System.Windows.Forms.Padding(20);
                    block.issueNameLabel.Text = issue.IssueName;
                    block.issueStateLabel.Text = issue.State;
                    block.issueReporterLabel.Text = reporter.UserName;
                    block.issueReportDateLabel.Text = issue.ReportDate.ToString();
                    block.issueAssigneeLabel.Text = assignee.UserName;
                    block.issueFinishDateLabel.Text = issue.FinishDate.ToString();
                    block.issueDescriptionRichTextBox.Text = issue.Description.Replace("<br>", "\n");
                    issueHistoryFlowLayoutPanel.Controls.Add(block);
                }

            }
        }
    }
}
