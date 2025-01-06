namespace NTierArchitecture.UI.Forms
{
    partial class SupplierForm
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
            label1 = new Label();
            txtCompanyName = new TextBox();
            label2 = new Label();
            txtContactTitle = new TextBox();
            label3 = new Label();
            txtCity = new TextBox();
            label4 = new Label();
            txtPhone = new TextBox();
            SuspendLayout();
            // 
            // lstListe
            // 
            lstListe.ItemHeight = 23;
            lstListe.Location = new Point(889, 30);
            lstListe.Margin = new Padding(4, 5, 4, 5);
            lstListe.Size = new Size(268, 395);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 239);
            label1.Name = "label1";
            label1.Size = new Size(88, 25);
            label1.TabIndex = 2;
            label1.Text = "Şirket Adı";
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(219, 239);
            txtCompanyName.Margin = new Padding(3, 4, 3, 4);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(398, 31);
            txtCompanyName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 277);
            label2.Name = "label2";
            label2.Size = new Size(75, 25);
            label2.TabIndex = 2;
            label2.Text = "İlgili Kişi";
            // 
            // txtContactTitle
            // 
            txtContactTitle.Location = new Point(219, 277);
            txtContactTitle.Margin = new Padding(3, 4, 3, 4);
            txtContactTitle.Name = "txtContactTitle";
            txtContactTitle.Size = new Size(398, 31);
            txtContactTitle.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 316);
            label3.Name = "label3";
            label3.Size = new Size(51, 25);
            label3.TabIndex = 2;
            label3.Text = "Şehir";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(219, 316);
            txtCity.Margin = new Padding(3, 4, 3, 4);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(398, 31);
            txtCity.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 354);
            label4.Name = "label4";
            label4.Size = new Size(68, 25);
            label4.TabIndex = 2;
            label4.Text = "Telefon";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(219, 354);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(398, 31);
            txtPhone.TabIndex = 3;
            // 
            // SupplierForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1236, 520);
            Controls.Add(txtPhone);
            Controls.Add(label4);
            Controls.Add(txtCity);
            Controls.Add(label3);
            Controls.Add(txtContactTitle);
            Controls.Add(label2);
            Controls.Add(txtCompanyName);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 13F);
            Margin = new Padding(8, 11, 8, 11);
            Name = "SupplierForm";
            Text = "SupplierForm";
            Load += SupplierForm_Load;
            Controls.SetChildIndex(lstListe, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(txtCompanyName, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(txtContactTitle, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(txtCity, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(txtPhone, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCompanyName;
        private Label label2;
        private TextBox txtContactTitle;
        private Label label3;
        private TextBox txtCity;
        private Label label4;
        private TextBox txtPhone;
    }
}