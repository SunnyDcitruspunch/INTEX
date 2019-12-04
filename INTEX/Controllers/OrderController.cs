using INTEX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace INTEX.Controllers
{
    public class OrderController : Controller
    {

        public static List<Compound> lsCompounds = new List<Compound>();

        // GET: Order
        public ActionResult Index()
        {
            return View(lsCompounds);
        }

        // GET: Order/Details/5
        public ActionResult Details(int id)
        {
            Compound oCompound = lsCompounds.Find(x => x.CompoundID == id);
            return View(oCompound);
        }

        // GET: Order/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Order/Create
        [HttpPost]
        public ActionResult Create(Compound aCompound)
        {
            if (ModelState.IsValid)
            {
                Random r = new Random();
                var x = r.Next(0, 1000000);
                string s = x.ToString("000000");

                aCompound.LTNumber = s;
                lsCompounds.Add(aCompound);
                return RedirectToAction("Index", "Payment", aCompound);
            }
            else
            {
                return View(aCompound);
            }
        }

        // GET: Order/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Order/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
