using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueTrackingSystem.Model.DataModel;
using IssueTrackingSystem.Model;

namespace IssueTrackingSystem.PMS.Controller
{
    class ProjectInfoController
    {
        ProjectModel model;

        public ProjectInfoController(ProjectModel projectModel)
        {
            model = projectModel;
        }

        public Project getProjectInfo(int userId, int projectId)
        {
            return model.getProjectInfo(userId, projectId);
        }

        public List<Project> getProjectListByUserId(int userId)
        {
            return model.getProjectListByUserId(userId);
        }

        public List<Project> getInvitedProjectListByUserId(int userId)
        {
            return model.getInvitedProjectListByUserId(userId);
        }

        public List<Project> getAllProjectList(int userId)
        {
            return model.getAllProjectList(userId);
        }

        public int deleteProject(int userId, int projectId)
        {
            return model.deleteProject(userId, projectId);
        }
    }
}
