
using cqrsShoppingApp.Application.Interfaces.CacheRepositories;
using cqrsShoppingApp.Application.Interfaces.Contexts;
using cqrsShoppingApp.Application.Interfaces.Repositories;
using cqrsShoppingApp.Infrastructure.CacheRepositories;
using cqrsShoppingApp.Infrastructure.DbContexts;
using cqrsShoppingApp.Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace cqrsShoppingApp.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
       public static void AddPersistenceContexts(this IServiceCollection services, IConfiguration configuration)
       {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddScoped<IApplicationDbContext, ApplicationDbContext>();
       }

        public static void AddRepositories(this IServiceCollection services)
        {
            #region Repositories

            services.AddTransient(typeof(IRepositoryAsync<>), typeof(RepositoryAsync<>));
            services.AddTransient<ICategoryCacheRepository, CategoryCacheRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            #endregion Repositories
        }
    }

}
