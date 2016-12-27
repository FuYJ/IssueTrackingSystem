using IssueTrackingSystem.AMS.Controller;
using IssueTrackingSystem.Model;
using IssueTrackingSystem.Model.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IssueTrackingSystem.AMS.View
{
    public partial class UserListView : IssueTrackingSystem.View.BaseView
    {
        private SecurityController securityController;
        private UserController userController;
        private UserModel userModel;
        private List<User> userList;

        public UserListView()
        {
            InitializeComponent();
            userModel = new UserModel();
            securityController = new SecurityController(userModel);
            userController = new UserController(userModel);

            userList = securityController.listAccounts();
        }

        private void AccountListViewLoad(object sender, EventArgs e)
        {
            foreach (User user in userList)
            {
                String userRole = null;
                if (user.Authority == (int)User.AuthorityEnum.GeneralUser)
                    userRole = "一般使用者";
                else
                    userRole = "系統管理員";
                userListDataGridView.Rows.Add(new Object[] { user.UserId, user.UserName, user.EmailAddress, userRole, user.JoinedProjects.Count, user.InvitedProjects.Count, user.Issues.Count, "刪除" });
            }
        }

        private void userRoleValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex >= 0) {
                User user = userModel.getUserInfo(int.Parse((String)userListDataGridView.Rows[e.RowIndex].Cells[0].Value));
                
            }
        }
    }
}
