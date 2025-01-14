using EntitiesKatmanı.Abstractions;

namespace NTierArchitecture.Entities.Models
{
    public class Teacher : BaseEntity
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? Branch { get; set; }
    }
}
