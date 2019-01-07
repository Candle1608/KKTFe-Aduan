using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace KKTF_e_Aduan.Models
{
    public class ComplaintViewModels
    {
        [Required(ErrorMessage = "Enter Name")]
        [Display(Name = "Name")]
        public string name { get; set; }
        [Required(ErrorMessage = "Enter Matric No")]
        [Display(Name = "Matric No")]
        public string matricNo { get; set; }
        [Required(ErrorMessage = "Enter Email")]
        [Display(Name = "Email")]
        public string email { get; set; }
        [Required(ErrorMessage = "Enter Phone Number")]
        [Display(Name = "Phone Number")]
        public string phoneNo { get; set; }
        [Required(ErrorMessage = "Enter Room Number")]
        [Display(Name = "Room Number")]
        public string roomNo { get; set; }
        [Required(ErrorMessage = "Enter Title")]
        [Display(Name = "Title")]
        public string title { get; set; }
        [Required(ErrorMessage = "Enter Explanation")]
        [Display(Name = "Explanation")]
        public string explanation { get; set; }
        [Required(ErrorMessage = "Choose type of complaint")]
        [Display(Name = "Type of Complaint")]
        public Nullable<int> typeOfComplaint { get; set; }
        [Required(ErrorMessage = "Choose type of damage")]
        [Display(Name = "Type of Damage")]
        public Nullable<int> typeOfDamage { get; set; }
        //
        public string status { get; set; }
        public string assignTechnician { get; set; }
        public int complaintCode { get; set; }
    }

}