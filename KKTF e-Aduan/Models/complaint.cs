//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KKTF_e_Aduan.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class complaint
    {
        public int complaintCode { get; set; }
        public string matricNo { get; set; }
        public string email { get; set; }
        public string phoneNo { get; set; }
        public string roomNo { get; set; }
        public string title { get; set; }
        public string explanation { get; set; }
        public Nullable<int> typeOfComplaint { get; set; }
        public Nullable<int> typeOfDamage { get; set; }
        public string status { get; set; }
        public string assignTechnician { get; set; }
        public string date { get; set; }
    
        public virtual typeOfComplaint typeOfComplaint1 { get; set; }
        public virtual typeOfDamage typeOfDamage1 { get; set; }
    }
}
