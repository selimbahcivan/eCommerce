using System.Linq.Expressions;
using ECommerceProject.Application.Repositories.Product;
using ECommerceProject.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace ECommerceProject.Persistence.Repositories.Product
{
    public class ProductReadRepository : ReadRepository<Domain.Entities.Product>, IProductReadRepository
    {
        public ProductReadRepository(EcommerceDbContext context) : base(context)
        {
        }
    }
}
