using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTrackingSystem.Model.ApiModel
{
    public class UserApiModel
    {
        private String state;
        private String name;
        private String userId;
        private String emailAddress;
        private String userRole;

        public String State
        {
            get { return state; }
            set { state = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public String UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        public String EmailAddress
        {
            get { return emailAddress; }
            set { emailAddress = value; }
        }

        public String UserRole
        {
            get { return userRole; }
            set { userRole = value; }
        }
    }
}
