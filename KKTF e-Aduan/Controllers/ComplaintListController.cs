using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KKTF_e_Aduan.Models;

namespace KKTF_e_Aduan.Controllers
{
    public class ComplaintListController : Controller
    {
        IList<complaint> ComplaintList = new List<complaint>()
            {
                new complaint(){complaintCode=10, assignTechnician="mohamad", status="process", },
                new complaint(){complaintCode=11, assignTechnician="ismail", status="done", },
            };

        //GET: Complaint
        public ActionResult Index()
        {
            MyDatabaseEntities db = new MyDatabaseEntities();

            List<complaint> complaintList = db.complaints.ToList();

            List<complaintListModels> complaintLMList = complaintList.Select(x => new complaintListModels
            {
                complaintCode = x.complaintCode,
                name = x.name,
                matricNo = x.matricNo,
                email = x.email,
                phoneNo = x.phoneNo,
                assignTechnician = x.assignTechnician,
                roomNo = x.roomNo,
                title = x.title,
                explaination = x.explanation,
                typeOfComplaint = x.typeOfComplaint,
                typeOfDamage = x.typeOfDamage,
                date = x.date,
                status = x.status,

            }).ToList();

            return View(complaintLMList);

        }

        public ActionResult Edit(int Code)
        {
            //Get complaintcode from ComplaintList
            var comp = complaint.Where(c => c.complaint == Code).FirstOrDefault();

            return View(comp);
        }

        [HttpPost]
        public ActionResult Edit (ComplaintListController Complaint)
        {
            return RedirectToAction("Index");
        }

        [HttpDelete]
        public ActionResult Delete (int id)
        {
            return RedirectToAction("Index");
        }

    }

}