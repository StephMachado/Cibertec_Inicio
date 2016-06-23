using System;
using System.Collections.Generic;
using System.Linq;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class ProductData: BaseDataAccess<Product>
    {
        public Product GetProduct(int id)
        {
            using (var dbContext = new WebContextDb())
            {
                return dbContext.Products.FirstOrDefault(x => x.Id == id);
            }
        }

        public List<Product> GetFakeProducts()
        {
            return new List<Product>
            {
                new Product {Id=1, Description="Cristal", Price=3.0, Date = DateTime.Now},
                new Product {Id=2, Description="Pilsen", Price=0.0, Date = null}
            };
        }
    }
}
