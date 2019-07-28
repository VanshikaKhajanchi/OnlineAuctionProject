using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace onlineauctionmvc.Models
{
    public class Bid
    {

        public int BidID { get; set; }
        public int SellerId { get; set; }
        public int BuyerID { get; set; }
        public int ItemID { get; set; }
        public int BidPrice { get; set; }
    }
}