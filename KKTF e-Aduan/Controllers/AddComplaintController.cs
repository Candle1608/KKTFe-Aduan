using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KKTF_e_Aduan.Models;

namespace KKTF_e_Aduan.Controllers
{
    public class AddComplaintController : Controller
    {
        // GET: AddComplaint
        public ActionResult Index()
        {
            MyDatabaseEntities1 db = new MyDatabaseEntities1();
            List<typeOfComplaint> typeofcomplaintlist = db.typeOfComplaints.ToList();
            List<typeOfDamage> typeofdamagelist = db.typeOfDamages.ToList();
            ViewBag.ComplaintList = new SelectList(typeofcomplaintlist, "typeOfComplaintId", "typeOfcomplaintName");
            ViewBag.ComplaintList1 = new SelectList(typeofdamagelist, "typeOfDamageId", "typeOfDamageName");
            return View();
        }
        [HttpPost]
        public ActionResult Index(ComplaintViewModels model)
        {
            try
            {

                MyDatabaseEntities1 db = new MyDatabaseEntities1();
                List<typeOfComplaint> typeofcomplaintlist = db.typeOfComplaints.ToList();
                List<typeOfDamage> typeofdamagelist = db.typeOfDamages.ToList();
                ViewBag.ComplaintList = new SelectList(typeofcomplaintlist, "typeOfComplaintId", "typeOfcomplaintName");
                ViewBag.ComplaintList1 = new SelectList(typeofdamagelist, "typeOfDamageId", "typeOfDamageName");

                complaint comp = new complaint();
                comp.name = model.name;
                comp.matricNo = model.matricNo;
                comp.email = model.email;
                comp.phoneNo = model.phoneNo;
                comp.roomNo = model.roomNo;
                comp.title = model.title;
                comp.explanation = model.explanation;
                comp.typeOfComplaint = model.typeOfComplaint;
                comp.typeOfDamage = model.typeOfDamage;

                db.complaints.Add(comp);
                db.SaveChanges();

                //int latestEmpId = comp.EmployeeID;

                //Site site = new Site();
                //site.SiteName = model.SiteName;
                //site.EmployeeID = latestEmpId;

                //db.Sites.Add(site);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View(model);
        }

    }
}