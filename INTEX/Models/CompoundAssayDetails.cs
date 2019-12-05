using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace INTEX.Models
{
    public class CompoundAssayDetails
    {
        [Key]
        [Required]
        [DisplayName("LT Number")]
        public int LTNumber { get; set; }

        [Required]
        [DisplayName("Compound Sequence Number")]
        public int CompoundSeqNum { get; set; }

        [Required]
        [DisplayName("Assay ID")]
        public int AssayID { get; set; }

        [Required]
        [DisplayName("Actual Cost")]
        public double Cost { get; set; }

        [Required]
        [DisplayName("Status")]
        public string StatusCode { get; set; }

        [Required]
        [DisplayName("Scheduled Date of Test")]
        public string ScheduledDate { get; set; }
    }
}