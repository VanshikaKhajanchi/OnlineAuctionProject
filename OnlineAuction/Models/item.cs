using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace onlineauctionmvc.Models
{
    public class item
    {

        public int itemid { get; set; }

        public string itemname { get; set; }

        public int categoryid { get; set; }

        public string discription { get; set; }

        public int sellerid { get; set; }

        public int buyerid { get; set; }

        public int price { get; set; }

        public int auctionid { get; set; }

        public int bidid { get; set; }



    }


}