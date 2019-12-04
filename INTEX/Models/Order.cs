using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace INTEX.Models
{
    public class Order
    {
        [Key]
        [Required]
        [DisplayName("Compound LT Number")]
        public int LTNumber { get; set; }

        [Required]
        [DisplayName("CustomerID")]
        public int CustomerID { get; set; }

        [Required]
        [DisplayName("Compound Name")]
        public string CompoundName { get; set; }

        [Required]
        [DisplayName("Quantity in Milligrams")]
        public double MilQuant { get; set; }

        [Required]
        [DisplayName("Order Total")]
        public double OrderTotal { get; set; }

        [Required]
        [DisplayName("Arrival Date")]
        public string DateArrived { get; set; }

        [Required]
        [DisplayName("Received By:")]
        public int ReceivedBy { get; set; }

        [Required]
        [DisplayName("Active Result")]
        public bool Active { get; set; }

        [Required]
        [DisplayName("Due Date")]
        public string DueDate { get; set; }

        [Required]
        [DisplayName("Comments")]
        public string Comments { get; set; }

        [Required]
        [DisplayName("Quantitative File Type")]
        public string QuantitativeFileType { get; set; }

        [Required]
        [DisplayName("Qualitative Results")]
        public string QualitativeResults { get; set; }

        [Required]
        [DisplayName("Quantitative Results")]
        public string QuantitativeResults { get; set; }

        [Required]
        [DisplayName("Maximum Tolerated Dose (MTD)")]
        public double MTD { get; set; }

        [Required]
        [DisplayName("Cost")]
        public double Cost { get; set; }

        [Required]
        [DisplayName("Date Confirmation Sent")]
        public string ConfirmationSentDate { get; set; }

        [Required]
        [DisplayName("Progress")]
        public string Progress { get; set; }
    }
}