using IssueTrackingSystem.Model.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTrackingSystem.Model
{
    class IssueModel
    {
        public void createIssue(Issue issue){
        
            //api

        }

        public Issue getIssuceInfo(int issueId) {
            Issue issue = new Issue();

            //api

            return issue;
        }

        public List<Issue> getIssueListByUserId(int userId) {
            List<Issue> issueList = new List<Issue>();

            //api

            return issueList;
        }

        public List<Issue> getIssueListByProjectId(int projectId) {
            List<Issue> issueList = new List<Issue>();

            //api

            return issueList;
        }

        public List<Issue> getAllIssueList() {
            List<Issue> issueList = new List<Issue>();

            //api

            return issueList;
        }

        public void updateIssue(Issue issue) { 
            
            //api

        }
    }
}
