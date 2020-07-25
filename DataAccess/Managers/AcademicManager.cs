using DataAccess.DbGateways;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccess.Managers
{
    public class AcademicManager
    {
        AcademicGateway academicGateway;
        public AcademicManager()
        {
            academicGateway = new AcademicGateway();
        }
        public SingleSmallTextModel getInstitutionNameByUserId(int userid, int defaultId)
        {            
            return academicGateway.getInstitutionNameByUserId(userid,defaultId);
        }
        public SingleSmallTextModel getLocationByUserId(int userid, int defaultId)
        {
            return academicGateway.getLocationByUserId(userid, defaultId);
        }
        public SingleSmallTextModel getCourseNameByUserId(int userid, int defaultId)
        {
            return academicGateway.getCourseNameByUserId(userid, defaultId);
        }
        public SingleSmallTextModel getCgpaByUserId(int userid, int defaultId)
        {
            return academicGateway.getCgpaByUserId(userid, defaultId);
        }
        public SingleDateModel getStartByUserId(int userid, int defaultId)
        {
            return academicGateway.getStartByUserId(userid, defaultId);
        }
        public SingleDateModel getEndByUserId(int userid, int defaultId)
        {
            return academicGateway.getEndByUserId(userid, defaultId);
        }
        public List<LargeTextListDataModel> getBriefPointByUserId(int userid, int defaultId)
        {
            return academicGateway.getBriefPointByUserId(userid, defaultId);
        }

        /**/
        public SingleSmallTextModel getInstitutionNameByUserId(int userid)
        {
            return academicGateway.getInstitutionNameByUserId(userid);
        }
        public SingleSmallTextModel getLocationByUserId(int userid)
        {
            return academicGateway.getLocationByUserId(userid);
        }
        public SingleSmallTextModel getCourseNameByUserId(int userid)
        {
            return academicGateway.getCourseNameByUserId(userid);
        }
        public SingleSmallTextModel getCgpaByUserId(int userid)
        {
            return academicGateway.getCgpaByUserId(userid);
        }
        public SingleDateModel getStartByUserId(int userid)
        {
            return academicGateway.getStartByUserId(userid);
        }
        public SingleDateModel getEndByUserId(int userid)
        {
            return academicGateway.getEndByUserId(userid);
        }
        public List<LargeTextListDataModel> getBriefPointByUserId(int userid)
        {
            return academicGateway.getBriefPointByUserId(userid);
        }

        public List<AcademicModel> Get_AcademicsDefault_ByUserId(int userid)
        {
            return academicGateway.Get_AcademicsDefault_ByUserId(userid);
        }


        public List<AcademicProfileModel> Get_AcademicProfile_ByUserId(List<AcademicModel> academicids, int userid)
        {
            return academicGateway.Get_AcademicProfile_ByUserId(academicids,userid);
        }
    }
}