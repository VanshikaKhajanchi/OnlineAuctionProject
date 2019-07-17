using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace onlineauctionmvc.Models
{
    public class Transaction
    {

        public int transid { get; set; }

        public int selleraccount { get; set; }

        public int buyeraccount { get; set; }

        public int amount { get; set; }

        public DateTime transtime { get; set; }

        private DateTime transdate { get; set; }

        public int itemid { get; set; }

       

    }
}