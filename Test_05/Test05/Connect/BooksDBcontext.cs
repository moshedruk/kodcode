using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;
using Test05.Models;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace Test05.Connect
{
    public class BooksDBcontext : DbContext
    {       
        public BooksDBcontext(DbContextOptions<BooksDBcontext> options) : base(options)
        {
           
            if (Database.EnsureCreated() && _library.Count() == 0)
            {
                Seed();
            }          
        }
        private static DbContextOptions Getoptions(string connectionString)
        {
            return SqlServerDbContextOptionsExtensions.UseSqlServer(new
                DbContextOptionsBuilder(), connectionString).Options;
        }
        private void Seed()
        {
            library mylibrary = new library
            {
               Name  = "glil"
            };
            _library.Add(mylibrary);
            SaveChanges();
        }
        private void Seedgrup()
        {
            Shelf classGrup = new Shelf
            {
                height = 0,
                width = 0,
                

            };
            _Shelf.Add(classGrup);
            SaveChanges();
        }
        public DbSet<library> _library { get; set; }
        public DbSet<Shelf> _Shelf { get; set; }
        public DbSet<Book> _Book { get; set; }
    }
}



