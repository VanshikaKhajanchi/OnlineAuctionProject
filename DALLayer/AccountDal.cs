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
    
        public class AccountDAL
        {
            public bool InsertAccount(Accountbal account)
            {
                bool status = false;

                SqlConnection cn = new SqlConnection
                      (ConfigurationManager.ConnectionStrings["onlineauctionstrings"].ConnectionString);
                try
                {

                    SqlCommand cmd = new SqlCommand("sp_InsertUsers", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@AccountNo", account.AccountNo);
                    cmd.Parameters.AddWithValue("@Userid",account.UserID);
                    cmd.Parameters.AddWithValue("@Balance",account.Balance);
                    cmd.Parameters.AddWithValue("@Bank",account.Bank);
                    cmd.Parameters.AddWithValue("@bankAccountno",account.BankAcctNo);
                    
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

        public bool UpdateAccount(Accountbal account)
        {
            bool status = false;

            SqlConnection cn = new SqlConnection
                  (ConfigurationManager.ConnectionStrings["onlineauctionstrings"].ConnectionString);
            try
            {

                SqlCommand cmd = new SqlCommand("sp_UpdateAccountTable", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@AccountNo", account.AccountNo);
                cmd.Parameters.AddWithValue("@Userid", account.UserID);
                cmd.Parameters.AddWithValue("@Balance", account.Balance);
                cmd.Parameters.AddWithValue("@Bank", account.Bank);
                cmd.Parameters.AddWithValue("@bankAccountno", account.BankAcctNo);

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
        public bool DeleteAccount(Accountbal account)
        {
            bool status = false;

            SqlConnection cn = new SqlConnection
                  (ConfigurationManager.ConnectionStrings["onlineauctionstrings"].ConnectionString);
            try
            {

                SqlCommand cmd = new SqlCommand("sp_DeleteAccountTable", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@AccountNo", account.AccountNo);
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








        }
}
