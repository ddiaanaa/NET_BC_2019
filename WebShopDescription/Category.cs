using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopDescription
{
    public class Category : BaseData
    {
        //public int Id { get; set; }       
        public string Title { get; set; }      
        public int? CategoryId { get; set; }//jo nullejams var but
        [NotMapped] //virtuāla kolonna-preču skaits
        public int ItemCount { get; set; }
    }
}
