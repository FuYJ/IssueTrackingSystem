using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IssueTrackingSystem.Model;
using IssueTrackingSystem.Model.DataModel;

namespace IssueTrackingSystem.PMS.View
{
    public partial class IssueList : Form
    {
        UserModel userModel;
        IssueModel issueModel;
        ProjectModel projectModel;
        ProjectMemberModel projectMemberModel;
        Project projectContext;

        public IssueList(UserModel userModel, IssueModel issueModel, ProjectModel projectModel, ProjectMemberModel projectMemberModel, Project project)
        {
            InitializeComponent();
            this.userModel = userModel;
            this.issueModel = issueModel;
            this.projectModel = projectModel;
            this.projectMemberModel = projectMemberModel;
            this.projectContext = project;
            this.projectModel.projectDataChanged += Update;
            this.issueModel.issueDataChanged += ShowIssue;
            Update();
            ShowIssue();
        }

        public void Update()
        {
            projectContext = projectModel.getProjectInfo(SecurityModel.getInstance().AuthenticatedUser.UserId, projectContext.ProjectId);
            _projectName.Text = projectContext.ProjectName;
        }

        public void ShowIssue()
        {
            issuesDataGridView.Rows.Clear();
            List<Issue> issueList = new List<Issue>();
            issueList = issueModel.getIssueListByProjectId(projectContext.ProjectId);
            issueList.Sort(compareIssueOrder);
            for(int i = 0; i < issueList.Count; i++)
            {
                issuesDataGridView.Rows.Add(
                    issueList[i].IssueId, 
                    issueList[i].IssueName, 
                    issueList[i].Priority, 
                    issueList[i].Serverity, 
                    issueList[i].ReporterId, 
                    issueList[i].PersonInChargeId, 
                    issueList[i].ReportDate, 
                    issueList[i].IssueGroupId, 
                    issueList[i].State);
            }
        }

        private void DeleteButtonClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private int compareIssueOrder(Issue a, Issue b)
        {
            if (a.IssueId > b.IssueId)
                return 1;
            else if (a.IssueId < b.IssueId)
                return -1;
            return 0;
        }
    }
}
