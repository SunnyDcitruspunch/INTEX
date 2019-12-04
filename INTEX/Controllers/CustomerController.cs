using INTEX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace INTEX.Controllers
{
    public class CustomerController : Controller
    {
        public static List<Compound> lsCompounds = new List<Compound>();
        public static List<Customer> lsCustomers = new List<Customer>();

        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult CreateOrder()
        {
            return View();
        }

        public ActionResult Order()
        {
            return View();
        }

        public ActionResult Payment()
        {
            return View();
        }

        public ActionResult Report()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCustomer(Customer aCustomer)
        {
            if (ModelState.IsValid)
            {
                lsCustomers.Add(aCustomer);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(aCustomer);
            }
        }

        [HttpPost]
        public ActionResult Login(FormCollection form, bool rememberMe = false)
        {
            String email = form["Email address"].ToString();
            String password = form["Password"].ToString();

            if (string.Equals(email, "holden.ford@northwest.com") && string.Equals(password, "greg2019!"))
            {
                FormsAuthentication.SetAuthCookie(email, rememberMe);
                return RedirectToAction("Index", "Customer");
            }
            else if (string.Equals(email, "bill.tench@northwest.com") && string.Equals(password, "tench2017!"))
            {
                FormsAuthentication.SetAuthCookie(email, rememberMe);
                return RedirectToAction("Index", "Customer");
            }
            else
            {
                return View();
            }
        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Customer/Edit/5
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

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Customer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
