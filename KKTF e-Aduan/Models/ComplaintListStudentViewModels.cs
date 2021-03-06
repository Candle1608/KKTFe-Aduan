﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KKTF_e_Aduan.Models
{
    public class ComplaintListStudentViewModels
    {
        public int complaintCode { get; set; }
        public string name { get; set; }
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
        public Nullable<System.DateTime> date { get; set; }

        public string typeOfcomplaintName { get; set; }
        public string typeOfDamageName { get; set; }

    }
}