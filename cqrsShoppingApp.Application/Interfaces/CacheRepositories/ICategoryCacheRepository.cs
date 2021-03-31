using cqrsShoppingApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cqrsShoppingApp.Application.Interfaces.CacheRepositories
{
    public interface ICategoryCacheRepository
    {
        Task<List<Category>> GetCachedListAsync();

        Task<Category> GetByIdAsync(int categoryId);
    }
}
