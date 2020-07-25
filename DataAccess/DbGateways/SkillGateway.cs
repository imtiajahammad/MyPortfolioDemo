using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DataAccess.DbGateways
{
    public class SkillGateway
    {
        public SingleSmallTextModel getTopicNameByUserId(int userid, int defaultId)
        {
            SingleSmallTextModel aSingleSmallTextModel = new SingleSmallTextModel();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_skills_topicName";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("userId", userid);
                    cmd.Parameters.AddWithValue("defaultId", defaultId);
                    cmd.Connection = aSqlConnection;
                    aSqlConnection.Open();
                    SqlDataReader aSqlDataReader = cmd.ExecuteReader();
                    while (aSqlDataReader.Read())
                    {
                        aSingleSmallTextModel.Id = Convert.ToInt32(aSqlDataReader["id"].ToString());
                        aSingleSmallTextModel.RepositorychildId = Convert.ToInt32(aSqlDataReader["repositorychildId"].ToString());
                        aSingleSmallTextModel.Data = aSqlDataReader["data"].ToString();
                        aSingleSmallTextModel.Description = aSqlDataReader["description"].ToString();
                    } 
                }
            }
            return aSingleSmallTextModel;
        }
        public List<SmallTextListDataModel> getSubTopicNameByUserId(int userid, int defaultId)
        {
            List<SmallTextListDataModel> list = new List<SmallTextListDataModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_skills_subTopicName";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("userId", userid);
                    cmd.Parameters.AddWithValue("defaultId", defaultId);
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
        public SingleIntegerModel getPercentageByUserId(int userid, int defaultId)
        {
            SingleIntegerModel aSingleIntegerModel = new SingleIntegerModel();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_skills_percentage";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("userId", userid);
                    cmd.Parameters.AddWithValue("defaultId", defaultId);
                    cmd.Connection = aSqlConnection;
                    aSqlConnection.Open();
                    SqlDataReader aSqlDataReader = cmd.ExecuteReader(); 
                    while (aSqlDataReader.Read())
                    {
                        aSingleIntegerModel.Id = Convert.ToInt32(aSqlDataReader["id"].ToString());
                        aSingleIntegerModel.RepositorychildId = Convert.ToInt32(aSqlDataReader["repositorychildId"].ToString());
                        aSingleIntegerModel.Data = Convert.ToInt32(aSqlDataReader["data"].ToString());
                        aSingleIntegerModel.Description = aSqlDataReader["description"].ToString();
                    } 
                }
            }
            return aSingleIntegerModel;
        }
        /**/
        public SingleSmallTextModel getTopicNameByUserId(int userid)
        {
            SingleSmallTextModel aSingleSmallTextModel = new SingleSmallTextModel();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_skills_topicName_ByUserId";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("userId", userid);
                    cmd.Connection = aSqlConnection;
                    aSqlConnection.Open();
                    SqlDataReader aSqlDataReader = cmd.ExecuteReader(); 
                    while (aSqlDataReader.Read())
                    {
                        aSingleSmallTextModel.Id = Convert.ToInt32(aSqlDataReader["id"].ToString());
                        aSingleSmallTextModel.RepositorychildId = Convert.ToInt32(aSqlDataReader["repositorychildId"].ToString());
                        aSingleSmallTextModel.Data = aSqlDataReader["data"].ToString();
                        aSingleSmallTextModel.Description = aSqlDataReader["description"].ToString();
                    }
                }
            }
            return aSingleSmallTextModel;
        }
        public List<SmallTextListDataModel> getSubTopicNameByUserId(int userid)
        {
            List<SmallTextListDataModel> list = new List<SmallTextListDataModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_skills_subTopicName_ByUserId";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("userId", userid);
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
        public SingleIntegerModel getEndDateByUserId(int userid)
        {
            SingleIntegerModel aSingleIntegerModel = new SingleIntegerModel();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_skills_percentage_ByUserId";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("userId", userid);
                    cmd.Connection = aSqlConnection;
                    aSqlConnection.Open();
                    SqlDataReader aSqlDataReader = cmd.ExecuteReader(); 
                    while (aSqlDataReader.Read())
                    {
                        aSingleIntegerModel.Id = Convert.ToInt32(aSqlDataReader["id"].ToString());
                        aSingleIntegerModel.RepositorychildId = Convert.ToInt32(aSqlDataReader["repositorychildId"].ToString());
                        aSingleIntegerModel.Data = Convert.ToInt32(aSqlDataReader["data"].ToString());
                        aSingleIntegerModel.Description = aSqlDataReader["description"].ToString();
                    } 
                }
            }
            return aSingleIntegerModel;
        }

        
        public List<SkillModel> Get_SkillsDefault_ByUserId(int userid)
        {
            List<SkillModel> list = new List<SkillModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_SkillsDefault_ByUserId";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("userid", userid);
                    cmd.Connection = aSqlConnection;
                    aSqlConnection.Open();
                    SqlDataReader aSqlDataReader = cmd.ExecuteReader();
                    SkillModel aSkillModel = new SkillModel();
                    while (aSqlDataReader.Read())
                    {
                        aSkillModel.id = Convert.ToInt32(aSqlDataReader["id"].ToString());
                        aSkillModel.topicNameId = Convert.ToInt32(aSqlDataReader["topicNameId"].ToString());
                        aSkillModel.subTopicNameId = Convert.ToInt32(aSqlDataReader["subTopicNameId"].ToString());
                        aSkillModel.percentageId = Convert.ToInt32(aSqlDataReader["percentageId"].ToString());                        
                    }
                    list.Add(aSkillModel);
                }
            }
            return list;
        }

        public List<SkillProfileModel> Get_SkillProfile_ByUserId(List<SkillModel> skillids, int userid)
        {
            List<SkillProfileModel> list = new List<SkillProfileModel>();
            foreach (SkillModel aSkillModel in skillids)
            {
                SkillProfileModel aSkillProfileModel = new SkillProfileModel();
                aSkillProfileModel.id = aSkillProfileModel.id;
                aSkillProfileModel.topicName = getTopicNameByUserId(userid, aSkillModel.topicNameId);
                aSkillProfileModel.subTopicName = getSubTopicNameByUserId(userid, aSkillModel.subTopicNameId);
                aSkillProfileModel.percentage = getPercentageByUserId(userid, aSkillModel.percentageId);
                list.Add(aSkillProfileModel);
            }
            return list;
        }
    }
}