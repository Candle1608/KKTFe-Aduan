using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KKTF_e_Aduan.Models
{
    public class ProfileViewModel
    {
        public string matricNo { get; set; }
        public string name { get; set; }
        public Nullable<int> ic { get; set; }
        public Nullable<int> phone { get; set; }
        public string address { get; set; }
        public string programme { get; set; }
        public string email { get; set; }
        public string faculty { get; set; } 
    }
}