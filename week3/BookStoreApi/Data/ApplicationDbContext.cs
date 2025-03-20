using System;
using Microsoft.EntityFrameworkCore;
using BookStoreApi.Models;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Net.Http.Headers;
using Microsoft.AspNetCore.Components.Routing;

namespace BookStoreApi.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }
        public DbSet<Author> Authors { get; set;}
        public DbSet <Book> Books { get; set;}
        public DbSet<Publisher> Publishers { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(
                new Author() { AuthorId = 1, Name = "John Smith", BirthDate = new DateTime(1980, 5, 15) },
                new Author() { AuthorId = 2, Name = "Jane Doe", BirthDate = new DateTime(1990, 8, 25) }
            
            );

            modelBuilder.Entity<Publisher>().HasData(
                new Publisher {PublisherId = 1, Name = "Tech Books Publishing", Location = "New York" },
                new Publisher { PublisherId = 2, Name = "Code Press", Location = "San Francisco" }
            );
        }
    

}
