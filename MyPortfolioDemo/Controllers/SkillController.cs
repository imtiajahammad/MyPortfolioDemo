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
    public class SkillController : ApiController
    {
        SkillManager skillManager;
        public SkillController()
        {
            this.skillManager = new SkillManager();
        }
        [HttpGet]
        //[Route("~api/skill/{userId:int}")]
        [Route("~/api/skill/{userId:int}")]
        public List<SkillProfileModel> Get(int userId)
        {
            List<SkillModel> skillModels = skillManager.Get_SkillsDefault_ByUserId(userId);
            return skillManager.Get_SkillProfile_ByUserId(skillModels, userId);
        }
    }
}
