using System;
using INTEX.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace INTEX.Models
{
    public class Order
    {
        //public DbSet<Customer> Customers { get; set; }
        public DbSet<Compound> Compounds { get; set; }
        public DbSet<Assay> Assays { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
    }

}