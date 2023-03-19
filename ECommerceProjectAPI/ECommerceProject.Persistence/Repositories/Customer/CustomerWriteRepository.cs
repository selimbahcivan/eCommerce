using ECommerceProject.Application.Repositories.Customer;
using ECommerceProject.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace ECommerceProject.Persistence.Repositories.Customer
{
    public class CustomerWriteRepository : WriteRepository<Domain.Entities.Customer>, ICustomerWriteRepository
    {
        public CustomerWriteRepository(EcommerceDbContext context) : base(context)
        {
        }
    }
}
