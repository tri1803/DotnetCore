using Microsoft.EntityFrameworkCore;

namespace Demo.Model
{
    //DbContext
    public class MyContext : DbContext
    {
        //dbset of Grade
        public DbSet<Grade> Grades { get; set; }
        
        //dbset of student
        public DbSet<Student> Students { get; set; }


        public DbSet<Role> Roles { get; set; }

        public DbSet<User> Users { get; set; }
        
        //contructor
        public MyContext(DbContextOptions<MyContext> options) : base(options) {}
    }
}