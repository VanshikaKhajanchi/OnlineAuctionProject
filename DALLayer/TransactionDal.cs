using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BALLayerLib;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DALLayer
{
    public class TransactionDal
    {



        public bool InsertTransaction(TransactionBal transaction)
        {
            bool status = false;

            SqlConnection cn = new SqlConnection
                  (ConfigurationManager.ConnectionStrings["onlineauctionstrings"].ConnectionString);
            try
            {

                SqlCommand cmd = new SqlCommand("sp_InsertTransactionTable", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@TransId", transaction.TransId);
                cmd.Parameters.AddWithValue("@SellerAccount", transaction.SellerAccount);
                cmd.Parameters.AddWithValue("@BuyerAccount", transaction.BuyerAccount);
                cmd.Parameters.AddWithValue("@Amount", transaction.Amount);
                cmd.Parameters.AddWithValue("@TransTime", transaction.TransTime);
                cmd.Parameters.AddWithValue("@TransDate", transaction.TransDate);
                cmd.Parameters.AddWithValue("@ItemID", transaction.ItemID);

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



        public bool UpdateTransaction(TransactionBal transaction)
        {
            bool status = false;

            SqlConnection cn = new SqlConnection
                  (ConfigurationManager.ConnectionStrings["onlineauctionstrings"].ConnectionString);
            try
            {

                SqlCommand cmd = new SqlCommand("sp_UpdateTransactionTable", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                //cmd.Parameters.AddWithValue("@TransId", transaction.TransId);
                cmd.Parameters.AddWithValue("@SellerAccount", transaction.SellerAccount);
                cmd.Parameters.AddWithValue("@BuyerAccount", transaction.BuyerAccount);
                cmd.Parameters.AddWithValue("@Amount", transaction.Amount);
                cmd.Parameters.AddWithValue("@TransTime", transaction.TransTime);
                cmd.Parameters.AddWithValue("@TransDate", transaction.TransDate);
                cmd.Parameters.AddWithValue("@ItemID", transaction.ItemID);

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



        public bool DeleteTransaction(TransactionBal transaction)
        {
            bool status = false;

            SqlConnection cn = new SqlConnection
                  (ConfigurationManager.ConnectionStrings["onlineauctionstrings"].ConnectionString);
            try
            {

                SqlCommand cmd = new SqlCommand("sp_DeleteTransactionTable", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@TransId", transaction.TransId);
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
