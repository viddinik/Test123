using NTierArchitecture.Entities.Abstractions;

namespace NTierArchitecture.Entities.Models
{
    public class OrderDetail : BaseEntity
    {
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public Order? Order { get; set; }
        public Guid OrderID { get; set; }
        public Product? Product { get; set; }
        public Guid ProductID { get; set; }

    }
}
