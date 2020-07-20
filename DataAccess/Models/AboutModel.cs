using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccess.Models
{
    public class AboutModel
    {
        public int id { get; set; }
        public int firstNameId { get; set; }
        public int middleNameId { get; set; }
        public int lastNameId { get; set; }
        public int phoneNumberId { get; set; }
        public int briefId { get; set; }
        public int languageId { get; set; }
        public int dobId { get; set; }
        public int countryId { get; set; }
        public int cityId { get; set; }
        public int fullAddressId { get; set; }
        public int socialLinksId { get; set; }
    }
}