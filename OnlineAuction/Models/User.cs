using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineAuction.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserFName { get; set; }
        public string UserLName { get; set; }
        public DateTime DOB { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public long phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public long Zip { get; set; }
        public DateTime DateCreated { get; set; }
        public string AadharNumber { get; set; }
        public byte[] AadharImage { get; set; }
        public string PassportNumber { get; set; }
        public byte[] PassportImage { get; set; }

    }
}