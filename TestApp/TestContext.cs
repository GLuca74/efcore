using Microsoft.EntityFrameworkCore;

namespace TestApp
{
    public class TestContext : Microsoft.EntityFrameworkCore.DbContext
    {
        protected override void OnModelCreating(Microsoft.EntityFrameworkCore.ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TestEntity>().HasKey(itm => itm.ID);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-6Q8KE4E\\MSSQLSERVER2022;Integrated Security=true;Initial Catalog=TestXXX;Encrypt=False");
        }
    }


    public class TestEntity
    {
        public Guid ID { get; set; }
    }

}
