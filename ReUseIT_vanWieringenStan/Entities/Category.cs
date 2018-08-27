using System;
using System.Collections.Generic;

namespace ReUseIT_vanWieringenStan.Entities
{
    public partial class Category
    {
        public Category()
        {
            Product = new HashSet<Product>();
        }

        public int CategoryId { get; set; }
        public string Description { get; set; }

        public ICollection<Product> Product { get; set; }
    }
}
