using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebShopDescription;

namespace WebShopTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetAllUsers()
        {
            UserManager manager = new UserManager();
            manager.Seed();

            var result = manager.GetAll();

            Assert.AreEqual("Email 1", result[0].Email);
            Assert.AreEqual("Password 1", result[0].Password);
            Assert.AreEqual(2, result.Count);
        }
        [TestMethod]
        public void TestCreateUser()
        {
            UserManager manager = new UserManager();
            User user = manager.Create(new User()
            {
                Email = "Email3",
                Password = "Password3"
            });
            Assert.AreEqual("Email3", user.Email);
            Assert.AreEqual("Password3", user.Password);
            Assert.IsTrue(user.Id > 0);
        }
        [TestMethod]
        public void TestGetUserByEmailAndPassword()
        {
            UserManager manager = new UserManager();
            manager.Seed();
            User user1 = manager.GetByEmail("Email 1");
            User user2 = manager.GetByEmail("Email 2");
            User user3 = manager.GetByEmail("Email 3");

            Assert.AreEqual("Email 1", user1.Email);
            Assert.AreEqual("Password 1", user1.Password);
            Assert.AreEqual("Email 2", user2.Email);
            Assert.AreEqual("Password 2", user2.Password);
            Assert.IsNull(user3);
        }
        [TestMethod]
        public void TestGetUserByEmail()
        {
            UserManager manager = new UserManager();
            manager.Seed();
            User user1 = manager.GetByEmail("Email 1");
            User user2 = manager.GetByEmail("Email 2");
            User user3 = manager.GetByEmail(null);

            Assert.AreEqual("Email 1", user1.Email);
            Assert.AreEqual("Password 1", user1.Password);
            Assert.AreEqual("Email 2", user2.Email);
            Assert.AreEqual("Password 2", user2.Password);
            Assert.IsNull(user3);
        }
        [TestMethod]

        public void TestCreate()
        {
            UserManager manager = new UserManager();
            User user = manager.Create(new User()
            {
                Email = "new email",
                Password = "new password"
            });
            Assert.AreEqual("new email", user.Email);
            Assert.AreEqual("new password", user.Password);
            Assert.IsTrue(user.Id > 0);
        }

        [TestMethod]

        public void TestUpdateUser()
        {
            UserManager manager = new UserManager();
            manager.Seed();

            manager.Update(new User()
            {
                Id = 2,
                Email = "new email"
            });

            var user = manager.GetByEmail("new email");
            Assert.AreEqual(2, user.Id);
            Assert.AreEqual("new email", user.Email);
        }
        [TestMethod]
        public void TestDeleteUser()
        {
            UserManager manager = new UserManager();
            manager.Seed();

            manager.Delete(1);

            var allUsers = manager.GetAll();
            var deleteUser = manager.GetByEmail("Email 1");

            Assert.AreEqual(1, allUsers.Count);
            Assert.IsNull(deleteUser);
        }
        [TestMethod]
        public void TestGetCategories()
         {
             CategoryManager manager = new CategoryManager();
             manager.Seed();

             var result = manager.GetAll();

             Assert.AreEqual("Electronics", result[0].Title);           
             Assert.AreEqual(4, result.Count);
         }
        [TestMethod]
        public void TestGetCategoryById()
        {
            CategoryManager manager = new CategoryManager();
            manager.Seed();

            Category category1 = manager.Get(1);
            Category category2 = manager.Get(2);
            Category category4 = manager.Get(3);
            Category category5 = manager.Get(4);
            Category category3 = manager.Get(5);

            Assert.AreEqual("Electronics", category1.Title);
            Assert.AreEqual("Clothing", category2.Title);
            Assert.AreEqual("Mobile", category4.Title);
            Assert.AreEqual("Men's clothing", category5.Title);
            Assert.IsNull(category3);
        }
        [TestMethod]
        public void TestGetAllItems()
        {
            ItemManager manager = new ItemManager();
            manager.Seed();

            var result = manager.GetAll(); 

            Assert.AreEqual("iPhone 11", result[0].Title);
            Assert.AreEqual("Trousers", result[1].Title);
            Assert.AreEqual(4, result.Count);

        }
        [TestMethod]
        public void TestGetItemByEmail()
        {
            UserManager manager = new UserManager();
            manager.Seed();
            User user1 = manager.GetByEmail("Email 1");
            User user2 = manager.GetByEmail("Email 2");
            User user3 = manager.GetByEmail(null);

            Assert.AreEqual("Email 1", user1.Email);
            Assert.AreEqual("Password 1", user1.Password);
            Assert.AreEqual("Email 2", user2.Email);
            Assert.AreEqual("Password 2", user2.Password);
            Assert.IsNull(user3);
        }
        public void TestCreateUser()
        {
            UserManager manager = new UserManager();
            User user = manager.Create(new User()
            {
                Email = "Email3",
                Password = "Password3"
            });
            Assert.AreEqual("Email3", user.Email);
            Assert.AreEqual("Password3", user.Password);
            Assert.IsTrue(user.Id > 0);
        }
        [TestMethod]
        public void TestGetUserByEmailAndPassword()
        {
            UserManager manager = new UserManager();
            manager.Seed();
            User user1 = manager.GetByEmail("Email 1");
            User user2 = manager.GetByEmail("Email 2");
            User user3 = manager.GetByEmail("Email 3");

            Assert.AreEqual("Email 1", user1.Email);
            Assert.AreEqual("Password 1", user1.Password);
            Assert.AreEqual("Email 2", user2.Email);
            Assert.AreEqual("Password 2", user2.Password);
            Assert.IsNull(user3);
        }
        
        [TestMethod]

        public void TestCreate()
        {
            UserManager manager = new UserManager();
            User user = manager.Create(new User()
            {
                Email = "new email",
                Password = "new password"
            });
            Assert.AreEqual("new email", user.Email);
            Assert.AreEqual("new password", user.Password);
            Assert.IsTrue(user.Id > 0);
        }

        [TestMethod]

        public void TestUpdateUser()
        {
            UserManager manager = new UserManager();
            manager.Seed();

            manager.Update(new User()
            {
                Id = 2,
                Email = "new email"
            });

            var user = manager.GetByEmail("new email");
            Assert.AreEqual(2, user.Id);
            Assert.AreEqual("new email", user.Email);
        }
        [TestMethod]
        public void TestDeleteUser()
        {
            UserManager manager = new UserManager();
            manager.Seed();

            manager.Delete(1);

            var allUsers = manager.GetAll();
            var deleteUser = manager.GetByEmail("Email 1");

            Assert.AreEqual(1, allUsers.Count);
            Assert.IsNull(deleteUser);
        }


    }
}


