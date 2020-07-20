using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccess.Models
{
    public class ExperienceModel
    {
        public int id { get; set; }
        public int companyNameId { get; set; }
        public int yourRoleId { get; set; }
        public int responsibilityBriefId { get; set; }
        public int responsibilitiesPointId { get; set; }
        public int accomplishmentsPointId { get; set; }
        public int workLocationId { get; set; }
        public int startDateId { get; set; }
        public int endDateId { get; set; }
        public int companyLinkId { get; set; }
    }
}