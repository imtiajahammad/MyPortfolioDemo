using DataAccess.DbGateways;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccess.Managers
{
    public class AboutManager
    {
        AboutGateway aboutGateway;
        public AboutManager()
        {
            this.aboutGateway = new AboutGateway();
        }
        public SingleSmallTextModel getFirstNameByUserId(int userid, int defaultId)
        {
            return aboutGateway.getFirstNameByUserId(userid, defaultId);
        }

        public SingleSmallTextModel getMiddleNameByUserId(int userid, int defaultId)
        {
            
            return aboutGateway.getMiddleNameByUserId(userid,defaultId);
        }

        public SingleSmallTextModel getLastNameByUserId(int userid, int defaultId)
        {
            return aboutGateway.getLastNameByUserId(userid, defaultId);
        }

        public List<SmallTextListDataModel> getPhoneNumbersByUserId(int userid, int defaultId)
        {
            return aboutGateway.getPhoneNumbersByUserId(userid, defaultId);
        }
        public List<LargeTextListDataModel> getBriefByUserId(int userid, int defaultId)
        {
            return aboutGateway.getBriefByUserId(userid, defaultId);
        }
        public List<SmallTextListDataModel> getLanguagesByUserId(int userid, int defaultId)
        {
            return aboutGateway.getLanguagesByUserId(userid, defaultId);
        }
        public SingleDateModel getDobByUserId(int userid, int defaultId)
        {
            return aboutGateway.getDobByUserId(userid, defaultId);
        }

        public SingleSmallTextModel getCountryByUserId(int userid, int defaultId)
        {
            return aboutGateway.getCountryByUserId(userid, defaultId);
        }

        public SingleSmallTextModel getCityByUserId(int userid, int defaultId)
        {
            return aboutGateway.getCityByUserId(userid, defaultId);
        }

        public SingleLargeTextModel getFullAddressByUserId(int userid, int defaultId)
        {
            return aboutGateway.getFullAddressByUserId(userid, defaultId);
        }

        public List<OnlineLinkDataModel> getSocialLinksByUserId(int userid, int defaultId)
        {
            return aboutGateway.getSocialLinksByUserId(userid, defaultId);
        }
        /**/
        public SingleSmallTextModel getFirstNameByUserId(int userid)
        {
            return aboutGateway.getFirstNameByUserId(userid);
        }

        public SingleSmallTextModel getMiddleNameByUserId(int userid)
        {
            return aboutGateway.getMiddleNameByUserId(userid);
        }

        public SingleSmallTextModel getLastNameByUserId(int userid)
        {
            return aboutGateway.getLastNameByUserId(userid);
        }

        public List<SmallTextListDataModel> getPhoneNumbersByUserId(int userid)
        {
            return aboutGateway.getPhoneNumbersByUserId(userid );
        }
        public List<LargeTextListDataModel> getBriefByUserId(int userid)
        {
            return aboutGateway.getBriefByUserId(userid );
        }
        public List<SmallTextListDataModel> getLanguagesByUserId(int userid)
        {
            return aboutGateway.getLanguagesByUserId(userid );
        }
        public SingleDateModel getDobByUserId(int userid)
        {
            return aboutGateway.getDobByUserId(userid);
        }

        public SingleSmallTextModel getCountryByUserId(int userid)
        {
            return aboutGateway.getCountryByUserId(userid);
        }

        public SingleSmallTextModel getCityByUserId(int userid)
        {
            return aboutGateway.getCityByUserId(userid);
        }

        public SingleLargeTextModel getFullAddressByUserId(int userid)
        {
            return aboutGateway.getFullAddressByUserId(userid);
        }

        public List<OnlineLinkDataModel> getSocialLinksByUserId(int userid)
        {
            return aboutGateway.getSocialLinksByUserId(userid);
        }

        /**/
        public List<AboutModel> Get_AboutDefault_ByUserId(int userid)
        {
            return aboutGateway.Get_AboutDefault_ByUserId(userid);
        }

        public List<AboutProfileModel> Get_AboutProfile_ByUserId(List<AboutModel> aboutids, int userid)
        {
            return aboutGateway.Get_AboutProfile_ByUserId(aboutids, userid);
        }
    }
}