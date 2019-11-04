﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebShop.Models;
using WebShopDescription;

namespace WebShop.Controllers
{
    public class AccountController : Controller
    {
        private UserManager _users;     

        public AccountController(UserManager userManager)
        {
            _users = userManager;       
        }

        public IActionResult SignIn()
        {
            return View();
        }
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(UserModel model)
        {
            if(ModelState.IsValid)
            {
                
                if(_users.GetByEmail(model.Email)!=null)
                {
                    ModelState.AddModelError("error", "Email already exists!");
                }
                else
                {
                    _users.Create(new WebShopDescription.User()
                    {
                        Email=model.Email,
                        Password=model.Password,
                    });
                    TempData["message"] = "Account created";
                    return RedirectToAction("SignIn");

                }
                
            }
            
            return View();
        }
        [HttpPost]
        public IActionResult SignIn(UserSignInModel model)
        {
            if (ModelState.IsValid)
            {             
                
                var user = _users.GetByEmailAndPassword(model.Email, model.Password);
                if (user != null)
                {
                    HttpContext.Session.SetInt32("userId", user.Id);
                    HttpContext.Session.SetUserEmail(user.Email);

                    TempData["message"] = "You have succesfully loged in";
                    return RedirectToAction("index", "item");
                }
                else
                {
                    ModelState.AddModelError("error", "Invalid email/password!");

                }

            }

            return View();
        }
        public IActionResult SignOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Item");
        }
    }
}