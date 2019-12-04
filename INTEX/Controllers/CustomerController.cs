using INTEX.DAL;
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
                aCustomer.CustomerID = lsCustomers.Count() + 1;
                lsCustomers.Add(aCustomer);
                return RedirectToAction("Menu", "CustomerHome");
            }
            else
            {
                return View(aCustomer);
            }
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(Customer aCustomer)
        {
            if (ModelState.IsValid)
            {
                aCustomer.CustomerID = lsCustomers.Count() + 1;
                lsCustomers.Add(aCustomer);
                return RedirectToAction("Login", "Customer");
            }
            else
            {
                return View(aCustomer);
            }
        }


        [HttpPost]
        public ActionResult Login(FormCollection form, bool rememberMe = false)
        {
            //String email = form["Email address"].ToString();
            //String password = form["Password"].ToString();

            //var db = new DBContext();
            //var currentUser = db.Database.SqlQuery<Customer>(
            //  "Select * " +
            //  "FROM Customer " +
            //  "WHERE Email = '" + email + "' AND " +
            //  "Password = '" + password + "'");

            //if (currentUser.Count() > 0)
            //{
            //    FormsAuthentication.SetAuthCookie(email, rememberMe);
            //    return RedirectToAction("Index", "Customer", new { userlogin = email });
            //}
            //else
            //{
            //    return View();
            //}

            return RedirectToAction("Index", "Customer");
        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            return View();
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
    }
}
