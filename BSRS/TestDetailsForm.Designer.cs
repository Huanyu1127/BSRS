namespace BSRS
{
	partial class TestDetailsForm
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestDetailsForm));
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.testDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.ucTestGrade1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ucTestGrade2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ucTestGrade3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ucTestGrade4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ucTestGrade5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.totalGradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.forTestDetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.testsIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.testsIndexVMBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Wheat;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.testDate,
            this.ucTestGrade1DataGridViewTextBoxColumn,
            this.ucTestGrade2DataGridViewTextBoxColumn,
            this.ucTestGrade3DataGridViewTextBoxColumn,
            this.ucTestGrade4DataGridViewTextBoxColumn,
            this.ucTestGrade5DataGridViewTextBoxColumn,
            this.totalGradeDataGridViewTextBoxColumn,
            this.forTestDetailsDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.testsIndexVMBindingSource;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Wheat;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView1.Location = new System.Drawing.Point(27, 191);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(707, 260);
			this.dataGridView1.TabIndex = 0;
			// 
			// testDate
			// 
			this.testDate.DataPropertyName = "testDate";
			this.testDate.HeaderText = "測驗日期";
			this.testDate.Name = "testDate";
			this.testDate.Width = 85;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = global::BSRS.Properties.Resources.grass;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox1.Location = new System.Drawing.Point(523, 26);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(182, 126);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.FloralWhite;
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox2.Location = new System.Drawing.Point(411, 64);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(188, 109);
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(137, 97);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 24);
			this.label1.TabIndex = 4;
			this.label1.Text = "Details";
			// 
			// ucTestGrade1DataGridViewTextBoxColumn
			// 
			this.ucTestGrade1DataGridViewTextBoxColumn.DataPropertyName = "ucTestGrade1";
			this.ucTestGrade1DataGridViewTextBoxColumn.HeaderText = "問題一";
			this.ucTestGrade1DataGridViewTextBoxColumn.Name = "ucTestGrade1DataGridViewTextBoxColumn";
			this.ucTestGrade1DataGridViewTextBoxColumn.Width = 72;
			// 
			// ucTestGrade2DataGridViewTextBoxColumn
			// 
			this.ucTestGrade2DataGridViewTextBoxColumn.DataPropertyName = "ucTestGrade2";
			this.ucTestGrade2DataGridViewTextBoxColumn.HeaderText = "問題二";
			this.ucTestGrade2DataGridViewTextBoxColumn.Name = "ucTestGrade2DataGridViewTextBoxColumn";
			this.ucTestGrade2DataGridViewTextBoxColumn.Width = 72;
			// 
			// ucTestGrade3DataGridViewTextBoxColumn
			// 
			this.ucTestGrade3DataGridViewTextBoxColumn.DataPropertyName = "ucTestGrade3";
			this.ucTestGrade3DataGridViewTextBoxColumn.HeaderText = "問題三";
			this.ucTestGrade3DataGridViewTextBoxColumn.Name = "ucTestGrade3DataGridViewTextBoxColumn";
			this.ucTestGrade3DataGridViewTextBoxColumn.Width = 72;
			// 
			// ucTestGrade4DataGridViewTextBoxColumn
			// 
			this.ucTestGrade4DataGridViewTextBoxColumn.DataPropertyName = "ucTestGrade4";
			this.ucTestGrade4DataGridViewTextBoxColumn.HeaderText = "問題四";
			this.ucTestGrade4DataGridViewTextBoxColumn.Name = "ucTestGrade4DataGridViewTextBoxColumn";
			this.ucTestGrade4DataGridViewTextBoxColumn.Width = 72;
			// 
			// ucTestGrade5DataGridViewTextBoxColumn
			// 
			this.ucTestGrade5DataGridViewTextBoxColumn.DataPropertyName = "ucTestGrade5";
			this.ucTestGrade5DataGridViewTextBoxColumn.HeaderText = "問題五";
			this.ucTestGrade5DataGridViewTextBoxColumn.Name = "ucTestGrade5DataGridViewTextBoxColumn";
			this.ucTestGrade5DataGridViewTextBoxColumn.Width = 72;
			// 
			// totalGradeDataGridViewTextBoxColumn
			// 
			this.totalGradeDataGridViewTextBoxColumn.DataPropertyName = "totalGrade";
			this.totalGradeDataGridViewTextBoxColumn.HeaderText = "總分";
			this.totalGradeDataGridViewTextBoxColumn.Name = "totalGradeDataGridViewTextBoxColumn";
			this.totalGradeDataGridViewTextBoxColumn.Width = 59;
			// 
			// forTestDetailsDataGridViewTextBoxColumn
			// 
			this.forTestDetailsDataGridViewTextBoxColumn.DataPropertyName = "forTestDetails";
			this.forTestDetailsDataGridViewTextBoxColumn.HeaderText = "得分範圍";
			this.forTestDetailsDataGridViewTextBoxColumn.Name = "forTestDetailsDataGridViewTextBoxColumn";
			this.forTestDetailsDataGridViewTextBoxColumn.Width = 85;
			// 
			// testsIndexVMBindingSource
			// 
			this.testsIndexVMBindingSource.DataSource = typeof(BSRS.Models.ViewModels.TestsIndexVM);
			// 
			// TestDetailsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(241)))), ((int)(((byte)(209)))));
			this.ClientSize = new System.Drawing.Size(765, 477);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.pictureBox2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "TestDetailsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "量表分數細覽";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.testsIndexVMBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource testsIndexVMBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn testDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn ucTestGrade1DataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ucTestGrade2DataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ucTestGrade3DataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ucTestGrade4DataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ucTestGrade5DataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn totalGradeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn forTestDetailsDataGridViewTextBoxColumn;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label1;
	}
}