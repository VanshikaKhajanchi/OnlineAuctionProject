using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineAuction.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddItem()
        {

            return View();
        }
        public ActionResult AddCategory()
        {

            return View();
        }
        public ActionResult AddSubcategory()
        {

            return View();
        }
        public ActionResult DeleteItem()
        {

            return View();
        }
        public ActionResult DeleteCategory()
        {

            return View();
        }
        public ActionResult DeleteSubcategory()
        {

            return View();
        }

    }
}