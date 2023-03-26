using System.Linq.Expressions;
using ECommerceProject.Application.Repositories.Order;
using ECommerceProject.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace ECommerceProject.Persistence.Repositories.Order
{
    public class OrderReadRepository : ReadRepository<Domain.Entities.Order>, IOrderReadRepository
    {
        public OrderReadRepository(EcommerceDbContext context) : base(context)
        {
        }
    }
}
