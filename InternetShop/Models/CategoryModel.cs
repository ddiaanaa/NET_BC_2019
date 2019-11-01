using LogicInternetveikals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetShop.Models
{
    public class CategoryModel
    {
        public List<Category> Categories { get; set; }
        public List<Advertisment> Ads { get; set; }
    }
}
