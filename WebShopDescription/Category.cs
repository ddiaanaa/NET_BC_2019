using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopDescription
{
    class Category
    {
        public int Id { get; set; }       
        public string Title { get; set; }      
        public int? CategoryId { get; set; }//jo nullejams var but
    }
}
