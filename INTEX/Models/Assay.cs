using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace INTEX.Models
{

    public class Assay
    {
        [Display(Name = "Assay Number")]
        public int AssayID { get; set; }

        [Display(Name = "Type of Assay")]
        public string TypeCode { get; set; }

        [Display(Name = "Summary of assay")]
        public string SummaryInfo { get; set; }

        [Display(Name = "Information about procedure")]
        public string DetailedInfo { get; set; }

        [Display(Name = "Procedure Details")]
        public string Procedure { get; set; }

        [Display(Name = "Literary Reference")]
        public string LiteratureReference { get; set; }
        
        [Display(Name="Estimated days to complete assay")]
        public int EstimaEstimateDaysToComplete { get; set; }
    }
}