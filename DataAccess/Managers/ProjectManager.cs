using DataAccess.DbGateways;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccess.Managers
{
    public class ProjectManager
    {
        ProjectGateway projectGateway;
        public ProjectManager()
        {
            this.projectGateway = new ProjectGateway();
        }
        public List<SmallTextListDataModel> getTechnologyTypeByUserId(int userid, int defaultId)
        { 
            return projectGateway.getTechnologyTypeByUserId(userid,defaultId);
        }
        public List<SmallTextListDataModel> getImagesByUserId(int userid, int defaultId)
        { 
            return projectGateway.getImagesByUserId(userid, defaultId);
        }
        public SingleSmallTextModel getProjectNameByUserId(int userid, int defaultId)
        { 
            return projectGateway.getProjectNameByUserId(userid, defaultId);
        }
        public SingleSmallTextModel getProjectSubNameByUserId(int userid, int defaultId)
        { 
            return projectGateway.getProjectSubNameByUserId(userid, defaultId);
        }
        public List<LargeTextListDataModel> getProjectBriefByUserId(int userid, int defaultId)
        { 
            return projectGateway.getProjectBriefByUserId(userid, defaultId);
        }
        public List<LargeTextListDataModel> getProjectKeyPointsByUserId(int userid, int defaultId)
        { 
            return projectGateway.getProjectKeyPointsByUserId(userid, defaultId);
        }
        public List<LargeTextListDataModel> getProjectTechnologyBriefByUserId(int userid, int defaultId)
        { 
            return projectGateway.getProjectTechnologyBriefByUserId(userid, defaultId);
        }
        public List<SmallTextListDataModel> getProjectTechnologiesByUserId(int userid, int defaultId)
        { 
            return projectGateway.getProjectTechnologiesByUserId(userid, defaultId);
        }
        public List<SmallTextListDataModel> getProjectTechnologiesIconsByUserId(int userid, int defaultId)
        { 
            return projectGateway.getProjectTechnologiesIconsByUserId(userid, defaultId);
        }
        public SingleLargeTextModel getProjectLiveLinkByUserId(int userid, int defaultId)
        { 
            return projectGateway.getProjectLiveLinkByUserId(userid, defaultId);
        }
        public SingleLargeTextModel getProjectSourceLinkByUserId(int userid, int defaultId)
        { 
            return projectGateway.getProjectSourceLinkByUserId(userid, defaultId);
        }
        public SingleDateModel getDateCreatedByUserId(int userid, int defaultId)
        { 
            return projectGateway.getDateCreatedByUserId(userid, defaultId);
        }
        public SingleLargeTextModel getOneSingleBriefForWholeProjectByUserId(int userid, int defaultId)
        { 
            return projectGateway.getOneSingleBriefForWholeProjectByUserId(userid, defaultId);
        }
        /**/
        public List<SmallTextListDataModel> getTechnologyTypeByUserId(int userid)
        { 
            return projectGateway.getTechnologyTypeByUserId(userid);
        }
        public List<SmallTextListDataModel> getImagesByUserId(int userid)
        { 
            return projectGateway.getImagesByUserId(userid);
        }
        public SingleSmallTextModel getProjectNameByUserId(int userid)
        { 
            return projectGateway.getProjectNameByUserId(userid);
        }
        public SingleSmallTextModel getProjectSubNameByUserId(int userid)
        { 
            return projectGateway.getProjectSubNameByUserId(userid);
        }
        public List<LargeTextListDataModel> getProjectBriefByUserId(int userid)
        { 
            return projectGateway.getProjectBriefByUserId(userid);
        }
        public List<LargeTextListDataModel> getProjectKeyPointsByUserId(int userid)
        { 
            return projectGateway.getProjectKeyPointsByUserId(userid);
        }
        public List<LargeTextListDataModel> getProjectTechnologyBriefByUserId(int userid)
        { 
            return projectGateway.getProjectTechnologyBriefByUserId(userid);
        }
        public List<SmallTextListDataModel> getProjectTechnologiesByUserId(int userid)
        { 
            return projectGateway.getProjectTechnologiesByUserId(userid);
        }
        public List<SmallTextListDataModel> getProjectTechnologiesIconsByUserId(int userid)
        { 
            return projectGateway.getProjectTechnologiesIconsByUserId(userid);
        }
        public SingleLargeTextModel getProjectLiveLinkByUserId(int userid)
        { 
            return projectGateway.getProjectLiveLinkByUserId(userid);
        }
        public SingleLargeTextModel getProjectSourceLinkByUserId(int userid)
        { 
            return projectGateway.getProjectSourceLinkByUserId(userid);
        }
        public SingleDateModel getDateCreatedByUserId(int userid)
        { 
            return projectGateway.getDateCreatedByUserId(userid);
        }
        public SingleLargeTextModel getOneSingleBriefForWholeProjectByUserId(int userid)
        { 
            return projectGateway.getOneSingleBriefForWholeProjectByUserId(userid);
        }

        public List<ProjectModel> Get_ProjectsDefault_ByUserId(int userid)
        { 
            return projectGateway.Get_ProjectsDefault_ByUserId(userid);
        }
        public List<ProjectProfileModel> Get_ProjectProfile_ByUserId(List<ProjectModel> projectids, int userid)
        {
            return projectGateway.Get_ProjectImagProfile_ByUserId(projectids,userid);
        }
    }
}