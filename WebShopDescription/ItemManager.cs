using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopDescription
{
    public class ItemManager
    {
        private int currentId;
        private List<Item> Items;
        public ItemManager()
        {
            Items = new List<Item>();
            currentId = 1;
        }
        public List<Item> GetAll()
        {
            return Items;
        }
        public List<Item> GetByCategory(int categoryId)
        {
            var items = Items.FindAll(i => i.CategoryId == categoryId);
            return items;
        }        
        public Item Create(Item item)
        {
            item.Id = currentId;
            Items.Add(item);
            currentId++;

            return item;
        }
        public void Delete(int id)
        {
            var item = Items.Find(u => u.Id == id);
            Items.Remove(item);
        }

        public void Update(Item item)
        {
            var currentItem = Items.Find(u => u.Id == item.Id);
            currentItem.Title = item.Title;
            currentItem.Photo = item.Photo;
            currentItem.CategoryId = item.CategoryId;
            currentItem.Description = item.Description;
            currentItem.Price = item.Price;
        }
        //STUB data
        //dummy data
        public void Seed()
        {
            Items.Add(new Item()
            {
                Id = 1,
                Title = "iPhone 11",
                Price = 1200.0m,
                Description = "new iPhone",
                CategoryId = 3

            });
            Items.Add(new Item()
            {
                Id = 2,
                Title = "Trousers",
                Price = 50.0m,
                Description = "Black, L size",
                CategoryId = 4
            });
            Items.Add(new Item()
            {
                Id = 3,
                Title = "Samsung Galaxy",
                Price = 900.0m,
                Description = "new Phone",
                CategoryId = 3
            });
            Items.Add(new Item()
            {
                Id = 4,
                Title = "Tshirt",
                Price = 20.0m,
                Description = "new TShirt, white, S small",
                CategoryId = 4
            });
        }

    }
}

