namespace UIKatmanı
{
    partial class AttendanceReportForm
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
            txtCourseId = new TextBox();
            dataGridViewReport = new DataGridView();
            btnLoadCourseReport = new Button();
            btnCourseAttendancePercentage = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport).BeginInit();
            SuspendLayout();
            // 
            // txtCourseId
            // 
            txtCourseId.Location = new Point(266, 182);
            txtCourseId.Name = "txtCourseId";
            txtCourseId.Size = new Size(180, 23);
            txtCourseId.TabIndex = 0;
            // 
            // dataGridViewReport
            // 
            dataGridViewReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReport.Location = new Point(541, 76);
            dataGridViewReport.Name = "dataGridViewReport";
            dataGridViewReport.Size = new Size(261, 226);
            dataGridViewReport.TabIndex = 1;
            // 
            // btnLoadCourseReport
            // 
            btnLoadCourseReport.Location = new Point(103, 122);
            btnLoadCourseReport.Name = "btnLoadCourseReport";
            btnLoadCourseReport.Size = new Size(106, 23);
            btnLoadCourseReport.TabIndex = 2;
            btnLoadCourseReport.Text = "Rapor Yükleme";
            btnLoadCourseReport.UseVisualStyleBackColor = true;
            // 
            // btnCourseAttendancePercentage
            // 
            btnCourseAttendancePercentage.Location = new Point(103, 245);
            btnCourseAttendancePercentage.Name = "btnCourseAttendancePercentage";
            btnCourseAttendancePercentage.Size = new Size(127, 23);
            btnCourseAttendancePercentage.TabIndex = 3;
            btnCourseAttendancePercentage.Text = "Yüzdelik Hesaplama";
            btnCourseAttendancePercentage.UseVisualStyleBackColor = true;
            // 
            // AttendanceReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 614);
            Controls.Add(btnCourseAttendancePercentage);
            Controls.Add(btnLoadCourseReport);
            Controls.Add(dataGridViewReport);
            Controls.Add(txtCourseId);
            Name = "AttendanceReportForm";
            Text = "AttendanceReportForm";
            Load += AttendanceReportForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCourseId;
        private DataGridView dataGridViewReport;
        private Button btnLoadCourseReport;
        private Button btnCourseAttendancePercentage;
    }
}