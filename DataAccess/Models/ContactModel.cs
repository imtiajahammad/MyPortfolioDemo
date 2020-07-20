using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccess.Models
{
    public class ContactModel
    {
        public int id { get; set; }
        public int nameId { get; set; }
        public int emailId { get; set; }
        public int messageId { get; set; }
    }
}