using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KKTF_e_Aduan.Models;

namespace KKTF_e_Aduan.Controllers
{
    public class TestController : Controller
    {
       
        public ActionResult Index()
        {
            MyDatabaseEntities db = new MyDatabaseEntities();

           return View();
        }

        [HttpPost]

        public ActionResult SaveRecord(EmployeeViewModel model)
        {
            
            try
            {
                MyDatabaseEntities db = new MyDatabaseEntities();

                technician tech = new technician();
                tech.techId = model.TechID;
                tech.techName = model.Name;
                tech.techAddress = model.Address;
                tech.techPhoneNo = model.PhoneNo;
                db.technicians.Add(tech);
                db.SaveChanges();
                int latesttechId = tech.techId;
                return RedirectToAction("Index");
            }

            catch (Exception ex)
            {
                throw ex;

            }

            
        }
    }
}
        