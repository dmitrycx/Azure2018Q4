using AwApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AwApi.Services.Products
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(AWContext context) : base(context)
        {
        }

        public AWContext AWContext => Context as AWContext;

        public IEnumerable<Product> GetBestProducts(int count) => AWContext.Product.OrderByDescending(p => p.StandardCost).Take(count).ToList();
    }
}
