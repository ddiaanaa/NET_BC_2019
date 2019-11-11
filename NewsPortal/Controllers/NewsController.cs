using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewsPortal.Models;
using NewsPortalLogic;

namespace NewsPortal.Controllers
{
    public class NewsController : Controller
    {
        private NewsManager news;
        private TopicsManager topics;
        public NewsController(NewsManager newsManager, TopicsManager topicsManager)
        {
            news = newsManager;
            topics = topicsManager;
        }
        public IActionResult Index(int id)
        {
            var model = new NewsModel();
            model.Topics = topics.GetTopics();
            model.News = news.Get(id);

            return View(model);
        }
    }
}