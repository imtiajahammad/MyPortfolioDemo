using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccess.Models
{
    public class SmallTextListDataModel
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Data { get; set; }
        public string Description { get; set; }
    }
}