using AspNetCoreHero.Abstractions.Domain;
using System;
using System.Collections.Generic;

namespace cqrsShoppingApp.Domain.Entities
{
    public class Order : AuditableEntity
    {
        public int BillingId { get; set; } // BillingId
        public int ShippingId { get; set; } // ShippingId
        public decimal Total { get; set; } // Total
        public DateTime OrderDate { get; set; } // OrderDate
        public string Status { get; set; } // Status
        public string Description { get; set; } // Description
        public string Currency { get; set; }
        public int? UserId { get; set; }
        public bool IsCoupon { get; set; }
        public bool IsActive { get; set; }
        public int? PaymentMethod { get; set; }

    }
}
