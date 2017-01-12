﻿using IssueTrackingSystem.Model;
using IssueTrackingSystem.Model.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IssueTrackingSystem.PMS.Controller;
using IssueTrackingSystem.AMS.Controller;
using IssueTrackingSystem.PMS.View;

namespace IssueTrackingSystem.AMS.View
{
    public partial class ProjectListView : IssueTrackingSystem.View.BaseView
    {
        private List<Project> joinedProjectList;
        private List<Project> invitedProjectList;
        private List<Project> allProjectList;
        private User user;
        private UserModel userModel;
        private IssueModel issueModel;
        private ProjectModel projectModel;
        private ProjectMemberModel projectMemberModel;
        private ProjectInfoController projectInfoController;
        private ProjectListController projectListController;

        public ProjectListView(UserModel userModel, IssueModel issueModel, ProjectModel projectModel, ProjectMemberModel projectMemberModel)
            : base(userModel, issueModel, projectModel, projectMemberModel)
        {
            InitializeComponent();
            this.userModel = userModel;
            this.issueModel = issueModel;
            this.projectModel = projectModel;
            this.projectMemberModel = projectMemberModel;
            projectInfoController = new ProjectInfoController(projectModel);
            projectListController = new ProjectListController(projectModel, projectMemberModel);

            projectModel.projectDataChanged += updateView;
            projectMemberModel.projectMemberDataChanged += updateView;

            user = SecurityModel.getInstance().AuthenticatedUser;

            systemManagerTableLayoutPanel.Enabled = true;
            systemManagerTableLayoutPanel.Visible = true;
            generalUserTableLayoutPanel.Enabled = false;
            generalUserTableLayoutPanel.Visible = false;
        }

        public ProjectListView(int tabIndex, UserModel userModel, IssueModel issueModel, ProjectModel projectModel, ProjectMemberModel projectMemberModel)
            : base(userModel, issueModel, projectModel, projectMemberModel)
        {
            InitializeComponent();
            this.userModel = userModel;
            this.issueModel = issueModel;
            this.projectModel = projectModel;
            this.projectMemberModel = projectMemberModel;
            projectInfoController = new ProjectInfoController(projectModel);
            projectListController = new ProjectListController(projectModel, projectMemberModel);

            projectModel.projectDataChanged += updateView;
            projectMemberModel.projectMemberDataChanged += updateView;

            user = SecurityModel.getInstance().AuthenticatedUser;
            int userId = user.UserId;
            joinedProjectList = projectInfoController.getProjectListByUserId(userId);
            invitedProjectList = projectInfoController.getInvitedProjectListByUserId(userId);
            projectTabControl.SelectTab(tabIndex);

            systemManagerTableLayoutPanel.Enabled = false;
            systemManagerTableLayoutPanel.Visible = false;
            generalUserTableLayoutPanel.Enabled = true;
            generalUserTableLayoutPanel.Visible = true;
        }

        private void projectListViewLoad(object sender, EventArgs e)
        {
            updateView();
        }

        private void invitedProjectsDataGridViewCellContentClicked(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.RowIndex >= 0 && e.RowIndex < invitedProjectsDataGridView.RowCount) {
                projectListController.dealWithProjectInvitation((int)invitedProjectsDataGridView.Rows[e.RowIndex].Cells[0].Value, true);
            }
            else if (e.ColumnIndex == 5 && e.RowIndex >= 0 && e.RowIndex < invitedProjectsDataGridView.RowCount) {
                projectListController.dealWithProjectInvitation((int)invitedProjectsDataGridView.Rows[e.RowIndex].Cells[0].Value, false);
            }
        }

        private void joinedProjectsDataGridViewCellDoubleClicked(object sender, DataGridViewCellEventArgs e)
        {
            User user = SecurityModel.getInstance().AuthenticatedUser;
            if (e.RowIndex >= 0 && e.RowIndex < joinedProjectsDataGridView.RowCount)
            {
                joinedProjectsDataGridView.Rows[e.RowIndex].Selected = true;
                Form form = FindForm("ProjectMainMenu");
                if(form != null)
                    form.Show();
                else
                {
                    ProjectMainMenu projectMainMenu = new ProjectMainMenu((int)(joinedProjectsDataGridView.Rows[e.RowIndex].Cells[0].Value), userModel, issueModel, projectModel, projectMemberModel);
                    projectMainMenu.Show();
                }
                
            }
        }

        private void joinedProjectsDataGridViewCellClicked(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < joinedProjectsDataGridView.RowCount)
            {
                joinedProjectsDataGridView.Rows[e.RowIndex].Selected = true;
            }
        }

        private void updateView()
        {
            userModel.updateAuthenticatedUser(user.UserId);
            allProjectList = projectInfoController.getAllProjectList(user.UserId);
            allProjectList.Sort(compareProjectOrder);

            if (user.Authority == (int)User.AuthorityEnum.GeneralUser)
            {
                joinedProjectList = SecurityModel.getInstance().AuthenticatedUser.JoinedProjects;
                invitedProjectList = SecurityModel.getInstance().AuthenticatedUser.InvitedProjects;
                joinedProjectList.Sort(compareProjectOrder);
                invitedProjectList.Sort(compareProjectOrder);
                joinedProjectsDataGridView.Rows.Clear();
                invitedProjectsDataGridView.Rows.Clear();
                foreach (Project project in joinedProjectList)
                    joinedProjectsDataGridView.Rows.Add(new Object[] { project.ProjectId, project.ProjectName, project.Description.Replace("<br>", "; "), project.Manager});
                foreach (Project project in invitedProjectList)
                    invitedProjectsDataGridView.Rows.Add(new Object[] { project.ProjectId, project.ProjectName, project.Description.Replace("<br>", "; "), project.Manager, "接受", "拒絕" });
            }
            else
            {
                allProjectsDataGridView.Rows.Clear();
                foreach (Project project in allProjectList)
                    allProjectsDataGridView.Rows.Add(new Object[] { project.ProjectId, project.ProjectName, project.Description.Replace("<br>", "; "), project.Manager });
            }
        }

        private Form FindForm(string formName)
        {
            foreach (Form form in Application.OpenForms)//获得所有打开的窗体
            {
                if (form.Name == formName)
                {
                    return form;
                }
            }
            return null;
        }

        private int compareProjectOrder(Project a, Project b)
        {
            if (a.ProjectId > b.ProjectId)
                return 1;
            else if (a.ProjectId < b.ProjectId)
                return -1;
            return 0;
        }
    }
}
