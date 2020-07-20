using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccess.Models
{
    public class AcademicModel
    {
        public int id { get; set; }
        public int institutionNameId { get; set; }
        public int locationId { get; set; }
        public int courseNameId { get; set; }
        public int cgpaId { get; set; }
        public int startId { get; set; }
        public int endId { get; set; }
        public int briefId { get; set; }
    }
}