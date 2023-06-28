using System;
using System.Collections.Generic;

namespace BTL.Models
{
    public partial class RelatedImage
    {
        public int RelatedImageId { get; set; }
        public string Image { get; set; }
        public string ProductId { get; set; }

        public Products Product { get; set; }
    }
}
