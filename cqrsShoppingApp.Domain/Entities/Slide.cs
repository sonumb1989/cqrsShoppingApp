using AspNetCoreHero.Abstractions.Domain;

namespace cqrsShoppingApp.Domain.Entities
{
    public class Slide : AuditableEntity
    {
        public string Image { get; set; } // Image (length: 100)
        public string Name { get; set; } // Name (length: 100)
        public string Description { get; set; } // Description (length: 50)
        public int TypeId { get; set; }
    }
}
