namespace NTierArchitecture.UI.Forms
{
    partial class CategoryForm
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
            txtCategoryName = new TextBox();
            label2 = new Label();
            txtDescription = new TextBox();
            SuspendLayout();
            // 
            // lstListe
            // 
            lstListe.ItemHeight = 25;
            lstListe.Location = new Point(105, 99);
            lstListe.Margin = new Padding(2, 2, 2, 2);
            lstListe.Size = new Size(495, 129);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 238);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(116, 25);
            label1.TabIndex = 1;
            label1.Text = "Kategori Adı";
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(259, 238);
            txtCategoryName.Margin = new Padding(2, 2, 2, 2);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(341, 32);
            txtCategoryName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 271);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 25);
            label2.TabIndex = 1;
            label2.Text = "Açıklama";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(259, 271);
            txtDescription.Margin = new Padding(2, 2, 2, 2);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(341, 84);
            txtDescription.TabIndex = 2;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 493);
            Controls.Add(txtDescription);
            Controls.Add(label2);
            Controls.Add(txtCategoryName);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(4, 5, 4, 5);
            Name = "CategoryForm";
            Text = "CategoryForm";
            Load += CategoryForm_Load;
            Controls.SetChildIndex(lstListe, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(txtCategoryName, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(txtDescription, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCategoryName;
        private Label label2;
        private TextBox txtDescription;
    }
}