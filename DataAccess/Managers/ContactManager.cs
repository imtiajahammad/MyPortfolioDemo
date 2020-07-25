using DataAccess.DbGateways;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccess.Managers
{
    public class ContactManager
    {
        ContactGeteway contactGeteway;
        public ContactManager()
        {
            this.contactGeteway = new ContactGeteway();
        }
        public SingleSmallTextModel getNameByUserId(int userid, int defaultId)
        { 
            return contactGeteway.getNameByUserId(userid, defaultId);
        }
        public SingleSmallTextModel getEmailByUserId(int userid, int defaultId)
        { 
            return contactGeteway.getEmailByUserId(userid, defaultId);
        }
        public SingleLargeTextModel getMessageByUserId(int userid, int defaultId)
        { 
            return contactGeteway.getMessageByUserId(userid, defaultId);
        }
        /**/
        public SingleSmallTextModel getNameByUserId(int userid)
        { 
            return contactGeteway.getNameByUserId(userid);
        }
        public SingleSmallTextModel getEmailByUserId(int userid)
        { 
            return contactGeteway.getEmailByUserId(userid);
        }
        public SingleLargeTextModel getMessageByUserId(int userid)
        { 
            return contactGeteway.getMessageByUserId(userid);
        }

        public List<ContactModel> Get_CareerAdjectiveDefault_ByUserId(int userid)
        { 
            return contactGeteway.Get_CareerAdjectiveDefault_ByUserId(userid);
        }

        public List<ContactProfileModel> Get_CareerAdjectiveProfile_ByUserId(List<ContactModel> contactids, int userid)
        { 
            return contactGeteway.Get_CareerAdjectiveProfile_ByUserId(contactids,userid);
        }
    }
}