using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DataAccess.DbGateways
{
    public class ContactGeteway
    {
        public SingleSmallTextModel getNameByUserId(int userid, int defaultId)
        {
            SingleSmallTextModel aSingleSmallTextModel = new SingleSmallTextModel();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_Contacts_name";
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
        public SingleSmallTextModel getEmailByUserId(int userid, int defaultId)
        {
            SingleSmallTextModel aSingleSmallTextModel = new SingleSmallTextModel();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_Contacts_email";
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
        public SingleLargeTextModel getMessageByUserId(int userid, int defaultId)
        {
            SingleLargeTextModel aSingleLargeTextModel = new SingleLargeTextModel();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_Contacts_message";
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
        public SingleSmallTextModel getNameByUserId(int userid)
        {
            SingleSmallTextModel aSingleSmallTextModel = new SingleSmallTextModel();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_Contacts_name_ByUserId";
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
        public SingleSmallTextModel getEmailByUserId(int userid)
        {
            SingleSmallTextModel aSingleSmallTextModel = new SingleSmallTextModel();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_Contacts_email_ByUserId";
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
        public SingleLargeTextModel getMessageByUserId(int userid)
        {
            SingleLargeTextModel aSingleLargeTextModel = new SingleLargeTextModel();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_Contacts_message_ByUserId";
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

        public List<ContactModel> Get_ContactDefault_ByUserId(int userid)
        {
            List<ContactModel> list = new List<ContactModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_ContactsDefault_ByUserId";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("userid", userid);
                    cmd.Connection = aSqlConnection;
                    aSqlConnection.Open();
                    SqlDataReader aSqlDataReader = cmd.ExecuteReader();
                    ContactModel aContactModel = new ContactModel();
                    while (aSqlDataReader.Read())
                    {
                        aContactModel.id = Convert.ToInt32(aSqlDataReader["id"].ToString());
                        aContactModel.nameId = Convert.ToInt32(aSqlDataReader["nameId"].ToString());
                        aContactModel.emailId = Convert.ToInt32(aSqlDataReader["emailId"].ToString());
                        aContactModel.messageId = Convert.ToInt32(aSqlDataReader["messageId"].ToString());                        
                    }
                    list.Add(aContactModel);
                }
            }
            return list;
        }

        public List<ContactProfileModel> Get_ContactProfile_ByUserId(List<ContactModel> contactids, int userid)
        {
            List<ContactProfileModel> list = new List<ContactProfileModel>();
            foreach (ContactModel aContactModel in contactids)
            {
                ContactProfileModel aContactProfileModel = new ContactProfileModel();
                aContactProfileModel.id = aContactProfileModel.id;
                aContactProfileModel.name = getNameByUserId(userid, aContactModel.nameId);
                aContactProfileModel.email = getEmailByUserId(userid, aContactModel.emailId);
                aContactProfileModel.message = getMessageByUserId(userid, aContactModel.messageId);
                list.Add(aContactProfileModel);
            }
            return list;
        }
    }
}