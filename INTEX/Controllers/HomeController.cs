using INTEX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace INTEX.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        //This is just a test to see how the assay catalog populates, this is not needed once we link the model to the database
        public static List<Assay> assayList = new List<Assay>()
        {
                new Assay{AssayID = 1, TypeCode = "BP", EstimateDaysToComplete = 4, LiteratureReferences = "Lord of the flies", Procedure = "Same as detailed description",SummaryInfo = "This is a fantastic and summarized description of how this is exactly what you need", DetailedInfo = "This is just like the summarized info but longer. this is describes what happens and why it happens"},
                new Assay{AssayID = 3, TypeCode = "BP", EstimateDaysToComplete = 2, LiteratureReferences = "To kill a mockingbird", Procedure = "Same as detailed description",SummaryInfo = "This is a fantastic and summarized description of how this is exactly what you need", DetailedInfo = "This is just like the summarized info but longer. this is describes what happens and why it happens"},
                new Assay{AssayID = 2, TypeCode = "DS", EstimateDaysToComplete = 1, LiteratureReferences = "Huckleberry Finn", Procedure = "Same as detailed description",SummaryInfo = "This is a fantastic and summarized description of how this is exactly what you need", DetailedInfo = "This is just like the summarized info but longer. this is describes what happens and why it happens"},
                new Assay{AssayID = 7, TypeCode = "IS", EstimateDaysToComplete = 1, LiteratureReferences = "The Book Theif", Procedure = "Same as detailed description",SummaryInfo = "This is a fantastic and summarized description of how this is exactly what you need", DetailedInfo = "This is just like the summarized info but longer. this is describes what happens and why it happens"},
                new Assay{AssayID = 5, TypeCode = "PF", EstimateDaysToComplete = 2, LiteratureReferences = "Mistborn", Procedure = "Same as detailed description",SummaryInfo = "This is a fantastic and summarized description of how this is exactly what you need", DetailedInfo = "This is just like the summarized info but longer. this is describes what happens and why it happens"},
                new Assay{AssayID = 6, TypeCode = "PS", EstimateDaysToComplete = 6, LiteratureReferences = "Pharmacology for Dummies", Procedure = "Same as detailed description",SummaryInfo = "This is a fantastic and summarized description of how this is exactly what you need", DetailedInfo = "This is just like the summarized info but longer. this is describes what happens and why it happens"},
                new Assay{AssayID = 4, TypeCode = "CS", EstimateDaysToComplete = 2, LiteratureReferences = "If You Give a Mouse a Cookie", Procedure = "Same as detailed description",SummaryInfo = "This is a fantastic and summarized description of how this is exactly what you need", DetailedInfo = "This is just like the summarized info but longer. this is describes what happens and why it happens"}
        };

        //Catalog Action Method
        public ActionResult Catalog()
        {
            return View(assayList);
        }
    }   
}