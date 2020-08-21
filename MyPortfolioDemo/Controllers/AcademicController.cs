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
    public class AcademicController : ApiController
    {
        AcademicManager academicManager;
        public AcademicController()
        {
            this.academicManager = new AcademicManager();
        }
        [HttpGet]
        //[Route("~/api/academic/{userId:int}")]
        public List<AcademicProfileModel> Get(int userId)
        {
            List<AcademicModel> academicIds 
                    = academicManager
                        .Get_AcademicsDefault_ByUserId(userId);
            return academicManager
                    .Get_AcademicProfile_ByUserId
                    (academicIds, userId);
        }
    }
}
