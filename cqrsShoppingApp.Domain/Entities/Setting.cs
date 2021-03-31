using AspNetCoreHero.Abstractions.Domain;

namespace cqrsShoppingApp.Domain.Entities
{
    public class Setting : AuditableEntity
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public string Title { get; set; }
        public int? TypeId { get; set; }
    }
}
