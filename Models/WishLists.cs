using System;
using System.Collections.Generic;

namespace BTL.Models
{
    public partial class WishLists
    {
        public int WishListsId { get; set; }
        public int? AccountId { get; set; }
        public string ProductId { get; set; }

        public Accounts Account { get; set; }
        public Products Product { get; set; }
    }
}
