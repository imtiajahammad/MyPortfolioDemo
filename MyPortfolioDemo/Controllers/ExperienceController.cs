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
    public class ExperienceController : ApiController
    {
        ExperienceManager experienceManager;
        public ExperienceController()
        {
            this.experienceManager = new ExperienceManager();
        }

        [HttpGet]
        //[Route("~api/image/{userId:int}")]
        public List<ExperienceProfileModel> Get(int userId)
        {
            List<ExperienceModel> experienceModels = experienceManager.Get_ExperiencesDefault_ByUserId(userId);
            return experienceManager.Get_ExperienceProfile_ByUserId(experienceModels, userId);
        }
    }
}
