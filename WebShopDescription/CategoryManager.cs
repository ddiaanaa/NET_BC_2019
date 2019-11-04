using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebShopDescription
{
    public class CategoryManager :BaseManager<Category>
    {
       // WebShopDB _db; // liek apakšsvītru ja privāta piekļuve, tiek definēts mainīgais klases ietvaros, ko var izmantot citās klasēs
        public CategoryManager(WebShopDB db): base(db)//parametrā saņemam klasi, ko izveidojām, un kas atbilst datubāzes shēmai
        {
            //_db = db;
       
        }
        protected override DbSet<Category> Table
        {
            get
            {
                return _db.Categories;
            }
        }

        //public List<Category> GetAll()//vai atgriez tik  kategorijy cik ievadijam
        //{
        //    return _db.Categories.ToList();
        //}
        //public Category Get(int id)//vai atgriez tik daudz precu cik esam definejusi 2 parbaudes ar esosu kategoriju un neesosu
        //{
        //    var category = _db.Categories.FirstOrDefault(c => c.Id == id);
        //    return category;
        //}        
        public void Seed()
        {

        }
    }
}
