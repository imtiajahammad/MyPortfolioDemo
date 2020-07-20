using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccess.Models
{
    public class SkillModel
    {
        public int id { get; set; }
        public int topicNameId { get; set; }
        public int subTopicNameId { get; set; }
        public int percentageId { get; set; }
    }
}