using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopDescription
{
    public class UserManager
    {
        private int currentId;
        private List<User> Users;
        public UserManager()
        {
            Users = new List<User>();
            currentId = 1;
        }
        public List<User> GetAll()
        {
            return Users;
        }
        public User GetByEmailAndPassword(int id, string password)
        {
            var user = Users.Find(u => u.Id == id && u.Password ==password);
            return user;
        }
        public User GetByEmail(string email)
        {
            var user = Users.Find(u => u.Email == email);
            return user;
        }
        public User Create(User user)
        {
            user.Id = currentId;
            Users.Add(user);
            currentId++;

            return user;
        }
        public void Delete(int id)
        {
            var user = Users.Find(u => u.Id == id);
            Users.Remove(user);
        }
       
        public void Update(User user)
        {
            var currentUser = Users.Find(u => u.Id == user.Id);
            currentUser.Email = user.Email;
            currentUser.Id = user.Id;
        }
        //STUB data
        //dummy data
        public void Seed()
        {
            Users.Add(new User()
            {
                Id = 1,
                Email = "Email 1",
                Password = "Password 1"

            });
            Users.Add(new User()
            {
                Id = 2,
                Email = "Email 2",
                Password = "Password 2"
            });
        }
    }
}
