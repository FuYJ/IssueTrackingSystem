using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTrackingSystem.Model.DataModel
{
    public static class ErrorManager
    {
        public enum ErrorCode { 
            Success, 
            UserNotSystemManager,
            UserNotProjectManager,
            CallingUserNotExist,
            CalledUserNotExist,
            PersonInChargeNotExist,
            ProjectNotExist,
            IssueNotExist,
            UserIsNotProjectMember,
            UserAlreadyInvitedOrInProject,
            UserNotInvitedOrInProject,
            ProjectManagerCanNotBeRemoved,
            SystemManagerCannotBeInvited,
            UsernameRepeated,
            EmailAddressFormatError,
            UserAccountNotExist,
            AuthenticateError,
            UserNotGeneralUser
        }
    }
}
