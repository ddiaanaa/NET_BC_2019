using System;
using System.Collections.Generic;
using System.Text;

namespace LogicInternetveikals
{
    public class CategoryManager
    {
        private int currentId;
        private List<Category> Categories;
        public CategoryManager()
        {
            Categories = new List<Category>();
            currentId = 1;
        }
        public List<Category> GetAll()//vai atgriez tik  kategoriju cik ievadijam
        {
            return Categories;
        }
        public Category Get(int id)//vai atgriez tik daudz precu cik esam definejusi 2 parbaudes ar esosu kategoriju un neesosu kategoriju
        {
            var category = Categories.Find(c => c.Id == id);
            return category;
        }
        public void Seed()
        {
            Categories.Add(new Category()
            {
                Id = 1,
                Title = "Electronics"         

            });
            Categories.Add(new Category()
            {
                Id = 2,
                Title = "Clothing",
            });
            Categories.Add(new Category()
            {
                Id = 3,
                Title = "Kids",
            });
            Categories.Add(new Category()
            {
                Id = 4,
                Title = "Books",
            }); 
            Categories.Add(new Category()
            {
                Id = 5,
                Title = "Mobile telephones",
                CategoryId = 1
            });
            Categories.Add(new Category()
            {
                Id = 14,
                Title = "Computers",
                CategoryId = 1
            });

            Categories.Add(new Category()
            {
                Id = 6,
                Title = "Men's clothing",
                CategoryId = 2
            });

            Categories.Add(new Category()
            {
                Id = 7,
                Title = "Women's clothing",
                CategoryId = 2
            });
            Categories.Add(new Category()
            {
                Id = 8,
                Title = "Kid's clothing",
                CategoryId = 2
            });
            Categories.Add(new Category()
            {
                Id = 9,
                Title = "Toys",
                CategoryId = 3
            });
            Categories.Add(new Category()
            {
                Id = 10,
                Title = "Games",
                CategoryId = 3
            });
            Categories.Add(new Category()
            {
                Id = 11,
                Title = "Classic",
                CategoryId = 4
            });
            Categories.Add(new Category()
            {
                Id = 12,
                Title = "Education",
                CategoryId = 4
            });
            Categories.Add(new Category()
            {
                Id = 13,
                Title = "Novels",
                CategoryId = 4
            });


        }
    }
}
