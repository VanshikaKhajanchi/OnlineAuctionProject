using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BALLayerLib
{
    class CategoryBal
    {

        private int categoryID;

        public int CategoryID
        {
            get { return categoryID; }
            set {
                try
                {

                    categoryID = value;
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


        private string categoryname;

        public string CategoryName
        {
            get { return categoryname; }
            set
            {
                try
                {

                    categoryname = value;

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
