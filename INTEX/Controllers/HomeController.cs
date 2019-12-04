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
        //This is just a test to see how the assay catalog populates, this is not needed once we link the model to the database
        public static List<Assay> assayList = new List<Assay>()
        {
                new Assay{AssayID = 1, TypeCode = "BP", EstimaEstimateDaysToComplete = 4, LiteratureReference = "Lord of the flies", Procedure = "Same as detailed description",SummaryInfo = "This is a fantastic and summarized description of how this is exactly what you need", DetailedInfo = "This is just like the summarized info but longer. this is describes what happens and why it happens"},
                new Assay{AssayID = 3, TypeCode = "BP", EstimaEstimateDaysToComplete = 2, LiteratureReference = "To kill a mockingbird", Procedure = "Same as detailed description",SummaryInfo = "This is a fantastic and summarized description of how this is exactly what you need", DetailedInfo = "This is just like the summarized info but longer. this is describes what happens and why it happens"},
                new Assay{AssayID = 2, TypeCode = "DS", EstimaEstimateDaysToComplete = 1, LiteratureReference = "Huckleberry Finn", Procedure = "Same as detailed description",SummaryInfo = "This is a fantastic and summarized description of how this is exactly what you need", DetailedInfo = "This is just like the summarized info but longer. this is describes what happens and why it happens"},
                new Assay{AssayID = 7, TypeCode = "IS", EstimaEstimateDaysToComplete = 1, LiteratureReference = "The Book Theif", Procedure = "Same as detailed description",SummaryInfo = "This is a fantastic and summarized description of how this is exactly what you need", DetailedInfo = "This is just like the summarized info but longer. this is describes what happens and why it happens"},
                new Assay{AssayID = 5, TypeCode = "PF", EstimaEstimateDaysToComplete = 2, LiteratureReference = "Mistborn", Procedure = "Same as detailed description",SummaryInfo = "This is a fantastic and summarized description of how this is exactly what you need", DetailedInfo = "This is just like the summarized info but longer. this is describes what happens and why it happens"},
                new Assay{AssayID = 6, TypeCode = "PS", EstimaEstimateDaysToComplete = 6, LiteratureReference = "Pharmacology for Dummies", Procedure = "Same as detailed description",SummaryInfo = "This is a fantastic and summarized description of how this is exactly what you need", DetailedInfo = "This is just like the summarized info but longer. this is describes what happens and why it happens"},
                new Assay{AssayID = 4, TypeCode = "CS", EstimaEstimateDaysToComplete = 2, LiteratureReference = "If You Give a Mouse a Cookie", Procedure = "Same as detailed description",SummaryInfo = "This is a fantastic and summarized description of how this is exactly what you need", DetailedInfo = "This is just like the summarized info but longer. this is describes what happens and why it happens"}
        };

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        //Catalog Action Method
        public ActionResult Catalog()
        {
            return View(assayList);
        }
    }
}