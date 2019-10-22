using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebShop.Models;
using WebShopDescription;

namespace WebShop.Controllers
{
    public class ItemController : Controller
    {
        public IActionResult Index(int Id)
        {
            var manager = new ItemManager();
            manager.Seed();
            //var items = manager.GetAll();
            var items = manager.GetByCategory(Id);

            var managerCat = new CategoryManager();
            managerCat.Seed();
            var categories = managerCat.GetAll();
            var model = new CatalogModel()
            {
                Items = items,
                Categories = categories
            };

            return View(model);
        }
    }
}