using System;

namespace NewsPortalLogic
{
    public class New : BaseData
    {
        //public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public DateTime AddingTime { get; set; }
        public string Photo { get; set; }
        public string Author { get; set; }
    }
}
