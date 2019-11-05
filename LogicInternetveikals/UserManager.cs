using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace LogicInternetveikals
{
    public class UserManager: BaseManager<User>
    {
        //private int currentId;
        //private static List<User> Users = new List<User>();//statisks neatkarigi no ta cik mums user manager klases, sis saraksts paliek 
        public UserManager(InternetShopDB db): base(db)
        {
            //currentId = 1;
        }
        protected override DbSet<User> Table
        {
            get
            {
                return _db.Users;
            }

        }        
             //public List<User> GetAll()
        //{
        //    return Users;
        //}
        public User GetByEmailAndPassword(string email, string password)
        {
            var user = Table.FirstOrDefault(u => u.Email == email && u.Password == password);
            return user;
        }
        public User GetByEmail(string email)
        {
            var user = Table.FirstOrDefault(u => u.Email == email);
            return user;
        }
        //public User Create(User user)
        //{
        //    user.Id = currentId;
        //    Users.Add(user);
        //    currentId++;

        //    return user;
        //}
        //public void Delete(int id)
        //{
        //    var user = Users.Find(u => u.Id == id);
        //    Users.Remove(user);
        //}

        //public void Update(User user)
        //{
        //    var currentUser = Users.Find(u => u.Id == user.Id);
        //    currentUser.Email = user.Email;
        //    currentUser.Id = user.Id;
        //}
        ////STUB data
        ////dummy data
        public void Seed()
        {
           
        }
    }
}
