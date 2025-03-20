using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookStoreApi.Models;

    public class BookstoreDbContext : DbContext
    {
        public BookstoreDbContext (DbContextOptions<BookstoreDbContext> options)
            : base(options)
        {
        }

        public DbSet<BookStoreApi.Models.Author> Author { get; set; } = default!;
    }
