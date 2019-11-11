using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LogicInternetveikals;
using Microsoft.AspNetCore.Mvc;

namespace InternetShop.Controllers
{
    public class CategoryController : Controller
    {
        private CategoryManager _categories;
        private AdvertismentManager _advertisments;

        public CategoryController(CategoryManager categoryManager, AdvertismentManager advertismentManager)
        {
            _categories = categoryManager;
            _advertisments = advertismentManager;
        }
        public IActionResult Index()
        {
               // var manager = new CategoryManager();
                //manager.Seed();
                //var items = manager.GetAll();
                var categories = _categories.GetAllWithAdvertismentCount();
            //sludinājumi kategorijā
            //   var Advertisment = _ads.GetByCategory(id);
            //    //atvērtās kategorijas dati
            //    var Category = _categories.Get(id);


            return View(categories);
            }      
    }
}