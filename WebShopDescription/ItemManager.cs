using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebShopDescription
{
    public class ItemManager : BaseManager<Item>
    {       
        
        public ItemManager(WebShopDB db):base(db)
        {           
           
        }
        protected override DbSet<Item> Table
        {
            get
            {
                return _db.Items;
            }
        }
        //public List<Item> GetAll()
        //{
        //    return _db.Items.ToList();
        //}
        public List<Item> GetByCategory(int categoryId)
        {
            var items = _db.Items.Where(i => i.CategoryId == categoryId).ToList();
            return items;
        }        
        //public Item Create(Item item)
        //{
        //    _db.Items.Add(item);
        //    _db.SaveChanges();

        //    return item;
        //}
        //public void Delete(int id)
        //{
        //    var item = _db.Items.FirstOrDefault(i => i.Id == id);
        //    _db.Items.Remove(item);
        //    _db.SaveChanges();
        //}

        //public void Update(Item item)
        //{
        //    var currentItem = _db.Items.FirstOrDefault(u => u.Id == item.Id);
        //    currentItem.Title = item.Title;
        //    currentItem.Photo = item.Photo;
        //    currentItem.CategoryId = item.CategoryId;
        //    currentItem.Description = item.Description;
        //    currentItem.Price = item.Price;
        //    _db.SaveChanges();
        //}
        ////STUB data
        ////dummy data
        //public Item Get(int id)
        //{
        //    Item item = _db.Items.FirstOrDefault(u => u.Id == id);
        //    return item;
        //}
        public void Seed()
        {
        }

    }
}

