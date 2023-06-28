using System;
using System.Collections.Generic;

namespace BTL.Models
{
    public partial class Products
    {
        public Products()
        {
            OrderDetails = new HashSet<OrderDetails>();
            ProductColors = new HashSet<ProductColors>();
            RelatedImage = new HashSet<RelatedImage>();
            WishLists = new HashSet<WishLists>();
        }

        public string ProductId { get; set; }
        public string NameProduct { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public double SalePrice { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public bool? Status { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CategoryId { get; set; }
        public string MaterialId { get; set; }
        public string BrandId { get; set; }

        public Brands Brand { get; set; }
        public Categories Category { get; set; }
        public Materials Material { get; set; }
        public ICollection<OrderDetails> OrderDetails { get; set; }
        public ICollection<ProductColors> ProductColors { get; set; }
        public ICollection<RelatedImage> RelatedImage { get; set; }
        public ICollection<WishLists> WishLists { get; set; }
    }
}
