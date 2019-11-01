using System;
using System.Collections.Generic;
using System.Text;

namespace LogicInternetveikals
{
    public class Advertisment
    {
        public int Id { get; set; }
        public string Photo { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Location { get; set; }
        public DateTime AddingTime { get; set; }
        public int Telephone { get; set; }
        public string Email { get; set; }
        public int? CategoryId { get; set; }//jo nullejams var but
    }
}
