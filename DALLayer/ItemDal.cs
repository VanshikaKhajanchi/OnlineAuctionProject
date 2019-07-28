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
  public class ItemDal
    {


        public bool InsertItem(ItemBal item)
        {
            bool status = false;

            SqlConnection cn = new SqlConnection
                  (ConfigurationManager.ConnectionStrings["onlineauctionstrings"].ConnectionString);
            try
            {

                SqlCommand cmd = new SqlCommand("sp_InsertItemTable", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                //cmd.Parameters.AddWithValue("@ItemId", item.ItemID);
                cmd.Parameters.AddWithValue("@ItemName", item.ItemName);
                cmd.Parameters.AddWithValue("@CategoryID", item.CategoryID);
                cmd.Parameters.AddWithValue("@ItemDiscription", item.ItemDiscription);
                cmd.Parameters.AddWithValue("@SellerId", item.SellerId);
                cmd.Parameters.AddWithValue("@BuyerID", item.BuyerID);
                cmd.Parameters.AddWithValue("@Price", item.Price);
                cmd.Parameters.AddWithValue("@AuctionID", item.AuctionID);
                cmd.Parameters.AddWithValue("@BidID", item.BidID);



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

        public bool UpdateItem(ItemBal item)
        {
            bool status = false;

            SqlConnection cn = new SqlConnection
                  (ConfigurationManager.ConnectionStrings["onlineauctionstrings"].ConnectionString);
            try
            {

                SqlCommand cmd = new SqlCommand("sp_UpdateItemTable", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                //cmd.Parameters.AddWithValue("@ItemId", item.ItemID);
                cmd.Parameters.AddWithValue("@ItemName", item.ItemName);
                cmd.Parameters.AddWithValue("@CategoryID", item.CategoryID);
                cmd.Parameters.AddWithValue("@ItemDiscription", item.ItemDiscription);
                cmd.Parameters.AddWithValue("@SellerId", item.SellerId);
                cmd.Parameters.AddWithValue("@BuyerID", item.BuyerID);
                cmd.Parameters.AddWithValue("@Price", item.Price);
                cmd.Parameters.AddWithValue("@AuctionID", item.AuctionID);
                cmd.Parameters.AddWithValue("@BidID", item.BidID);



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

        public bool DeleteItem(ItemBal item)
        {
            bool status = false;

            SqlConnection cn = new SqlConnection
                  (ConfigurationManager.ConnectionStrings["onlineauctionstrings"].ConnectionString);
            try
            {

                SqlCommand cmd = new SqlCommand("sp_DeleteItemTable", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ItemId", item.ItemID);

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