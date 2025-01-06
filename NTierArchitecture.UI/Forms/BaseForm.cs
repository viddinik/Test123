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
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        //protected nedir açıkla
        //protected erişim belirleyicisi, sadece tanımlandığı sınıf ve bu sınıftan türetilen sınıflar tarafından erişilebilir.

        protected virtual void btnKaydet_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnSil_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnGuncelle_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnListele_Click(object sender, EventArgs e)
        {

        }

        private void BaseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
