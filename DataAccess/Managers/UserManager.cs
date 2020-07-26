using DataAccess.DbGateways;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccess.Managers
{
    public class UserManager
    {
        UserGateway userGateway;
        public UserManager()
        {
            this.userGateway = new UserGateway();
        }
        public int getCareerAdjectiveId_ByUserId(int userid)
        {
            return userGateway.getCareerAdjectiveId_ByUserId(userid);
        }
        public int getProjectId_ByUserId(int userid)
        { 
            return userGateway.getProjectId_ByUserId(userid);
        }
        public int getContactId_ByUserId(int userid)
        { 
            return userGateway.getContactId_ByUserId(userid);
        }
        public int getAboutId_ByUserId(int userid)
        { 
            return userGateway.getAboutId_ByUserId(userid);
        }
        public int getSelfImageId_ByUserId(int userid)
        { 
            return userGateway.getSelfImageId_ByUserId(userid);
        }
        public int getExperienceId_ByUserId(int userid)
        { 
            return userGateway.getExperienceId_ByUserId(userid);
        }
        public int getSkillId_ByUserId(int userid)
        { 
            return userGateway.getSkillId_ByUserId(userid);
        }
        public int getAcademicId_ByUserId(int userid)
        { 
            return userGateway.getAcademicId_ByUserId(userid);
        }
        public int GetCareerAdjectiveId_ByUserId(int userid)
        { 
            return userGateway.GetCareerAdjectiveId_ByUserId(userid);
        }
    }
}