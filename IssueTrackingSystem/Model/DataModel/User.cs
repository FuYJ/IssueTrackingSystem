using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTrackingSystem.Model.DataModel
{
    public class User
    {
        private int userId;
        private String userName;
        private String password;
        private int authority;
        private String emailAddress;
        private List<Project> joinedProjects;
        private List<Project> invitedProjects;
        private List<Issue> issues;

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

        public List<Project> JoinedProjects
        {
            get { return joinedProjects; }
            set { joinedProjects = value; }
        }

        public List<Project> InvitedProjects
        {
            get { return invitedProjects; }
            set { invitedProjects = value; }
        }

        public List<Issue> Issues
        {
            get { return issues; }
            set { issues = value; }
        }

    }
}
