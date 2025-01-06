using NTierArchitecture.Business.Services;
using NTierArchitecture.DataAccess.Context;
using NTierArchitecture.DataAccess.Repositories;
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

namespace NTierArchitecture.UI.Forms
{
    public partial class SupplierForm : BaseForm
    {
        private readonly SupplierService _supplierService;
        public SupplierForm()
        {
            InitializeComponent();
            var dbContext = new ApplicationDbContext();
            var repository = new SupplierRepository(dbContext);
            _supplierService = new SupplierService(repository);
        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {

        }

        protected override void btnGuncelle_Click(object sender, EventArgs e)
        {
            
        }

        protected override void btnKaydet_Click(object sender, EventArgs e)
        {
            

        }

        protected override void btnListele_Click(object sender, EventArgs e)
        {
            
        }

        protected override void btnSil_Click(object sender, EventArgs e)
        {
           
        }
    }
}
