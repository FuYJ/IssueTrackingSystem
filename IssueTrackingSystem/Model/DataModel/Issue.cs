using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTrackingSystem.Model.DataModel
{
    class Issue
    {
        private int issueId;
        private String issueName;
        private String description;
        private String state;
        private String serverity;
        private int priority;
        private int issueGroupId;
        private int reporterId;
        private DateTime reportDate;
        private int personInChargeId;
        private DateTime finishDate;

        public int IssueId
        {
            get { return issueId; }
            set { issueId = value; }
        }

        public String IssueName
        {
            get { return issueName; }
            set { issueName = value; }
        }

        public String Description
        {
            get { return description; }
            set { description = value; }
        }

        public String State
        {
            get { return state; }
            set { state = value; }
        }

        public String Serverity
        {
            get { return serverity; }
            set { serverity = value; }
        }

        public int Priority
        {
            get { return priority; }
            set { priority = value; }
        }

        public int IssueGroupId
        {
            get { return issueGroupId; }
            set { issueGroupId = value; }
        }

        public int ReporterId
        {
            get { return reporterId; }
            set { reporterId = value; }
        }

        public DateTime ReportDate
        {
            get { return reportDate; }
            set { reportDate = value; }
        }

        public int PersonInChargeId
        {
            get { return personInChargeId; }
            set { personInChargeId = value; }
        }

        public DateTime FinishDate
        {
            get { return finishDate; }
            set { finishDate = value; }
        }
    }
}
