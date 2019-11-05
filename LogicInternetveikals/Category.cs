using System;
using System.Collections.Generic;
using System.Text;

namespace LogicInternetveikals
{
    public class Category: BaseData
    {
        //public int Id { get; set; }
        public string Title { get; set; }       
        public int? CategoryId { get; set; }//jo nullejams var but
    }    
}
