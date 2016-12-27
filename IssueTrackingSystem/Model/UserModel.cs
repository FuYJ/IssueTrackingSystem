using IssueTrackingSystem.Model.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using IssueTrackingSystem.Model.ApiModel;
using Newtonsoft.Json.Linq;
using Chsword;

namespace IssueTrackingSystem.Model
{
    class UserModel
    {
        public User createUser(User user)
        {
            var req = WebRequest.Create(Server.ApiUrl + "/users");
            req.Method = "POST";
            req.ContentType = "application/json";
            String contentData = "{\"name\":\"" + user.UserName + "\"," +
                                  "\"password\":\"" + user.Password + "\"," +
                                  "\"emailAddress\":\"" + user.EmailAddress + "\"}";
            using (var writer = new StreamWriter(req.GetRequestStream()))
            {
                writer.Write(contentData);
            }

            var resp = (HttpWebResponse)req.GetResponse();
            using (var reader = new StreamReader(resp.GetResponseStream()))
            {
                var userData = reader.ReadToEnd();
                UserApiModel userApiModel = new UserApiModel();
                userApiModel = JsonConvert.DeserializeObject<UserApiModel>(userData);

                user.UserId = formatStateToUserId(userApiModel.State, userApiModel.UserId);
            }

            return user;
        }

        public User authenticateUser(User user)
        {
            var req = WebRequest.Create(Server.ApiUrl + "/session");
            req.Method = "POST";
            req.ContentType = "application/json";
            String contentData = "{\"name\":\"" + user.UserName + "\"," +
                                  "\"password\":\"" + user.Password + "\"}";
            using (var writer = new StreamWriter(req.GetRequestStream())) {
                writer.Write(contentData);
            }

            var resp = (HttpWebResponse)req.GetResponse();
            using (var reader = new StreamReader(resp.GetResponseStream()))
            {
                var userData = reader.ReadToEnd();
                UserApiModel userApiModel = new UserApiModel();
                userApiModel = JsonConvert.DeserializeObject<UserApiModel>(userData);

                user.Authority = formatUserRoleToAuthority(userApiModel.UserRole);
                user.UserId = formatStateToUserId(userApiModel.State, userApiModel.UserId);
            }
            getUserInfo(user.UserId);
            return user;
        }

        public User getUserInfo(int userId) {
            User user = new User();

            var req = WebRequest.Create(Server.ApiUrl + "/users/" + userId);
            req.Method = "GET";

            var resp = (HttpWebResponse)req.GetResponse();
            using (var reader = new StreamReader(resp.GetResponseStream()))
            {
                var userData = reader.ReadToEnd();
                UserApiModel userApiModel = new UserApiModel();
                userApiModel = JsonConvert.DeserializeObject<UserApiModel>(userData);

                user.UserId = formatStateToUserId(userApiModel.State, userApiModel.UserId);
                user.UserName = userApiModel.Name;
                user.EmailAddress = userApiModel.EmailAddress;
                user.Authority = formatUserRoleToAuthority(userApiModel.UserRole);
                user.JoinedProjects = getJoinedProjectsByUser(user.UserId);
                user.InvitedProjects = getInvitedProjectsByUser(user.UserId);
                user.Issues = new List<Issue>();
            }
            SecurityModel.getInstance().AuthenticatedUser = user;
            return user;
        }

        public List<User> getUserList() {
            List<User> userList = new List<User>();
            var req = WebRequest.Create(Server.ApiUrl + "/users/list/" + SecurityModel.getInstance().AuthenticatedUser.UserId);
            req.Method = "GET";

            var resp = (HttpWebResponse)req.GetResponse();
            using (var reader = new StreamReader(resp.GetResponseStream()))
            {
                var userData = reader.ReadToEnd();
                dynamic userApiModel = new JDynamic(userData);

                if (userApiModel.state == 0)
                {
                    foreach (dynamic o in userApiModel.list)
                    {
                        User user = new User();
                        user.Authority = formatUserRoleToAuthority(o.userRole);
                        user.UserId = o.userId;
                        user.UserName = o.name;
                        user.EmailAddress = o.emailAddress;
                        user.JoinedProjects = getJoinedProjectsByUser(user.UserId);
                        user.InvitedProjects = getInvitedProjectsByUser(user.UserId);
                        user.Issues = new List<Issue>();
                        userList.Add(user);
                    }
                }
                else {
                    userList = null;
                }
            }
            return userList;
        }

        public User updateUserInfo(User user)
        {
            var req = WebRequest.Create(Server.ApiUrl + "/users/" + user.UserId);
            req.Method = "PUT";
            req.ContentType = "application/json";
            String contentData = "{\"name\":\"" + user.UserName + "\"," +
                                  "\"password\":\"" + user.Password + "\"," +
                                  "\"userRole\":\"" + getUserRole(user.Authority) + "\"," +
                                  "\"emailAddress\":\"" + user.EmailAddress + "\"}";
            using (var writer = new StreamWriter(req.GetRequestStream()))
            {
                writer.Write(contentData);
            }

            var resp = (HttpWebResponse)req.GetResponse();
            using (var reader = new StreamReader(resp.GetResponseStream()))
            {
                var userData = reader.ReadToEnd();
                String state = userData;

                user.UserId = formatStateToUserId(state, user.UserId.ToString());
            }
            getUserInfo(user.UserId);
            return user;
        }

        public void deleteUser(int userId) { 
            
            //api

        }

        private int formatStateToUserId(String state, String userId) {
            if (int.Parse(state) == 0)
            {
                return int.Parse(userId);
            }
            else
            {
                return 0;
            }
        }

        private int formatUserRoleToAuthority(String userRole)
        {
            if (userRole == "SystemManager")
            {
                return (int)User.AuthorityEnum.SystemManager;
            }
            else
            {
                return (int)User.AuthorityEnum.GeneralUser;
            }
        }

        private String getUserRole(int authority) {
            if (authority == (int)User.AuthorityEnum.SystemManager)
                return "SystemManager";
            else
                return "GeneralUser";
        }

        private List<Project> getJoinedProjectsByUser(int userId) {
            List<Project> projectList = new List<Project>();
            var req = WebRequest.Create(Server.ApiUrl + "/projects/list/" + userId);
            req.Method = "GET";
            
            var resp = (HttpWebResponse)req.GetResponse();
            using (var reader = new StreamReader(resp.GetResponseStream()))
            {
                var userData = reader.ReadToEnd();
                dynamic userApiModel = JsonConvert.DeserializeObject<dynamic>(userData);
                int state = int.Parse((string)userApiModel.state);

                if (state == 0)
                {
                    foreach (dynamic o in userApiModel.list)
                    {
                        Project project = new Project();
                        project.ProjectId = o.projectId;
                        project.ProjectName = o.projectName;
                        project.Description = o.description;
                        project.Manager = o.manager;
                        project.TimeStamp = DateTime.FromFileTime(long.Parse((string)o.timeStamp));
                        projectList.Add(project);
                    }
                }
            }
            return projectList;
        }

        private List<Project> getInvitedProjectsByUser(int userId)
        {
            List<Project> projectList = new List<Project>();
            var req = WebRequest.Create(Server.ApiUrl + "/projects/" + userId);
            req.Method = "GET";

            var resp = (HttpWebResponse)req.GetResponse();
            using (var reader = new StreamReader(resp.GetResponseStream()))
            {
                var userData = reader.ReadToEnd();
                dynamic userApiModel = JsonConvert.DeserializeObject<dynamic>(userData);
                int state = int.Parse((string)userApiModel.state);

                if (state == 0)
                {
                    foreach (dynamic o in userApiModel.list)
                    {
                        Project project = new Project();
                        project.ProjectId = o.projectId;
                        project.ProjectName = o.projectName;
                        project.Description = o.description;
                        project.Manager = o.manager;
                        project.TimeStamp = DateTime.FromFileTime(long.Parse((string)o.timeStamp));
                        projectList.Add(project);
                    }
                }
            }
            return projectList;
        }
    }
}
