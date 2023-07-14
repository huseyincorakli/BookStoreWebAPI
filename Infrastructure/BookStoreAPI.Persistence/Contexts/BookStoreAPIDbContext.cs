using BookStoreAPI.Domain.Entities;
using BookStoreAPI.Domain.Entities.Common;
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

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
              var datas=  ChangeTracker.Entries<BaseEntity>();
            foreach (var item in datas)
            {
                if (item.State == EntityState.Added)
                {
                    item.Entity.CreatedDate = DateTime.UtcNow;
                    item.Entity.UpdatedDate = DateTime.UtcNow;
                }   
                if(item.State==EntityState.Modified)
                    item.Entity.UpdatedDate= DateTime.UtcNow;
            }

            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
