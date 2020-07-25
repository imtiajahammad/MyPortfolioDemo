using DataAccess.DbGateways;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccess.Managers
{
    public class ExperienceManager
    {
        ExperienceGateway experienceGateway;
        public ExperienceManager()
        {
            this.experienceGateway = new ExperienceGateway();
        }

        public SingleSmallTextModel getCompanyNameByUserId(int userid, int defaultId)
        { 
            return experienceGateway.getCompanyNameByUserId(userid,defaultId);
        }
        public SingleSmallTextModel getYourRoleByUserId(int userid, int defaultId)
        { 
            return experienceGateway.getYourRoleByUserId(userid, defaultId);
        }
        public SingleLargeTextModel getResponsibilityBriefByUserId(int userid, int defaultId)
        { 
            return experienceGateway.getResponsibilityBriefByUserId(userid, defaultId);
        }
        public List<LargeTextListDataModel> getResponsibilitiesPointByUserId(int userid, int defaultId)
        { 
            return experienceGateway.getResponsibilitiesPointByUserId(userid, defaultId);
        }
        public List<LargeTextListDataModel> getAccomplishmentsPointByUserId(int userid, int defaultId)
        { 
            return experienceGateway.getAccomplishmentsPointByUserId(userid, defaultId);
        }
        public SingleSmallTextModel getWorkLocationByUserId(int userid, int defaultId)
        { 
            return experienceGateway.getWorkLocationByUserId(userid, defaultId);
        }
        public SingleDateModel getStartDateByUserId(int userid, int defaultId)
        { 
            return experienceGateway.getStartDateByUserId(userid, defaultId);
        }
        public SingleDateModel getEndDateByUserId(int userid, int defaultId)
        { 
            return experienceGateway.getEndDateByUserId(userid, defaultId);
        }
        public SingleLargeTextModel getCompanyLinkByUserId(int userid, int defaultId)
        { 
            return experienceGateway.getCompanyLinkByUserId(userid, defaultId);
        }
        /**/
        public SingleSmallTextModel getCompanyNameByUserId(int userid)
        { 
            return experienceGateway.getCompanyNameByUserId(userid);
        }
        public SingleSmallTextModel getYourRoleByUserId(int userid)
        { 
            return experienceGateway.getYourRoleByUserId(userid);
        }
        public SingleLargeTextModel getResponsibilityBriefByUserId(int userid)
        { 
            return experienceGateway.getResponsibilityBriefByUserId(userid);
        }
        public List<LargeTextListDataModel> getResponsibilitiesPointByUserId(int userid)
        { 
            return experienceGateway.getResponsibilitiesPointByUserId(userid);
        }
        public List<LargeTextListDataModel> getAccomplishmentsPointByUserId(int userid)
        { 
            return experienceGateway.getAccomplishmentsPointByUserId(userid);
        }
        public SingleSmallTextModel getWorkLocationByUserId(int userid)
        { 
            return experienceGateway.getWorkLocationByUserId(userid);
        }
        public SingleDateModel getStartDateByUserId(int userid)
        { 
            return experienceGateway.getStartDateByUserId(userid);
        }
        public SingleDateModel getEndDateByUserId(int userid)
        { 
            return experienceGateway.getEndDateByUserId(userid);
        }
        public SingleLargeTextModel getCompanyLinkByUserId(int userid)
        { 
            return experienceGateway.getCompanyLinkByUserId(userid);
        }


        public List<ExperienceModel> Get_ExperiencesDefault_ByUserId(int userid)
        { 
            return experienceGateway.Get_ExperiencesDefault_ByUserId(userid);
        }
        public List<ExperienceProfileModel> Get_ExperienceProfile_ByUserId(List<ExperienceModel> experienceids, int userid)
        { 
            return experienceGateway.Get_ExperienceProfile_ByUserId(experienceids,userid);
        }
    }
}