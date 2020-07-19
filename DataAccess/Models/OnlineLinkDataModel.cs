using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccess.Models
{
    public class OnlineLinkDataModel
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public string IconLink { get; set; }

        public string Description { get; set; }

    }
}