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
    public partial class ClassManagementForm : Form
    {
        private readonly ClassService _classService;
        public ClassManagementForm()
        {
            InitializeComponent();
            var dbContext = new SchoolDbContext();
            _classService = new ClassService(dbContext);
            LoadClasses();
        }
        private void LoadClasses()
        {
            dataGridViewClasses.DataSource = _classService.GetAllClasses();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var newClass = new Class { Name = txtClassName.Text };
                _classService.AddClass(newClass);
                LoadClasses();
                MessageBox.Show("Sınıf başarıyla eklendi.");
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
                if (dataGridViewClasses.SelectedRows.Count > 0)
                {
                    var classId = (int)dataGridViewClasses.SelectedRows[0].Cells["Id"].Value;
                    _classService.DeleteClass(classId);
                    LoadClasses();
                    MessageBox.Show("Sınıf başarıyla silindi.");
                }
                else
                {
                    MessageBox.Show("Lütfen silmek istediğiniz sınıfı seçin.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }

        private void ClassManagementForm_Load(object sender, EventArgs e)
        {

        }
    }
}
