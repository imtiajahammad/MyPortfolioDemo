using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DataAccess.DbGateways
{
    public class CareerAdjectiveGateway
    {
        public List<SmallTextListDataModel> getPersonalQualitiesByUserId(int userid)
        {
            List<SmallTextListDataModel> list = new List<SmallTextListDataModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_CareerAdjective_personalQuality_ByUserId";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = aSqlConnection;
                    aSqlConnection.Open();
                    SqlDataReader aSqlDataReader = cmd.ExecuteReader();
                    SmallTextListDataModel aSmallTextListDataModel = new SmallTextListDataModel();
                    while (aSqlDataReader.Read())
                    {
                        aSmallTextListDataModel.Id = Convert.ToInt32(aSqlDataReader["id"].ToString());
                        aSmallTextListDataModel.ParentId = Convert.ToInt32(aSqlDataReader["parentId"].ToString());
                        aSmallTextListDataModel.Data = aSqlDataReader["data"].ToString();
                        aSmallTextListDataModel.Description = aSqlDataReader["description"].ToString();
                    }
                    list.Add(aSmallTextListDataModel);
                }
            }
            return list;
        }
        public List<SmallTextListDataModel> getSkillsByTopicByUserId(int userid)
        {
            List<SmallTextListDataModel> list = new List<SmallTextListDataModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_CareerAdjective_skillsByTopic_ByUserId";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = aSqlConnection;
                    aSqlConnection.Open();
                    SqlDataReader aSqlDataReader = cmd.ExecuteReader();
                    SmallTextListDataModel aSmallTextListDataModel = new SmallTextListDataModel();
                    while (aSqlDataReader.Read())
                    {
                        aSmallTextListDataModel.Id = Convert.ToInt32(aSqlDataReader["id"].ToString());
                        aSmallTextListDataModel.ParentId = Convert.ToInt32(aSqlDataReader["parentId"].ToString());
                        aSmallTextListDataModel.Data = aSqlDataReader["data"].ToString();
                        aSmallTextListDataModel.Description = aSqlDataReader["description"].ToString();
                    }
                    list.Add(aSmallTextListDataModel);
                }
            }
            return list;
        }
        public List<LargeTextListDataModel> getBriefAboutMeByUserId(int userid)
        {
            List<LargeTextListDataModel> list = new List<LargeTextListDataModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_CareerAdjective_briefAboutMe_ByUserId";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = aSqlConnection;
                    aSqlConnection.Open();
                    SqlDataReader aSqlDataReader = cmd.ExecuteReader();
                    LargeTextListDataModel aLargeTextListDataModel = new LargeTextListDataModel();
                    while (aSqlDataReader.Read())
                    {
                        aLargeTextListDataModel.Id = Convert.ToInt32(aSqlDataReader["id"].ToString());
                        aLargeTextListDataModel.ParentId = Convert.ToInt32(aSqlDataReader["parentId"].ToString());
                        aLargeTextListDataModel.Data = aSqlDataReader["data"].ToString();
                        aLargeTextListDataModel.Description = aSqlDataReader["description"].ToString();
                    }
                    list.Add(aLargeTextListDataModel);
                }
            }
            return list;
        }
        public List<SmallTextListDataModel> getMyWorkFeaturesByUserId(int userid)
        {
            List<SmallTextListDataModel> list = new List<SmallTextListDataModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_CareerAdjective_myWorkFeatures_ByUserId";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = aSqlConnection;
                    aSqlConnection.Open();
                    SqlDataReader aSqlDataReader = cmd.ExecuteReader();
                    SmallTextListDataModel aSmallTextListDataModel = new SmallTextListDataModel();
                    while (aSqlDataReader.Read())
                    {
                        aSmallTextListDataModel.Id = Convert.ToInt32(aSqlDataReader["id"].ToString());
                        aSmallTextListDataModel.ParentId = Convert.ToInt32(aSqlDataReader["parentId"].ToString());
                        aSmallTextListDataModel.Data = aSqlDataReader["data"].ToString();
                        aSmallTextListDataModel.Description = aSqlDataReader["description"].ToString();
                    }
                    list.Add(aSmallTextListDataModel);
                }
            }
            return list;
        }
        public List<SmallTextListDataModel> getCurrentFocusByUserId(int userid)
        {
            List<SmallTextListDataModel> list = new List<SmallTextListDataModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_CareerAdjective_currentFocus_ByUserId";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = aSqlConnection;
                    aSqlConnection.Open();
                    SqlDataReader aSqlDataReader = cmd.ExecuteReader();
                    SmallTextListDataModel aSmallTextListDataModel = new SmallTextListDataModel();
                    while (aSqlDataReader.Read())
                    {
                        aSmallTextListDataModel.Id = Convert.ToInt32(aSqlDataReader["id"].ToString());
                        aSmallTextListDataModel.ParentId = Convert.ToInt32(aSqlDataReader["parentId"].ToString());
                        aSmallTextListDataModel.Data = aSqlDataReader["data"].ToString();
                        aSmallTextListDataModel.Description = aSqlDataReader["description"].ToString();
                    }
                    list.Add(aSmallTextListDataModel);
                }
            }
            return list;
        }


        public List<SingleLargeTextModel> getOnlineResumeLinkByUserId(int userid)
        {
            List<SingleLargeTextModel> list = new List<SingleLargeTextModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_CareerAdjective_onlineResumeLink_ByUserId";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = aSqlConnection;
                    aSqlConnection.Open();
                    SqlDataReader aSqlDataReader = cmd.ExecuteReader();
                    SingleLargeTextModel aSingleLargeTextModel = new SingleLargeTextModel();
                    while (aSqlDataReader.Read())
                    {
                        aSingleLargeTextModel.Id = Convert.ToInt32(aSqlDataReader["id"].ToString());
                        aSingleLargeTextModel.RepositorychildId = Convert.ToInt32(aSqlDataReader["repositorychildId"].ToString());
                        aSingleLargeTextModel.Data = aSqlDataReader["data"].ToString();
                        aSingleLargeTextModel.Description = aSqlDataReader["description"].ToString();
                    }
                    list.Add(aSingleLargeTextModel);
                }
            }
            return list;
        }
        public List<LargeTextListDataModel> getDetailsListByUserId(int userid)
        {
            List<LargeTextListDataModel> list = new List<LargeTextListDataModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_CareerAdjective_detailsList_ByUserId";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = aSqlConnection;
                    aSqlConnection.Open();
                    SqlDataReader aSqlDataReader = cmd.ExecuteReader();
                    LargeTextListDataModel aLargeTextListDataModel = new LargeTextListDataModel();
                    while (aSqlDataReader.Read())
                    {
                        aLargeTextListDataModel.Id = Convert.ToInt32(aSqlDataReader["id"].ToString());
                        aLargeTextListDataModel.ParentId = Convert.ToInt32(aSqlDataReader["parentId"].ToString());
                        aLargeTextListDataModel.Data = aSqlDataReader["data"].ToString();
                        aLargeTextListDataModel.Description = aSqlDataReader["description"].ToString();
                    }
                    list.Add(aLargeTextListDataModel);
                }
            }
            return list;
        }

        public List<CareerAdjectiveModel> Get_CareerAdjectiveDefault_ByUserId(int userid)
        {
            List<CareerAdjectiveModel> list = new List<CareerAdjectiveModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_CareerAdjectiveDefault_ByUserId";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("userid", userid);
                    cmd.Connection = aSqlConnection;
                    aSqlConnection.Open();
                    SqlDataReader aSqlDataReader = cmd.ExecuteReader();
                    CareerAdjectiveModel aCareerAdjectiveModel = new CareerAdjectiveModel();
                    while (aSqlDataReader.Read())
                    {
                        aCareerAdjectiveModel.id = Convert.ToInt32(aSqlDataReader["id"].ToString());
                        aCareerAdjectiveModel.personalQualityId = Convert.ToInt32(aSqlDataReader["personalQualityId"].ToString());
                        aCareerAdjectiveModel.skillsByTopicId = Convert.ToInt32(aSqlDataReader["skillsByTopicId"].ToString());
                        aCareerAdjectiveModel.briefAboutMeId = Convert.ToInt32(aSqlDataReader["briefAboutMeId"].ToString());
                        aCareerAdjectiveModel.myWorkFeatureId = Convert.ToInt32(aSqlDataReader["myWorkFeatureId"].ToString());
                        aCareerAdjectiveModel.currentFocusId = Convert.ToInt32(aSqlDataReader["currentFocusId"].ToString());
                        aCareerAdjectiveModel.onlineResumeLinkId = Convert.ToInt32(aSqlDataReader["onlineResumeLinkId"].ToString());
                        aCareerAdjectiveModel.detailsListId = Convert.ToInt32(aSqlDataReader["detailsListId"].ToString());
                    }
                    list.Add(aCareerAdjectiveModel);
                }
            }
            return list;
        }
    }
}