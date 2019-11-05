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

        public CategoryController(CategoryManager categoryManager)
        {
            _categories = categoryManager;
        }
        public IActionResult Index()
        {
               // var manager = new CategoryManager();
                //manager.Seed();
                //var items = manager.GetAll();
                var categories = _categories.GetAll();               
                
                return View(categories);
            }      
    }
}