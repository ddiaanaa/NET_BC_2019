using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LogicInternetveikals
{
    public class Category: BaseData
    {
        //public int Id { get; set; }
        public string Title { get; set; }       
        public int? CategoryId { get; set; }//jo nullejams var but
        //virtuālā īpašība - sludinājumu skaits kategorijā
        [NotMapped]
        public int AdvertismentCount { get; set; }
    }    
}
