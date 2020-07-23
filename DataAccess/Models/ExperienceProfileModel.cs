using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccess.Models
{
    public class ExperienceProfileModel
    {
        public int id { get; set; }
        public SingleSmallTextModel companyName { get; set; }
        public SingleSmallTextModel yourRole { get; set; }
        public SingleLargeTextModel responsibilityBrief { get; set; }
        public List<LargeTextListDataModel> responsibilitiesPoints { get; set; }
        public List<LargeTextListDataModel> accomplishmentsPoints { get; set; }
        public SingleSmallTextModel workLocation { get; set; }
        public SingleDateModel startDate { get; set; }
        public SingleDateModel endDate { get; set; }
        public SingleLargeTextModel companyLink { get; set; }
    }
}