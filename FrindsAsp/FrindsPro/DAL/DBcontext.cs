using FrindsPro.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
namespace FrindsPro.DAL
{
    public class DBcontext : DbContext
    {
        public DBcontext(string connectionString) : base (Getoptions(connectionString))
        {
            Database.EnsureCreated();
            if (Frinds.Count() == 0)
            {
                Seed();
            }
        }
        private void Seed()
        {
            ClassFrind classFrind = new ClassFrind
            {
                
                FirstName = "John",
                LastName = "Doe",
                PhoneNumber = 1234567890,
                Email = "john.doe@example.com",
            };
            Frinds.Add(classFrind);
            SaveChanges();
        }
        private static DbContextOptions Getoptions(string connectionString)
        {
            return  SqlServerDbContextOptionsExtensions.UseSqlServer(new
                DbContextOptionsBuilder(), connectionString).Options;
        }
        public DbSet<ClassFrind> Frinds { get; set; }
        public DbSet<Image> images { get; set; }


    }
}
