using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace cqrsShoppingApp.Domain.Entities
{
    public class BaseEntity
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Description("Boolean(true/false)")]
        public bool IsDeleted { get; set; }

        [Required]
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string  CreateUser { get; set; }
        public string UpdateUser { get; set; }
    }
}
