using BusinessKatmanı.Services;
using DataAccessKatmanı.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIKatmanı
{
    public partial class AttendanceReportForm : Form
    {
        private readonly AttendanceService _attendanceService;

        public AttendanceReportForm()
        {
            InitializeComponent();
            InitializeComponent();
            var dbContext = new SchoolDbContext();
            _attendanceService = new AttendanceService(dbContext);
        }
        private void btnLoadCourseReport_Click(object sender, EventArgs e)
        {
            try
            {
                int courseId = int.Parse(txtCourseId.Text);
                var report = _attendanceService.GetStudentAttendanceReport(courseId);
                dataGridViewReport.DataSource = report.Select(r => new
                {
                    r.StudentName,
                    r.AttendanceCount,
                    r.TotalClasses,
                    AttendancePercentage = (r.AttendanceCount / (double)r.TotalClasses) * 100
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }

        private void btnCourseAttendancePercentage_Click(object sender, EventArgs e)
        {
            try
            {
                int courseId = int.Parse(txtCourseId.Text);
                double percentage = _attendanceService.GetCourseAttendancePercentage(courseId);
                MessageBox.Show($"Dersin yoklama yüzdesi: {percentage:F2}%");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }


        private void AttendanceReportForm_Load(object sender, EventArgs e)
        {

        }
    }
}
