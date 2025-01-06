using NTierArchitecture.Entities.Abstractions;

namespace NTierArchitecture.Entities.Models
{
    public class Supplier : BaseEntity
    {
        public string? CompanyName { get; set; }
        public string? ContactTitle { get; set; }
        public string? City { get; set; }
        public string? Phone { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
