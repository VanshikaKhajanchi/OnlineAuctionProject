using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BALLayerLib
{
    public class Accountbal
    {
        private int accountno;

        public int AccountNo
        {
            get { return accountno; }
            set
            {
                try
                {

                    accountno = value;
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


        private int userid;

        public int UserID
        {
            get { return userid; }
            set
            {
                try
                {

                    userid = value;
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


        private double balance;

        public double Balance
        {
            get { return balance; }
            set
            {
                try
                {

                    balance = value;
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

        private string bank;

        public string Bank
        {
            get { return bank; }
            set
            {
                try
                {

                    bank = value;

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


        private int bankaccountno;

        public int BankAcctNo
        {
            get { return bankaccountno; }
    
            set
            {
                try
                {

                    bankaccountno = value;

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
