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
        private List<Issue> issueList;
        private UserModel userModel;
        private UserController userController;
        private IssueModel issueModel;
        private IssueController issueController;

        public IssueListView()
        {
            InitializeComponent();
            issueList = SecurityModel.getInstance().AuthenticatedUser.Issues;
        }

        private void IssueListViewLoad(object sender, EventArgs e)
        {
            foreach(Issue issue in issueList){
                User reporter = userController.getUser(issue.ReporterId);
                User personInCharge = userController.getUser(issue.PersonInChargeId);
                issuesDataGridView.Rows.Add(new Object[] { issue.IssueId, issue.IssueName, issue.Priority, issue.Serverity, reporter.UserName, personInCharge.UserName, issue.ReportDate, issue.FinishDate, issue.State });
            }
        }

        private void createIssueButtonClicked(object sender, EventArgs e)
        {
            CreateIssueView createIssueView = new CreateIssueView();
            createIssueView.Show(this);
            this.Hide();
        }


    }
}
