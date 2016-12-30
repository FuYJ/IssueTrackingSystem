using IssueTrackingSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IssueTrackingSystem.PMS.Controller;
using IssueTrackingSystem.Model.DataModel;


namespace IssueTrackingSystem.PMS.View
{
    public partial class Member : IssueTrackingSystem.View.BaseView
    {
        private UserModel userModel;
        private IssueModel issueModel;
        private ProjectModel projectModel;
        private ProjectMemberController memberController = new ProjectMemberController();
        private Project project = new Project();
        private String UPDATE = "Update";
        private String DELETE = "Delete";

        public Member(UserModel userModel, IssueModel issueModel, ProjectModel projectModel, Project project)
                    : base(userModel, issueModel, projectModel)
        {
            InitializeComponent();
            this.userModel = userModel;
            this.issueModel = issueModel;
            this.projectModel = projectModel;
            this.project = project;
            ShowData();
            _dataGridView.Rows.Add("1", "TEST", "123", "general_user", "Update", "Delete");
        }

        public void ShowData()
        {
            if (_memberList.SelectedTab.Name.Equals("_existingMemberTable"))
            {
                ShowgMember(_dataGridView, true);
            }
            else if (_memberList.SelectedTab.Name.Equals("_joiningMemberTable"))
            {
                ShowgMember(_dataGridViewJoining, false);
            }
            else if (_memberList.SelectedTab.Name.Equals("_inviteMemberTable"))
            {

            }
        }

        public void ShowgMember(DataGridView table, bool joined)
        {
            List<ProjectMember> memberList = new List<ProjectMember>();
            List<User> userList = new List<User>();
            memberList = memberController.getMemberByProjectId(project.ProjectId, joined);
            userList = memberController.getUserByProjectId(project.ProjectId, joined);
            for(int i = 0; i < userList.Count; i++)
            {
                table.Rows.Add(userList[i].UserId.ToString(), userList[i].UserName, userList[i].EmailAddress, memberList[i].Role, UPDATE, DELETE);
            }
        }

        private void InviteMemberClicked(object sender, EventArgs e)
        {
            ProjectMember member = new ProjectMember();
//            memberController.createMember()
        }

        private void MemberListSelectedIndexChanged(object sender, EventArgs e)
        {
            ShowData();
        }

        private void DataGridViewCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int col = e.ColumnIndex;
            int row = e.RowIndex;
            if(e.RowIndex >= 0)
            {
                if(col == 4)
                {
                    UpdateMember(new ProjectMember(Convert.ToInt16(_dataGridView.Rows[row].Cells[0].Value), project.ProjectId, _dataGridView.Rows[row].Cells[3].Value.ToString()), true);
                }
                if(col == 5)
                {

                }
            }
        }

        public void UpdateMember(ProjectMember member, bool joined)
        {
            memberController.updateInfo(member, joined);
        }
    }
}
