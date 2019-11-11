using LogicInternetveikals;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternetShop.Models
{
    public class AdModel
    {
        public int Id { get; set; }
      
        public string Photo { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string Location { get; set; }
        public DateTime AddingTime { get; set; }
        [Required]
        public string Telephone { get; set; }
        public string Email { get; set; }
        public int? CategoryId { get; set; }//jo nullejams var but
        

        public List<Category> Categories { get; set; }
    }
}
