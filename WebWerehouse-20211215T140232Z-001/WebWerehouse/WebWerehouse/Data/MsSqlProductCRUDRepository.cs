using WebWerehouse.Abstract;
using WebWerehouse.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebWerehouse.Data
{
    public class MsSqlProductCRUDRepository : IProductCRUDRepository
    {
        private readonly ApplicationDbContext _context;


        public MsSqlProductCRUDRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IQueryable<Product> Products => _context.Products;
        public IQueryable<Сhemistry> Chemistres => _context.Сhemistry;

        public void Create(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void Create(Сhemistry сhemistry)
        {
            _context.Сhemistry.Add(сhemistry);
            _context.SaveChanges();
        }

        public void Update(Product product)
        {
            var entity = _context.Products.Find(product.Id);
            _context.Entry(entity).CurrentValues.SetValues(product);
            _context.SaveChanges();
        }

        public void Update(Сhemistry сhemistry)
        {
            var entity = _context.Сhemistry.Find(сhemistry.Id);
            _context.Entry(entity).CurrentValues.SetValues(сhemistry);
            _context.SaveChanges();
        }
    }
}
