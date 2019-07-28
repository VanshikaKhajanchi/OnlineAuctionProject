using onlineauctionmvc.Models;
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
    public class ItemController : Controller
    {
        // GET: Item
        public ActionResult Index()
        {
            return View();
        }
        //create
        [HttpGet]
        public ActionResult AddItem()
        {
              return View();
        }
        [HttpPost]
        public ActionResult AddItem(Item item )
        {
            ItemBal bal = new ItemBal();
            ItemDal dal = new ItemDal();
            bal.ItemID = item.ItemID;
            bal.ItemName = item.ItemName;
            bal.CategoryID = item.CategoryID;
            bal.ItemDiscription = item.Description;
            bal.SellerId = item.SellerID;
            bal.BuyerID = item.BuyerID;
            bal.Price = item.Price;
            bal.AuctionID = item.AuctionID;
            bal.BidID = item.BidID;
            bool status = dal.InsertItem(bal);
            ViewBag.data = status;
            return View();                    
        }
        //update
        [HttpGet]
        public ActionResult UpdateItem()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UpdateItem(Item item)
        {
            ItemBal bal = new ItemBal();
            ItemDal dal = new ItemDal();
            bal.ItemName = item.ItemName;
            bal.CategoryID = item.CategoryID;
            bal.ItemDiscription = item.Description;
            bal.SellerId = item.SellerID;
            bal.BuyerID = item.BuyerID;
            bal.Price = item.Price;
            bal.AuctionID = item.AuctionID;
            bal.BidID = item.BidID;
            bool status = dal.UpdateItem(bal);
            ViewBag.data = status;
            return View();
        }
        //delete
        [HttpGet]
        public ActionResult DeleteItem()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DeleteItem(Item item)
        {
            ItemBal bal = new ItemBal();
            ItemDal dal = new ItemDal();
            bal.ItemID = item.ItemID;
            bool status = dal.DeleteItem(bal);
            ViewBag.data = status;
            return View();
        }
    }
}