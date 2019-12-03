using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace INTEX.DAL
{
    public class DBContext : DbContext
    {
        public DBContext() : base("DBContext")
        {

        }
    }
}