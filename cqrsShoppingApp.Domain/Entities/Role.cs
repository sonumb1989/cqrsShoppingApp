using AspNetCoreHero.Abstractions.Domain;

namespace cqrsShoppingApp.Domain.Entities
{
    public class Role : AuditableEntity
    {
        public string Name { get; set; } // Name (length: 50)
    }
}
