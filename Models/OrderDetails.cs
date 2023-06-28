using System;
using System.Collections.Generic;

namespace BTL.Models
{
    public partial class OrderDetails
    {
        public int OrderDetailsId { get; set; }
        public int? OrderId { get; set; }
        public string ProductId { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Color { get; set; }

        public Orders Order { get; set; }
        public Products Product { get; set; }
    }
}
