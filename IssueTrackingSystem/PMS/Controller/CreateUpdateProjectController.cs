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
        private UserModel userModel;
        private IssueModel issueModel;
        private ProjectModel projectModel;

        public CreateUpdateProjectController(UserModel userModel, IssueModel issueModel, ProjectModel projectModel)
        {
            this.userModel = userModel;
            this.issueModel = issueModel;
            this.projectModel = projectModel;
        }

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
            ProjectApiModel model = projectModel.createProject(user.UserId, project);
            return model;
        }

        public ProjectApiModel UpdateProject(Project project)
        {
            User user = SecurityModel.getInstance().AuthenticatedUser;
            ProjectApiModel model = projectModel.updateProjectInfo(user.UserId, project);
            return model;
        }
    }
}
