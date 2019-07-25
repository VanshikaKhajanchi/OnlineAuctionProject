using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace onlineauctionmvc.Models
{
    public class SubCategory
    {

        public int SubcategoryID { get; set; }

        public int CategoryID { get; set; }

        public string  SubCategoryName { get; set; }
    }
}