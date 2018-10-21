using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AwApi.Models;
using AwApi.Services.Products;

namespace AwApi.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AWContext _context;

        public UnitOfWork(AWContext context)
        {
            _context = context;
            Products = new ProductRepository(_context);
        }

        public IProductRepository Products { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
