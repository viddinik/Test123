namespace UIKatmanı
{
    partial class ClassManagementForm
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
            txtClassName = new TextBox();
            dataGridViewClasses = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClasses).BeginInit();
            SuspendLayout();
            // 
            // txtClassName
            // 
            txtClassName.Location = new Point(309, 160);
            txtClassName.Name = "txtClassName";
            txtClassName.Size = new Size(100, 23);
            txtClassName.TabIndex = 0;
            // 
            // dataGridViewClasses
            // 
            dataGridViewClasses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClasses.Location = new Point(521, 52);
            dataGridViewClasses.Name = "dataGridViewClasses";
            dataGridViewClasses.Size = new Size(251, 217);
            dataGridViewClasses.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(106, 133);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Sınıf Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(106, 183);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 23);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Sınıf Silme";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // ClassManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 555);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dataGridViewClasses);
            Controls.Add(txtClassName);
            Name = "ClassManagementForm";
            Text = "ClassManagementForm";
            Load += ClassManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewClasses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtClassName;
        private DataGridView dataGridViewClasses;
        private Button btnAdd;
        private Button btnDelete;
    }
}