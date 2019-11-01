using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LogicInternetveikals;
using Microsoft.AspNetCore.Mvc;

namespace InternetShop.Controllers
{
    public class AdvertismentController : Controller
    {
        public IActionResult Index(int id)
        {
            var manager = new AdvertismentManager();
            manager.Seed();
            var ads = manager.GetAll();
            return View(ads.FindAll(a => a.CategoryId == id));
           
        }
        public IActionResult AdDescription(int id)
        {
            var manager = new AdvertismentManager();
            manager.Seed();
            var ads = manager.Get(id);
            return View(ads);

        }
    }
}