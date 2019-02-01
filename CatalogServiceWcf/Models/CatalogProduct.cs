using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CatalogServiceWcf.Models
{
    public class CatalogProduct
    {
        public Guid Id { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }

        public int StoresCount { get; set; }
        public Decimal MinPrice { get; set; }

    }
}