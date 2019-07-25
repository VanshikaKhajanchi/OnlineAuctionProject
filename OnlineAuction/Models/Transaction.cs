using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace onlineauctionmvc.Models
{
    public class Transaction
    {

        public int TransID { get; set; }

        public int SellerAccount { get; set; }

        public int BuyerAccount { get; set; }

        public int Amount { get; set; }

        public DateTime Transtime { get; set; }

        private DateTime Transdate { get; set; }

        public int itemid { get; set; }

       

    }
}