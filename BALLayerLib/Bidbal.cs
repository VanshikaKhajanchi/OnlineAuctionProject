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

        public int Bid
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


        private int sellerID;

        public int Sellerid
        {
            get { return sellerID; }
            set {
                try
                {

                    sellerID = value;
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

        private int buyerID;

        public int Buyerid
        {
            get { return buyerID; }
            set {
                try
                {

                    buyerID = value;
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

        private int itemID;

        public int Itemid
        {
            get { return itemID; }
            set {
                try
                {

                    itemID = value;
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

        public int Bidprice
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
