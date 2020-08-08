using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DataAccess.DbGateways
{
    public class ImageGateway
    {
        public List<SmallTextListDataModel> getHomeImageByUserId(int userid, int defaultId)
        {
            List<SmallTextListDataModel> list = new List<SmallTextListDataModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_selfImages_homeImageList";
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
        /**/
        public List<SmallTextListDataModel> getHomeImageByUserId(int userid)
        {
            List<SmallTextListDataModel> list = new List<SmallTextListDataModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_selfImages_homeImageList_ByUserId";
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


        public List<SelfImageModel> Get_SelfImagesDefault_ByUserId(int userid)
        {
            List<SelfImageModel> list = new List<SelfImageModel>();
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "get_SelfImagesDefault_ByUserId";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("userid", userid);
                    cmd.Connection = aSqlConnection;
                    aSqlConnection.Open();
                    SqlDataReader aSqlDataReader = cmd.ExecuteReader();
                    SelfImageModel aSelfImageModel = new SelfImageModel();
                    while (aSqlDataReader.Read())
                    {
                        aSelfImageModel.id = Convert.ToInt32(aSqlDataReader["id"].ToString());
                        aSelfImageModel.homeImageListId = Convert.ToInt32(aSqlDataReader["homeImageListId"].ToString());
                    }
                    list.Add(aSelfImageModel);
                }
            }
            return list;
        }

        public List<SelfImagProfileModel> Get_SelfImagProfile_ByUserId(List<SelfImageModel> selfImagids, int userid)
        {
            List<SelfImagProfileModel> list = new List<SelfImagProfileModel>();
            foreach (SelfImageModel aSelfImageModel in selfImagids)
            {
                SelfImagProfileModel aSelfImagProfileModel = new SelfImagProfileModel();
                aSelfImagProfileModel.id = aSelfImageModel.id;
                aSelfImagProfileModel.homeImageList = getHomeImageByUserId(userid, aSelfImageModel.homeImageListId);
                list.Add(aSelfImagProfileModel);
            }
            return list;
        }

        public int UpdateExperienceDefault(SelfImageModel selfImageModel/*int userid, int defaultId*/)
        {
            int rowAffected = 0;
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "update selfImages_default SET homeImageListId = @homeImageListId where id = @id";
                    //cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@id", selfImageModel.id);
                    cmd.Parameters.AddWithValue("@homeImageListId", selfImageModel.homeImageListId);

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