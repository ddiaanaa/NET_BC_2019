using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebShop.Models;
using WebShopDescription;

namespace WebShop.Controllers // sesija ir lietotaja darbibas noteikta laika spridi, maksimums 1 sunda internetbanka 5 minimums
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
        public IActionResult Buy(int id)
        {
            var manager = new ItemManager();
            manager.Seed();
            var item = manager.Get();
            var basket = HttpContext.Session.GetUserBasket();
            if (basket == null)
            {
                basket = new List<int>();
            }
            basket.Add(id);
            HttpContext.Session.SetUserBasket(basket);
            return RedirectToAction("Index", "Item", new { id = item.CategoryId });

        }
        public IActionResult Basket()
        {
            var basket = HttpContext.Session.GetUserBasket();
            List<Item> items = new List<Item>();

            if (basket != null)
            {
                var manager = new ItemManager();
                manager.Seed();
                foreach (var id in basket)
                {
                    items.Add(manager.Get(id));
                }

            }

            return View(items);// šim tipam ir jāsakrīt ar to, ko mēs padodam uz view un definējam augšpusē
            //define jaunu sarakstu precēm;
            //Par katru preci, kas ir lietotāja sesijā atlasa tās datus un pievieno sarakstam
            //Atgriež preču sarakstu uz View;
        }
        public IActionResult Delete()
        {

        }
    }
}