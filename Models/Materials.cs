using System;
using System.Collections.Generic;

namespace BTL.Models
{
    public partial class Materials
    {
        public Materials()
        {
            Products = new HashSet<Products>();
        }

        public string MaterialId { get; set; }
        public string NameMaterial { get; set; }
        public bool? Status { get; set; }

        public ICollection<Products> Products { get; set; }
    }
}
