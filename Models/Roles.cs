using System;
using System.Collections.Generic;

namespace BTL.Models
{
    public partial class Roles
    {
        public Roles()
        {
            Accounts = new HashSet<Accounts>();
        }

        public int RoleId { get; set; }
        public string NameRole { get; set; }
        public bool? Status { get; set; }

        public ICollection<Accounts> Accounts { get; set; }
    }
}
