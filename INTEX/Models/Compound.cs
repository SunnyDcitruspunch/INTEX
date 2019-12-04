using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace INTEX.Models
{
    [Table("Compound")]
    public class Compound
    {
        [Key]
        [Display(Name = "Northwest Labs Test Number")]
        public int LTNumber { get; set; }

        [Display(Name = "Customer ID")]
        public int CustomerID { get; set; }

        [Display(Name = "Compound Name")]
        public string CompoundName { get; set; }

        [Display(Name = "Quantity in Milligrams")]
        public double MillQuant { get; set; }

        [Display(Name = "Order Total")]
        public double OrderTotal { get; set; }

        [Display(Name = "Date Arrived")]
        public string DateArrived { get; set; }

        [Display(Name = "Received By")]
        public int ReceivedBy { get; set; }

        [Display(Name = "Active")]
        public bool Active { get; set; }

        [Display(Name = "Due Date")]
        public string DueDate { get; set; }

        [Display(Name = "Comments")]
        public string Comments { get; set; }

        [Display(Name = "Northwest Labs Test Number")]
        public string QuantitativeFileType { get; set; }

        [Display(Name = "Qualitative Result File")]
        public string QualitativeResults { get; set; }

        [Display(Name = "Quantitative Result File")]
        public string QuantitativeResults { get; set; }

        [Display(Name = "Maximum tolerated dose")]
        public double MTD { get; set; }

        [Display(Name = "Cost")]
        public double Cost { get; set; }
    }
}