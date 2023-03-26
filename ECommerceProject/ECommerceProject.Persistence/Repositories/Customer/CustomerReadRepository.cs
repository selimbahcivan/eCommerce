using System.Linq.Expressions;
using ECommerceProject.Application.Repositories.Customer;
using ECommerceProject.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace ECommerceProject.Persistence.Repositories.Customer
{
    public class CustomerReadRepository : ReadRepository<Domain.Entities.Customer>, ICustomerReadRepository
    {
        public CustomerReadRepository(EcommerceDbContext context) : base(context)
        {
        }
    }
}
