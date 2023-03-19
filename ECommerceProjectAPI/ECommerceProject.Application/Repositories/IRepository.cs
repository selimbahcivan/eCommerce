using ECommerceProject.Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace ECommerceProject.Application.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        DbSet<T> Table { get; }
    }
}
