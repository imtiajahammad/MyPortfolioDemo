using DataAccess.DbGateways;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccess.Managers
{
    public class CareerAdjectiveManager
    {
        CareerAdjectiveGateway careerAdjectiveGateway;
        public CareerAdjectiveManager()
        {
            this.careerAdjectiveGateway = new CareerAdjectiveGateway();
        }

        public List<SmallTextListDataModel> getPersonalQualitiesByUserId(int userid, int defaultId)
        {
            return careerAdjectiveGateway.getPersonalQualitiesByUserId(userid,defaultId);
        }
        public List<SmallTextListDataModel> getSkillsByTopicByUserId(int userid, int defaultId)
        { 
            return careerAdjectiveGateway.getSkillsByTopicByUserId(userid, defaultId);
        }
        public List<LargeTextListDataModel> getBriefAboutMeByUserId(int userid, int defaultId)
        { 
            return careerAdjectiveGateway.getBriefAboutMeByUserId(userid, defaultId);
        }
        public List<SmallTextListDataModel> getMyWorkFeaturesByUserId(int userid, int defaultId)
        { 
            return careerAdjectiveGateway.getMyWorkFeaturesByUserId(userid, defaultId);
        }
        public List<SmallTextListDataModel> getCurrentFocusByUserId(int userid, int defaultId)
        { 
            return careerAdjectiveGateway.getCurrentFocusByUserId(userid, defaultId);
        }
        public SingleLargeTextModel getOnlineResumeLinkByUserId(int userid, int defaultId)
        { 
            return careerAdjectiveGateway.getOnlineResumeLinkByUserId(userid, defaultId);
        }
        public List<LargeTextListDataModel> getDetailsListByUserId(int userid, int defaultId)
        { 
            return careerAdjectiveGateway.getDetailsListByUserId(userid, defaultId);
        }
        /**/
        public List<SmallTextListDataModel> getPersonalQualitiesByUserId(int userid)
        { 
            return careerAdjectiveGateway.getPersonalQualitiesByUserId(userid);
        }
        public List<SmallTextListDataModel> getSkillsByTopicByUserId(int userid)
        { 
            return careerAdjectiveGateway.getSkillsByTopicByUserId(userid);
        }
        public List<LargeTextListDataModel> getBriefAboutMeByUserId(int userid)
        { 
            return careerAdjectiveGateway.getBriefAboutMeByUserId(userid);
        }
        public List<SmallTextListDataModel> getMyWorkFeaturesByUserId(int userid)
        { 
            return careerAdjectiveGateway.getMyWorkFeaturesByUserId(userid);
        }
        public List<SmallTextListDataModel> getCurrentFocusByUserId(int userid)
        { 
            return careerAdjectiveGateway.getCurrentFocusByUserId(userid);
        }
        public List<SingleLargeTextModel> getOnlineResumeLinkByUserId(int userid)
        { 
            return careerAdjectiveGateway.getOnlineResumeLinkByUserId(userid);
        }
        public List<LargeTextListDataModel> getDetailsListByUserId(int userid)
        { 
            return careerAdjectiveGateway.getDetailsListByUserId(userid);
        }

        public List<CareerAdjectiveModel> Get_CareerAdjectiveDefault_ByUserId(int userid)
        { 
            return careerAdjectiveGateway.Get_CareerAdjectiveDefault_ByUserId(userid);
        }

        public List<CareerAdjectiveProfileModel> Get_CareerAdjectiveProfile_ByUserId(List<CareerAdjectiveModel> careerAdjectiveids, int userid)
        { 
            return careerAdjectiveGateway.Get_CareerAdjectiveProfile_ByUserId(careerAdjectiveids,userid);
        }
    }
}