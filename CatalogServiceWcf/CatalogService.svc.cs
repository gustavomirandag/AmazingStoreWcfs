using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using CatalogServiceWcf.Models;

namespace CatalogServiceWcf
{
    public class CatalogService : ICatalogService
    {
        //Ram Database
        private readonly static List<CatalogProduct> _catalog =
            new List<CatalogProduct>()
            {
                new CatalogProduct
                {
                    Id = Guid.NewGuid(),
                    Title = "Bicicleta",
                    MinPrice = 500
                },
                new CatalogProduct
                {
                    Id = Guid.NewGuid(),
                    Title = "Notebook Gamer",
                    MinPrice = 5000
                },
                new CatalogProduct
                {
                    Id = Guid.NewGuid(),
                    Title = "Kindle",
                    MinPrice = 300
                }
            };

        public IEnumerable<CatalogProduct> GetAllAvailableProducts()
        {
            return _catalog;
        }
    }
}
