using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BALLayerLib
{
    class CategoryBal
    {

        private int CategoryID;

        public int cid
        {
            get { return CategoryID; }
            set {
                try
                {

                    CategoryID = value;
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


        private string CategoryName;

        public string categoryname
        {
            get { return CategoryName; }
            set
            {
                try
                {

                    CategoryName = value;

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
