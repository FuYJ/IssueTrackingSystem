using IssueTrackingSystem.Model.DataModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IssueTrackingSystem.Model
{
    class IssueModel
    {
        public Issue createIssue(Issue issue)
        {
            User user = SecurityModel.getInstance().AuthenticatedUser;
            var req = WebRequest.Create(Server.ApiUrl + "/issues/" + user.UserId + "/" + issue.ProjectId);
            req.Method = "POST";
            req.ContentType = "application/json";
            String contentData = "{\"title\":\"" + issue.IssueName + "\"," +
                                  "\"description\":\"" + issue.Description + "\"," +
                                  "\"state\":\"" + user.EmailAddress + "\"," +
                                  "\"severity\":\"" + issue.Serverity + "\"," +
                                  "\"priority\":\"" + issue.Priority + "\"," +
                                  "\"personInChargeId\":\"" + issue.PersonInChargeId + "\"}";
            using (var writer = new StreamWriter(req.GetRequestStream()))
            {
                writer.Write(contentData);
            }

            var resp = (HttpWebResponse)req.GetResponse();
            using (var reader = new StreamReader(resp.GetResponseStream()))
            {
                var issueData = reader.ReadToEnd();
                dynamic issueApiModel = JsonConvert.DeserializeObject<dynamic>(issueData);
                issue.IssueId = formatStateToIssueId((String)issueApiModel.state, (String)issueApiModel.issue.issueId);
                issue.IssueGroupId = issueApiModel.issue.issueGroupId;
                issue.ReporterId = issueApiModel.issue.reporterId;
                issue.ReportDate = DateTime.FromFileTime((long)issueApiModel.issue.reportTime);
                issue.FinishDate = DateTime.MaxValue;
            }

            return issue;
        }

        public Issue getIssueInfo(int issueId)
        {
            Issue issue = new Issue();
            User user = SecurityModel.getInstance().AuthenticatedUser;
            
            var req = WebRequest.Create(Server.ApiUrl + "/issues/" + user.UserId + "/" + issue.IssueId);
            req.Method = "GET";
            
            var resp = (HttpWebResponse)req.GetResponse();
            using (var reader = new StreamReader(resp.GetResponseStream()))
            {
                var issueData = reader.ReadToEnd();
                dynamic issueApiModel = JsonConvert.DeserializeObject<dynamic>(issueData);
                issue.IssueId = formatStateToIssueId((String)issueApiModel.state, (String)issueApiModel.issue.issueId);
                issue.IssueName = issueApiModel.issue.title;
                issue.IssueGroupId = issueApiModel.issue.issueGroupId;
                issue.Description = issueApiModel.issue.description;
                issue.Priority = issueApiModel.issue.priority;
                issue.Serverity = issueApiModel.issue.serverity;
                issue.ReporterId = issueApiModel.issue.reporterId;
                issue.ReportDate = DateTime.FromFileTime((long)issueApiModel.issue.reportTime);
                issue.PersonInChargeId = issueApiModel.issue.personInChargeId;
                issue.FinishDate = (issueApiModel.issue.finishTime == String.Empty) ? DateTime.MaxValue : DateTime.FromFileTime((long)issueApiModel.issue.finishTime);
            }

            return issue;
        }

        public List<Issue> getIssueListByUserId(int userId) {
            List<Issue> issueList = new List<Issue>();

            var req = WebRequest.Create(Server.ApiUrl + "/issues/list/" + userId);
            req.Method = "GET";
            req.ContentType = "application/json";

            var resp = (HttpWebResponse)req.GetResponse();
            using (var reader = new StreamReader(resp.GetResponseStream()))
            {
                var issueData = reader.ReadToEnd();
                dynamic issueApiModel = JsonConvert.DeserializeObject<dynamic>(issueData);
                foreach (dynamic o in issueApiModel)
                {
                    if ((int)o.issue.state == 0)
                    {
                        Issue issue = new Issue();
                        issue.IssueId = o.issue.issueId;
                        issue.IssueName = o.issue.title;
                        issue.Description = o.issue.description;
                        issue.Serverity = o.issue.serverity;
                        issue.Priority = o.issue.priority;
                        issue.ReporterId = o.issue.reporterId;
                        issue.ReportDate = DateTime.FromFileTime((long)o.issue.reportTime);
                        issue.PersonInChargeId = o.issue.personInChargeId;
                        issue.FinishDate = (o.issue.finishTime == String.Empty) ? DateTime.MaxValue : DateTime.FromFileTime((long)o.issue.finishTime);
                        issueList.Add(issue);
                    }
                }
            }

            return issueList;
        }

        public List<Issue> getIssueListByProjectId(int projectId) {
            List<Issue> issueList = new List<Issue>();

            //api

            return issueList;
        }

        public List<Issue> getAllIssueList()
        {
            List<Issue> issueList = new List<Issue>();
            User user = SecurityModel.getInstance().AuthenticatedUser;

            var req = WebRequest.Create(Server.ApiUrl + "/issues/" + user.UserId);
            req.Method = "GET";
            req.ContentType = "application/json";

            var resp = (HttpWebResponse)req.GetResponse();
            using (var reader = new StreamReader(resp.GetResponseStream()))
            {
                var issueData = reader.ReadToEnd();
                dynamic issueApiModel = JsonConvert.DeserializeObject<dynamic>(issueData);
                foreach (dynamic o in issueApiModel)
                {
                    if ((int)o.issue.state == 0)
                    {
                        Issue issue = new Issue();
                        issue.IssueId = o.issue.issueId;
                        issue.IssueName = o.issue.title;
                        issue.Description = o.issue.description;
                        issue.Serverity = o.issue.serverity;
                        issue.Priority = o.issue.priority;
                        issue.ReporterId = o.issue.reporterId;
                        issue.ReportDate = DateTime.FromFileTime((long)o.issue.reportTime);
                        issue.PersonInChargeId = o.issue.personInChargeId;
                        issue.FinishDate = (o.issue.finishTime == String.Empty) ? DateTime.MaxValue : DateTime.FromFileTime((long)o.issue.finishTime);
                        issueList.Add(issue);
                    }
                }
            }

            return issueList;
        }

        public void updateIssue(Issue issue) { 
            
            //api

        }

        private int formatStateToIssueId(String state, String issueId)
        {
            if (int.Parse(state) == 0)
            {
                return int.Parse(issueId);
            }
            else
            {
                return 0;
            }
        }
    }
}
