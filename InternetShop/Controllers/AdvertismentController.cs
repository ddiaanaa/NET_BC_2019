using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InternetShop.Extensions;
using InternetShop.Models;
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
        public IActionResult NewAdd()//pec noklusejuma get metode
        {
            //var manager = new AdvertismentManager();
            //var newAd = manager.Create(int id, s);
            AdModel model = new AdModel();
            CategoryManager categoryManager = new CategoryManager();
            categoryManager.Seed();

            model.Email = HttpContext.Session.GetUserEmail();
            model.Categories = categoryManager.GetAll();

            return View(model);
        }
        [HttpPost]
        public IActionResult NewAdd(AdModel model)
        {
            if(ModelState.IsValid)
            {
                //TODO: ieraksta saglabāšana
            }
            return View(model);
        }
    }
}