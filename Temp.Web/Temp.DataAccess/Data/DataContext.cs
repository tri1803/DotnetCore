﻿using Microsoft.EntityFrameworkCore;

namespace Temp.DataAccess
{    
    /// <summary>
    /// DbContext
    /// </summary>
    public class DataContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        
        public DbSet<Product> Products { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<User> Users { get; set; }
        
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}
    }
}