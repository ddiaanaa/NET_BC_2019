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
        private CategoryManager _categories;
        private AdvertismentManager _ads;

        public AdvertismentController(CategoryManager categoryManager, AdvertismentManager adManager)
        {
            _categories = categoryManager;
            _ads = adManager;
        }
        public IActionResult Index(int id)
        {
            //var manager = new AdvertismentManager();
            //manager.Seed();
            var ads = _ads.GetAll();
            return View(ads.FindAll(a => a.CategoryId == id));
            //AdListModel model = new AdListModel();
            //{
            //    //sludinājumi kategorijā
            //    var Advertisment = _ads.GetByCategory(id);
            //    //atvērtās kategorijas dati
            //    var Category = _categories.Get(id);
            //};
            //return View(model);
           
        }
        public IActionResult AdDescription(int id)
        {
            //var manager = new AdvertismentManager();
            //manager.Seed();
            var ads = _ads.Get(id);
            return View(ads);

        }
        public IActionResult NewAdd()//pec noklusejuma get metode
        {
            //var manager = new AdvertismentManager();
            //var newAd = manager.Create(int id, s);
            AdModel model = new AdModel();
           //CategoryManager categoryManager = new CategoryManager();
            //categoryManager.Seed();

            model.Email = HttpContext.Session.GetUserEmail();
            model.Categories = _categories.GetAll();

            return View(model);
        }
        [HttpPost]
        public IActionResult NewAdd(AdModel model)
        {
            model.Categories = _categories.GetAll();//post pieprasījuma velreiz japielasa kategorijas (kaut kadi dati get pieprasijuma, japievieno manuali pasiem)
           
            if (ModelState.IsValid)
            {
                //or var ad = new Ad(){}; _ads.Create(ad);
                _ads.Create(new LogicInternetveikals.Advertisment()
                {
                    Title = model.Title,
                    Description = model.Description,
                    Price = model.Price,
                    Location = model.Location,
                    AddingTime = DateTime.Now,
                    Telephone = model.Telephone,
                    Email = model.Email,
                    CategoryId = model.CategoryId
                });
               //TempData["message"] = "New advertisment created"; //kur var pievienot sludinājumu,jūs esat veiksm
                return RedirectToAction(nameof(Index), new {id =model.CategoryId });//? kas ir nameof?
            }            
                return View(model);
                    
 
        }
    }
}