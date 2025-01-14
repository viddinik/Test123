using EntitiesKatmanı.Abstractions;

namespace NTierArchitecture.Entities.Models
{
    public class Course : BaseEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int TeacherId { get; set; }
    }
}
