using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace INTEX.Models
{
    public class WorkOrder
    {
        [Key]
        [Required]
        [DisplayName("Order ID")]
        public int OrderID { get; set; }

        [Required]
        [DisplayName("Progress")]
        public string Progress { get; set; }

        [Required]
        [DisplayName("LT Number")]
        public int LTNumber { get; set; }

        [Required]
        [DisplayName("Customer ID")]
        public int CustomerID { get; set; }

        [Required]
        [DisplayName("Order Total")]
        public double OrderTotal { get; set; }

        [Required]
        [DisplayName("Date Arrived")]
        public string DateArrived { get; set; }

        [Required]
        [DisplayName("Received By")]
        public int ReceivedBy { get; set; }

        [Required]
        [DisplayName("Due Date")]
        public string DueDate { get; set; }

        [Required]
        [DisplayName("Quote")]
        public int Quote { get; set; }

        [Required]
        [DisplayName("Discount")]
        public int Discount { get; set; }

        [Required]
        [DisplayName("Current Cost")]
        public double CurrentCost { get; set; }

        [Required]
        [DisplayName("Order ID")]
        public string ConfirmationSentDate { get; set; }

        [Required]
        [DisplayName("Summary Report")]
        public string SummaryReport { get; set; }
    }
}