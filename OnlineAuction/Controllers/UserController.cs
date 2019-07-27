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
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SignupUser()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult SignupUser(User user)
        {
            UserBal bal = new UserBal();
            UserDAL dAL = new UserDAL();
            bal.UserID = user.UserId;
            bal.UserFName = user.UserFName;
            bal.UserLName = user.UserLName;
            bal.DOB = user.DOB;
            bal.Email = user.Email;
            bal.Password = user.Password;
            bal.Phone = user.phone;
            bal.Address = user.Address;
            bal.City = user.City;
            bal.Country = user.Country;
            bal.Zip = user.Zip; 
            bal.AadharNumber = user.AadharNumber;
            bal.PassportNumber = user.PassportNumber;
            bool status=dAL.InsertUser(bal);
            ViewBag.data = status;
            return View();
        }
        public ActionResult Signup()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Signup(User user)
        {
            UserBal bal = new UserBal();
            UserDAL dAL = new UserDAL();
            bal.UserID = user.UserId;
            bal.UserFName = user.UserFName;
            bal.UserLName = user.UserLName;
            bal.DOB = user.DOB;
            bal.Email = user.Email;
            bal.Password = user.Password;
            bal.Phone = user.phone;
            bal.Address = user.Address;
            bal.City = user.City;
            bal.Country = user.Country;
            bal.Zip = user.Zip;
            bal.AadharNumber = user.AadharNumber;
            bal.PassportNumber = user.PassportNumber;
            bool status = dAL.InsertUser(bal);
            ViewBag.data = status;
            return View();
        }


        public ActionResult LoginUser()
        {

            return View();
        }
        [HttpPost]
        public ActionResult LoginUser(User user)
        {
            UserBal bal = new UserBal();
            UserDAL dAL = new UserDAL();
            bal.Email = user.Email;
            bal.Password = user.Password;
            bool status = dAL.ValidateUser(bal);
            ViewBag.data = status;
            if (status == true)
            { return RedirectToAction("UserProfile", "User"); }
            else {
                return View();
            }
        }
       
        public ActionResult Login()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Login(User user)
        {

            return View();
        }

        public ActionResult UserProfile()
        {

            return View();
        }
    }
}