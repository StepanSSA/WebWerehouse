using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebWerehouse.Domains
{
    public class Сhemistry
    {
        public int Id { get; set; }
        [Display(Name = "Название")]
        public string Name { get; set; }
        [Display(Name = "Количество(штук)")]
        public int Quantity { get; set; }
        [Display(Name = "Цена")]
        public int Price { get; set; }
        [Display(Name = "Размер")]
        public string Size { get; set; }
    }
}
