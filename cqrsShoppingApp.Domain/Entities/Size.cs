using AspNetCoreHero.Abstractions.Domain;

namespace cqrsShoppingApp.Domain.Entities
{
    public class Size : AuditableEntity
    {
        public string Name { get; set; } // Name
    }
}
