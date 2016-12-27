using IssueTrackingSystem.Model;
using IssueTrackingSystem.Model.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTrackingSystem.ITS.Controller
{
    class IssueController
    {
        private IssueModel issueModel;

        public IssueController(IssueModel issueModel)
        {
            this.issueModel = issueModel;
        }

        public List<Issue> listAllIssues() {
            List<Issue> issueList = new List<Issue>();

            //api

            return issueList;
        }
        
        public List<Issue> listIssues(String keyword, String searchType)
        {
            List<Issue> issueList = new List<Issue>();

            //api

            return issueList;
        }

        public Issue getIssuedetails(int issueId)
        {
            Issue issue = new Issue();

            //api

            return issue;
        }

        public Issue createIssue(Issue issue)
        {
            issue = issueModel.createIssue(issue);

            return issue;
        }

        public Issue updateIssue(Issue issue)
        {

            //api

            return issue;
        }
    }
}
