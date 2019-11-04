using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicInternetveikals
{
    public class CategoryManager: BaseManager<Category>
    {
       
        public class CategoryManager(InternetShopDB db): base(db)
        {
           // Categories = new List<Category>();
           // currentId = 1;
        }    
    protected override DbSet<Category>Table
    {
        get
        {
            return _db.Categories;
        }
    }    
        public void Seed()
        {
        }
    }
}
