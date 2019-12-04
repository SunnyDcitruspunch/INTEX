using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace INTEX.Models
{
    [Table("Assay")]
    public class Assay
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int AssayID { get; set; }

        [HiddenInput(DisplayValue = false)]
        public string TypeCode { get; set; }

        [Display(Name = "Assay Summary")]
        public string SummaryInfo { get; set; }

        [Display(Name = "Assay Details")]
        public string DetailedInfo { get; set; }

        [Display(Name = "Assay Procedure")]
        public string Procedure { get; set; }

        [Display(Name = "Literature References")]
        public string LiteratureReferences { get; set; }

        [Display(Name = "Estimated Days to Complete")]
        public int EstimateDaysToComplete { get; set; }
    }
}