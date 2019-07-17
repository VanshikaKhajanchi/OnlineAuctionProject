using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineAuction.Models
{
    public class Auction
    {
        public int AuctionID { get; set; }
        public DateTime AucDate { get; set; }
        public DateTime AucTime { get; set; }
        public decimal AucDuration { get; set; }
        public int SellerId{ get; set; }
     
    }
}