using BookStoreAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreAPI.Persistence.Contexts
{
    public class BookStoreAPIDbContext : DbContext
    {
        public BookStoreAPIDbContext(DbContextOptions options) : base(options)
        {}
        DbSet<Product>Products { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<Customer> Customers { get; set; }
    }
}
