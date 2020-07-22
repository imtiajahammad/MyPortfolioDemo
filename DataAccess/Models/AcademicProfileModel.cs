using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccess.Models
{
    public class AcademicProfileModel
    {
        public int id { get; set; }
        public SingleSmallTextModel institutionName { get; set; }
        public SingleSmallTextModel location { get; set; }
        public SingleSmallTextModel courseName { get; set; }
        public SingleSmallTextModel cgpa { get; set; }
        public SingleDateModel start { get; set; }
        public SingleDateModel end { get; set; }
        public LargeTextListDataModel briefPoint { get; set; }
    }
}