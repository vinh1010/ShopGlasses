using System;
using System.Collections.Generic;

namespace BTL.Models
{
    public partial class Brands
    {
        public Brands()
        {
            Products = new HashSet<Products>();
        }

        public string BrandId { get; set; }
        public string NameBrand { get; set; }
        public string Image { get; set; }
        public bool? Status { get; set; }

        public ICollection<Products> Products { get; set; }
    }
}
