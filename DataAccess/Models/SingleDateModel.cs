using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccess.Models
{
    public class SingleDateModel
    {
        public int Id { get; set; }
        public int RepositorychildId { get; set; }
        public string /*DateTime*/ Data { get; set; }
        public string Description { get; set; }
    }
}