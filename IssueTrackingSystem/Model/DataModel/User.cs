using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTrackingSystem.Model.DataModel
{
    class User
    {
        private int userId;
        private String userName;
        private String password;
        private int authority;
        private String emailAddress;
        private List<int> projects;
        private List<int> issues;

        public enum AuthorityEnum
        {
            SystemManager,
            GeneralUser
        }

        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        public String UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public String Password
        {
            get { return password; }
            set { password = value; }
        }

        public int Authority
        {
            get { return authority; }
            set { authority = value; }
        }

        public String EmailAddress
        {
            get { return emailAddress; }
            set { emailAddress = value; }
        }

        public List<int> Projects
        {
            get { return projects; }
            set { projects = value; }
        }

        public List<int> Issues
        {
            get { return issues; }
            set { issues = value; }
        }

    }
}
