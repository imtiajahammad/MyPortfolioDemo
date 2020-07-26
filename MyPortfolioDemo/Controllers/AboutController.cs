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
    public class AboutController : ApiController
    {
        AboutManager aboutManager;
        public AboutController()
        {
            this.aboutManager = new AboutManager();
        }
        [HttpGet]
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        [HttpGet]
        // GET api/values/5
        public List<AboutProfileModel> Get(int userId)
        {
            //return "value";
            List<AboutModel> aboutids = aboutManager.Get_AboutDefault_ByUserId(userId);
            return aboutManager.Get_AboutProfile_ByUserId(aboutids, userId);
        }
        [HttpPost]
        // POST api/values
        public void Post([FromBody]string value)
        {
        }
        [HttpPut]
        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }
        [HttpDelete]
        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
