using AspNetCoreHero.Abstractions.Domain;
using System.ComponentModel.DataAnnotations.Schema;

namespace cqrsShoppingApp.Domain.Entities
{
    [Table("Products")]
    public class Product : AuditableEntity
    {
        public string Code { get; set; } // Code (length: 10)
        public string Name { get; set; } // Name (length: 100)
        public string FriendlyName { get; set; } // FriendlyName (length: 150)

        public decimal Price { get; set; } // Price

        public decimal? PriceVN { get; set; } // Price

        public decimal DiscountedPrice { get; set; } // DiscountedPrice

        public decimal? DiscountedPriceVN { get; set; } // DiscountedPrice

        public string Description { get; set; } // Description (length: 1000)

        public string Image { get; set; } // Image (length: 100)

        public string FlickImage { get; set; }

        public bool IsNew { get; set; } // IsNew

        public bool IsSale { get; set; } // IsSale

        public bool? IsBest { get; set; }

        public bool? IsCart { get; set; } // IsActive

        public bool? IsFlicker { get; set; }

    }
}
