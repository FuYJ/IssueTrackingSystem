using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueTrackingSystem.Model.DataModel;
using Newtonsoft.Json;
using IssueTrackingSystem.Model.ApiModel;
using System.Net;
using System.IO;
using Chsword;

namespace IssueTrackingSystem.Model
{
    class ProjectModel
    {
        public void createProject(int userId, Project project)
        {
            var req = WebRequest.Create(Server.ApiUrl + "/projects/" + userId);
            req.Method = "POST";
            req.ContentType = "application/json";
            String contentData = "{\"projectName\":\"" + project.ProjectName + "\"," +
                                  "\"description\":\"" + project.Description + "\"}";
            using (var writer = new StreamWriter(req.GetRequestStream()))
            {
                writer.Write(contentData);
            }

            var resp = (HttpWebResponse)req.GetResponse();
            using (var reader = new StreamReader(resp.GetResponseStream()))
            {
                var projectData = reader.ReadToEnd();
                dynamic projectApiModel = JsonConvert.DeserializeObject<dynamic>(projectData);
                if (projectApiModel.state == 0)
                {
/*                    foreach (dynamic o in projectApiModel.list)
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
                    }*/
                }
                else {
                    
                }
            }
        }

        public void getProjectInfo()
        {

        }

        public void getProjectListByUserId()
        {

        }

        public void getInvitedProjectListByUserId()
        {

        }

        public void deleteProject()
        {

        }

        private int formatStateToProject(String state, String userId)
        {
            if (int.Parse(state) == 0)
            {
                return int.Parse(userId);
            }
            else
            {
                return 0;
            }
        }
    }
}
