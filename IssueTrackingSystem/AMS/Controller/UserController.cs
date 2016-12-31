using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueTrackingSystem.Model;
using IssueTrackingSystem.Model.DataModel;

namespace IssueTrackingSystem.AMS.Controller
{
    class UserController
    {
        private UserModel userModel;

        public UserController(UserModel userModel) {
            this.userModel = userModel;
        }

        public User createUser(User user) 
        {
            user = userModel.createUser(user);

            return user;
        }

        public User authenticateUser(User user)
        {
            user = userModel.authenticateUser(user);

            return user;
        }

        public User updateUser(User user)
        {
            user = userModel.updateUserInfo(user);

            return user;
        }

        public User getUser(int userId) {
            User user = new User();

            user = userModel.getUserInfo(userId);

            return user;
        }

        public int deleteUser(int userId) {
            return userModel.deleteUser(userId);
        }
    }
}
