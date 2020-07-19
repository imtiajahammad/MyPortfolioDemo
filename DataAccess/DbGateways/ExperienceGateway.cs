using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DataAccess.DbGateways
{
    public class ExperienceGateway
    {
        public List<SingleSmallTextModel> getCompanyNameByUserId(int userid)
        {
            List<SingleSmallTextModel> list = new List<SingleSmallTextModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_experience_companyName_ByUserId";
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
        public List<SingleSmallTextModel> getYourRoleByUserId(int userid)
        {
            List<SingleSmallTextModel> list = new List<SingleSmallTextModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_experience_yourRole_ByUserId";
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
        public List<SingleLargeTextModel> getResponsibilityBriefByUserId(int userid)
        {
            List<SingleLargeTextModel> list = new List<SingleLargeTextModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_experience_responsibilityBrief_ByUserId";
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

        public List<LargeTextListDataModel> getResponsibilitiesPointByUserId(int userid)
        {
            List<LargeTextListDataModel> list = new List<LargeTextListDataModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_experience_responsibilitiesPoint_ByUserId";
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

        public List<LargeTextListDataModel> getAccomplishmentsPointByUserId(int userid)
        {
            List<LargeTextListDataModel> list = new List<LargeTextListDataModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_experience_accomplishmentsPoint_ByUserId";
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

        public List<SingleSmallTextModel> getWorkLocationByUserId(int userid)
        {
            List<SingleSmallTextModel> list = new List<SingleSmallTextModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_experience_workLocation_ByUserId";
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

        public List<SingleDateModel> getStartDateByUserId(int userid)
        {
            List<SingleDateModel> list = new List<SingleDateModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_experience_startDate_ByUserId";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = aSqlConnection;
                    aSqlConnection.Open();
                    SqlDataReader aSqlDataReader = cmd.ExecuteReader();
                    SingleDateModel aSingleDateModel = new SingleDateModel();
                    while (aSqlDataReader.Read())
                    {
                        aSingleDateModel.Id = Convert.ToInt32(aSqlDataReader["id"].ToString());
                        aSingleDateModel.RepositorychildId = Convert.ToInt32(aSqlDataReader["repositorychildId"].ToString());
                        aSingleDateModel.Data = Convert.ToDateTime(aSqlDataReader["data"].ToString());
                        aSingleDateModel.Description = aSqlDataReader["description"].ToString();
                    }
                    list.Add(aSingleDateModel);
                }
            }
            return list;
        }

        public List<SingleDateModel> getEndDateByUserId(int userid)
        {
            List<SingleDateModel> list = new List<SingleDateModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_experience_endDate_ByUserId";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = aSqlConnection;
                    aSqlConnection.Open();
                    SqlDataReader aSqlDataReader = cmd.ExecuteReader();
                    SingleDateModel aSingleDateModel = new SingleDateModel();
                    while (aSqlDataReader.Read())
                    {
                        aSingleDateModel.Id = Convert.ToInt32(aSqlDataReader["id"].ToString());
                        aSingleDateModel.RepositorychildId = Convert.ToInt32(aSqlDataReader["repositorychildId"].ToString());
                        aSingleDateModel.Data = Convert.ToDateTime(aSqlDataReader["data"].ToString());
                        aSingleDateModel.Description = aSqlDataReader["description"].ToString();
                    }
                    list.Add(aSingleDateModel);
                }
            }
            return list;
        }
        public List<SingleLargeTextModel> getCompanyLinkByUserId(int userid)
        {
            List<SingleLargeTextModel> list = new List<SingleLargeTextModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_experience_companyLink_ByUserId";
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

    }
}