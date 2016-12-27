using IssueTrackingSystem.Model.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTrackingSystem.PMS.View
{
    class Project
    {
        private int projectId;
        private String projectName;
        private String description;
        private List<User> members;
        private List<Issue> issues;

        public int ProjectId
        {
            get { return projectId; }
            set { projectId = value; }
        }

        public String ProjectName
        {
            get { return projectName; }
            set { projectName = value; }
        }

        public String Description
        {
            get { return description; }
            set { description = value; }
        }

        internal List<User> Members
        {
            get { return members; }
            set { members = value; }
        }

        internal List<Issue> Issues
        {
            get { return issues; }
            set { issues = value; }
        }
    }
}
