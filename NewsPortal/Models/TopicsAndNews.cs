using NewsPortalLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsPortal.Models
{
    public class TopicsAndNews
    {
        public New New { get; set; }
        public List<New> News { get; set; }
        public List<Topic> Topics { get; set; }
        public int ActiveCategoryId {get; set;}
       
        
    }
}
