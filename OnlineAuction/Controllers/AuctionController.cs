﻿using System;
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
        public ActionResult ActionName()
        {

            return View();
        }
    }
}