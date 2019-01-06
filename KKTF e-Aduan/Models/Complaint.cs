using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KKTF_e_Aduan.Models
{
    [Table("complaint")]
    public class complaint
    {
        [Key]
        public string name { get; set; }
        [StringLength(50)]
        public string matricNo { get; set; }
        [StringLength(50)]
        public string email { get; set; }
        [StringLength(50)]

    }
}