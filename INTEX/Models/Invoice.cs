using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace INTEX.Models
{
    [Table("Invoice")]
    public class Invoice
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int InvoiceID { get; set; }

        [Display(Name = "Payment Method")]
        public string PaymentMethod { get; set; }

        [Display(Name = "Payment Due Date")]
        public string PaymentDueDate  { get; set; }

        [Display(Name = "Early Payment Date")]
        public string EarlyPaymentDate { get; set; }

        [Display(Name = "Discount")]
        public double? Discount { get; set; }

        [HiddenInput(DisplayValue = false)]
        public string InvoiceSentDate { get; set; }
    }
}