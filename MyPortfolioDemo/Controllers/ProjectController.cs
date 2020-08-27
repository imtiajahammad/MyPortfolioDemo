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
    public class ProjectController : ApiController
    {
        ProjectManager projectManager;
        public ProjectController()
        {
            this.projectManager = new ProjectManager();
        }
        [HttpGet]
        //[Route("~api/project/{userId:int}")]
        [Route("~/api/project/{userId:int}")]
        public List<ProjectProfileModel> Get(int userId)
        {
            List<ProjectModel> projectModels = projectManager.Get_ProjectsDefault_ByUserId(userId);
            return projectManager.Get_SelfImagProfile_ByUserId(projectModels, userId);
        }
    }
}
