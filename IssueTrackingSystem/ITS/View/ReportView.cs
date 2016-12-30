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
    public partial class ReportView : IssueTrackingSystem.View.BaseView
    {
        private UserModel userModel;
        private IssueModel issueModel;
        private ProjectModel projectModel;
        private List<Issue> issueList;

        public ReportView(List<Issue> issueList, UserModel userModel, IssueModel issueModel, ProjectModel projectModel)
            : base(userModel, issueModel, projectModel)
        {
            InitializeComponent();
            this.userModel = userModel;
            this.issueModel = issueModel;
            this.projectModel = projectModel;

            this.issueList = issueList;
        }

        private void ReportViewLoad(object sender, EventArgs e)
        {
            Dictionary<String, int> issueStatus = new Dictionary<string,int>();
            int value = 0;
            foreach (Issue issue in issueList) {
                if (issueStatus.TryGetValue(issue.State, out value))
                {
                    issueStatus.Remove(issue.State);
                    issueStatus.Add(issue.State, value + 1);
                }
                else
                {
                    issueStatus.Add(issue.State, 1);
                }
            }
            pieChart.Series["Series1"].Points.DataBindXY(issueStatus.Keys, issueStatus.Values);

            Dictionary<String, int> resolvedIssues = new Dictionary<String, int>();
            Dictionary<String, int> unresolvedIssues = new Dictionary<String, int>();
            foreach (Issue issue in issueList)
            {
            }
            lineChart.Series["ResolvedIssueSeries"].Points.DataBindXY(issueStatus.Keys, issueStatus.Values);
            lineChart.Series["UnresolvedIssueSeries"].Points.DataBindXY(issueStatus.Keys, issueStatus.Values);
        }
    }
}
