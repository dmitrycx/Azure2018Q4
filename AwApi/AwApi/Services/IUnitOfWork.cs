using AwApi.Services.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AwApi.Services
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository Products { get; }
        int Complete();
    }
}
