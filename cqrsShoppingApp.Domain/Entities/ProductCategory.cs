using AspNetCoreHero.Abstractions.Domain;
using System.ComponentModel.DataAnnotations.Schema;

namespace cqrsShoppingApp.Domain.Entities
{
    [Table("ProductCategories")]
    public class ProductCategory : AuditableEntity
    {
        public int ProductId { get; set; } // Id (Primary key)
        public int CategoryId { get; set; } // Id (Primary key)
    }
}
