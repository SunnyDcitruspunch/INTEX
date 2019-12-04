using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace INTEX.Models
{
    [Table("Assay")]
    public class Assay
    {
        [Key]
        public int AssayID { get; set; }

        public string TypeCode { get; set; }

        public string SummaryInfo { get; set; }

        public string DetailInfo { get; set; }

        public string Procedure { get; set; }

        public string LiteratureReferences { get; set; }

        public int EstimateDaysToComplete { get; set; }
    }
}