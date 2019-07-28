using BALLayerLib;
using DALLayer;
using onlineauctionmvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineAuction.Models;

namespace OnlineAuction.Views.Home
{
    public class BidController : Controller
    {
        // GET: Bid
        public ActionResult Index()
        {
            return View();
        }
        //create
        [HttpGet]
        public ActionResult AddBid()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddBid(Bid bid)
        {
            Bidbal bal = new Bidbal();
            BidDal dal = new BidDal();
            bal.BidID = bid.BidID;
            bal.SellerID = bid.SellerId;
            bal.BuyerID = bid.BuyerID;
            bal.ItemID = bid.ItemID;
            bal.BidPrice = bid.BidPrice;
            bool status = dal.InsertBid(bal);
            ViewBag.data = status;
            return View();
        }

        //Update
        [HttpGet]
        public ActionResult UpdateBid()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UpdateBid(Bid bid)
        {
            Bidbal bal = new Bidbal();
            BidDal dal = new BidDal();
           
            bal.SellerID = bid.SellerId;
            bal.BuyerID = bid.BuyerID;
            bal.ItemID = bid.ItemID;
            bal.BidPrice = bid.BidPrice;
            bool status = dal.UpdateBid(bal);
            ViewBag.data = status;
            return View();
        }
        //Delete
        [HttpGet]
        public ActionResult DeleteBid()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DeleteBid(Bid bid)
        {
            Bidbal bal = new Bidbal();
            BidDal dal = new BidDal();
            bal.BidID = bid.BidID;
            bool status = dal.DeleteBid(bal);
            ViewBag.data = status;
            return View();
        }
    }
}