namespace NTierArchitecture.UI.Forms
{
    partial class BaseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnListele = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnKaydet = new Button();
            lstListe = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnListele);
            groupBox1.Controls.Add(btnGuncelle);
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(btnKaydet);
            groupBox1.Location = new Point(105, 8);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(494, 87);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "İşlem Menüsü";
            // 
            // btnListele
            // 
            btnListele.Location = new Point(365, 28);
            btnListele.Margin = new Padding(2);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(116, 45);
            btnListele.TabIndex = 0;
            btnListele.Text = "Listele";
            btnListele.UseVisualStyleBackColor = true;
            btnListele.Click += btnListele_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(245, 28);
            btnGuncelle.Margin = new Padding(2);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(116, 45);
            btnGuncelle.TabIndex = 0;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(125, 28);
            btnSil.Margin = new Padding(2);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(116, 45);
            btnSil.TabIndex = 0;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(4, 28);
            btnKaydet.Margin = new Padding(2);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(116, 45);
            btnKaydet.TabIndex = 0;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // lstListe
            // 
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 25;
            lstListe.Location = new Point(105, 99);
            lstListe.Margin = new Padding(2);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(495, 129);
            lstListe.TabIndex = 1;
            // 
            // BaseForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 453);
            Controls.Add(lstListe);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(4, 5, 4, 5);
            Name = "BaseForm";
            Text = "BaseForm";
            Load += BaseForm_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnListele;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnKaydet;
        protected ListBox lstListe;
    }
}