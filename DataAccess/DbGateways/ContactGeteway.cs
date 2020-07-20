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
        public List<SingleSmallTextModel> getNameByUserId(int userid)
        {
            List<SingleSmallTextModel> list = new List<SingleSmallTextModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_Contacts_name_ByUserId";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("userid", userid);
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
        public List<SingleSmallTextModel> getEmailByUserId(int userid)
        {
            List<SingleSmallTextModel> list = new List<SingleSmallTextModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_Contacts_email_ByUserId";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("userid", userid);
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

        public List<SingleLargeTextModel> getMessageByUserId(int userid)
        {
            List<SingleLargeTextModel> list = new List<SingleLargeTextModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_Contacts_message_ByUserId";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("userid", userid);
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

        public List<ContactModel> Get_CareerAdjectiveDefault_ByUserId(int userid)
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
    }
}