using System;
using System.Collections.Generic;

namespace BTL.Models
{
    public partial class Categories
    {
        public Categories()
        {
            Products = new HashSet<Products>();
        }

        public string CategoryId { get; set; }
        public string NameCategory { get; set; }
        public bool? Status { get; set; }
        public string ParentId { get; set; }

        public ICollection<Products> Products { get; set; }
    }
}
