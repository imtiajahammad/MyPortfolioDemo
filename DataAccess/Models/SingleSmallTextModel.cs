using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccess.Models
{
    public class SingleSmallTextModel
    {
        public int Id { get; set; }
        public int RepositorychildId { get; set; }
        public string Data { get; set; }
        public string Description { get; set; }
    }
}