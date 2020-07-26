using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccess.Models
{
    public class ProjectProfileModel
    {
        public int id { get; set; }
        public List<SmallTextListDataModel> technologyType { get; set; }
        public List<SmallTextListDataModel> images { get; set; }
        public SingleSmallTextModel projectName { get; set; }
        public SingleSmallTextModel projectSubName { get; set; }
        public List<LargeTextListDataModel> projectBrief { get; set; }
        public List<LargeTextListDataModel> projectKeyPoints { get; set; }
        public List<LargeTextListDataModel> projectTechnologyBrief { get; set; }
        public List<SmallTextListDataModel> projectTechnologies { get; set; }
        public List<SmallTextListDataModel> projectTechnologiesIcons { get; set; }
        public SingleLargeTextModel projectLiveLink { get; set; }
        public SingleLargeTextModel projectSourceLink { get; set; }
        public SingleDateModel dateCreated { get; set; }
        public SingleLargeTextModel oneSingleBriefForWholeProject { get; set; }
    }
}