using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace onlineauctionmvc.Models
{
    public class Item
    {

        public int ItemID { get; set; }

        public string ItemName { get; set; }

        public int CategoryID { get; set; }

        public string Description { get; set; }

        public int SellerID { get; set; }

        public int BuyerID { get; set; }

        public int Price { get; set; }

        public int AuctionID { get; set; }

        public int BidID { get; set; }



    }


}