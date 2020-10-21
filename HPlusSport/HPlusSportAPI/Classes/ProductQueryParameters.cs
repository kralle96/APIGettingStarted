﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPlusSportAPI.Classes
{
    public class ProductQueryParameters : QueryParameters
    {
        public string Sku { get; set; }
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }

        public string Name { get; set; }
    }
}
