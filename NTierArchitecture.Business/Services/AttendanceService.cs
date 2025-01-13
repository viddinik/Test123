using DataAccessKatmanı.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessKatmanı.Services
{
    public class AttendanceService
    {
        private readonly SchoolDbContext _context;

        public AttendanceService(SchoolDbContext context)
        {
            _context = context;
        }

        public double GetCourseAttendancePercentage(int courseId)
        {
            var totalRecords = _context.Attendances.Count(a => a.CourseId == courseId);
            if (totalRecords == 0) return 0;

            var attendedRecords = _context.Attendances.Count(a => a.CourseId == courseId && a.Status);
            return (attendedRecords / (double)totalRecords) * 100;
        }

        public List<(string StudentName, int AttendanceCount, int TotalClasses)> GetStudentAttendanceReport(int courseId)
        {
            var report = _context.Students
                .Join(_context.Attendances.Where(a => a.CourseId == courseId),
                      student => student.Id,
                      attendance => attendance.StudentId,
                      (student, attendance) => new { student.FullName, attendance.Status })
                .GroupBy(x => x.FullName)
                .Select(g => (
                    StudentName: g.Key,
                    AttendanceCount: g.Count(x => x.Status),
                    TotalClasses: g.Count()
                )).ToList();

            return report;
        }

    }
}
