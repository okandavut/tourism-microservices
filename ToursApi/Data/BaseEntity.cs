using System;
using System.ComponentModel.DataAnnotations;

namespace Otiport.API.Data
{
    public class BaseEntity<TProperty> where TProperty : struct
    {
        [Key]
        public TProperty Id { get; set; } = default(TProperty);
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public string CreatedBy { get; set; } = "System";
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
    }
}