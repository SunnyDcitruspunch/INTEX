using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INTEX.Models
{
    public class Invoice
    {
        public int InvoiceID { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentDueDate  { get; set; }
        public string EarlyPaymentDate { get; set; }
        public double Discount { get; set; }
        public double AdvanceMoney { get; set; }
        public string InvoiceSendDate { get; set; }
    }
}