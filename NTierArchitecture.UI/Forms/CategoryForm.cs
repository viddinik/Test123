﻿using System;
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
    public partial class CategoryForm : BaseForm
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            
        }

        protected override void btnKaydet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
            
        }

        protected override void btnSil_Click(object sender, EventArgs e)
        {

        }

        protected override void btnListele_Click(object sender, EventArgs e)
        {
            lstListe.Items.Add("Test");
        }

        protected override void btnGuncelle_Click(object sender, EventArgs e)
        {

        }
    }
}
