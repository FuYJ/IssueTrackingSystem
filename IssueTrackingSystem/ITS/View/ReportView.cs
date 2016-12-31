using IssueTrackingSystem.AMS.Controller;
using IssueTrackingSystem.ITS.Controller;
using IssueTrackingSystem.Model;
using IssueTrackingSystem.Model.DataModel;
using IssueTrackingSystem.PMS.Controller;
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
        private ProjectMemberModel projectMemberModel;
        private ReportController reportController;
        private SecurityController securityController;
        private ProjectInfoController projectInfoController;
        private User user;
        private List<Issue> issueList;

        public ReportView(UserModel userModel, IssueModel issueModel, ProjectModel projectModel, ProjectMemberModel projectMemberModel)
            : base(userModel, issueModel, projectModel, projectMemberModel)
        {
            InitializeComponent();
            this.userModel = userModel;
            this.issueModel = issueModel;
            this.projectModel = projectModel;
            this.projectMemberModel = projectMemberModel;
            securityController = new SecurityController(userModel);
            projectInfoController = new ProjectInfoController();
            reportController = new ReportController(userModel, issueModel, projectModel);

            user = SecurityModel.getInstance().AuthenticatedUser;

            initializeView();
        }

        private void ReportViewLoad(object sender, EventArgs e)
        {
            projectInfoGroupBox.Visible = false;
        }

        private void updateChart()
        {
            if (searchTypeComboBox.SelectedIndex == 0)
            {
                int projectId = ((Project)searchKeyComboBox.SelectedItem).ProjectId;
                reportController.updateIssueStatesByProject(projectId);
                reportController.updateResolvedAndUnresolvedIssuesByProject(projectId);
            }
            else
            {
                int userId = ((User)searchKeyComboBox.SelectedItem).UserId;
                reportController.updateIssueStatesByUser(userId);
                reportController.updateResolvedAndUnresolvedIssuesByUser(userId);
            }

            pieChart.Series["issueStates"].Points.Clear();
            lineChart.Series["resolvedIssues"].Points.Clear();
            lineChart.Series["unresolvedIssues"].Points.Clear();

            //Draw Pie Chart
            Dictionary<String, int> issueStates = reportController.IssueStates;
            pieChart.Series["issueStates"].Points.DataBindXY(issueStates.Keys, issueStates.Values);
            pieChart.Series["issueStates"]["PieLabelStyle"] = "Outside";
            pieChart.Series["issueStates"]["PieLineColor"] = "Black";
            pieChart.Series["issueStates"].Label = "#AXISLABEL : #VALY\r\n#PERCENT{P1}";
            if (issueStates.Count == 0)
                toolStripStatusLabel.Text = "尚未有議題記錄";

            //Draw Line Chart
            Dictionary<String, int> resolvedIssues = reportController.ResolvedIssues;
            Dictionary<String, int> unresolvedIssues = reportController.UnresolvedIssues;
            lineChart.Series["resolvedIssues"].Points.DataBindXY(resolvedIssues.Keys, resolvedIssues.Values);
            lineChart.Series["unresolvedIssues"].Points.DataBindXY(unresolvedIssues.Keys, unresolvedIssues.Values);
            if (resolvedIssues.Count == 0 && unresolvedIssues.Count == 0)
                toolStripStatusLabel.Text = "尚未有議題記錄";
        
        }

        private void updateProjectInfo()
        {
            if (searchTypeComboBox.SelectedIndex == 0)
            {
                projectInfoGroupBox.Visible = true;
                Project project = (Project)searchKeyComboBox.SelectedItem;
                projectNameLabel.Text = project.ProjectName;
                projectDescriptionLabel.Text = project.Description;
                projectManagerLabel.Text = project.Manager;
                projectCreatedDateLabel.Text = project.TimeStamp.Date.ToString();
            }
            else {
                projectInfoGroupBox.Visible = false;
            }
        }

        private void initializeView()
        {
            if (user.Authority == (int)User.AuthorityEnum.GeneralUser)
            {
                searchTypeComboBox.SelectedIndex = 0;
                foreach (Project _project in user.JoinedProjects)
                    searchKeyComboBox.Items.Add(_project);
                if (searchKeyComboBox.Items.Count > 0)
                    searchKeyComboBox.SelectedIndex = 0;
            }
            else
            {
                searchTypeComboBox.SelectedIndex = 0;
                List<Project> projects = projectInfoController.getAllProjectList(user.UserId);
                foreach (Project _project in projects)
                    searchKeyComboBox.Items.Add(_project);
                if (searchKeyComboBox.Items.Count > 0)
                    searchKeyComboBox.SelectedIndex = 0;
            }
        }

        private void searchTypeComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            searchKeyComboBox.Items.Clear();
            if (user.Authority == (int)User.AuthorityEnum.GeneralUser)
            {
                if (searchTypeComboBox.SelectedIndex == 0)
                {
                    foreach (Project _project in user.JoinedProjects)
                        searchKeyComboBox.Items.Add(_project);
                    if (searchKeyComboBox.Items.Count > 0)
                        searchKeyComboBox.SelectedIndex = 0;
                }
                else
                {
                    searchKeyComboBox.Items.Add(user);
                    searchKeyComboBox.SelectedIndex = 0;
                }
            }
            else
            {
                if (searchTypeComboBox.SelectedIndex == 0)
                {
                    List<Project> projects = projectInfoController.getAllProjectList(user.UserId);
                    foreach (Project _project in projects)
                        searchKeyComboBox.Items.Add(_project);
                    if (searchKeyComboBox.Items.Count > 0)
                        searchKeyComboBox.SelectedIndex = 0;
                }
                else
                {
                    List<User> users = securityController.listAccounts();
                    foreach (User _user in users)
                        searchKeyComboBox.Items.Add(_user);
                    if (searchKeyComboBox.Items.Count > 0)
                        searchKeyComboBox.SelectedIndex = 0;
                }
            }
        }

        private void generateReportButtonClicked(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "";

            updateChart();
            updateProjectInfo();
        }
    }
}
