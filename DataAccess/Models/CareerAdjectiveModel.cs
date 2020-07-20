using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccess.Models
{
    public class CareerAdjectiveModel
    {
        public int id { get; set; }
        public int personalQualityId { get; set; }
        public int skillsByTopicId { get; set; }
        public int briefAboutMeId { get; set; }
        public int myWorkFeatureId { get; set; }
        public int currentFocusId { get; set; }
        public int onlineResumeLinkId { get; set; }
        public int detailsListId { get; set; }
    }
}