using KKTF_e_Aduan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KKTF_e_Aduan.Controllers
{
    public class ComplaintListStudentController : Controller
    {
        // GET: ComplaintListStudent
        public ActionResult Index()
        {
            MyDatabaseEntities1 db = new MyDatabaseEntities1();

            List<complaint> complaintlist = db.complaints.ToList();

            List<ComplaintListStudentViewModels> complaintVMList = complaintlist.Select(x => new ComplaintListStudentViewModels
            {
                complaintCode = x.complaintCode,
                roomNo = x.roomNo,
                title = x.title,
                explanation = x.explanation,
                typeOfComplaint = x.typeOfComplaint,
                typeOfDamage = x.typeOfDamage,
                date = x.date,
                status = x.status,

            }).ToList();

            return View(complaintVMList);
        }
        //public ActionResult ComplaintDetails(int complaintCode)
        //{
        //    MyDatabaseEntities1 db = new MyDatabaseEntities1();
        //    complaint comp = db.complaints.SingleOrDefault(x => x.complaintCode == complaintCode);

        //    ComplaintListStudentViewModels compVM = new ComplaintListStudentViewModels();


        //    compVM.complaintCode = comp.complaintCode;
        //    compVM.roomNo = comp.roomNo;
        //    compVM.title = comp.title;
        //    compVM.explanation = comp.explanation;
        //    compVM.typeOfComplaint = comp.typeOfComplaint;
        //    compVM.typeOfDamage = comp.typeOfDamage;
        //    compVM.date = comp.date;
        //    compVM.status = comp.status;
        //    return View(compVM);
        //}
    }
}