using System;
using TestAPI2.Models;
using Microsoft.EntityFrameworkCore;
namespace TestAPI2
{
    public class ApiContext : DbContext
    {
        protected override void OnConfiguring
       (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "AuthorDb");
        }

        public DbSet<Company> Company { get; set; }
        public DbSet<Car> Cars { get; set; }
    }
}