using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BALLayerLib
{
    public class TransactionBal
    {

        private int transid;

        public int TransId
        {
            get { return transid; }
            set {
                try
                {

                    transid = value;
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


        private int selleraccount;

        public int SellerAccount
        {
            get { return selleraccount; }
            set {
                try
                {

                    selleraccount  = value;
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


        private int buyeraccount;

        public int BuyerAccount
        {
            get { return buyeraccount; }
            set {
                try
                {

                    buyeraccount = value;
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

        private int amount;

        public int Amount
        {
            get { return amount; }
            set {
                try
                {

                    amount = value;
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

        private DateTime transtime;

        public DateTime TransTime
        {
            get { return transtime; }
            set
            {
                try
                {

                    transtime = value;
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

        private DateTime transdate;

        public DateTime TransDate
        {
            get { return transdate; }
            set
            {
                try
                {

                    transdate = value;
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



    }
}
