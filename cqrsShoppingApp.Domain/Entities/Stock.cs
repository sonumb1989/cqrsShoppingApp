using AspNetCoreHero.Abstractions.Domain;

namespace cqrsShoppingApp.Domain.Entities
{
    public class Stock : AuditableEntity
    {
        public int ProductId { get; set; }
        public int SizeId { get; set; }
        public int ColorId { get; set; }
        public int Quantity { get; set; }
        public int RemainQuantity { get; set; }
        public bool InStock { get; set; }

        public virtual Product Product { get; set; }
        public virtual Size Size { get; set; }
        public virtual Color Color { get; set; }

    }
}
