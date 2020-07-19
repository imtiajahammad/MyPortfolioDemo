using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DataAccess.DbGateways
{
    public class AcademicGateway
    {
        public List<SingleSmallTextModel> getInstitutionNameByUserId(int userid)
        {
            List<SingleSmallTextModel> list = new List<SingleSmallTextModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_academics_institutionName_ByUserId";
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

        public List<SingleSmallTextModel> getLocationByUserId(int userid)
        {
            List<SingleSmallTextModel> list = new List<SingleSmallTextModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_academics_location_ByUserId";
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

        public List<SingleSmallTextModel> getCourseNameByUserId(int userid)
        {
            List<SingleSmallTextModel> list = new List<SingleSmallTextModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_academics_courseName_ByUserId";
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

        public List<SingleSmallTextModel> getCgpaByUserId(int userid)
        {
            List<SingleSmallTextModel> list = new List<SingleSmallTextModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_academics_cgpa_ByUserId";
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

        public List<SingleDateModel> getStartByUserId(int userid)
        {
            List<SingleDateModel> list = new List<SingleDateModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_academics_start_ByUserId";
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

        public List<SingleDateModel> getEndByUserId(int userid)
        {
            List<SingleDateModel> list = new List<SingleDateModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_academics_end_ByUserId";
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

        public List<LargeTextListDataModel> getBriefPointByUserId(int userid)
        {
            List<LargeTextListDataModel> list = new List<LargeTextListDataModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_academics_brief_ByUserId";
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
    }
}