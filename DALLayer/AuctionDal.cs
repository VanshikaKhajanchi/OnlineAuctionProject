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
   
        public class AuctionDAL
        {
            public bool InsertAuction(AuctionBal auction )
            {
                bool status = false;

                SqlConnection cn = new SqlConnection
                      (ConfigurationManager.ConnectionStrings["onlineauctionstrings"].ConnectionString);
                try
                {

                    SqlCommand cmd = new SqlCommand("sp_InsertAuctionTable", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@AuctionId", auction.AuctionID);
                    cmd.Parameters.AddWithValue("@AuctionDate",auction.AucDate);
                    cmd.Parameters.AddWithValue("@AuctionTime",auction.AucTime);
                    cmd.Parameters.AddWithValue("@AuctionDuration",auction.AucDuration);
                    cmd.Parameters.AddWithValue("@Sellerid",auction.SellerId);
                    

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


        public bool UpdateAuction(AuctionBal auction)
        {
            bool status = false;

            SqlConnection cn = new SqlConnection
                  (ConfigurationManager.ConnectionStrings["onlineauctionstrings"].ConnectionString);
            try
            {

                SqlCommand cmd = new SqlCommand("sp_UpdateAuctionTable", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                //cmd.Parameters.AddWithValue("@AuctionId", auction.AuctionID);
                cmd.Parameters.AddWithValue("@AuctionDate", auction.AucDate);
                cmd.Parameters.AddWithValue("@AuctionTime", auction.AucTime);
                cmd.Parameters.AddWithValue("@AuctionDuration", auction.AucDuration);
                cmd.Parameters.AddWithValue("@Sellerid", auction.SellerId);


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

        public bool DeleteAuction(AuctionBal auction)
        {
            bool status = false;

            SqlConnection cn = new SqlConnection
                  (ConfigurationManager.ConnectionStrings["onlineauctionstrings"].ConnectionString);
            try
            {

                SqlCommand cmd = new SqlCommand("sp_InsertAuctionTable", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@AuctionId", auction.AuctionID);
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
