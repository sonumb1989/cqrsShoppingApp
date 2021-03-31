using AspNetCoreHero.Abstractions.Domain;
using System.ComponentModel.DataAnnotations.Schema;

namespace cqrsShoppingApp.Domain.Entities
{
    [Table("ProductSizes")]
    public class ProductSize : AuditableEntity
    {
        public int ProductId { get; set; } // Id (Primary key)
        public int SizeId { get; set; } // Id (Primary key)
    }
}
