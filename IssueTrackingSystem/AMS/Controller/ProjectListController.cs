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

        public ProjectListController(ProjectModel projectModel) {
            this.projectModel = projectModel;
        }

        public List<Project> listJoinedProjects() { 
            List<Project> projectList = new List<Project>();

            //api

            return projectList;
        }

        public List<Project> listInvitedProjects()
        {
            List<Project> projectList = new List<Project>();

            //api

            return projectList;
        }

        public void acceptInvitation(int projectId)
        {
            //api
        }
    }
}
