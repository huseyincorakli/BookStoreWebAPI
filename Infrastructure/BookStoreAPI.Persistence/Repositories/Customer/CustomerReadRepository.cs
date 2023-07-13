using BookStoreAPI.Application.Repositories;
using BookStoreAPI.Domain.Entities;
using BookStoreAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreAPI.Persistence.Repositories
{
    public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
    {
        public CustomerReadRepository(BookStoreAPIDbContext context) : base(context)
        {
        }
    }
}
