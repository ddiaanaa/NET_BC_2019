using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewsPortal.Models;
using NewsPortalLogic;

namespace NewsPortal.Controllers
{
    public class TopicsController : Controller
    {
        private TopicsManager _topics;
        private NewsManager _news;
        public TopicsController(TopicsManager topicsManager, NewsManager newsManager)
        {
            _topics = topicsManager;
            _news = newsManager;
        }
        public IActionResult Index(int id)
        {
            if(id==0)
            {
                id = 1;
            }
            var model = new TopicsAndNews();
            model.Topics = _topics.GetTopics();
            model.News = _news.GetByCategory(id);
            model.ActiveCategoryId = id;
           
            return View(model);
        }
    }
}