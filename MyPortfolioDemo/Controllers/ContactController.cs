using DataAccess.Managers;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyPortfolioDemo.Controllers
{
    public class ContactController : ApiController
    {
        ContactManager contactManager;
        public ContactController()
        {
            this.contactManager = new ContactManager();
        }
        [HttpGet]
        //[Route("~api/contact/{userId:int}")]
        [Route("~/api/contact/{userId:int}")]
        public List<ContactProfileModel> Get(int userId)
        {
            List<ContactModel> contactModels = contactManager.Get_ContactDefault_ByUserId(userId);
            return contactManager.Get_ContactProfile_ByUserId(contactModels, userId);
        }
    }
}
