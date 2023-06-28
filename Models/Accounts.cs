using System;
using System.Collections.Generic;

namespace BTL.Models
{
    public partial class Accounts
    {
        public Accounts()
        {
            WishLists = new HashSet<WishLists>();
        }

        public int AccountId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool? Status { get; set; }
        public int? RoleId { get; set; }

        public Roles Role { get; set; }
        public ICollection<WishLists> WishLists { get; set; }
    }
}
