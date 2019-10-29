using System;
using System.Collections.Generic;
using System.Text;

namespace LogicInternetveikals
{
    public class AdvertismentManager
    {
        private int currentId;
        private List<Advertisment> Ads;
            public AdvertismentManager()
            {
                Ads = new List<Advertisment>();
                currentId = 1;
            }
            public List<Advertisment> GetAll()
            {
                return Ads;
            }
            public List<Advertisment> GetByCategory(int categoryId)
            {
                var ads = Ads.FindAll(i => i.CategoryId == categoryId);
                return ads;
            }
            public Advertisment Create(Advertisment ads)
            {
                ads.Id = currentId;
                Ads.Add(ads);
                currentId++;

                return ads;
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
            public Item Get(int id)
            {
                Item item = Items.Find(u => u.Id == id);
                return item;
            }
        public void Seed()
        {
            Ads.Add(new Advertisment()
            {
                Id = 1,
                Photo = "",
                Title = "iPhone 11",
                Price = 1200.0m,
                Description = "new iPhone",
                Location = "Riga",
                AddingTime = DateTime.Now,
                Telephone = 28842088,
                Email = "info@internetshop.lv",
                CategoryId = 5

            });
            Ads.Add(new Advertisment()
            {
                Id = 2,
                Photo = "",
                Title = "Samsung Galaxy",
                Price = 900.0m,
                Description = "new Samsung telephone",
                Location = "Riga",
                AddingTime = DateTime.Now,
                Telephone = 28842088,
                Email = "info@internetshop.lv",
                CategoryId = 5

            });
            Ads.Add(new Advertisment()
            {
                Id = 3,
                Photo = "",
                Title = "Trousers",
                Price = 70.0m,
                Description = "M size, black color",
                Location = "Riga",
                AddingTime = DateTime.Now,
                Telephone = 28842088,
                Email = "info@internetshop.lv",
                CategoryId = 6

            });
            Ads.Add(new Advertisment()
            {
                Id = 4,
                Photo = "",
                Title = "Skirt",
                Price = 50.0m,
                Description = "S size, navy blue",
                Location = "Riga",
                AddingTime = DateTime.Now,
                Telephone = 28842088,
                Email = "info@internetshop.lv",
                CategoryId = 7

            });
            Ads.Add(new Advertisment()
            {
                Id = 5,
                Photo = "",
                Title = "MacBook Pro",
                Price = 1500.0m,
                Description = "new computer",
                Location = "Riga",
                AddingTime = DateTime.Now,
                Telephone = 28842088,
                Email = "info@internetshop.lv",
                CategoryId = 6

            });
            Ads.Add(new Advertisment()
            {
                Id = 1,
                Photo = "",
                Title = "Huawei",
                Price = 800.0m,
                Description = "new computer",
                Location = "Riga",
                AddingTime = DateTime.Now,
                Telephone = 28842088,
                Email = "info@internetshop.lv",
                CategoryId = 6

            });
        }
        }
}
