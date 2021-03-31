using AspNetCoreHero.Abstractions.Domain;
using System;

namespace cqrsShoppingApp.Domain.Entities
{
    public class StaticPage : AuditableEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public bool Status { get; set; }
        public string ShortName { get; set; }
        public string Name { get; set; }
    }
}
