using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineAuction.Models;
using DALLayer;
using BALLayerLib;

namespace OnlineAuction.Controllers
{
    public class AuctionController : Controller
    {
        // GET: Auction
        public ActionResult Index()
        {
            return View();
        }
        //create
        [HttpGet]
        public ActionResult AddAuction()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAuction(Auction auction)
        {
            AuctionBal bal = new AuctionBal();
            AuctionDAL dal = new AuctionDAL();
            bal.AuctionID = auction.AuctionID;
            bal.AucDate = auction.AucDate;
            bal.AucTime = auction.AucTime;
            bal.AucDuration = auction.AucDuration;
            bal.SellerId = auction.SellerId;
            bool status = dal.InsertAuction(bal);
            ViewBag.data = status;
            return View();
        }
        //Update
        [HttpGet]
        public ActionResult UpdateAuction()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UpdateAuction(Auction auction)
        {
            AuctionBal bal = new AuctionBal();
            AuctionDAL dal = new AuctionDAL();
            
            bal.AucDate = auction.AucDate;
            bal.AucTime = auction.AucTime;
            bal.AucDuration = auction.AucDuration;
            bal.SellerId = auction.SellerId;
            bool status = dal.UpdateAuction(bal);
            ViewBag.data = status;
            return View();
        }
        //Delete
        [HttpGet]
        public ActionResult DeleteAuction()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DeleteAuction(Auction auction)
        {
            AuctionBal bal = new AuctionBal();
            AuctionDAL dal = new AuctionDAL();
            bal.AuctionID = auction.AuctionID;
            bool status = dal.DeleteAuction(bal);
            ViewBag.data = status;
            return View();
        }

    }
}