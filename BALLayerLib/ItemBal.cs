using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BALLayerLib
{
   public class ItemBal
    {

        private int itemid;

        public int ItemID
        {
            get { return itemid; }
            set {
                try
                {

                    itemid = value;
                }

                catch (ArgumentNullException)
                {
                    throw new ArgumentNullException("null or empty not allowed");
                }

                catch (FormatException)
                {
                    throw new FormatException("not correct format");

                }
                catch (Exception)
                {
                    throw new Exception("An Exception occured");
                }
            }
        }


        private string itemname;

        public string ItemName
        {
            get { return itemname; }
            set {

                try
                {
                        itemname = value;
                    
                }
                catch (ArgumentNullException)
                {

                    throw new ArgumentNullException("null or empty not allowed");
                }
                catch (FormatException)
                {
                    throw new FormatException("not correct format");

                }
                catch (Exception)
                {
                    throw new Exception("An Exception occured");
                }

            }
        }


        private int categoryid;

        public int CategoryID
        {
            get { return categoryid; }
            set
            {
                try
                {

                    categoryid = value;
                }

                catch (ArgumentNullException)
                {
                    throw new ArgumentNullException("null or empty not allowed");
                }

                catch (FormatException)
                {
                    throw new FormatException("not correct format");

                }
                catch (Exception)
                {
                    throw new Exception("An Exception occured");
                }
            }
        }


        private string discription;

        public string ItemDiscription
        {
            get { return discription; }
            set {
                try
                {
             
                        discription = value;
                    
                }
                catch (ArgumentNullException)
                {

                    throw new ArgumentNullException("null or empty not allowed");
                }
                catch (FormatException)
                {
                    throw new FormatException("not correct format");

                }
                catch (Exception)
                {
                    throw new Exception("An Exception occured");
                }
            }
        }


        private int sellerid;

        public int SellerId
        {
            get { return sellerid; }
            set {
                try
                {

                    sellerid = value;
                }

                catch (ArgumentNullException)
                {
                    throw new ArgumentNullException("null or empty not allowed");
                }

                catch (FormatException)
                {
                    throw new FormatException("not correct format");

                }
                catch (Exception)
                {
                    throw new Exception("An Exception occured");
                }
            }
        }

        private int buyerid;

        public int BuyerID
        {
            get { return buyerid; }
            set {
                try
                {

                    buyerid = value;
                }

                catch (ArgumentNullException)
                {
                    throw new ArgumentNullException("null or empty not allowed");
                }

                catch (FormatException)
                {
                    throw new FormatException("not correct format");

                }
                catch (Exception)
                {
                    throw new Exception("An Exception occured");
                }
            }
        }

        private int price;

        public int Price
        {
            get { return price; }
            set {
                try
                {

                    price= value;
                }

                catch (ArgumentNullException)
                {
                    throw new ArgumentNullException("null or empty not allowed");
                }

                catch (FormatException)
                {
                    throw new FormatException("not correct format");

                }
                catch (Exception)
                {
                    throw new Exception("An Exception occured");
                }
            }
        }

        private int auctionid;

        public int AuctionID
        {
            get { return auctionid; }
            set {
                try
                {

                    auctionid = value;
                }

                catch (ArgumentNullException)
                {
                    throw new ArgumentNullException("null or empty not allowed");
                }

                catch (FormatException)
                {
                    throw new FormatException("not correct format");

                }
                catch (Exception)
                {
                    throw new Exception("An Exception occured");
                }
            }
        }


        private int bidid;

        public int BidID
        {
            get { return bidid; }
            set {
                try
                {

                    bidid = value;
                }

                catch (ArgumentNullException)
                {
                    throw new ArgumentNullException("null or empty not allowed");
                }

                catch (FormatException)
                {
                    throw new FormatException("not correct format");

                }
                catch (Exception)
                {
                    throw new Exception("An Exception occured");
                }
            }
        }


    }
}
