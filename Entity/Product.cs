﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCodeFirst.Entity
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        public string ProductName { get; set; }
        public string ProductBrand { get; set; }
        public string ProductCategoryName { get; set; }
        public int ProductInStock { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
    }
}
