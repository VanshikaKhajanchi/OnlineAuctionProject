using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace onlineauctionmvc.Models
{
    public class Bid
    {

        public int BidID { get; set; }

        public int sellerid { get; set; }

        public int buyerid { get; set; }

        public int itemid { get; set; }

        public int bidprice { get; set; }


    }
}