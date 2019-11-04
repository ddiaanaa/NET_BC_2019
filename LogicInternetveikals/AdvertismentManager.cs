using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicInternetveikals
{
    public class AdvertismentManager :BaseManager<Advertisment>
    {
        //private int currentId;
        //private List<Advertisment> Ads;
            public AdvertismentManager(InternetShopDB db): 
            base(db)
            {
                //Ads = new List<Advertisment>();
                //currentId = 1;
            }
            protected override DbSet<Advertisment>Table
            {
                get
                {
                    return _db.Advertisments;
                }
            }
    //public List<Advertisment> GetAll()
    //{
    //    return Ads;
    //}
    public List<Advertisment> GetByCategory(int categoryId)
            {
                var ads = _db.Ads.Where(i => i.CategoryId == categoryId).ToList();
                return ads;
            }
            //public Advertisment Create(Advertisment ads)
            //{
            //    ads.Id = currentId;
            //    Ads.Add(ads);
            //    currentId++;

            //    return ads;
            //}
            //public void Delete(int id)
            //{
            //    var ads = Ads.Find(u => u.Id == id);
            //    Ads.Remove(ads);
            //}

            //public void Update(Advertisment ads)
            //{
            //    var currentAds = Ads.Find(u => u.Id == ads.Id);
            //    currentAds.Title = ads.Title;
            //    currentAds.Photo = ads.Photo;
            //    currentAds.CategoryId = ads.CategoryId;
            //    currentAds.Description = ads.Description;
            //    currentAds.Price = ads.Price;
            //    currentAds.Location = ads.Location;
            //    currentAds.AddingTime = ads.AddingTime;
            //    currentAds.Telephone = ads.Telephone;
            //    currentAds.Email = ads.Email;
            //}
            ////STUB data
            ////dummy data
            public Advertisment Get(int id)
            {
                Advertisment ads = _db.Items.FirstOrDefault(u => u.Id == id);
                return ads;
            }
        public void Seed()
        {
            //Ads.Add(new Advertisment()
            //{
            //    Id = 1,
            //    Photo = "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/MWYK2?wid=2000&hei=2000&fmt=jpeg&qlt=80&op_usm=0.5,0.5&.v=1567304928359",
            //    Title = "iPhone 11",
            //    Price = 1200.0m,
            //    Description = "new iPhone",
            //    Location = "Riga",
            //    AddingTime = DateTime.Now,
            //    Telephone = 28842088,
            //    Email = "info@internetshop.lv",
            //    CategoryId = 5

            //});
            //Ads.Add(new Advertisment()
            //{
            //    Id = 2,
            //    Photo = "http://www.three.co.uk/static/images/device_pages/MobileVersion/Samsung/Galaxy_S10/Prism_Black/carousel/1.jpg",
            //    Title = "Samsung Galaxy",
            //    Price = 900.0m,
            //    Description = "new Samsung telephone",
            //    Location = "Riga",
            //    AddingTime = DateTime.Now,
            //    Telephone = 28842088,
            //    Email = "info@internetshop.lv",
            //    CategoryId = 5

            //});
            //Ads.Add(new Advertisment()
            //{
            //    Id = 3,
            //    Photo = "https://www.customcuero.es/5330-big_default_2x/mens-jeans-bycity-tejano-ii-black.jpg",
            //    Title = "Trousers",
            //    Price = 70.0m,
            //    Description = "M size, black color",
            //    Location = "Riga",
            //    AddingTime = DateTime.Now,
            //    Telephone = 28842088,
            //    Email = "info@internetshop.lv",
            //    CategoryId = 6

            //});
            //Ads.Add(new Advertisment()
            //{
            //    Id = 4,
            //    Photo = "http://stylowoshop.com/1795-thickbox_default/pleated-skirt-flared-in-navy-blue.jpg",
            //    Title = "Skirt",
            //    Price = 50.0m,
            //    Description = "S size, navy blue",
            //    Location = "Riga",
            //    AddingTime = DateTime.Now,
            //    Telephone = 28842088,
            //    Email = "info@internetshop.lv",
            //    CategoryId = 7

            //});
            //Ads.Add(new Advertisment()
            //{
            //    Id = 5,
            //    Photo = "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/mbp13touch-space-select-201807?wid=892&hei=820&&qlt=80&.v=1529520060550",
            //    Title = "MacBook Pro",
            //    Price = 1500.0m,
            //    Description = "new computer",
            //    Location = "Riga",
            //    AddingTime = DateTime.Now,
            //    Telephone = 28842088,
            //    Email = "info@internetshop.lv",
            //    CategoryId = 14

            //});
            //Ads.Add(new Advertisment()
            //{
            //    Id = 6,
            //    Photo = "https://consumer.huawei.com/content/dam/huawei-cbg-site/common/mkt/list-image/pc/matebook-x-pro-2019/matebookxpro2019-grey.png",
            //    Title = "Huawei",
            //    Price = 800.0m,
            //    Description = "new computer",
            //    Location = "Riga",
            //    AddingTime = DateTime.Now,
            //    Telephone = 28842088,
            //    Email = "info@internetshop.lv",
            //    CategoryId = 14

            //});
        }
        }

