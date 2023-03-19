using ECommerceProject.Application.Repositories.Order;
using ECommerceProject.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace ECommerceProject.Persistence.Repositories.Order
{
    public class OrderWriteRepository : WriteRepository<Domain.Entities.Order>, IOrderWriteRepository
    {
        public OrderWriteRepository(EcommerceDbContext context) : base(context)
        {
        }
    }
}
