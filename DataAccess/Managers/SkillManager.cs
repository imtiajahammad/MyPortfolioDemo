using DataAccess.DbGateways;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccess.Managers
{
    public class SkillManager
    {
        SkillGateway skillGateway;
        public SkillManager()
        {
            this.skillGateway = new SkillGateway();
        }
        public SingleSmallTextModel getTopicNameByUserId(int userid, int defaultId)
        {            
            return skillGateway.getTopicNameByUserId(userid,defaultId);
        }
        public List<SmallTextListDataModel> getSubTopicNameByUserId(int userid, int defaultId)
        { 
            return skillGateway.getSubTopicNameByUserId(userid, defaultId);
        }
        public SingleIntegerModel getPercentageByUserId(int userid, int defaultId)
        { 
            return skillGateway.getPercentageByUserId(userid, defaultId);
        }
        /**/
        public SingleSmallTextModel getTopicNameByUserId(int userid)
        { 
            return skillGateway.getTopicNameByUserId(userid);
        }
        public List<SmallTextListDataModel> getSubTopicNameByUserId(int userid)
        { 
            return skillGateway.getSubTopicNameByUserId(userid);
        }
        public SingleIntegerModel getEndDateByUserId(int userid)
        { 
            return skillGateway.getEndDateByUserId(userid);
        }


        public List<SkillModel> Get_SkillsDefault_ByUserId(int userid)
        { 
            return skillGateway.Get_SkillsDefault_ByUserId(userid);
        }

        public List<SkillProfileModel> Get_SkillProfile_ByUserId(List<SkillModel> skillids, int userid)
        { 
            return skillGateway.Get_SkillProfile_ByUserId(skillids,userid);
        }
    }
}