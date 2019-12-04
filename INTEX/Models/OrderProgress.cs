using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INTEX.Models
{
    public class OrderProgress
    {
        public Order orders { get; set; }
        public Progress progresses { get; set; }
    }
}