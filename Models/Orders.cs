using System;
using System.Collections.Generic;

namespace BTL.Models
{
    public partial class Orders
    {
        public Orders()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }

        public int OrderId { get; set; }
        public string Email { get; set; }
        public string NameCustomer { get; set; }
        public string Phone { get; set; }
        public int TotalQuantity { get; set; }
        public double TotalMoney { get; set; }
        public string Adress { get; set; }
        public string Note { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int Status { get; set; }

        public ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
