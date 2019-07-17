using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BALLayerLib
{
    class AuctionBal
    {

        private int AuctionID;

        public int auctionid
        {
            get { return AuctionID; }
            set {
                try
                {

                    AuctionID = value;
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

        private DateTime AucDate;

        public DateTime aucdate
        {
            get { return AucDate; }
            set {
                try
                {

                    AucDate = value;
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

        private DateTime AucTime;

        public DateTime auctime
        {
            get { return AucTime; }
            set {
                try
                {

                    AucTime = value;
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

        private decimal AucDuration;

        public decimal aucduration
        {
            get { return AucDuration; }
            set {
                try
                {

                    AucDuration = value;
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

        private int SellerId;

        public int sellerid
        {
            get { return SellerId; }
            set {
                try
                {

                    SellerId= value;
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
