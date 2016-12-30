﻿using IssueTrackingSystem.Model.DataModel;
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
    public class IssueModel
    {
        public event ModelChangedEventHandler issueDataChanged;
        public delegate void ModelChangedEventHandler();

        public Issue createIssue(Issue issue)
        {
            User user = SecurityModel.getInstance().AuthenticatedUser;
            var req = WebRequest.Create(Server.ApiUrl + "/issues/" + user.UserId + "/" + issue.ProjectId);
            req.Method = "POST";
            req.ContentType = "application/json";
            String contentData = "{\"title\":\"" + issue.IssueName + "\"," +
                                  "\"description\":\"" + issue.Description + "\"," +
                                  "\"state\":\"" + issue.State + "\"," +
                                  "\"serverity\":\"" + issue.Serverity + "\"," +
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
                issue.ReportDate = new DateTime((new DateTime(1970, 1, 1, 0, 0, 0).Ticks) + (long)issueApiModel.issue.reportTime * 10000).ToLocalTime();
                issue.FinishDate = DateTime.MaxValue;
            }
            Notify();

            return issue;
        }

        public Issue getIssueInfo(int issueId)
        {
            Issue issue = new Issue();
            User user = SecurityModel.getInstance().AuthenticatedUser;
            
            var req = WebRequest.Create(Server.ApiUrl + "/issues/" + user.UserId + "/" + issueId);
            req.Method = "GET";
            
            var resp = (HttpWebResponse)req.GetResponse();
            using (var reader = new StreamReader(resp.GetResponseStream()))
            {
                var issueData = reader.ReadToEnd();
                dynamic issueApiModel = JsonConvert.DeserializeObject<dynamic>(issueData);
                issue.IssueId = formatStateToIssueId((String)issueApiModel.state, (String)issueApiModel.issue.issueId);
                issue.State = issueApiModel.issue.state;
                issue.IssueName = issueApiModel.issue.title;
                issue.IssueGroupId = issueApiModel.issue.issueGroupId;
                issue.Description = issueApiModel.issue.description;
                issue.Priority = issueApiModel.issue.priority;
                issue.Serverity = issueApiModel.issue.serverity;
                issue.ReporterId = issueApiModel.issue.reporterId;
                issue.ReportDate = new DateTime((new DateTime(1970, 1, 1, 0, 0, 0).Ticks) + (long)issueApiModel.issue.reportTime * 10000).ToLocalTime();
                issue.PersonInChargeId = issueApiModel.issue.personInChargeId;
                issue.FinishDate = (issueApiModel.issue.finishTime == null) ? DateTime.MaxValue : new DateTime((new DateTime(1970, 1, 1, 0, 0, 0).Ticks) + (long)issueApiModel.issue.finishTime * 10000).ToLocalTime();
                issue.ProjectId = issueApiModel.issue.projectId;
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
                if ((int)issueApiModel.state == 0)
                {
                    foreach (dynamic o in issueApiModel.list)
                    {
                        Issue issue = new Issue();
                        issue.IssueId = o.issueId;
                        issue.IssueGroupId = o.issueGroupId;
                        issue.State = o.state;
                        issue.IssueName = o.title;
                        issue.IssueGroupId = o.issueGroupId;
                        issue.Description = o.description;
                        issue.Serverity = o.serverity;
                        issue.Priority = o.priority;
                        issue.ReporterId = o.reporterId;
                        issue.ReportDate = new DateTime((new DateTime(1970, 1, 1, 0, 0, 0).Ticks) + (long)o.reportTime * 10000).ToLocalTime();
                        issue.PersonInChargeId = o.personInChargeId;
                        issue.FinishDate = (o.finishTime == null) ? DateTime.MaxValue : new DateTime((new DateTime(1970, 1, 1, 0, 0, 0).Ticks) + (long)o.finishTime * 10000).ToLocalTime();
                        issue.ProjectId = o.projectId;
                        issueList.Add(issue);
                    }
                }
            }

            return issueList;
        }

        public List<Issue> getIssueListByProjectId(int projectId)
        {
            List<Issue> issueList = new List<Issue>();
            User user = SecurityModel.getInstance().AuthenticatedUser;

            var req = WebRequest.Create(Server.ApiUrl + "/issues/list/" + user.UserId + "/" + projectId);

            req.Method = "GET";
            req.ContentType = "application/json";

            var resp = (HttpWebResponse)req.GetResponse();
            using (var reader = new StreamReader(resp.GetResponseStream()))
            {
                var issueData = reader.ReadToEnd();
                dynamic issueApiModel = JsonConvert.DeserializeObject<dynamic>(issueData);
                if ((int)issueApiModel.state == 0)
                {
                    foreach (dynamic o in issueApiModel.list)
                    {
                        Issue issue = new Issue();
                        issue.IssueId = o.issueId;
                        issue.IssueGroupId = o.issueGroupId;
                        issue.State = o.state;
                        issue.IssueName = o.title;
                        issue.Description = o.description;
                        issue.Serverity = o.serverity;
                        issue.Priority = o.priority;
                        issue.ReporterId = o.reporterId;
                        issue.ReportDate = new DateTime((new DateTime(1970, 1, 1, 0, 0, 0).Ticks) + (long)o.reportTime * 10000).ToLocalTime();
                        issue.PersonInChargeId = o.personInChargeId;
                        issue.FinishDate = (o.finishTime == null) ? DateTime.MaxValue : new DateTime((new DateTime(1970, 1, 1, 0, 0, 0).Ticks) + (long)o.finishTime * 10000).ToLocalTime();
                        issue.ProjectId = o.projectId;
                        issueList.Add(issue);
                    }
                }
            }

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
                if ((int)issueApiModel.state == 0)
                {
                    foreach (dynamic o in issueApiModel.list)
                    {
                        Issue issue = new Issue();
                        issue.IssueId = o.issueId;
                        issue.IssueGroupId = o.issueGroupId;
                        issue.State = o.state;
                        issue.IssueName = o.title;
                        issue.Description = o.description;
                        issue.Serverity = o.serverity;
                        issue.Priority = o.priority;
                        issue.ReporterId = o.reporterId;
                        issue.ReportDate = new DateTime((new DateTime(1970, 1, 1, 0, 0, 0).Ticks) + (long)o.reportTime * 10000).AddHours(8);
                        issue.PersonInChargeId = o.personInChargeId;
                        issue.FinishDate = (o.finishTime == null) ? DateTime.MaxValue : new DateTime((new DateTime(1970, 1, 1, 0, 0, 0).Ticks) + (long)o.finishTime * 10000).ToLocalTime();
                        issue.ProjectId = o.projectId;
                        issueList.Add(issue);
                    }
                }
            }

            return issueList;
        }

        public int updateIssue(Issue issue)
        {
            User user = SecurityModel.getInstance().AuthenticatedUser;

            var req = WebRequest.Create(Server.ApiUrl + "/issues/put/" + user.UserId + "/" + issue.IssueId);
            req.Method = "POST";
            req.ContentType = "application/json";
            String contentData = "{\"title\":\"" + issue.IssueName + "\"," +
                                  "\"description\":\"" + issue.Description + "\"," +
                                  "\"state\":\"" + issue.State + "\"," +
                                  "\"serverity\":\"" + issue.Serverity + "\"," +
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
                issue.IssueId = formatStateToIssueId((String)issueApiModel.state, (String)issueApiModel.issueId);
            }
            Notify();

            return issue.IssueId;
        }

        private int formatStateToIssueId(String state, String issueId)
        {
            if (int.Parse(state) == 0)
            {
                return int.Parse(issueId);
            }
            else
            {
                return -int.Parse(state);
            }
        }

        void Notify()
        {
            if (issueDataChanged != null)
            {
                issueDataChanged();
            }
        }
    }
}
