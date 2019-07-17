using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BALLayerLib
{
    public class UserBal
    {

        private int UserID;


        public int userid
        {
            get { return UserID; }
            set
            {


                try
                {

                    UserID = value;
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




        private string UserFName;


        public string Fname
        {
            get { return UserFName; }
            set
            {
                try
                {
                   
                        UserFName = value;
                    
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



        private string UserLName;

        public string Lname
        {
            get { return UserLName; }
            set
            {
                try
                {
                
                        UserLName = value;
                    
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

        public DateTime Date
        {
            get { return date; }
            set {
                try
                {

                    Date = value;

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

        private string Email;

        public string email
        {
            get { return Email; }
            set {
                try
                {

                    Email = value;
                    
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


        private string Password;

        public string pass
        {
            get { return Password; }
            set {
                try
                {

                        Password = value;
                    
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
    


        private int Phone;

        public int phone
        {
            get { return Phone; }
            set {

                try
                {

                    Phone = value;
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

        private string Address;

        public string address
        {
            get { return Address; }
            set {
                try
                {

                        Address = value;
                    
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

        private string City;

        public string city
        {
            get { return City; }
            set {
                try
                { 
                        City = value;
                    
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

        private string Country;

        public string country
        {
            get { return Country; }
            set {
                try
                { 
           
                        Country = value;
                    
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

        private int Zip;

        public int zip
        {
            get { return Zip; }
            set
            {
                try
                {

                    Zip = value;
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


        private DateTime Date_created;

        public DateTime D_created
        {
            get { return Date_created; }
            set {
                try
                {

                    Date_created = value;

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
