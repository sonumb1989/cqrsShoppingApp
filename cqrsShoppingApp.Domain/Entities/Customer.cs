using AspNetCoreHero.Abstractions.Domain;

namespace cqrsShoppingApp.Domain.Entities
{
    public class Customer : AuditableEntity
    {
        public string IdentityId { get; set; }
        public string Location { get; set; }
        public string Locale { get; set; }
        public string Gender { get; set; }
    }
}
