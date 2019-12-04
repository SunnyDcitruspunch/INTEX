using INTEX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace INTEX.Controllers
{
    public class SingaporeController : Controller
    {
        public static List<Order> lstOrders = new List<Order>();
        public static List<Progress> lstProgress = new List<Progress>();
        public static List<Assay> lstAssay = new List<Assay>();

        // GET: Singapore
        public ActionResult Index()
        {
            ViewBag.EmpName = "Luke Skywalker";

            //add values to progress
            if (lstProgress.Count() == 0)
            {
                lstProgress.Add(new Progress()
                {
                    ProgressCode = "Passed",
                    ProgressDesc = "Passed"
                });

                lstProgress.Add(new Progress()
                {
                    ProgressCode = "In Progress",
                    ProgressDesc = "In Progress"
                });

                lstProgress.Add(new Progress()
                {
                    ProgressCode = "Failed",
                    ProgressDesc = "Failed"
                });
                return View();
            }
            else
            {
                return View();
            }

        }

        public ActionResult Order()
        {
            //test order to always have one in there
            lstOrders.Add(new Order()
            {
                LTNumber = 2585,
                CustomerID = 25,
                CompoundName = "The Compound",
                MilQuant = 3.44,
                OrderTotal = 56.99,
                DateArrived = "4/25/19",
                ReceivedBy = 23,
                Active = true,
                DueDate = "5/30/19",
                Comments = "This is the comment for the order",
                QuantitativeFileType = "jpeg. maybe.",
                QualitativeResults = "Passed",
                QuantitativeResults = "Failed",
                MTD = 3.22,
                Cost = 55.66,
                ConfirmationSentDate = "6/18/2012 09:54:22"
            });

            ViewBag.Name = "Work Order: " + ViewBag.WorkOrder;

            //ViewBag.WorkOrder = myOrder.LTNumber; not sure what this was

            return View(lstOrders);
        }

        // CREATE: Order
        public ActionResult Create()
        {
            ViewBag.Progress = lstProgress;

            return View();
        }

        [HttpPost]
        public ActionResult Create(Order myOrder)
        {
            lstOrders.Add(myOrder);

            return RedirectToAction("Order", lstOrders);
        }

        // EDIT: Order
        public ActionResult Edit(int id)
        {
            ViewBag.Progress = lstProgress;
            Order oOrder = lstOrders.Find(x => x.LTNumber == id);

            return View(oOrder);
        }

        [HttpPost]
        public ActionResult Edit(Order newOrder)
        {
            var obj = lstOrders.FirstOrDefault(x => x.LTNumber == newOrder.LTNumber);
            if (obj != null)
            {
                obj.Progress = newOrder.Progress;
                obj.CustomerID = newOrder.CustomerID;
                obj.CompoundName = newOrder.CompoundName;
                obj.MilQuant = newOrder.MilQuant;
                obj.OrderTotal = newOrder.OrderTotal;
                obj.DateArrived = newOrder.DateArrived;
                obj.ReceivedBy = newOrder.ReceivedBy;
                obj.Active = newOrder.Active;
                obj.DueDate = newOrder.DueDate;
                obj.Comments = newOrder.Comments;
                obj.QuantitativeFileType = newOrder.QuantitativeFileType;
                obj.QualitativeResults = newOrder.QualitativeResults;
                obj.QuantitativeResults = newOrder.QuantitativeResults;
                obj.MTD = newOrder.MTD;
                obj.Cost = newOrder.Cost;
                obj.ConfirmationSentDate = newOrder.ConfirmationSentDate;
            }

            return RedirectToAction("Index");
        }

        // GET: Order Details
        public ActionResult Details(int id)
        {
            Order oOrder = lstOrders.Find(x => x.LTNumber == id);

            return View(oOrder);
        }

        // GET: Progress/AddProgress/5
        public ActionResult AddOwner(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderProgress orderProgress = new OrderProgress();

            orderProgress.orders = lstOrders.Find(x => x.LTNumber == id);

            if (orderProgress.orders == null)
            {
                return HttpNotFound();
            }

            if (orderProgress.progresses.ProgressCode != null)
            {
                return RedirectToAction("Order");
            }

            return View(orderProgress);
        }

        // ASSAY------------------------------------------------------------------------
        public ActionResult Assay()
        {
            return View(lstAssay);
        }

        // CREATE: Assay
        public ActionResult CreateAssay()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateAssay(Assay myAssay)
        {
            lstAssay.Add(myAssay);

            return RedirectToAction("Assay", lstAssay);
        }

        // EDIT: Assay
        public ActionResult EditAssay(int id)
        {
            Assay oAssay = lstAssay.Find(x => x.AssayID == id);

            return View(oAssay);
        }

        [HttpPost]
        public ActionResult EditAssay(Assay newAssay)
        {
            var obj = lstAssay.FirstOrDefault(x => x.AssayID == newAssay.AssayID);
            if (obj != null)
            {
                obj.TypeCode = newAssay.TypeCode;
                obj.SummaryInfo = newAssay.SummaryInfo;
                obj.DetailedInfo = newAssay.DetailedInfo;
                obj.Procedure = newAssay.Procedure;
                obj.LiteratureReferences = newAssay.LiteratureReferences;
                obj.EstimatedDaysToComplete = newAssay.EstimatedDaysToComplete;
            }

            return RedirectToAction("Assay");
        }

        // GET: CompountAssayDetails / Test
        public ActionResult CompoundAssayDetails()
        {
            return View();
        }
    }  
} 