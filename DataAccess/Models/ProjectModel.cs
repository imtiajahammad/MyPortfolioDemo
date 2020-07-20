using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccess.Models
{
    public class ProjectModel
    {
        public int id { get; set; }
        public int technologyTypeId { get; set; }
        public int imageId { get; set; }
        public int projectNameId { get; set; }
        public int projectSubNameId { get; set; }
        public int projectBriefId { get; set; }
        public int projectKeyPointId { get; set; }
        public int projectTechnologyBriefId { get; set; }
        public int projectTechnologieId { get; set; }
        public int projectTechnologiesIconId { get; set; }
        public int projectLiveLinkId { get; set; }
        public int projectSourceLinkId { get; set; }
        public int dateCreatedId { get; set; }
        public int oneSingleBriefForWholeProjectId { get; set; }
    }
}
