using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using IssueTrackingSystem.Model.ApiModel;
using IssueTrackingSystem.Model.DataModel;
using System.Net;
using System.IO;
using Chsword;

namespace IssueTrackingSystem.Model
{
    public class ProjectMemberModel
    {
        public int createMember(ProjectMember member)
        {
            int state = 0;
            var req = WebRequest.Create(Server.ApiUrl + "/members/" + member.UserId + "/" + member.ProjectId);
            req.Method = "POST";
            req.ContentType = "application/json";
            String contentData = "{\"userId\":\"" + member.UserId + "\"," +
                                  "\"role\":\"" + member.Role + "\"}";
            using (var writer = new StreamWriter(req.GetRequestStream()))
            {
                writer.Write(contentData);
            }

            var resp = (HttpWebResponse)req.GetResponse();
            using (var reader = new StreamReader(resp.GetResponseStream()))
            {
                var membertData = reader.ReadToEnd();
                dynamic memberApiModel = JsonConvert.DeserializeObject<dynamic>(membertData);
                state = memberApiModel.State;
            }

            return state;
        }

        public List<ProjectMember> getMemberByProjectId(ProjectMember member, String joined)
        {
            List<ProjectMember> memberList = new List<ProjectMember>();
            var req = WebRequest.Create(Server.ApiUrl + "/members/list/" + member.UserId + "/" + member.ProjectId);
            req.Method = "GET";
            var resp = (HttpWebResponse)req.GetResponse();
            using (var reader = new StreamReader(resp.GetResponseStream()))
            {
                var membertData = reader.ReadToEnd();
                dynamic memberApiModel = JsonConvert.DeserializeObject<dynamic>(membertData);
                int state = memberApiModel.State;
                if(state == 0)
                {
                    foreach (dynamic o in memberApiModel.list)
                    {
                        ProjectMember projectMember = new ProjectMember();
                        projectMember.UserId = o.userId;
                        projectMember.Role = o.role;
                        if (joined.Equals(o.isJoined))
                        {
                            memberList.Add(projectMember);
                        }
                    }
                }
            }
            return memberList;
        }

        public int updateInfo(ProjectMember member, String joined)
        {
            int state = 0;
            var req = WebRequest.Create(Server.ApiUrl + "/members/put/" + member.UserId + "/" + member.ProjectId);
            req.Method = "POST";
            req.ContentType = "application/json";
            String contentData = "{\"userId\":\"" + member.UserId + "\"," +
                                  "\"role\":\"" + member.Role + "\"," +
                                  "\"isJoined\":\"" + joined + "\"}";
            using (var writer = new StreamWriter(req.GetRequestStream()))
            {
                writer.Write(contentData);
            }

            var resp = (HttpWebResponse)req.GetResponse();
            using (var reader = new StreamReader(resp.GetResponseStream()))
            {
                var membertData = reader.ReadToEnd();
                dynamic memberApiModel = JsonConvert.DeserializeObject<dynamic>(membertData);
                state = memberApiModel.State;
            }

            return state;
        }

        public int deleteMember(int managerId,ProjectMember member)
        {
            int state = 0;
            var req = WebRequest.Create(Server.ApiUrl + "/members/delete/" + managerId + "/" + member.ProjectId + "/" + member.UserId);
            req.Method = "POST";
            req.ContentType = "application/json";
            String contentData = "{}";
            using (var writer = new StreamWriter(req.GetRequestStream()))
            {
                writer.Write(contentData);
            }

            var resp = (HttpWebResponse)req.GetResponse();
            using (var reader = new StreamReader(resp.GetResponseStream()))
            {
                var membertData = reader.ReadToEnd();
                dynamic memberApiModel = JsonConvert.DeserializeObject<dynamic>(membertData);
                state = memberApiModel.State;
            }
            return state;
        }
    }
}
