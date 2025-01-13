using BusinessKatmanı.Services;
using NTierArchitecture.Entities.Models;
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
    public partial class CourseManagementForm : Form
    {
        private readonly CourseService _courseService;
        public CourseManagementForm()
        {
            InitializeComponent();
            var dbContext = new SchoolDbContext();
            _courseService = new CourseService(dbContext);
            LoadCourses();
        }
        private void LoadCourses()
        {
            dataGridViewCourses.DataSource = _courseService.GetAllCourses();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var newCourse = new Course { Name = txtCourseName.Text };
                _courseService.AddCourse(newCourse);
                LoadCourses();
                MessageBox.Show("Ders başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewCourses.SelectedRows.Count > 0)
                {
                    var courseId = (int)dataGridViewCourses.SelectedRows[0].Cells["Id"].Value;
                    _courseService.DeleteCourse(courseId);
                    LoadCourses();
                    MessageBox.Show("Ders başarıyla silindi.");
                }
                else
                {
                    MessageBox.Show("Lütfen silmek istediğiniz dersi seçin.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }


        private void CourseManagementForm_Load(object sender, EventArgs e)
        {

        }
    }
}
