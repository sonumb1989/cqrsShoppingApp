using AspNetCoreHero.Abstractions.Domain;
using System;

namespace cqrsShoppingApp.Domain.Entities
{
    public class DetailImage : AuditableEntity
    {
        public string ImageName { get; set; } // Image (length: 100)
        public int ProductId { get; set; } // ProductId
        public int Order { get; set; } // Order
        public string ProductCode { get; set; } // ProductCode (length: 10)
    }
}
