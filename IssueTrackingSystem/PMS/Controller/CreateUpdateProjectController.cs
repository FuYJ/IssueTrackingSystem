using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueTrackingSystem.Model;
using IssueTrackingSystem.Model.DataModel;
using IssueTrackingSystem.Model.ApiModel;

namespace IssueTrackingSystem.PMS.Controller
{
    class CreateUpdateProjectController
    {
        public ProjectApiModel CreateUpdateProject(String movement, Project project)
        {
            ProjectApiModel model = new ProjectApiModel();
            if (Project.CREATE.Equals(movement))
            {
                model = CreateProject(project);
            }
            else if (Project.UPDATE.Equals(movement))
            {
                model = UpdateProject(project);
            }
            return model;
        }

        public ProjectApiModel CreateProject(Project project)
        {
            User user = SecurityModel.getInstance().AuthenticatedUser;
            ProjectModel projectModel = new ProjectModel();
            ProjectApiModel model = projectModel.createProject(user.UserId, project);
            return model;
        }

        public ProjectApiModel UpdateProject(Project project)
        {
            User user = SecurityModel.getInstance().AuthenticatedUser;
            ProjectModel projectModel = new ProjectModel();
            ProjectApiModel model = projectModel.updateProjectInfo(user.UserId, project);
            return model;
        }
    }
}
