using System;
using System.Collections.Generic;

namespace BTL.Models
{
    public partial class Posts
    {
        public int PostId { get; set; }
        public string NamePost { get; set; }
        public string Content { get; set; }
        public bool? Status { get; set; }
    }
}
