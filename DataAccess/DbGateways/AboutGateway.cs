using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DataAccess.DbGateways
{
    public class AboutGateway
    {
        public SingleSmallTextModel getFirstNameByUserId(int userid,int defaultId)
        {
            SingleSmallTextModel aSingleSmallTextModel = new SingleSmallTextModel();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_About_firstName";
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
        public SingleSmallTextModel getMiddleNameByUserId(int userid, int defaultId)
        {
            SingleSmallTextModel aSingleSmallTextModel = new SingleSmallTextModel();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_About_middleName";
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

        public SingleSmallTextModel getLastNameByUserId(int userid, int defaultId)
        {
            SingleSmallTextModel aSingleSmallTextModel = new SingleSmallTextModel();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_About_lastName";
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

        public List<SmallTextListDataModel> getPhoneNumbersByUserId(int userid, int defaultId)
        {
            List<SmallTextListDataModel> list = new List<SmallTextListDataModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_About_phoneNumbers";
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
        public List<LargeTextListDataModel> getBriefByUserId(int userid, int defaultId)
        {
            List<LargeTextListDataModel> list = new List<LargeTextListDataModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_About_brief";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("userId", userid);
                    cmd.Parameters.AddWithValue("defaultId", defaultId);
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
        public List<SmallTextListDataModel> getLanguagesByUserId(int userid, int defaultId)
        {
            List<SmallTextListDataModel> list = new List<SmallTextListDataModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_About_language";
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
        public SingleDateModel getDobByUserId(int userid, int defaultId)
        {
            SingleDateModel aSingleDateModel = new SingleDateModel();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_About_dob";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("userId", userid);
                    cmd.Parameters.AddWithValue("defaultId", defaultId);
                    cmd.Connection = aSqlConnection;
                    aSqlConnection.Open();
                    SqlDataReader aSqlDataReader = cmd.ExecuteReader();
                    while (aSqlDataReader.Read())
                    {
                        aSingleDateModel.Id = Convert.ToInt32(aSqlDataReader["id"].ToString());
                        aSingleDateModel.RepositorychildId = Convert.ToInt32(aSqlDataReader["repositorychildId"].ToString());
                        aSingleDateModel.Data = Convert.ToDateTime(aSqlDataReader["data"].ToString());
                        aSingleDateModel.Description = aSqlDataReader["description"].ToString();
                    }
                }
            }
            return aSingleDateModel;
        }
        public SingleSmallTextModel getCountryByUserId(int userid, int defaultId)
        {
            SingleSmallTextModel aSingleSmallTextModel = new SingleSmallTextModel();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_About_country";
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
        public SingleSmallTextModel getCityByUserId(int userid, int defaultId)
        {
            SingleSmallTextModel aSingleSmallTextModel = new SingleSmallTextModel();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_About_city";
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
        public SingleLargeTextModel getFullAddressByUserId(int userid, int defaultId)
        {
            SingleLargeTextModel aSingleLargeTextModel = new SingleLargeTextModel();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_About_fullAddress";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("userId", userid);
                    cmd.Parameters.AddWithValue("defaultId", defaultId);
                    cmd.Connection = aSqlConnection;
                    aSqlConnection.Open();
                    SqlDataReader aSqlDataReader = cmd.ExecuteReader();

                    while (aSqlDataReader.Read())
                    {
                        aSingleLargeTextModel.Id = Convert.ToInt32(aSqlDataReader["id"].ToString());
                        aSingleLargeTextModel.RepositorychildId = Convert.ToInt32(aSqlDataReader["repositorychildId"].ToString());
                        aSingleLargeTextModel.Data = aSqlDataReader["data"].ToString();
                        aSingleLargeTextModel.Description = aSqlDataReader["description"].ToString();
                    }
                }
            }
            return aSingleLargeTextModel;
        }
        public List<OnlineLinkDataModel> getSocialLinksByUserId(int userid, int defaultId)
        {
            List<OnlineLinkDataModel> list = new List<OnlineLinkDataModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_About_socialLinks";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("userId", userid);
                    cmd.Parameters.AddWithValue("defaultId", defaultId);
                    cmd.Connection = aSqlConnection;
                    aSqlConnection.Open();
                    SqlDataReader aSqlDataReader = cmd.ExecuteReader();
                    OnlineLinkDataModel aOnlineLinkDataModel = new OnlineLinkDataModel();
                    while (aSqlDataReader.Read())
                    {

                        aOnlineLinkDataModel.Id = Convert.ToInt32(aSqlDataReader["id"].ToString());
                        aOnlineLinkDataModel.ParentId = Convert.ToInt32(aSqlDataReader["parentId"].ToString());
                        aOnlineLinkDataModel.Title = aSqlDataReader["title"].ToString();
                        aOnlineLinkDataModel.Link = aSqlDataReader["link"].ToString();
                        aOnlineLinkDataModel.IconLink = aSqlDataReader["icon"].ToString();
                        aOnlineLinkDataModel.Description = aSqlDataReader["description"].ToString();
                    }
                    list.Add(aOnlineLinkDataModel);
                }
            }
            return list;
        }
        /**/
        public SingleSmallTextModel getFirstNameByUserId(int userid)
        {
            SingleSmallTextModel aSingleSmallTextModel = new SingleSmallTextModel();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_About_firstName_ByUserId";
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
        public SingleSmallTextModel getMiddleNameByUserId(int userid)
        {
            SingleSmallTextModel aSingleSmallTextModel = new SingleSmallTextModel();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_About_middleName_ByUserId";
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

        public SingleSmallTextModel getLastNameByUserId(int userid)
        {
            SingleSmallTextModel aSingleSmallTextModel = new SingleSmallTextModel();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_About_lastName_ByUserId";
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

        public List<SmallTextListDataModel> getPhoneNumbersByUserId(int userid)
        {
            List<SmallTextListDataModel> list = new List<SmallTextListDataModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_About_phoneNumbers_ByUserId";
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
        public List<LargeTextListDataModel> getBriefByUserId(int userid)
        {
            List<LargeTextListDataModel> list = new List<LargeTextListDataModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_About_brief_ByUserId";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("userId", userid);
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
        public List<SmallTextListDataModel> getLanguagesByUserId(int userid)
        {
            List<SmallTextListDataModel> list = new List<SmallTextListDataModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_About_language_ByUserId";
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
        public SingleDateModel getDobByUserId(int userid)
        {
            SingleDateModel aSingleDateModel = new SingleDateModel();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_About_dob_ByUserId";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("userId", userid);
                    cmd.Connection = aSqlConnection;
                    aSqlConnection.Open();
                    SqlDataReader aSqlDataReader = cmd.ExecuteReader();

                    while (aSqlDataReader.Read())
                    {
                        aSingleDateModel.Id = Convert.ToInt32(aSqlDataReader["id"].ToString());
                        aSingleDateModel.RepositorychildId = Convert.ToInt32(aSqlDataReader["repositorychildId"].ToString());
                        aSingleDateModel.Data = Convert.ToDateTime(aSqlDataReader["data"].ToString());
                        aSingleDateModel.Description = aSqlDataReader["description"].ToString();
                    }
 
                }
            }
            return aSingleDateModel;
        }

        public SingleSmallTextModel getCountryByUserId(int userid)
        {
            SingleSmallTextModel aSingleSmallTextModel = new SingleSmallTextModel();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_About_country_ByUserId";
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

        public SingleSmallTextModel getCityByUserId(int userid)
        {
            SingleSmallTextModel aSingleSmallTextModel = new SingleSmallTextModel();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_About_city_ByUserId";
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

        public SingleLargeTextModel getFullAddressByUserId(int userid)
        {
            SingleLargeTextModel aSingleLargeTextModel = new SingleLargeTextModel();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_About_fullAddress_ByUserId";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("userId", userid);
                    cmd.Connection = aSqlConnection;
                    aSqlConnection.Open();
                    SqlDataReader aSqlDataReader = cmd.ExecuteReader();
 
                    while (aSqlDataReader.Read())
                    {
                        aSingleLargeTextModel.Id = Convert.ToInt32(aSqlDataReader["id"].ToString());
                        aSingleLargeTextModel.RepositorychildId = Convert.ToInt32(aSqlDataReader["repositorychildId"].ToString());
                        aSingleLargeTextModel.Data = aSqlDataReader["data"].ToString();
                        aSingleLargeTextModel.Description = aSqlDataReader["description"].ToString();
                    }
 
                }
            }
            return aSingleLargeTextModel;
        }

        public List<OnlineLinkDataModel> getSocialLinksByUserId(int userid)
        {
            List<OnlineLinkDataModel> list = new List<OnlineLinkDataModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_About_socialLinks_ByUserId";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("userId", userid);
                    cmd.Connection = aSqlConnection;
                    aSqlConnection.Open();
                    SqlDataReader aSqlDataReader = cmd.ExecuteReader();
                    OnlineLinkDataModel aOnlineLinkDataModel = new OnlineLinkDataModel();
                    while (aSqlDataReader.Read())
                    {
                        aOnlineLinkDataModel.Id = Convert.ToInt32(aSqlDataReader["id"].ToString());
                        aOnlineLinkDataModel.ParentId = Convert.ToInt32(aSqlDataReader["parentId"].ToString());
                        aOnlineLinkDataModel.Title = aSqlDataReader["title"].ToString();
                        aOnlineLinkDataModel.Link = aSqlDataReader["link"].ToString();
                        aOnlineLinkDataModel.IconLink = aSqlDataReader["icon"].ToString();
                        aOnlineLinkDataModel.Description = aSqlDataReader["description"].ToString();
                    }
                    list.Add(aOnlineLinkDataModel);
                }
            }
            return list;
        }

        /**/
        public List<AboutModel> Get_AboutDefault_ByUserId(int userid)
        {
            Object conStr=System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"];/* LocalSqlServer*/

            Object conStr2 = System.Configuration.ConfigurationManager.ConnectionStrings;
            Object conStr3 = System.Configuration.ConfigurationManager.ConnectionStrings["LocalSqlServer"];

            List<AboutModel> list = new List<AboutModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_AboutDefault_ByUserId";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("userid", userid);
                    cmd.Connection = aSqlConnection;
                    aSqlConnection.Open();
                    SqlDataReader aSqlDataReader = cmd.ExecuteReader();
                    AboutModel aAboutModel = new AboutModel();
                    while (aSqlDataReader.Read())
                    {
                        aAboutModel.id = Convert.ToInt32(aSqlDataReader["id"].ToString());
                        aAboutModel.firstNameId = Convert.ToInt32(aSqlDataReader["firstNameId"].ToString());
                        aAboutModel.middleNameId = Convert.ToInt32(aSqlDataReader["middleNameId"].ToString());
                        aAboutModel.lastNameId = Convert.ToInt32(aSqlDataReader["lastNameId"].ToString());
                        aAboutModel.phoneNumberId = Convert.ToInt32(aSqlDataReader["phoneNumberId"].ToString());
                        aAboutModel.briefId = Convert.ToInt32(aSqlDataReader["briefId"].ToString());
                        aAboutModel.languageId = Convert.ToInt32(aSqlDataReader["languageId"].ToString());
                        aAboutModel.dobId = Convert.ToInt32(aSqlDataReader["dobId"].ToString());
                        aAboutModel.countryId = Convert.ToInt32(aSqlDataReader["countryId"].ToString());
                        aAboutModel.cityId = Convert.ToInt32(aSqlDataReader["cityId"].ToString());
                        aAboutModel.fullAddressId = Convert.ToInt32(aSqlDataReader["fullAddressId"].ToString());
                        aAboutModel.socialLinksId = Convert.ToInt32(aSqlDataReader["socialLinksId"].ToString());
                    }
                    list.Add(aAboutModel);
                }
            }            
            return list;
        }

        public List<AboutProfileModel> Get_AboutProfile_ByUserId(List<AboutModel> aboutids,int userid)
        {
            List<AboutProfileModel> list = new List<AboutProfileModel>();
            foreach (AboutModel aAboutModel in aboutids)
            {
                AboutProfileModel aAboutProfileModel = new AboutProfileModel();
                aAboutProfileModel.id=aAboutModel.id;
                aAboutProfileModel.FirstName = getFirstNameByUserId(userid,aAboutModel.firstNameId);
                aAboutProfileModel.MiddleName = getMiddleNameByUserId(userid, aAboutModel.middleNameId);
                aAboutProfileModel.LastName = getLastNameByUserId(userid, aAboutModel.lastNameId);
                aAboutProfileModel.phoneNumbers = getPhoneNumbersByUserId(userid, aAboutModel.phoneNumberId);
                aAboutProfileModel.brief = getBriefByUserId(userid, aAboutModel.briefId);
                aAboutProfileModel.languages = getLanguagesByUserId(userid, aAboutModel.languageId);
                aAboutProfileModel.DOB = getDobByUserId(userid, aAboutModel.dobId);

                aAboutProfileModel.country = getCountryByUserId(userid, aAboutModel.countryId);
                aAboutProfileModel.city = getCityByUserId(userid, aAboutModel.cityId);
                aAboutProfileModel.fullAddress = getFullAddressByUserId(userid, aAboutModel.fullAddressId);
                aAboutProfileModel.socialLinks = getSocialLinksByUserId(userid, aAboutModel.socialLinksId);
                list.Add(aAboutProfileModel);
            }
            return list;
        }
    }
}