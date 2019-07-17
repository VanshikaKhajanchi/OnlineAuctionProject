using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BALLayerLib
{
    public class UserBal
    {

        private int userID;


        public int UserID
        {
            get { return userID; }
            set
            {


                try
                {

                    userID = value;
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




        private string userfname;


        public string UserFName
        {
            get { return userfname; }
            set
            {
                try
                {

                    userfname = value;
                    
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



        private string userlname;

        public string UserLName
        {
            get { return userlname; }
            set
            {
                try
                {

                    userlname = value;
                    
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



        private DateTime date;

        public DateTime DOB
        {
            get { return date; }
            set {
                try
                {

                    date = value;

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

        private string email;

        public string Email
        {
            get { return email; }
            set {
                try
                {

                    email = value;
                    
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


        private string password;

        public string Password
        {
            get { return password; }
            set {
                try
                {

                    password = value;
                    
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
    


        private long phone;

        public long Phone
        {
            get { return phone; }
            set {

                try
                {

                    phone = value;
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

        private string address;

        public string Address
        {
            get { return address; }
            set {
                try
                {

                    address = value;
                    
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

        private string city;

        public string City
        {
            get { return city; }
            set {
                try
                { 
                        city = value;
                    
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

        private string country;

        public string Country
        {
            get { return country; }
            set {
                try
                {

                    country = value;
                    
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

        private long zip;

        public long Zip
        {
            get { return zip; }
            set
            {
                try
                {

                    zip = value;
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


        private DateTime D_created;

        public DateTime Date_created
        {
            get { return D_created; }
            set {
                try
                {

                    D_created = value;

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

        private string adharnumber;

        public string AadharNumber
        {
            get { return adharnumber; }
            set { adharnumber = value; }
        }
        private string passportnum;

        public string PassportNumber
        {
            get { return passportnum; }
            set { passportnum = value; }
        }



    }
}
