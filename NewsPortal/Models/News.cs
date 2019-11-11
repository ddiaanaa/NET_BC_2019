using NewsPortalLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsPortal.Models
{
    public class NewsModel
    {
        public New News { get; set; }        

        public List<Topic> Topics { get; set; }
    }
}
