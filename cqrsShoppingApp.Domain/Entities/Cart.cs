using AspNetCoreHero.Abstractions.Domain;
using System;

namespace cqrsShoppingApp.Domain.Entities
{
    public class Cart : AuditableEntity
    {
        public int ProductId { get; set; } // ProductId
        public int Quantity { get; set; } // Quantity
        public string Size { get; set; } // Size
        public string Color { get; set; } // Color
    }
}
