using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebWerehouse.Domains;
using WebWerehouse.Models;

namespace WebWerehouse.Abstract
{
    public interface IProductCRUDRepository : IProductRepository
    {
        void Create(Product product);

        void Create(Сhemistry сhemistry);

        void Update(Product product);

        void Update(Сhemistry сhemistry);
    }
}
