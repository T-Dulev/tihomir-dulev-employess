
namespace LongestPeriodUI
{
    partial class LongestPeriodForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.EmployeeId1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeId2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaysWorked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonFileSelect = new System.Windows.Forms.Button();
            this.labelFileName = new System.Windows.Forms.Label();
            this.labelMaxInterval = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeId1,
            this.EmployeeId2,
            this.ProjectId,
            this.DaysWorked});
            this.dataGridView.Location = new System.Drawing.Point(13, 56);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(501, 382);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // EmployeeId1
            // 
            this.EmployeeId1.HeaderText = "Employee ID #1";
            this.EmployeeId1.Name = "EmployeeId1";
            this.EmployeeId1.Width = 120;
            // 
            // EmployeeId2
            // 
            this.EmployeeId2.HeaderText = "Employee ID #2";
            this.EmployeeId2.Name = "EmployeeId2";
            this.EmployeeId2.Width = 120;
            // 
            // ProjectId
            // 
            this.ProjectId.HeaderText = "Project ID";
            this.ProjectId.Name = "ProjectId";
            // 
            // DaysWorked
            // 
            this.DaysWorked.HeaderText = "Days worked";
            this.DaysWorked.Name = "DaysWorked";
            // 
            // buttonFileSelect
            // 
            this.buttonFileSelect.Location = new System.Drawing.Point(13, 12);
            this.buttonFileSelect.Name = "buttonFileSelect";
            this.buttonFileSelect.Size = new System.Drawing.Size(75, 23);
            this.buttonFileSelect.TabIndex = 1;
            this.buttonFileSelect.Text = "File select";
            this.buttonFileSelect.UseVisualStyleBackColor = true;
            this.buttonFileSelect.Click += new System.EventHandler(this.buttonFileSelect_Click);
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFileName.Location = new System.Drawing.Point(94, 13);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(0, 21);
            this.labelFileName.TabIndex = 2;
            // 
            // labelMaxInterval
            // 
            this.labelMaxInterval.AutoSize = true;
            this.labelMaxInterval.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMaxInterval.Location = new System.Drawing.Point(15, 445);
            this.labelMaxInterval.Name = "labelMaxInterval";
            this.labelMaxInterval.Size = new System.Drawing.Size(0, 21);
            this.labelMaxInterval.TabIndex = 3;
            // 
            // LongestPeriodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(526, 478);
            this.Controls.Add(this.labelMaxInterval);
            this.Controls.Add(this.labelFileName);
            this.Controls.Add(this.buttonFileSelect);
            this.Controls.Add(this.dataGridView);
            this.Name = "LongestPeriodForm";
            this.Text = "Longest period";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeId1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeId2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaysWorked;
        private System.Windows.Forms.Button buttonFileSelect;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.Label labelMaxInterval;
    }
}

