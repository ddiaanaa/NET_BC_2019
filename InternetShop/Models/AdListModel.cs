using LogicInternetveikals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetShop.Models
{
    public class AdListModel
    {
        public List<Advertisment> Ads { get; set; }
        public Category Category { get; set; }

    }
}
