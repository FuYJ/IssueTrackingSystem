﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTrackingSystem.Model.DataModel
{
    public class Project
    {
        private int projectId;
        private String projectName;
        private String description;
        private String manager;
        private DateTime timeStamp;
        private List<int> members;
        private List<int> issues;

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

        public String Manager
        {
            get { return manager; }
            set { manager = value; }
        }

        public DateTime TimeStamp
        {
            get { return timeStamp; }
            set { timeStamp = value; }
        }

        public List<int> Members
        {
            get { return members; }
            set { members = value; }
        }

        public List<int> Issues
        {
            get { return issues; }
            set { issues = value; }
        }
    }
}