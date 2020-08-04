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
    public class ImageController : ApiController
    {
        ImageManager imageManager;
        public ImageController()
        {
            this.imageManager = new ImageManager();
        }

        [HttpGet]
        [Route("~api/image/{userId:int}")]
        public List<SelfImagProfileModel> Get(int userId)
        {
            List<SelfImageModel> selfImageModels = imageManager.Get_SelfImagesDefault_ByUserId(userId);
            return imageManager.Get_SelfImagProfile_ByUserId(selfImageModels, userId);
        }
    }
}
