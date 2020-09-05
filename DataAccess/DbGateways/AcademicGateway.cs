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

        public SingleSmallTextModel getInstitutionNameByUserId(int userid, int defaultId)
        {
            SingleSmallTextModel aSingleSmallTextModel = new SingleSmallTextModel();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_academics_institutionName";
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
        public SingleSmallTextModel getLocationByUserId(int userid, int defaultId)
        {
            SingleSmallTextModel aSingleSmallTextModel = new SingleSmallTextModel();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_academics_location";
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
        public SingleSmallTextModel getCourseNameByUserId(int userid, int defaultId)
        {
            SingleSmallTextModel aSingleSmallTextModel = new SingleSmallTextModel();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_academics_courseName";
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
        public SingleSmallTextModel getCgpaByUserId(int userid, int defaultId)
        {
            SingleSmallTextModel aSingleSmallTextModel = new SingleSmallTextModel();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_academics_cgpa";
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
        public SingleDateModel getStartByUserId(int userid, int defaultId)
        {
            SingleDateModel aSingleDateModel = new SingleDateModel();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_academics_start";
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
                        aSingleDateModel.Data = /*Convert.ToDateTime(*/aSqlDataReader["data"].ToString()/*)*/;
                        aSingleDateModel.Description = aSqlDataReader["description"].ToString();
                    }
 
                }
            }
            return aSingleDateModel;
        }
        public SingleDateModel getEndByUserId(int userid, int defaultId)
        {
            SingleDateModel aSingleDateModel = new SingleDateModel();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_academics_end";
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
                        aSingleDateModel.Data = /*Convert.ToDateTime(*/aSqlDataReader["data"].ToString()/*)*/;
                        aSingleDateModel.Description = aSqlDataReader["description"].ToString();
                    }
                }
            }
            return aSingleDateModel;
        }
        public List<LargeTextListDataModel> getBriefPointByUserId(int userid, int defaultId)
        {
            List<LargeTextListDataModel> list = new List<LargeTextListDataModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_academics_brief";
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

        /**/
        public  SingleSmallTextModel  getInstitutionNameByUserId(int userid)
        {
             SingleSmallTextModel aSingleSmallTextModel = new SingleSmallTextModel();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_academics_institutionName_ByUserId";
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
        public SingleSmallTextModel getLocationByUserId(int userid)
        {
            SingleSmallTextModel aSingleSmallTextModel = new SingleSmallTextModel();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_academics_location_ByUserId";
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
        public SingleSmallTextModel getCourseNameByUserId(int userid)
        {

            SingleSmallTextModel aSingleSmallTextModel = new SingleSmallTextModel();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_academics_courseName_ByUserId";
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
        public SingleSmallTextModel getCgpaByUserId(int userid)
        {
            SingleSmallTextModel aSingleSmallTextModel = new SingleSmallTextModel();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_academics_cgpa_ByUserId";
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
        public SingleDateModel getStartByUserId(int userid)
        {
            SingleDateModel aSingleDateModel = new SingleDateModel();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_academics_start_ByUserId";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("userId", userid);
                    cmd.Connection = aSqlConnection;
                    aSqlConnection.Open();
                    SqlDataReader aSqlDataReader = cmd.ExecuteReader();
                    
                    while (aSqlDataReader.Read())
                    {
                        aSingleDateModel.Id = Convert.ToInt32(aSqlDataReader["id"].ToString());
                        aSingleDateModel.RepositorychildId = Convert.ToInt32(aSqlDataReader["repositorychildId"].ToString());
                        aSingleDateModel.Data = /*Convert.ToDateTime(*/aSqlDataReader["data"].ToString()/*)*/;
                        aSingleDateModel.Description = aSqlDataReader["description"].ToString();
                    }
 
                }
            }
            return aSingleDateModel;
        }
        public SingleDateModel getEndByUserId(int userid)
        {
            SingleDateModel aSingleDateModel = new SingleDateModel();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_academics_end_ByUserId";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("userId", userid);
                    cmd.Connection = aSqlConnection;
                    aSqlConnection.Open();
                    SqlDataReader aSqlDataReader = cmd.ExecuteReader();

                    while (aSqlDataReader.Read())
                    {
                        aSingleDateModel.Id = Convert.ToInt32(aSqlDataReader["id"].ToString());
                        aSingleDateModel.RepositorychildId = Convert.ToInt32(aSqlDataReader["repositorychildId"].ToString());
                        aSingleDateModel.Data = /*Convert.ToDateTime(*/aSqlDataReader["data"].ToString()/*)*/;
                        aSingleDateModel.Description = aSqlDataReader["description"].ToString();
                    }
                    
                }
            }
            return aSingleDateModel
                ;
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

        public List<AcademicModel> Get_AcademicsDefault_ByUserId(int userid)
        {
            List<AcademicModel> list = new List<AcademicModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_AcademicsDefault_ByUserId";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("userid", userid);
                    cmd.Connection = aSqlConnection;
                    aSqlConnection.Open();
                    SqlDataReader aSqlDataReader = cmd.ExecuteReader();
                    AcademicModel aAcademicModel = new AcademicModel();
                    while (aSqlDataReader.Read())
                    {
                        aAcademicModel.id = Convert.ToInt32(aSqlDataReader["id"].ToString());
                        aAcademicModel.institutionNameId = Convert.ToInt32(aSqlDataReader["institutionNameId"].ToString());
                        aAcademicModel.locationId = Convert.ToInt32(aSqlDataReader["locationId"].ToString());
                        aAcademicModel.courseNameId = Convert.ToInt32(aSqlDataReader["courseNameId"].ToString());
                        aAcademicModel.cgpaId = Convert.ToInt32(aSqlDataReader["cgpaId"].ToString());
                        aAcademicModel.startId = Convert.ToInt32(aSqlDataReader["startId"].ToString());
                        aAcademicModel.endId = Convert.ToInt32(aSqlDataReader["endId"].ToString());
                        aAcademicModel.briefId = Convert.ToInt32(aSqlDataReader["briefId"].ToString());
                    }
                    list.Add(aAcademicModel);
                }
            }
            return list;
        }


        public List<AcademicProfileModel> Get_AcademicProfile_ByUserId(List<AcademicModel> academicids, int userid)
        {
            List<AcademicProfileModel> list = new List<AcademicProfileModel>();
            foreach (AcademicModel aAcademicModel in academicids)
            {
                AcademicProfileModel aAcademicProfileModel = new AcademicProfileModel();
                aAcademicProfileModel.id = aAcademicModel.id;
                aAcademicProfileModel.institutionName = getInstitutionNameByUserId(userid, aAcademicModel.institutionNameId);
                aAcademicProfileModel.location= getLocationByUserId(userid, aAcademicModel.locationId);
                aAcademicProfileModel.courseName= getCourseNameByUserId(userid, aAcademicModel.courseNameId);
                aAcademicProfileModel.cgpa= getCgpaByUserId(userid, aAcademicModel.cgpaId);
                aAcademicProfileModel.start= getStartByUserId(userid, aAcademicModel.startId);
                aAcademicProfileModel.end= getEndByUserId(userid, aAcademicModel.endId);
                aAcademicProfileModel.briefPoint= getBriefPointByUserId(userid, aAcademicModel.briefId);
                list.Add(aAcademicProfileModel);
            }
            return list;
        }

        public int UpdateAcademicDefault(AcademicModel academicModel/*int userid, int defaultId*/)
        {
            int rowAffected = 0;
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "update academics_default set institutionNameId=@institutionNameId,locationId=@locationId,courseNameId=@courseNameId,cgpaId=@cgpaId,startId=@startId,endId=@endId,briefId=@briefId where id=@id";
                    //cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@id", academicModel.id);
                    cmd.Parameters.AddWithValue("@institutionNameId", academicModel.institutionNameId);
                    cmd.Parameters.AddWithValue("@locationId", academicModel.locationId);
                    cmd.Parameters.AddWithValue("@courseNameId", academicModel.courseNameId);
                    cmd.Parameters.AddWithValue("@cgpaId", academicModel.cgpaId);
                    cmd.Parameters.AddWithValue("@startId", academicModel.startId);
                    cmd.Parameters.AddWithValue("@endId", academicModel.endId);
                    cmd.Parameters.AddWithValue("@briefId", academicModel.briefId);

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