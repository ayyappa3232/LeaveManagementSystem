//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LeaveManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Web;
    using System.Web.Mvc;
    
    public partial class Registrationtbl
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public System.DateTime Dob { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string Pincode { get; set; }
        public string MobileNo { get; set; }
        public bool IsAdmin { get; set; }
        public string ProfilePic { get; set; }
        public HttpPostedFileBase ImageFile { get; set; }


    }
}
