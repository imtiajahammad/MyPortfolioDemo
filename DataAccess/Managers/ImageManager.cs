using DataAccess.DbGateways;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccess.Managers
{
    public class ImageManager
    {
        ImageGateway imageGateway;
        public ImageManager()
        {
            this.imageGateway = new ImageGateway();
        }
        public List<SmallTextListDataModel> getHomeImageByUserId(int userid, int defaultId)
        { 
            return imageGateway.getHomeImageByUserId(userid,defaultId);
        }
        /**/
        public List<SmallTextListDataModel> getHomeImageByUserId(int userid)
        { 
            return imageGateway.getHomeImageByUserId(userid);
        }


        public List<SelfImageModel> Get_SelfImagesDefault_ByUserId(int userid)
        { 
            return imageGateway.Get_SelfImagesDefault_ByUserId(userid);
        }

        public List<SelfImagProfileModel> Get_SelfImagProfile_ByUserId(List<SelfImageModel> selfImagids, int userid)
        { 
            return imageGateway.Get_SelfImagProfile_ByUserId(selfImagids,userid);
        }
    }
}