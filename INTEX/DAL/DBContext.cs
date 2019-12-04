using System;
using INTEX.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace INTEX.DAL
{
    public class DBContext : DbContext
    {
        public DBContext() : base("DBContext")
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Compound> Compounds { get; set; }
        public DbSet<Compound> Assays { get; set; }
    }
}