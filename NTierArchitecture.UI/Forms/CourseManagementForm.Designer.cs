namespace UIKatmanı
{
    partial class CourseManagementForm
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
            txtCourseName = new TextBox();
            dataGridViewCourses = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCourses).BeginInit();
            SuspendLayout();
            // 
            // txtCourseName
            // 
            txtCourseName.Location = new Point(211, 172);
            txtCourseName.Name = "txtCourseName";
            txtCourseName.Size = new Size(145, 23);
            txtCourseName.TabIndex = 0;
            // 
            // dataGridViewCourses
            // 
            dataGridViewCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCourses.Location = new Point(422, 71);
            dataGridViewCourses.Name = "dataGridViewCourses";
            dataGridViewCourses.Size = new Size(294, 251);
            dataGridViewCourses.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(73, 136);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(92, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Ders Ekleme";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(73, 227);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(92, 23);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Ders Silme";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // CourseManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 542);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dataGridViewCourses);
            Controls.Add(txtCourseName);
            Name = "CourseManagementForm";
            Text = "CourseManagementForm";
            Load += CourseManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCourses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCourseName;
        private DataGridView dataGridViewCourses;
        private Button btnAdd;
        private Button btnDelete;
    }
}