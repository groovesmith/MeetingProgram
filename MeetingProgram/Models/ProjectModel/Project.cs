using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingProgram.Models.ProjectModel
{
    public class Project
    {
        public Project(int projectID, string projectName, string projectLocation, string description)
        {
            ProjectID = projectID;
            ProjectName = projectName;
            ProjectLocation = projectLocation;
        }
        public Project()
        {

        }

        public int ProjectID { get; set; }
        public string ProjectName { get; set; }
        public string ProjectLocation { get; set; }
        public string Description { get; set; }
    }
}
