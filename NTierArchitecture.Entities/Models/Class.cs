using EntitiesKatmanı.Abstractions;

namespace NTierArchitecture.Entities.Models
{
    public class Class : BaseEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
