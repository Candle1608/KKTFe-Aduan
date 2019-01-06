using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EditableListMvc.Controllers
{
    public class ComplaintListController : Controller
    {
        // TODO: remove mock database
        private static List<Models.Complaint> MockDb = new List<Models.Complaint>
            {
                new Models.Complaint { PrimaryKey = 1, FirstName = "Fred", LastName="Than", Age=54 },
                new Models.Complaint { PrimaryKey = 2, FirstName = "Erin", LastName="Saavedra", Age=37 },
                new Models.Complaint { PrimaryKey = 4, FirstName = "Abdul", LastName = "Banas", Age = 12 }
            };

        private List<Models.Complaint> _complaintList;
        private List<Models.Complaint> ComplaintList
        {
            get
            {
                if (_complaintList == null)
                    _complaintList = Session["ComplaintList"] as List<Models.Complaint>;
                return _complaintList;
            }
            set
            {
                _complaintList = value;
                Session["ComplaintList"] = _complaintList;
            }
        }

        // GET: ComplaintList
        public ActionResult Index()
        {
            if (ComplaintList == null)
            {
                // TODO: load real data from database
                ComplaintList = MockDb;
            }
            return View(ComplaintList);
        }

        [HttpPost]
        public ActionResult Index(List<Models.Complaint> complaintList, string command)
        {
            try
            {
                if (command == "Add")
                {
                    complaintList.Add(new Models.Complaint { PrimaryKey = -1 });
                    ComplaintList = complaintList;
                }
                else if (command == "Delete")
                {
                    int pos = complaintList.Count();
                    while (pos > 0)
                    {
                        pos--;
                        if (complaintList[pos].Remove)
                            complaintList.RemoveAt(pos);
                    }
                    ComplaintList = complaintList;
                }
                else if (command == "Edit")
                {
                    // force reload of data from database
                    ComplaintList = null;
                }
                else
                {
                    // update actual database
                    MockDb = complaintList;
                    // force reload of data from database
                    ComplaintList = null;
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}