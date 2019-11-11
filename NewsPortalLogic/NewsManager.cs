using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewsPortalLogic
{
    public class NewsManager :BaseManager<New>
    {
        public NewsManager(NewsPortalDB db) : base(db)          
        {
            // Categories = new List<Category>();
            // currentId = 1;
        }
        protected override DbSet<New> Table//=>_db.News
        {
            get
            {
                return _db.News;
            }
        }
        public List<New> GetByCategory(int CategoryId)
        {
            var news = Table.Where(i => i.CategoryId == CategoryId).OrderByDescending(i => i.AddingTime).Take(10).ToList();
            return news;
        }
        public List<New> GetLatest()
        {
            var news = Table.OrderByDescending(i => i.AddingTime).Take(10).ToList();//funkcija, kas atgriez velakas zinas
            return news;
        }
        public New Get(int id)
        {
            New newsInfo = _db.News.FirstOrDefault(u => u.Id == id);
            return newsInfo;
        }
    }
}
