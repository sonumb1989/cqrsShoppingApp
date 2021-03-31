using AspNetCoreHero.Abstractions.Domain;
using System.Collections.Generic;

namespace cqrsShoppingApp.Domain.Entities
{
    public class Color : AuditableEntity
    {
        public string Name { get; set; } // Name
        public string Value { get; set; } // Value
    }
}
