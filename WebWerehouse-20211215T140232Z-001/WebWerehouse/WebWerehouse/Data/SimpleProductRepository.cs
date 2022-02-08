using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebWerehouse.Abstract;
using WebWerehouse.Domains;

namespace WebWerehouse.Data
{
    public class SimpleProductRepository : IProductRepository
    {
        public IQueryable<Product> Products =>
            new List<Product>()
            {
                new Product()
                {
                    Name = "Гель",
                    Price = 150,
                    Quantity = 740,
                    Size = "250мл",
                    Sold = 100,
                    Created = 840
                },
                new Product()
                {
                    Name = "Шампунь",
                    Price = 150,
                    Quantity = 740,
                    Size = "250мл",
                    Sold = 100,
                    Created = 840
                },
                new Product()
                {
                    Name = "Шампунь - пенка",
                    Price = 100,
                    Quantity = 640,
                    Size = "250мл",
                    Sold = 200,
                    Created = 840
                },
                new Product()
                {
                    Name = "гель - пенка",
                    Price = 100,
                    Quantity = 640,
                    Size = "250мл",
                    Sold = 200,
                    Created = 840
                }
            }.AsQueryable();

        public IQueryable<Сhemistry> Chemistres =>
            new List<Сhemistry>()
            {
                new Сhemistry()
                {
                    Name = "Гель",
                    Price = 150,
                    Quantity = 740,
                    Size = "250мл",
                },
                new Сhemistry()
                {
                    Name = "E342",
                    Price = 150,
                    Quantity = 740,
                    Size = "250мл"
                },
                new Сhemistry()
                {
                    Name = "#567",
                    Price = 100,
                    Quantity = 640,
                    Size = "250мл"
                },
                new Сhemistry()
                {
                    Name = "E843",
                    Price = 100,
                    Quantity = 640,
                    Size = "250мл"
                }
            }.AsQueryable();
    }
}
