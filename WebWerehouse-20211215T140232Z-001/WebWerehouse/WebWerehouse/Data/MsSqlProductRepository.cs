using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebWerehouse.Abstract;
using WebWerehouse.Domains;

namespace WebWerehouse.Data
{
    public class MsSqlProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;


        public MsSqlProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IQueryable<Product> Products => _context.Products;

        public IQueryable<Сhemistry> Chemistres => _context.Сhemistry;
    }
}
