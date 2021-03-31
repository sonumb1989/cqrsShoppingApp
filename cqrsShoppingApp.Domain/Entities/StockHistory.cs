using AspNetCoreHero.Abstractions.Domain;
using System;

namespace cqrsShoppingApp.Domain.Entities
{
    public class StockHistory : AuditableEntity
    {
        public int StockId { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual Stock Stock { get; set; }
    }
}
