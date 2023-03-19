using ECommerceProject.Application.Repositories.Product;
using ECommerceProject.Persistence.Contexts;

namespace ECommerceProject.Persistence.Repositories.Product
{
    public class ProductWriteRepository : WriteRepository<Domain.Entities.Product>, IProductWriteRepository
    {
        public ProductWriteRepository(EcommerceDbContext context) : base(context)
        {
        }
    }
}
