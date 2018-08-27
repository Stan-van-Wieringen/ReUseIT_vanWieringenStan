using System;
using System.Collections.Generic;

namespace ReUseIT_vanWieringenStan.Entities
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string Description { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal Price { get; set; }
        public bool Available { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
