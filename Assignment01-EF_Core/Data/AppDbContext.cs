using Microsoft.EntityFrameworkCore;
using Assignment01_EF_Core.Models;

namespace Assignment01_EF_Core.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
    @"Server=.\MSSQLSERVER01;Database=ReadMoreBooksDB;Trusted_Connection=True;TrustServerCertificate=True");
        }

    }
}