using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BALLayerLib
{
    class SubCategorybal
    {
        private int subCategoryID;

        public int Subcategoryid
        {
            get { return subCategoryID; }
            set {
                try
                {

                    subCategoryID = value;
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




        private int categoryID;

        public int Cid
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


        private string subCategoryName;

        public string Subcategoryname
        {
            get { return subCategoryName; }
            set
            {
                try
                {

                    subCategoryName = value;

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
