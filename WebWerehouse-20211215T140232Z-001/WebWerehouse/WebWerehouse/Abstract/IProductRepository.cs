using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebWerehouse.Domains;
using WebWerehouse.Models;

namespace WebWerehouse.Abstract
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }
        IQueryable<Сhemistry> Chemistres { get; }
    }
}
