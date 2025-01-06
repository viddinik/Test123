using NTierArchitecture.Entities.Abstractions;

namespace NTierArchitecture.Entities.Models
{
    public class Product : BaseEntity
    {
        public string? ProductName { get; set; }
        public double UnitPrice { get; set; }
        public bool Discontinued { get; set; }
        public int UnitsInStock { get; set; }
        public Category? Category { get; set; }
        public Guid CategoryID { get; set; }
        public Supplier? Supplier { get; set; }
        public Guid SupplierID { get; set; }

    }
}
