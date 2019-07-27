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
    public class BidDal
    {
        public bool InsertBid(Bidbal bid)
        {
            bool status = false;

            SqlConnection cn = new SqlConnection
                  (ConfigurationManager.ConnectionStrings["onlineauctionstrings"].ConnectionString);
            try
            {

                SqlCommand cmd = new SqlCommand("sp_InsertBidTable", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@BidID", bid.BidID);
                cmd.Parameters.AddWithValue("@SellerID", bid.SellerID);
                cmd.Parameters.AddWithValue("@BuyerID", bid.BuyerID);
                cmd.Parameters.AddWithValue("@ItemID", bid.ItemID);
                cmd.Parameters.AddWithValue("@BidPrice", bid.BidPrice);
                
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

        public bool UpdateBid(Bidbal bid)
        {
            bool status = false;

            SqlConnection cn = new SqlConnection
                  (ConfigurationManager.ConnectionStrings["onlineauctionstrings"].ConnectionString);
            try
            {

                SqlCommand cmd = new SqlCommand("sp_UpdateBidTable", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@BidID", bid.BidID);
                cmd.Parameters.AddWithValue("@SellerID", bid.SellerID);
                cmd.Parameters.AddWithValue("@BuyerID", bid.BuyerID);
                cmd.Parameters.AddWithValue("@ItemID", bid.ItemID);
                cmd.Parameters.AddWithValue("@BidPrice", bid.BidPrice);

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

        public bool DeleteBid(Bidbal bid)
        {
            bool status = false;

            SqlConnection cn = new SqlConnection
                  (ConfigurationManager.ConnectionStrings["onlineauctionstrings"].ConnectionString);
            try
            {

                SqlCommand cmd = new SqlCommand("sp_DeleteBidTable", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@BidID", bid.BidID);
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
