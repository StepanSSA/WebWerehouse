using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebWerehouse.Abstract;
using WebWerehouse.Domains;
using WebWerehouse.Models;

namespace WebWerehouse.Controllers
{
    public class TableController : Controller
    {
        private readonly IProductCRUDRepository _repo;
        private int _pageSize = 3;

        public TableController(IProductCRUDRepository repo )
        {
            _repo = repo;
        }

        public IActionResult TableProducts(int page = 1)
        {
            return View(_repo.Products);
        }


        public IActionResult Edit(long Id)
        {
            var product = _repo
                .Products
                .FirstOrDefault(p => p.Id == Id);

            if (product == null) return View("Error");

            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            
            if (ModelState.IsValid)
            {
                var p = _repo.Products.FirstOrDefault(p => p.Id == product.Id);
                var PrevQuantity = p.Quantity;

                if (PrevQuantity < product.Quantity)
                {
                    if (User.IsInRole("manager"))
                    {
                        var difference = product.Quantity - PrevQuantity;
                        product.Sold -= difference;
                        _repo.Update(product);
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        var difference = product.Quantity - PrevQuantity;
                        product.Created += difference;
                        _repo.Update(product);
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    if (User.IsInRole("manager"))
                    {
                        var difference = PrevQuantity - product.Quantity;
                        product.Sold += difference;
                        _repo.Update(product);
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        _repo.Update(product);
                        return RedirectToAction("Index", "Home");
                    }
                }
            }
            return RedirectToAction("Error");
        }

        public IActionResult Create()
        {
            var product = new Product();
            return View(product);
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _repo.Create(product);
                return RedirectToAction("Index", "Home");
            }
            return View("Error");
        }
    }
}
