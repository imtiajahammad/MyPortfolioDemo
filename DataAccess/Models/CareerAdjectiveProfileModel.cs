using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccess.Models
{
    public class CareerAdjectiveProfileModel
    {
        public int id { get; set; }
        public List<SmallTextListDataModel> personalQualities { get; set; }
        public List<SmallTextListDataModel> skillsByTopic { get; set; }
        public List<LargeTextListDataModel> briefAboutMe { get; set; }
        public List<SmallTextListDataModel> myWorkFeatures { get; set; }
        public List<SmallTextListDataModel> currentFocus { get; set; }
        public SingleLargeTextModel onlineResumeLink { get; set; }
        public List<LargeTextListDataModel> detailsList { get; set; }
    }
}