using IssueTrackingSystem.Model;
using IssueTrackingSystem.Model.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTrackingSystem.AMS.Controller
{
    class ProjectListController
    {
        private ProjectModel projectModel;
        private ProjectMemberModel projectMemberModel;

        public ProjectListController(ProjectModel projectModel, ProjectMemberModel projectMemberModel) {
            this.projectModel = projectModel;
            this.projectMemberModel = projectMemberModel;
        }

        public void dealWithProjectInvitation(int projectId, bool isAccepted)
        {
            User user = SecurityModel.getInstance().AuthenticatedUser;
            ProjectMember projectMember = new ProjectMember();
            projectMember.UserId = user.UserId;
            projectMember.ProjectId = projectId;
            projectMemberModel.dealWithProjectInvitation(projectMember, isAccepted);
        }
    }
}
