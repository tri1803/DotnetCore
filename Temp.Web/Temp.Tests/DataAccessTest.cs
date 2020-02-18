using Microsoft.EntityFrameworkCore;
using Temp.DataAccess.Data;
using System;
using System.Collections.Generic;

namespace Temp.Tests
{
    public class DataAccessTest
    {
        public DataAccessTest()
        {
            var buider = new DbContextOptionsBuilder<DataContext>();
            buider.UseInMemoryDatabase(Guid.NewGuid().ToString());
            var options = buider.Options;
            
            ApplicationDbContext = new DataContext(options);
            var users = new List<User>
            {
                new User{Id = 1, Username = "test 1", Password = "123qwe", RoleId = 1, CreateDate = DateTime.Now, ExpiredDate = DateTime.MaxValue, Type = 0},
                new User{Id = 2, Username = "test 2", Password = "123qwe", RoleId = 2, CreateDate = DateTime.Now, ExpiredDate = DateTime.Now, Type = 0},
            };
            
            ApplicationDbContext.AddRange(users);
            ApplicationDbContext.SaveChanges();
        }

        private DataContext ApplicationDbContext { get;  set; }
    }
}