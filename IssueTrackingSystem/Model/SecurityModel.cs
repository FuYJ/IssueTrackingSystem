using IssueTrackingSystem.Model.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace IssueTrackingSystem.Model
{
    public class SecurityModel
    {
        private User authenticatedUser;
        private bool isProgramRunning;
        private static SecurityModel securityModel = null;

        HttpWebRequest req = WebRequest.Create(Server.ApiUrl) as HttpWebRequest;

        public static SecurityModel getInstance(){
            if (securityModel == null)
            {
                securityModel = new SecurityModel();
            }
            return securityModel;
        }

        private SecurityModel(){
            isProgramRunning = true;
        }

        public User AuthenticatedUser
        {
            get { return authenticatedUser; }
            set { authenticatedUser = value; }
        }

        public bool IsProgramRunning
        {
            get { return isProgramRunning; }
            set { isProgramRunning = value; }
        }
    }
}
