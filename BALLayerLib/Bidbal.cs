using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BALLayerLib
{
    public class Bidbal
    {
        private int bidID;

        public int BidID
        {
            get { return bidID; }
            set {
                try
                {
                    bidID = value;
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

        public int SellerID
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


        private int bidPrice;

        public int BidPrice
        {
            get { return bidPrice; }
            set {
                try
                {

                    bidPrice = value;
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
