using AwApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AwApi.Services.Products
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> GetBestProducts(int count);
    }
}
