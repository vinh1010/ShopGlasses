using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTL.Models
{
    public class Cart
    {
        public string IdProduct { get; set; }
        public string NameProduct { get; set; }
        public string Image { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
    }
}
