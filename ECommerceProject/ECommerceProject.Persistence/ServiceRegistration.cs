using ECommerceProject.Application.Repositories.Customer;
using ECommerceProject.Application.Repositories.Order;
using ECommerceProject.Application.Repositories.Product;
using ECommerceProject.Persistence.Contexts;
using ECommerceProject.Persistence.Repositories.Customer;
using ECommerceProject.Persistence.Repositories.Order;
using ECommerceProject.Persistence.Repositories.Product;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerceProject.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<EcommerceDbContext>(opt => opt.UseNpgsql(Configuration.ConfigurationString));
            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
        }
    }
}
