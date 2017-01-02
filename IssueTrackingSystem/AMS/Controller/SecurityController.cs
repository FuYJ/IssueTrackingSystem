using IssueTrackingSystem.Model;
using IssueTrackingSystem.Model.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTrackingSystem.AMS.Controller
{
    class SecurityController
    {
        private UserModel userModel;

        public SecurityController(UserModel userModel) {
            this.userModel = userModel;
        }

        public List<User> listAccounts() {
            List<User> userList = new List<User>();

            userList = userModel.getUserList();

            return userList;
        }
    }
}
