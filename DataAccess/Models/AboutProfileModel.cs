using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccess.Models
{
    public class AboutProfileModel
    {
        public int id { get; set; }
        public SingleSmallTextModel FirstName { get; set; }
        public SingleSmallTextModel MiddleName { get; set; }
        public SingleSmallTextModel LastName { get; set; }
        public List<SmallTextListDataModel> phoneNumbers { get; set; }
        public List<LargeTextListDataModel> brief { get; set; }
        public List<SmallTextListDataModel> languages { get; set; }
        public SingleDateModel DOB { get; set; }
        public SingleSmallTextModel country { get; set; }
        public SingleSmallTextModel city { get; set; }
        public SingleLargeTextModel fullAddress { get; set; }
        public OnlineLinkDataModel socialLinks { get; set; }

    }
}