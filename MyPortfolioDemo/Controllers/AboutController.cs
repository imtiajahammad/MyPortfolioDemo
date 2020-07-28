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
        /*[HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "about1", "about2" };
        }*/
        [HttpGet]
        public List<AboutProfileModel> Get(int userId)
        {
            //http://localhost:57260/api/about?userid=1
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
