using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace INTEX.Models
{
    //Datetime string?
    [Table("Compound")]
    public class Compound
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int CompoundID { get; set; }

        public string LTNumber { get; set; }

        //[HiddenInput(DisplayValue = false)]
        //public int CustomerID { get; set; }

        [Display(Name = "Compound Name")]
        public string CompoundName { get; set; }

        [Display(Name = "Quantity (mg)")]
        public double MillQuant { get; set; }

        [Display(Name = "Order Total")]
        public double OrderTotal { get; set; }

        [Display(Name = "Date Arrived")]
        public string DateArrived { get; set; }

        [Display(Name = "Received By")]
        public string ReceivedBy { get; set; }

        [Display(Name = "Active")]
        public bool Active { get; set; }

        [Display(Name = "Expected Receive Date")]
        public string DueDate { get; set; }

        [Display(Name = "Comments")]
        public string Comments { get; set; }

        [Display(Name = "Quantitative File Type")]
        public string QuantitativeFileType { get; set; }

        [Display(Name = "Qualitative Result File")]
        public string QualitativeResults { get; set; }

        [Display(Name = "Quantitative Result File")]
        public string QuantitativeResults { get; set; }

        [Display(Name = "Maximum tolerated dose")]
        public double MTD { get; set; }

        [Display(Name = "Cost")]
        public double Cost { get; set; }

        [Display(Name = "Confirmation Sent Date")]
        public string ConfirmationSentDate { get; set; }
    }
}