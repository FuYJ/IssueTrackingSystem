using IssueTrackingSystem.Model;
using IssueTrackingSystem.Model.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTrackingSystem.ITS.Controller
{
    class ReportController
    {
        private IssueModel issueModel;

        public ReportController(IssueModel issueModel) {
            this.issueModel = issueModel;
        }

        public List<Issue> getIssuesByProject(int projectId){
            List<Issue> issueList = new List<Issue>();

            //api

            return issueList;
        }
        public List<Issue> getIssuesByUser(int userId)
        {
            List<Issue> issueList = new List<Issue>();

            //api

            return issueList;
        }
    }
}
