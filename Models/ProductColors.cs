using System;
using System.Collections.Generic;

namespace BTL.Models
{
    public partial class ProductColors
    {
        public int ProductColorsId { get; set; }
        public string ColorId { get; set; }
        public string ProductId { get; set; }

        public Colors Color { get; set; }
        public Products Product { get; set; }
    }
}
