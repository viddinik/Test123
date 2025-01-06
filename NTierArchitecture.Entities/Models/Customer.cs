using NTierArchitecture.Entities.Abstractions;

namespace NTierArchitecture.Entities.Models
{
    public class Customer : BaseEntity
    {
        public string? CustomerName { get; set; }
        public string? County { get; set; }
        public string? City { get; set; }
        public string? Phone { get; set; }
        public ICollection<Order>? Orders { get; set; }
    }
}
