using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DataAccess.DbGateways
{
    public class CommonGateway
    {
        public int UpdateSingleSmallTextModel(SingleSmallTextModel singleSmallTextModel/*int userid, int defaultId*/)
        {
            int returnBool=0;
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "Update_SingleSmallTextModel";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("id", singleSmallTextModel.Id);
                    cmd.Parameters.AddWithValue("repositorychildId", singleSmallTextModel.RepositorychildId);
                    cmd.Parameters.AddWithValue("data", singleSmallTextModel.Data);
                    cmd.Parameters.AddWithValue("description", singleSmallTextModel.Description);

                    cmd.Parameters.Add("returnBool", SqlDbType.Int);
                    cmd.Parameters["returnBool"].Direction = ParameterDirection.Output;

                    cmd.Connection = aSqlConnection;
                    try
                    {
                        aSqlConnection.Open();
                        Object obj=cmd.ExecuteReader();
                        returnBool =Convert.ToInt32(cmd.Parameters["returnBool"].Value);
                    }
                    catch(Exception ex)
                    {
                        //throw error
                    }
                    /*finally
                    {
                        aSqlConnection.Close();
                    }*/
                }
            }
            return returnBool;
        }

        public int UpdateSingleLargeTextModel(SingleLargeTextModel singleLargeTextModel/*int userid, int defaultId*/)
        {
            int returnBool = 0;
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "Update_SingleLargeText_default";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("id", singleLargeTextModel.Id);
                    cmd.Parameters.AddWithValue("repositorychildId", singleLargeTextModel.RepositorychildId);
                    cmd.Parameters.AddWithValue("data", singleLargeTextModel.Data);
                    cmd.Parameters.AddWithValue("description", singleLargeTextModel.Description);

                    cmd.Parameters.Add("returnBool", SqlDbType.Int);
                    cmd.Parameters["returnBool"].Direction = ParameterDirection.Output;

                    cmd.Connection = aSqlConnection;
                    try
                    {
                        aSqlConnection.Open();
                        Object obj = cmd.ExecuteReader();
                        returnBool = Convert.ToInt32(cmd.Parameters["returnBool"].Value);
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
            return returnBool;
        }


        public int UpdateSingleIntegerModel(SingleIntegerModel singleIntegerModel/*int userid, int defaultId*/)
        {
            int returnBool = 0;
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "Update_SingleIntegerDefault";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("id", singleIntegerModel.Id);
                    cmd.Parameters.AddWithValue("repositorychildId", singleIntegerModel.RepositorychildId);
                    cmd.Parameters.AddWithValue("data", singleIntegerModel.Data);
                    cmd.Parameters.AddWithValue("description", singleIntegerModel.Description);

                    cmd.Parameters.Add("returnBool", SqlDbType.Int);
                    cmd.Parameters["returnBool"].Direction = ParameterDirection.Output;

                    cmd.Connection = aSqlConnection;
                    try
                    {
                        aSqlConnection.Open();
                        Object obj = cmd.ExecuteReader();
                        returnBool = Convert.ToInt32(cmd.Parameters["returnBool"].Value);
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
            return returnBool;
        }

        public int UpdateSingleDateModel(SingleDateModel singleDateModel/*int userid, int defaultId*/)
        {
            int returnBool = 0;
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "Update_SingleIntegerDefault";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("id", singleDateModel.Id);
                    cmd.Parameters.AddWithValue("repositorychildId", singleDateModel.RepositorychildId);
                    cmd.Parameters.AddWithValue("data", singleDateModel.Data);
                    cmd.Parameters.AddWithValue("description", singleDateModel.Description);

                    cmd.Parameters.Add("returnBool", SqlDbType.Int);
                    cmd.Parameters["returnBool"].Direction = ParameterDirection.Output;

                    cmd.Connection = aSqlConnection;
                    try
                    {
                        aSqlConnection.Open();
                        Object obj = cmd.ExecuteReader();
                        returnBool = Convert.ToInt32(cmd.Parameters["returnBool"].Value);
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
            return returnBool;
        }
        public int UpdateLargeTextListDataModel(LargeTextListDataModel largeTextListDataModel/*int userid, int defaultId*/)
        {
            int returnBool = 0;
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "Update_LargeTextListData";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("id", largeTextListDataModel.Id);
                    cmd.Parameters.AddWithValue("parentId", largeTextListDataModel.ParentId);
                    cmd.Parameters.AddWithValue("data", largeTextListDataModel.Data);
                    cmd.Parameters.AddWithValue("description", largeTextListDataModel.Description);

                    cmd.Parameters.Add("returnBool", SqlDbType.Int);
                    cmd.Parameters["returnBool"].Direction = ParameterDirection.Output;

                    cmd.Connection = aSqlConnection;
                    try
                    {
                        aSqlConnection.Open();
                        Object obj = cmd.ExecuteReader();
                        returnBool = Convert.ToInt32(cmd.Parameters["returnBool"].Value);
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
            return returnBool;
        }

        public int UpdateSmallTextListDataModel(SmallTextListDataModel  smallTextListDataModel/*int userid, int defaultId*/)
        {
            int returnBool = 0;
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "Update_SmallTextListData";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("id", smallTextListDataModel.Id);
                    cmd.Parameters.AddWithValue("parentId", smallTextListDataModel.ParentId);
                    cmd.Parameters.AddWithValue("data", smallTextListDataModel.Data);
                    cmd.Parameters.AddWithValue("description", smallTextListDataModel.Description);

                    cmd.Parameters.Add("returnBool", SqlDbType.Int);
                    cmd.Parameters["returnBool"].Direction = ParameterDirection.Output;

                    cmd.Connection = aSqlConnection;
                    try
                    {
                        aSqlConnection.Open();
                        Object obj = cmd.ExecuteReader();
                        returnBool = Convert.ToInt32(cmd.Parameters["returnBool"].Value);
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
            return returnBool;
        }

        public int UpdateOnlineLinkDataModel(OnlineLinkDataModel onlineLinkDataModel/*int userid, int defaultId*/)
        {
            int returnBool = 0;
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "Update_OnlineLinkData";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("id", onlineLinkDataModel.Id);
                    cmd.Parameters.AddWithValue("parentId", onlineLinkDataModel.ParentId);
                    cmd.Parameters.AddWithValue("title", onlineLinkDataModel.Title);
                    cmd.Parameters.AddWithValue("link", onlineLinkDataModel.Link);
                    cmd.Parameters.AddWithValue("icon", onlineLinkDataModel.IconLink); 
                    cmd.Parameters.AddWithValue("description", onlineLinkDataModel.Description);

                    cmd.Parameters.Add("returnBool", SqlDbType.Int);
                    cmd.Parameters["returnBool"].Direction = ParameterDirection.Output;

                    cmd.Connection = aSqlConnection;
                    try
                    {
                        aSqlConnection.Open();
                        Object obj = cmd.ExecuteReader();
                        returnBool = Convert.ToInt32(cmd.Parameters["returnBool"].Value);
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
            return returnBool;
        }


        public int DeleteSingleSmallTextModel(int Id/*int userid, int defaultId*/)
        {
            int rowAffected = 0;
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "delete from singleSmallText_default  where id=@defaultId";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@defaultId", Id);
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
        public int DeleteSingleLargeTextModel(int Id/*int userid, int defaultId*/)
        {
            int rowAffected = 0;
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "delete from singleLargeText_default where id=@defaultId";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@defaultId", Id);
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
        public int DeleteSingleIntegerModel(int Id/*int userid, int defaultId*/)
        {
            int rowAffected = 0;
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "delete from singleIntegerDefault where id=@defaultId";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@defaultId", Id);
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
        public int DeleteSingleDateModel(int Id/*int userid, int defaultId*/)
        {
            int rowAffected = 0;
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "delete from singleDateDefault where id=@defaultId";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@defaultId", Id);
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
        public int DeleteLargeTextListDataModel(int Id/*int userid, int defaultId*/)
        {
            int rowAffected = 0;
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "delete From LargeTextListData where id=@defaultId";// and parentId=@parentId";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@defaultId", Id);
                    //cmd.Parameters.AddWithValue("@defaultId", largeTextListDataModel.Id);
                    //cmd.Parameters.AddWithValue("@parentId", largeTextListDataModel.ParentId);
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
        public int DeleteSmallTextListDataModel(int Id/*int userid, int defaultId*/)
        {
            int rowAffected = 0;
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "delete From smalltextListData where id=@defaultId";// and parentId=@parentId";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@defaultId", Id);
                    //cmd.Parameters.AddWithValue("@parentId", smallTextListDataModel.ParentId);
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
        public int DeleteOnlineLinkDataModel(int Id/*int userid, int defaultId*/)
        {
            int rowAffected = 0;
            using (SqlConnection aSqlConnection
                = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "delete From onlineLinkData where id=@defaultId";// and parentId=@parentId";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@defaultId", Id);
                    //cmd.Parameters.AddWithValue("@parentId", onlineLinkDataModel.ParentId);
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