using KKTF_e_Aduan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KKTF_e_Aduan.Controllers
{
    public class ProfileController : Controller
    {
        
        // GET: Profile
        public ActionResult Profile1()
        {
           
            ProfileEntities DB = new ProfileEntities();
            //List<Table> profile = DB.KKTF_e_Aduan.ToList();
            return View();
        }

        
    }
}