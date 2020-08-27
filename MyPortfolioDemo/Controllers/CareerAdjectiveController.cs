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
    public class CareerAdjectiveController : ApiController
    {
        CareerAdjectiveManager careerAdjectiveManager;
        public CareerAdjectiveController()
        {
            this.careerAdjectiveManager = new CareerAdjectiveManager();
        }
        [HttpGet]
        //[Route("~/api/careerAdjective/{userId:int}")]
        [Route("~/api/careerAdjective/{userId:int}")]
        public List<CareerAdjectiveProfileModel> Get(int userId)
        {
            List<CareerAdjectiveModel> careerAdjectiveIds = careerAdjectiveManager.Get_CareerAdjectiveDefault_ByUserId(userId);
            return careerAdjectiveManager.Get_CareerAdjectiveProfile_ByUserId(careerAdjectiveIds, userId);
        }
    }
}
