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
        public List<SingleSmallTextModel> getTopicNameByUserId(int userid)
        {
            List<SingleSmallTextModel> list = new List<SingleSmallTextModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_skills_topicName_ByUserId";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = aSqlConnection;
                    aSqlConnection.Open();
                    SqlDataReader aSqlDataReader = cmd.ExecuteReader();
                    SingleSmallTextModel aSingleSmallTextModel = new SingleSmallTextModel();
                    while (aSqlDataReader.Read())
                    {
                        aSingleSmallTextModel.Id = Convert.ToInt32(aSqlDataReader["id"].ToString());
                        aSingleSmallTextModel.RepositorychildId = Convert.ToInt32(aSqlDataReader["repositorychildId"].ToString());
                        aSingleSmallTextModel.Data = aSqlDataReader["data"].ToString();
                        aSingleSmallTextModel.Description = aSqlDataReader["description"].ToString();
                    }
                    list.Add(aSingleSmallTextModel);
                }
            }
            return list;
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

        public List<SingleIntegerModel> getEndDateByUserId(int userid)
        {
            List<SingleIntegerModel> list = new List<SingleIntegerModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_skills_subTopicName_ByUserId";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = aSqlConnection;
                    aSqlConnection.Open();
                    SqlDataReader aSqlDataReader = cmd.ExecuteReader();
                    SingleIntegerModel aSingleIntegerModel = new SingleIntegerModel();
                    while (aSqlDataReader.Read())
                    {
                        aSingleIntegerModel.Id = Convert.ToInt32(aSqlDataReader["id"].ToString());
                        aSingleIntegerModel.RepositorychildId = Convert.ToInt32(aSqlDataReader["repositorychildId"].ToString());
                        aSingleIntegerModel.Data = Convert.ToInt32(aSqlDataReader["data"].ToString());
                        aSingleIntegerModel.Description = aSqlDataReader["description"].ToString();
                    }
                    list.Add(aSingleIntegerModel);
                }
            }
            return list;
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
    }
}