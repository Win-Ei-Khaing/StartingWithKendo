using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Win.Models
{
    public class Seeed_Rec
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public bool Discontinued { get; set; }
    }
    public class SeedModel
    {
    }
}