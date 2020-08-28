using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DataAccess.DbGateways
{
    public class ProjectGateway
    {
        public List<SmallTextListDataModel> getTechnologyTypeByUserId(int userid, int defaultId)
        {
            List<SmallTextListDataModel> list = new List<SmallTextListDataModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_Projects_technologyType";
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
        public List<SmallTextListDataModel> getImagesByUserId(int userid, int defaultId)
        {
            List<SmallTextListDataModel> list = new List<SmallTextListDataModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_Projects_images";
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
        public SingleSmallTextModel getProjectNameByUserId(int userid, int defaultId)
        {
            SingleSmallTextModel aSingleSmallTextModel = new SingleSmallTextModel();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_Projects_projectName";
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
        public SingleSmallTextModel getProjectSubNameByUserId(int userid, int defaultId)
        {
            SingleSmallTextModel aSingleSmallTextModel = new SingleSmallTextModel();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_Projects_projectSubName";
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
        public List<LargeTextListDataModel> getProjectBriefByUserId(int userid, int defaultId)
        {
            List<LargeTextListDataModel> list = new List<LargeTextListDataModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_Projects_projectBrief";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("userId", userid);
                    cmd.Parameters.AddWithValue("defaultId", defaultId);
                    cmd.Connection = aSqlConnection;
                    aSqlConnection.Open();
                    SqlDataReader aSqlDataReader = cmd.ExecuteReader();                    
                    while (aSqlDataReader.Read())
                    {
                        LargeTextListDataModel aLargeTextListDataModel = new LargeTextListDataModel();
                        aLargeTextListDataModel.Id = Convert.ToInt32(aSqlDataReader["id"].ToString());
                        aLargeTextListDataModel.ParentId = Convert.ToInt32(aSqlDataReader["parentId"].ToString());
                        aLargeTextListDataModel.Data = aSqlDataReader["data"].ToString();
                        aLargeTextListDataModel.Description = aSqlDataReader["description"].ToString();
                        list.Add(aLargeTextListDataModel);
                    }                    
                }
            }
            return list;
        }
        public List<LargeTextListDataModel> getProjectKeyPointsByUserId(int userid, int defaultId)
        {
            List<LargeTextListDataModel> list = new List<LargeTextListDataModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_Projects_projectKeyPoints";
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
        public List<LargeTextListDataModel> getProjectTechnologyBriefByUserId(int userid, int defaultId)
        {
            List<LargeTextListDataModel> list = new List<LargeTextListDataModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_Projects_projectTechnologyBrief";
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
        public List<SmallTextListDataModel> getProjectTechnologiesByUserId(int userid, int defaultId)
        {
            List<SmallTextListDataModel> list = new List<SmallTextListDataModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_Projects_projectTechnologies";
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
        public List<SmallTextListDataModel> getProjectTechnologiesIconsByUserId(int userid, int defaultId)
        {
            List<SmallTextListDataModel> list = new List<SmallTextListDataModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_Projects_projectTechnologiesIcons";
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
        public SingleLargeTextModel getProjectLiveLinkByUserId(int userid, int defaultId)
        {
            SingleLargeTextModel aSingleLargeTextModel = new SingleLargeTextModel();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_Projects_projectLiveLink";
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
        public SingleLargeTextModel getProjectSourceLinkByUserId(int userid, int defaultId)
        {
            SingleLargeTextModel aSingleLargeTextModel = new SingleLargeTextModel();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_Projects_projectSourceLink";
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
        public SingleDateModel getDateCreatedByUserId(int userid, int defaultId)
        {
            SingleDateModel aSingleDateModel = new SingleDateModel();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_Projects_dateCreated";
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
        public SingleLargeTextModel getOneSingleBriefForWholeProjectByUserId(int userid, int defaultId)
        {
            SingleLargeTextModel aSingleLargeTextModel = new SingleLargeTextModel();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_Projects_oneSingleBriefForWholeProject";
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
        /**/
        public SmallTextListDataModel getTechnologyTypeByUserId(int userid)
        {
            SmallTextListDataModel aSmallTextListDataModel = new SmallTextListDataModel();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_Projects_technologyType_ByUserId";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("userId", userid);
                    cmd.Connection = aSqlConnection;
                    aSqlConnection.Open();
                    SqlDataReader aSqlDataReader = cmd.ExecuteReader();
                    while (aSqlDataReader.Read())
                    {
                        aSmallTextListDataModel.Id = Convert.ToInt32(aSqlDataReader["id"].ToString());
                        aSmallTextListDataModel.ParentId = Convert.ToInt32(aSqlDataReader["parentId"].ToString());
                        aSmallTextListDataModel.Data = aSqlDataReader["data"].ToString();
                        aSmallTextListDataModel.Description = aSqlDataReader["description"].ToString();
                    }
                }
            }
            return aSmallTextListDataModel;
        }
        public List<SmallTextListDataModel> getImagesByUserId(int userid)
        {
            List<SmallTextListDataModel> list = new List<SmallTextListDataModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_Projects_images_ByUserId";
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
        public SingleSmallTextModel getProjectNameByUserId(int userid)
        {
            SingleSmallTextModel aSingleSmallTextModel = new SingleSmallTextModel();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_Projects_projectName_ByUserId";
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
        public SingleSmallTextModel getProjectSubNameByUserId(int userid)
        {
            SingleSmallTextModel aSingleSmallTextModel = new SingleSmallTextModel();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_Projects_projectSubName_ByUserId";
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
        public List<LargeTextListDataModel> getProjectBriefByUserId(int userid)
        {
            List<LargeTextListDataModel> list = new List<LargeTextListDataModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_Projects_projectBrief_ByUserId";
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
        public List<LargeTextListDataModel> getProjectKeyPointsByUserId(int userid)
        {
            List<LargeTextListDataModel> list = new List<LargeTextListDataModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_Projects_projectKeyPoints_ByUserId";
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
        public List<LargeTextListDataModel> getProjectTechnologyBriefByUserId(int userid)
        {
            List<LargeTextListDataModel> list = new List<LargeTextListDataModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_Projects_projectTechnologyBrief_ByUserId";
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
        public List<SmallTextListDataModel> getProjectTechnologiesByUserId(int userid)
        {
            List<SmallTextListDataModel> list = new List<SmallTextListDataModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_Projects_projectTechnologies_ByUserId";
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
        public List<SmallTextListDataModel> getProjectTechnologiesIconsByUserId(int userid)
        {
            List<SmallTextListDataModel> list = new List<SmallTextListDataModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_Projects_projectTechnologiesIcons_ByUserId";
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
        public SingleLargeTextModel getProjectLiveLinkByUserId(int userid)
        {
            SingleLargeTextModel aSingleLargeTextModel = new SingleLargeTextModel();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_Projects_projectLiveLink_ByUserId";
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
        public SingleLargeTextModel getProjectSourceLinkByUserId(int userid)
        {
            SingleLargeTextModel aSingleLargeTextModel = new SingleLargeTextModel();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_Projects_projectSourceLink_ByUserId";
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
        public SingleDateModel getDateCreatedByUserId(int userid)
        {
            SingleDateModel aSingleDateModel = new SingleDateModel();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_Projects_dateCreated_ByUserId";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("userId", userid);
                    cmd.Connection = aSqlConnection;
                    aSqlConnection.Open();
                    SqlDataReader aSqlDataReader = cmd.ExecuteReader();
                    while (aSqlDataReader.Read())
                    {
                        aSingleDateModel.Id = Convert.ToInt32(aSqlDataReader["id"].ToString());
                        aSingleDateModel.RepositorychildId = Convert.ToInt32(aSqlDataReader["repositorychildId"].ToString());
                        aSingleDateModel.Data =Convert.ToDateTime(aSqlDataReader["data"].ToString());
                        aSingleDateModel.Description = aSqlDataReader["description"].ToString();
                    }
                }
            }
            return aSingleDateModel;
        }
        public SingleLargeTextModel getOneSingleBriefForWholeProjectByUserId(int userid)
        {
            SingleLargeTextModel aSingleLargeTextModel = new SingleLargeTextModel();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_Projects_oneSingleBriefForWholeProject_ByUserId";
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

        public List<ProjectModel> Get_ProjectsDefault_ByUserId(int userid)
        {
            List<ProjectModel> list = new List<ProjectModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_ProjectsDefault_ByUserId";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("userid", userid); 
                    cmd.Connection = aSqlConnection;
                    aSqlConnection.Open();
                    SqlDataReader aSqlDataReader = cmd.ExecuteReader();
                    ProjectModel aProjectModel = new ProjectModel();
                    while (aSqlDataReader.Read())
                    {
                        aProjectModel.id = Convert.ToInt32(aSqlDataReader["id"].ToString());
                        aProjectModel.technologyTypeId = Convert.ToInt32(aSqlDataReader["technologyTypeId"].ToString());
                        aProjectModel.imageId = Convert.ToInt32(aSqlDataReader["imageId"].ToString());
                        aProjectModel.projectNameId = Convert.ToInt32(aSqlDataReader["projectNameId"].ToString());
                        aProjectModel.projectSubNameId = Convert.ToInt32(aSqlDataReader["projectSubNameId"].ToString());
                        aProjectModel.projectBriefId = Convert.ToInt32(aSqlDataReader["projectBriefId"].ToString());
                        aProjectModel.projectKeyPointId = Convert.ToInt32(aSqlDataReader["projectKeyPointId"].ToString());
                        aProjectModel.projectTechnologyBriefId = Convert.ToInt32(aSqlDataReader["projectTechnologyBriefId"].ToString());
                        aProjectModel.dateCreatedId = Convert.ToInt32(aSqlDataReader["dateCreatedId"].ToString());                  
                        aProjectModel.projectTechnologieId = Convert.ToInt32(aSqlDataReader["projectTechnologieId"].ToString());
                        aProjectModel.projectTechnologiesIconId = Convert.ToInt32(aSqlDataReader["projectTechnologiesIconId"].ToString());
                        aProjectModel.projectLiveLinkId = Convert.ToInt32(aSqlDataReader["projectLiveLinkId"].ToString());
                        aProjectModel.projectSourceLinkId = Convert.ToInt32(aSqlDataReader["projectSourceLinkId"].ToString());
                        aProjectModel.dateCreatedId = Convert.ToInt32(aSqlDataReader["dateCreatedId"].ToString());
                        aProjectModel.oneSingleBriefForWholeProjectId = Convert.ToInt32(aSqlDataReader["oneSingleBriefForWholeProjectId"].ToString());                        
                    }
                    list.Add(aProjectModel);
                }
            }
            return list;
        }
        public List<ProjectProfileModel> Get_ProjectImagProfile_ByUserId(List<ProjectModel> projectids, int userid)
        {
            List<ProjectProfileModel> list = new List<ProjectProfileModel>();
            foreach (ProjectModel aProjectModel in projectids)
            {
                ProjectProfileModel aProjectProfileModel = new ProjectProfileModel();
                aProjectProfileModel.id = aProjectModel.id;
                aProjectProfileModel.technologyType = getTechnologyTypeByUserId(userid, aProjectModel.technologyTypeId);
                aProjectProfileModel.images = getImagesByUserId(userid, aProjectModel.imageId);
                aProjectProfileModel.projectName = getProjectNameByUserId(userid, aProjectModel.projectNameId);
                aProjectProfileModel.projectSubName = getProjectSubNameByUserId(userid, aProjectModel.projectSubNameId);
                aProjectProfileModel.projectBrief = getProjectBriefByUserId(userid, aProjectModel.projectBriefId);
                aProjectProfileModel.projectKeyPoints = getProjectKeyPointsByUserId(userid, aProjectModel.projectKeyPointId);
                aProjectProfileModel.projectTechnologyBrief = getProjectTechnologyBriefByUserId(userid, aProjectModel.projectTechnologyBriefId);
                aProjectProfileModel.projectTechnologies = getProjectTechnologiesByUserId(userid, aProjectModel.projectTechnologieId);
                aProjectProfileModel.projectTechnologiesIcons = getProjectTechnologiesIconsByUserId(userid, aProjectModel.projectTechnologiesIconId);
                aProjectProfileModel.projectLiveLink = getProjectLiveLinkByUserId(userid, aProjectModel.projectLiveLinkId);
                aProjectProfileModel.projectSourceLink = getProjectSourceLinkByUserId(userid, aProjectModel.projectSourceLinkId);
                aProjectProfileModel.dateCreated = getDateCreatedByUserId(userid, aProjectModel.dateCreatedId);
                aProjectProfileModel.oneSingleBriefForWholeProject = getOneSingleBriefForWholeProjectByUserId(userid, aProjectModel.oneSingleBriefForWholeProjectId);
                list.Add(aProjectProfileModel);
            }
            return list;
        }
        public int UpdateProjectDefault(ProjectModel projectModel/*int userid, int defaultId*/)
        {
            int rowAffected = 0;
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "update projects_default set technologyTypeId = @technologyTypeId,	" +
                        "imageId = @imageId,	projectNameId = @projectNameId,	projectSubNameId = @projectSubNameId," +
                        "	projectBriefId = @projectBriefId,	projectKeyPointId = @projectKeyPointId," +
                        "	projectTechnologyBriefId = @projectTechnologyBriefId,	projectTechnologieId = @projectTechnologieId,	" +
                        "projectTechnologiesIconId = @projectTechnologiesIconId,	projectLiveLinkId = @projectLiveLinkId," +
                        "	projectSourceLinkId = @projectSourceLinkId,	dateCreatedId = @dateCreatedId,	oneSingleBriefForWholeProjectId = @oneSingleBriefForWholeProjectId, where id = @id";
                    //cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@id", projectModel.id);
                    cmd.Parameters.AddWithValue("@technologyTypeId", projectModel.technologyTypeId);
                    cmd.Parameters.AddWithValue("@imageId", projectModel.imageId);
                    cmd.Parameters.AddWithValue("@projectNameId", projectModel.projectNameId);
                    cmd.Parameters.AddWithValue("@projectSubNameId", projectModel.projectSubNameId);
                    cmd.Parameters.AddWithValue("@projectBriefId", projectModel.projectBriefId);
                    cmd.Parameters.AddWithValue("@projectKeyPointId", projectModel.projectKeyPointId);
                    cmd.Parameters.AddWithValue("@projectTechnologyBriefId", projectModel.projectTechnologyBriefId);
                    cmd.Parameters.AddWithValue("@projectTechnologieId", projectModel.projectTechnologieId);
                    cmd.Parameters.AddWithValue("@projectTechnologiesIconId", projectModel.projectTechnologiesIconId);
                    cmd.Parameters.AddWithValue("@projectLiveLinkId", projectModel.projectLiveLinkId);
                    cmd.Parameters.AddWithValue("@projectSourceLinkId", projectModel.projectSourceLinkId);
                    cmd.Parameters.AddWithValue("@dateCreatedId", projectModel.dateCreatedId);
                    cmd.Parameters.AddWithValue("@oneSingleBriefForWholeProjectId", projectModel.oneSingleBriefForWholeProjectId);

                    //cmd.Parameters.Add("returnBool", SqlDbType.Int);
                    //cmd.Parameters["returnBool"].Direction = ParameterDirection.Output;
                    cmd.Connection = aSqlConnection;
                    try
                    {
                        aSqlConnection.Open();
                        rowAffected = cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        //throw error
                    }
                    /*finally
                    {
                        aSqlConnection.Close();
                    }*/
                }
            }
            return rowAffected;
        }

    }
}