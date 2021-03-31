using AspNetCoreHero.Abstractions.Domain;
using System.Collections.Generic;

namespace cqrsShoppingApp.Domain.Entities
{
    public class Category : AuditableEntity
    {
        public int ParentId { get; set; } // ParentId
        public string Name { get; set; } // Name
        public bool IsActive { get; set; } // IsActive
        public string Image { get; set; } // Image (length: 100)
    }
}
