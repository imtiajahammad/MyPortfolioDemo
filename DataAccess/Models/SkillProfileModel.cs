using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccess.Models
{
    public class SkillProfileModel
    {
        public int id { get; set; }
        public SingleSmallTextModel topicName { get; set; }
        public List<SmallTextListDataModel> subTopicName { get; set; }
        public SingleIntegerModel percentage { get; set; }
    }
}  