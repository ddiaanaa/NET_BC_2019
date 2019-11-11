using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicInternetveikals
{
    public class CategoryManager : BaseManager<Category>
    {

        public CategoryManager(InternetShopDB db) : base(db)
        {
            // Categories = new List<Category>();
            // currentId = 1;
        }
        protected override DbSet<Category> Table
        {
            get
            {
                return _db.Categories;
            }
        }
        public List<Category> GetAllWithAdvertismentCount()
        {
            var categories = Table.ToList();
            categories.ForEach(c =>
            {
                c.AdvertismentCount = _db.Advertisments.Count(a => a.CategoryId == c.Id);
            });
            return categories;
        }
        public void Seed()
        {
        }
    }

}