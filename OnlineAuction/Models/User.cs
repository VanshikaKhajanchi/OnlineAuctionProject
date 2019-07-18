using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineAuction.Models
{
    public class User
    {

        public int UserId { get; set; }

        [Required(ErrorMessage ="Required Field")]
        public string UserFName { get; set; }
        [Required(ErrorMessage = "Required Field")]
        public string UserLName { get; set; }
        [Required(ErrorMessage = "Required Field")]
        public DateTime DOB { get; set; }
        [Required(ErrorMessage = "Required Field")]
        [EmailAddress(ErrorMessage = "Enter Genuine Validations")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Required Field")]
        [MinLength(8,ErrorMessage ="MINIMUN 8 Characters Required")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Required Field")]
        public string Confirmpassword { get; set; }
        [Phone(ErrorMessage = "Enter Genuine Phone Number")]
        [Required(ErrorMessage = "Required Field")]
        public long phone { get; set; }
        [Required(ErrorMessage = "Required Field")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Required Field")]
        public string City { get; set; }
        [Required(ErrorMessage = "Required Field")]
        public string Country { get; set; }
        public long Zip { get; set; }
        public string AadharNumber { get; set; }
        //public byte[] AadharImage { get; set; }
        public string PassportNumber { get; set; }
      //  public byte[] PassportImage { get; set; }

    }
}