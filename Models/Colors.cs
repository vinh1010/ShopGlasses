using System;
using System.Collections.Generic;

namespace BTL.Models
{
    public partial class Colors
    {
        public Colors()
        {
            ProductColors = new HashSet<ProductColors>();
        }

        public string ColorId { get; set; }
        public string NameColor { get; set; }
        public bool? Status { get; set; }

        public ICollection<ProductColors> ProductColors { get; set; }
    }
}
