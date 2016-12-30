using IssueTrackingSystem.AMS.Controller;
using IssueTrackingSystem.ITS.Controller;
using IssueTrackingSystem.Model;
using IssueTrackingSystem.Model.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IssueTrackingSystem.ITS.View
{
    public partial class IssueListView : IssueTrackingSystem.View.BaseView
    {
        private UserModel userModel;
        private IssueModel issueModel;
        private ProjectModel projectModel;
        private ProjectMemberModel projectMemberModel;
        private UserController userController;
        private IssueController issueController;

        private User user;
        private List<Issue> issueList;
        private String initialKeyword;
        private int initialSearchType;

        public IssueListView(UserModel userModel, IssueModel issueModel, ProjectModel projectModel, ProjectMemberModel projectMemberModel)
            : base(userModel, issueModel, projectModel, projectMemberModel)
        {
            InitializeComponent();
            this.userModel = userModel;
            this.issueModel = issueModel;
            this.projectModel = projectModel;
            this.projectMemberModel = projectMemberModel;
            userController = new UserController(userModel);
            issueController = new IssueController(userModel, issueModel, projectModel);

            user = SecurityModel.getInstance().AuthenticatedUser;
            initialKeyword = user.UserName;
            initialSearchType = (int)Issue.SearchType.ByPersonInChargeName;
        }

        private void IssueListViewLoad(object sender, EventArgs e)
        {
            keywordTextBox.Text = initialKeyword;
            selectSearchTypeComboBox.SelectedIndex = initialSearchType;
            issueList = issueController.searchIssues(keywordTextBox.Text, selectSearchTypeComboBox.SelectedIndex);

            issuesDataGridView.Rows.Clear();
            foreach(Issue issue in issueList){
                User reporter = userController.getUser(issue.ReporterId);
                User personInCharge = userController.getUser(issue.PersonInChargeId);
                issuesDataGridView.Rows.Add(new Object[] { issue.IssueId, issue.IssueName, issue.Priority, issue.Serverity, reporter.UserName, personInCharge.UserName, issue.ReportDate.Date, user.JoinedProjects.Find(x => x.ProjectId == issue.ProjectId).ProjectName, issue.State });
            }
        }

        private void createIssueButtonClicked(object sender, EventArgs e)
        {
            CreateIssueView createIssueView = new CreateIssueView(userModel, issueModel, projectModel, projectMemberModel);
            createIssueView.Show(this);
            this.Hide();
        }

        private void searchButtonClicked(object sender, EventArgs e)
        {
            issueList = issueController.searchIssues(keywordTextBox.Text, selectSearchTypeComboBox.SelectedIndex);
            issuesDataGridView.Rows.Clear();
            foreach (Issue issue in issueList)
            {
                User reporter = userController.getUser(issue.ReporterId);
                User personInCharge = userController.getUser(issue.PersonInChargeId);
                issuesDataGridView.Rows.Add(new Object[] { issue.IssueId, issue.IssueName, issue.Priority, issue.Serverity, reporter.UserName, personInCharge.UserName, issue.ReportDate, user.JoinedProjects.Find(x => x.ProjectId == issue.ProjectId).ProjectName, issue.State });
            }
        }

        private void issuesDataGridViewCellDoubleClicked(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < issuesDataGridView.RowCount)
            {
                IssueInfoView issueInfoView = new IssueInfoView((int)issuesDataGridView.Rows[e.RowIndex].Cells[0].Value, userModel, issueModel, projectModel, projectMemberModel);
                issueInfoView.Show(this);
            }
        }

        private void viewStatisticReportButtonClicked(object sender, EventArgs e)
        {
            ReportView reportView = new ReportView(issueList, userModel, issueModel, projectModel, projectMemberModel);
            reportView.Show(this);
        }
    }
}
