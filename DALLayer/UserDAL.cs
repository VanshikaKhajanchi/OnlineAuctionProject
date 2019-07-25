using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BALLayerLib;
using System.Configuration;
using System.Data;


namespace DALLayer
{
    public class UserDAL
    {
        public bool InsertUser(UserBal user)
        {
            bool status = false;

            SqlConnection cn = new SqlConnection
                  (ConfigurationManager.ConnectionStrings["onlineauctionstrings"].ConnectionString);
            try
            {

                SqlCommand cmd = new SqlCommand("sp_InsertUsers", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UserFName", user.UserFName);
                cmd.Parameters.AddWithValue("@UserLName", user.UserLName);
                cmd.Parameters.AddWithValue("@DOB", user.DOB);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@Phone", user.Phone);
                cmd.Parameters.AddWithValue("@Address", user.Address);
                cmd.Parameters.AddWithValue("@City", user.City);
                cmd.Parameters.AddWithValue("@Country", user.Country);
                cmd.Parameters.AddWithValue("@Zip", user.Zip);
                //cmd.Parameters.AddWithValue("@Date_created", user.Date_created);
                cmd.Parameters.AddWithValue("@AadharNumber", user.AadharNumber);
                cmd.Parameters.AddWithValue("@PassportNumber", user.PassportNumber);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i < 0)
                {
                    status = true;
                }




            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);


            }
            finally
            {
                cn.Close();
            }
            return status;
        }


        public bool UpdateUser(UserBal user)
        {
            bool status = false;

            SqlConnection cn = new SqlConnection
                  (ConfigurationManager.ConnectionStrings["onlineauctionstrings"].ConnectionString);
            try
            {

                SqlCommand cmd = new SqlCommand("sp_UpdateUsers", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UserFName", user.UserFName);
                cmd.Parameters.AddWithValue("@UserLName", user.UserLName);
                cmd.Parameters.AddWithValue("@DOB", user.DOB);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@Phone", user.Phone);
                cmd.Parameters.AddWithValue("@Address", user.Address);
                cmd.Parameters.AddWithValue("@City", user.City);
                cmd.Parameters.AddWithValue("@Country", user.Country);
                cmd.Parameters.AddWithValue("@Zip", user.Zip);
                cmd.Parameters.AddWithValue("@Date_created", user.Date_created);
                cmd.Parameters.AddWithValue("@AadharNumber", user.AadharNumber);
                cmd.Parameters.AddWithValue("@PassportNumber", user.PassportNumber);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i < 0)
                {
                    status = true;
                }




            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);


            }
            finally
            {
                cn.Close();
            }
            return status;
        }



        public bool DeleteUser(UserBal user)
        {
            bool status = false;

            SqlConnection cn = new SqlConnection
                  (ConfigurationManager.ConnectionStrings["onlineauctionstrings"].ConnectionString);
            try
            {

                SqlCommand cmd = new SqlCommand("sp_UpdateUsers", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UserID", user.UserID);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i < 0)
                {
                    status = true;
                }




            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);


            }
            finally
            {
                cn.Close();
            }
            return status;
        }

        public bool ValidateUser(UserBal user)
        {
            bool status = false;
            SqlConnection cn = new SqlConnection
                (ConfigurationManager.ConnectionStrings["onlineauctionstrings"].ConnectionString);
            try
            {
                SqlCommand cmd = new SqlCommand("sp_ValidateUser", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cn.Open();  

                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                if (dt.Rows.Count>0)
                {
                    status = true;
                }
                //if (dr.HasRows)
                //{
                //    status = true;
                //}
            
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
            return status; 
        }

    }
}
    
