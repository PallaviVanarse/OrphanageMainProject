using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrphanageAPI.Models
{
    public class OrphanageRegistrationView
    {
        public int oId { get; set; }
        public string oName { get; set; }
        public string oRegistrationNum { get; set; }
        public string addressLine1 { get; set; }
        public string addressLine2 { get; set; }
        public string landmark { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string pincode { get; set; }
        public string phoneNum { get; set; }
        public string password { get; set; }
    }
}