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
        private UserModel userModel;
        private IssueModel issueModel;
        private ProjectModel projectModel;
        private IssueController issueController;
        private Dictionary<String, int> resolvedIssues;
        private Dictionary<String, int> unresolvedIssues;
        private Dictionary<String, int> issueStates;
        private List<Issue> issueList;

        public Dictionary<String, int> IssueStates
        {
            get { return issueStates; }
            set { issueStates = value; }
        }

        public Dictionary<String, int> ResolvedIssues
        {
            get { return resolvedIssues; }
            set { resolvedIssues = value; }
        }

        public Dictionary<String, int> UnresolvedIssues
        {
            get { return unresolvedIssues; }
            set { unresolvedIssues = value; }
        }

        public ReportController(UserModel userModel, IssueModel issueModel, ProjectModel projectModel) {
            this.userModel = userModel;
            this.issueModel = issueModel;
            this.projectModel = projectModel;
            issueController = new IssueController(userModel, issueModel, projectModel);
            resolvedIssues = new Dictionary<String, int>();
            unresolvedIssues = new Dictionary<String, int>();
            issueStates = new Dictionary<string, int>();
        }

        public void updateResolvedAndUnresolvedIssuesByProject(int projectId) {
            unresolvedIssues.Clear();
            resolvedIssues.Clear();
            
            unresolvedIssues.Add("0", 0);
            resolvedIssues.Add("0", 0);

            issueList = issueController.getIssueList();
            foreach (Issue issue in issueList)
            {
                if (issue.ProjectId.Equals(projectId))
                {
                    List<Issue> issueHistory = issueController.getIssueDetails(issue.IssueId);
                    DateTime startDate = (issueHistory.Count > 1) ? issueHistory[1].ReportDate : issueHistory[0].ReportDate;
                    DateTime endDate = issueHistory[0].ReportDate;
                    if (issueHistory[0].State == "已完成")
                    {
                        DateTime date = startDate;
                        for (date.Date.ToString(); !date.Date.ToString().Equals(endDate.Date.ToString()); date = date.AddDays(1))
                        {
                            addIssues(date, false);
                            setZeroIssues(date, true);
                        }
                        addIssues(issueHistory[0].FinishDate.Date, true);
                        setZeroIssues(issueHistory[0].FinishDate.Date, false);
                    }
                    else
                    {
                        DateTime date = startDate;
                        for (date.Date.ToString(); !date.Date.ToString().Equals(DateTime.Now.AddDays(1).Date.ToString()); date = date.AddDays(1))
                        {
                            addIssues(date, false);
                            setZeroIssues(date, true);
                        }
                    }
                }
            }
        }

        public void updateResolvedAndUnresolvedIssuesByUser(int userId)
        {
            unresolvedIssues.Clear();
            resolvedIssues.Clear();

            unresolvedIssues.Add("0", 0);
            resolvedIssues.Add("0", 0);

            issueList = issueController.listAllIssues();
            foreach (Issue issue in issueList)
            {
                if (issue.PersonInChargeId == userId)
                {
                    List<Issue> issueHistory = issueController.getIssueDetails(issue.IssueId);
                    int issueFinishedIndex = issueHistory.FindIndex(x => x.PersonInChargeId == userId) + 1;
                    DateTime startDate = issue.ReportDate;
                    if (issueFinishedIndex < issueHistory.Count)
                    {
                        DateTime endDate = issueHistory[issueFinishedIndex].ReportDate;
                        {
                            DateTime date = startDate;
                            for (date.Date.ToString(); !date.Date.ToString().Equals(endDate.Date.ToString()); date = date.AddDays(1))
                            {
                                addIssues(date, false);
                                setZeroIssues(date, true);
                            }
                            addIssues(issueHistory[issueFinishedIndex].FinishDate.Date, true);
                            setZeroIssues(issueHistory[issueFinishedIndex].FinishDate.Date, false);
                        }
                    }
                    else
                    {
                        DateTime date = startDate;
                        for (date.Date.ToString(); !date.Date.ToString().Equals(DateTime.Now.AddDays(1).Date.ToString()); date = date.AddDays(1))
                        {
                            addIssues(date, false);
                            setZeroIssues(date, true);
                        }
                    }
                }
            }
        }

        public void updateIssueStatesByProject(int projectId)
        {
            issueStates.Clear();

            //issueList = issueController.getIssueList();
            issueList = issueModel.getIssueListByProjectId(projectId);
            int value = 0;
            foreach (Issue issue in issueList)
            {
                if (issue.FinishDate == DateTime.MaxValue || issue.State == "已完成")
                {
                    if (issueStates.TryGetValue(issue.State, out value))
                    {
                        issueStates.Remove(issue.State);
                        issueStates.Add(issue.State, value + 1);
                    }
                    else
                    {
                        issueStates.Add(issue.State, 1);
                    }
                }
            }
        }

        public void updateIssueStatesByUser(int userId)
        {
            issueStates.Clear();

            issueList = issueModel.getIssueListByUserId(userId);
            int value = 0;
            foreach (Issue issue in issueList)
            {
                if (issue.FinishDate == DateTime.MaxValue || issue.State == "已完成")
                {
                    if (issueStates.TryGetValue(issue.State, out value))
                    {
                        issueStates.Remove(issue.State);
                        issueStates.Add(issue.State, value + 1);
                    }
                    else
                    {
                        issueStates.Add(issue.State, 1);
                    }
                }
            }
        }

        private void addIssues(DateTime date, bool isResolved) {
            int value;
            if (!isResolved)
            {
                if (unresolvedIssues.TryGetValue(date.Date.ToString(), out value))
                {
                    unresolvedIssues.Remove(date.Date.ToString());
                    unresolvedIssues.Add(date.Date.ToString(), value + 1);
                }
                else
                {
                    unresolvedIssues.Add(date.Date.ToString(), 1);
                }
            }
            else
            {
                if (resolvedIssues.TryGetValue(date.Date.ToString(), out value))
                {
                    resolvedIssues.Remove(date.Date.ToString());
                    resolvedIssues.Add(date.Date.ToString(), value + 1);
                }
                else
                {
                    resolvedIssues.Add(date.Date.ToString(), 1);
                }
            }
        }
        private void setZeroIssues(DateTime date, bool isResolved)
        {
            int value;
            if (!isResolved)
            {
                if (!unresolvedIssues.TryGetValue(date.Date.ToString(), out value))
                {
                    unresolvedIssues.Add(date.Date.ToString(), 0);
                }
            }
            else
            {
                if (!resolvedIssues.TryGetValue(date.Date.ToString(), out value))
                {
                    resolvedIssues.Add(date.Date.ToString(), 0);
                }
            }
        }
    }
}
