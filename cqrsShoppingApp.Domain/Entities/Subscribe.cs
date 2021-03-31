using AspNetCoreHero.Abstractions.Domain;
using System;

namespace cqrsShoppingApp.Domain.Entities
{
    public class Subscribe : AuditableEntity
    {
        public string Email { get; set; }
    }
}
