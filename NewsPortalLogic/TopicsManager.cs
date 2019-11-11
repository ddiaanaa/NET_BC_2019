using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewsPortalLogic
{
    public class TopicsManager : BaseManager<Topic>
    {
        public TopicsManager(NewsPortalDB db) : base(db)
        {
           
        }
        protected override DbSet<Topic> Table
        {
            get
            {
                return _db.Topics;
            }
        }
        public List<Topic> GetTopics()
        {
            var topics = Table.ToList();
            return topics;
        }
    }
}
