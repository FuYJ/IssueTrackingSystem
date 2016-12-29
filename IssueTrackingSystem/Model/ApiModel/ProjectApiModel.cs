using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueTrackingSystem.Model.DataModel;

namespace IssueTrackingSystem.Model.ApiModel
{
    class ProjectApiModel
    {
        private int state;
        private Project projectContext = new Project();

        public int State
        {
            get { return state; }
            set { state = value; }
        }

        public Project ProjectContext
        {
            get { return projectContext; }
            set { projectContext = value; }
        }
    }
}
