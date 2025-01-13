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
    public partial class StudentManagementForm : Form
    {
        private readonly StudentService _studentService;
        private readonly ClassService _classService;
        public StudentManagementForm()
        {
            InitializeComponent();
            var dbContext = new SchoolDbContext();
            _studentService = new StudentService(dbContext);
            _classService = new ClassService(dbContext);
            LoadClasses();
            LoadStudents();
        }

        private void LoadClasses()
        {
            var classes = _classService.GetAllClasses();
            comboBoxClass.DataSource = classes;
            comboBoxClass.DisplayMember = "Name";
            comboBoxClass.ValueMember = "Id";
        }


        private void LoadStudents()
        {
            var students = _studentService.GetAllStudents();
            dataGridViewStudents.DataSource = students.Select(s => new
            {
                s.Id,
                s.FullName,
                ClassName = _classService.GetAllClasses().FirstOrDefault(c => c.Id == s.ClassId)?.Name
            }).ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var student = new Student
                {
                    FullName = txtFullName.Text,
                    ClassId = (int)comboBoxClass.SelectedValue
                };
                _studentService.AddStudent(student);
                LoadStudents();
                MessageBox.Show("Öğrenci başarıyla eklendi.");
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
                if (dataGridViewStudents.SelectedRows.Count > 0)
                {
                    var studentId = (int)dataGridViewStudents.SelectedRows[0].Cells["Id"].Value;
                    _studentService.DeleteStudent(studentId);
                    LoadStudents();
                    MessageBox.Show("Öğrenci başarıyla silindi.");
                }
                else
                {
                    MessageBox.Show("Lütfen silmek istediğiniz öğrenciyi seçin.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewStudents.SelectedRows.Count > 0)
                {
                    var studentId = (int)dataGridViewStudents.SelectedRows[0].Cells["Id"].Value;
                    var student = new Student
                    {
                        Id = studentId,
                        FullName = txtFullName.Text,
                        ClassId = (int)comboBoxClass.SelectedValue
                    };
                    _studentService.UpdateStudent(student);
                    LoadStudents();
                    MessageBox.Show("Öğrenci başarıyla güncellendi.");
                }
                else
                {
                    MessageBox.Show("Lütfen güncellemek istediğiniz öğrenciyi seçin.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }
    
        private void StudentManagementForm_Load(object sender, EventArgs e)
        {

        }
    }
}
