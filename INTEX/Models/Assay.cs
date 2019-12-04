using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace INTEX.Models
{
    public class Assay
    {
        [Key]
        public int AssayID { get; set; }
        public string TypeCode { get; set; }
        public string SummaryInfo { get; set; }
        public string DetailedInfo { get; set; }
        public string Procedure { get; set; }
        public string LiteratureReferences { get; set; }
        public int EstimatedDaysToComplete { get; set; }
    }
}