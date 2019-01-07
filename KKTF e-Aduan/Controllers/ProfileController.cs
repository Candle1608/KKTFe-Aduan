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
        private List<Profile> emp;
        public ProfileController()
        {
            emp = new List<Profile>()
                {
                    new Profile()
                    { Name =  "" },
                };
        }
        
        
        // GET: Profile
        public ActionResult Profile()
        {
            var entities = new TestProfileDBEntities();
            return View();
        }
    }
}