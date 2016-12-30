using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueTrackingSystem.Model;
using IssueTrackingSystem.Model.DataModel;
using IssueTrackingSystem.AMS.Controller;

namespace IssueTrackingSystem.PMS.Controller
{
    class ProjectMemberController
    {
        ProjectMemberModel model = new ProjectMemberModel();
        UserModel userModel = new UserModel();

        public ProjectMemberController(ProjectMemberModel projectMemberModel, UserModel userModel)
        {
            model = projectMemberModel;
            this.userModel = userModel;
        }

        public int createMember(ProjectMember member)
        {
            return model.createMember(member);
        }

        public List<ProjectMember> getMemberByProjectId(int projectId, bool joined)
        {
            return model.getMemberByProjectId(projectId, joined);
        }

        public List<User> getUserByProjectId(int projectId, bool joined)
        {
            List<User> userList = new List<User>();
            List<ProjectMember> memberList = model.getMemberByProjectId(projectId, joined);
            for(int i = 0; i < memberList.Count; i++)
            {
                userList.Add(userModel.getUserInfo(memberList[i].UserId));
            }
            return userList;
        }

        public int updateInfo(ProjectMember member, bool joined)
        {
            return model.updateInfo(member, joined);
        }

        public int deleteMember(int managerId, ProjectMember member)
        {
            return model.deleteMember(managerId, member);
        }
    }
}
