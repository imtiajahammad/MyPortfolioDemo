using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccess.Models
{
    public class SelfImageProfileModel
    {
        public int id { get; set; }
        public List<SmallTextListDataModel> homeImageList { get; set; }

    }
}