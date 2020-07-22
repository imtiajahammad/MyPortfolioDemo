using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccess.Models
{
    public class ContactProfileModel
    {
        public int id { get; set; }
        public SingleSmallTextModel name { get; set; }
        public SingleSmallTextModel email { get; set; }
        public SingleLargeTextModel message { get; set; }

    }
}