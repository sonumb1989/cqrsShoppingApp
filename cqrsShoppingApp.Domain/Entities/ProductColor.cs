using AspNetCoreHero.Abstractions.Domain;
using System.ComponentModel.DataAnnotations.Schema;

namespace cqrsShoppingApp.Domain.Entities
{
    [Table("ProductColors")]
    public class ProductColor : AuditableEntity
    {
        public int ProductId { get; set; } // Id (Primary key)
        public int ColorId { get; set; } // Id (Primary key)
    }
}
