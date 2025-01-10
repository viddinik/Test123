namespace NTierArchitecture.Entities.Models
{
    public class Attendance
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; } // katılım var mı yok mu sorgusu. 
    }
}
