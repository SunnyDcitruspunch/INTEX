using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace INTEX.Models
{
    public class CompoundAssayDetails
    {
        [Key]
        public int LTNumber { get; set; }
        public int CompoundSeqNum { get; set; }
        public int AssayID { get; set; }
        public double Cost { get; set; }
        public string StatusCode { get; set; }
        public string ScheduledDate { get; set; }
    }
}