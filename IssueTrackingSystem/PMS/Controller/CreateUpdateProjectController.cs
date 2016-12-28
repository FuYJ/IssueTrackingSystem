using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueTrackingSystem.Model;
using IssueTrackingSystem.Model.DataModel;

namespace IssueTrackingSystem.PMS.Controller
{
    class CreateUpdateProjectController
    {
        public int CreateUpdateProject(String movement, Project project)
        {
            int state = 0;
            if (Project.CREATE.Equals(movement))
            {
                state = CreateProject(project);
            }
            else if (Project.UPDATE.Equals(movement))
            {
                state = UpdateProject(project);
            }
            return state;
        }

        public int CreateProject(Project project)
        {
            User user = SecurityModel.getInstance().AuthenticatedUser;
            ProjectModel projectModel = new ProjectModel();
            int state = projectModel.createProject(user.UserId, project);
            return state;
        }

        public int UpdateProject(Project project)
        {
            User user = SecurityModel.getInstance().AuthenticatedUser;
            ProjectModel projectModel = new ProjectModel();
            int state = projectModel.updateProjectInfo(user.UserId, project);
            return state;
        }
    }
}
