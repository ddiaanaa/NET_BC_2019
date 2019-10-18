using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopDescription
{
    class CategoryManager
    {
        private int currentId;
        private List<Category> Categories;
        public CategoryManager()
        {
            Categories = new List<Category>();
            currentId = 1;
        }
        public List<Category> GetAll()//vai atgriez tik  kategorijy cik ievadijam
        {
            return Categories;
        }
        public Category Get(int id)//vai atgriez tik daudz precu cik esam definejusi 2 parbaudes ar esosu kategoriju un neesosu
        {
            var category = Categories.Find(c => c.Id == id);
            return category;
        }
        public void Seed()
        {
            Categories.Add(new Category()
            {
                Id = 1,
                Title = "Electronics",                

            });
            Categories.Add(new Category()
            {
                Id = 2,
                Title = "Clothing",                
            });
            Categories.Add(new Category()
            {
                Id = 3,
                Title = "Mobile",
                CategoryId = 1
            });
            Categories.Add(new Category()
            {
                Id = 4,
                Title = "Men's clothing",
                CategoryId=2
            });
        }
    }
}
