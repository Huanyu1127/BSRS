namespace BSRS
{
	partial class DeleteTestForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteTestForm));
			this.notesTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.deleteButton = new System.Windows.Forms.Button();
			this.dateLabel = new System.Windows.Forms.Label();
			this.gradeLabel = new System.Windows.Forms.Label();
			this.categoryLabel = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// notesTextBox
			// 
			this.notesTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(226)))), ((int)(((byte)(217)))));
			this.notesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.notesTextBox.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.notesTextBox.Location = new System.Drawing.Point(386, 103);
			this.notesTextBox.Multiline = true;
			this.notesTextBox.Name = "notesTextBox";
			this.notesTextBox.ReadOnly = true;
			this.notesTextBox.Size = new System.Drawing.Size(201, 167);
			this.notesTextBox.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(35, 127);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "分數";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(35, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "日期";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.Location = new System.Drawing.Point(35, 179);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 20);
			this.label3.TabIndex = 1;
			this.label3.Text = "策略";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label4.Location = new System.Drawing.Point(382, 75);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 20);
			this.label4.TabIndex = 1;
			this.label4.Text = "心情札記";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(35, 44);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(0, 12);
			this.label5.TabIndex = 1;
			// 
			// deleteButton
			// 
			this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
			this.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(218)))), ((int)(((byte)(213)))));
			this.deleteButton.FlatAppearance.BorderSize = 3;
			this.deleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(218)))), ((int)(((byte)(213)))));
			this.deleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(218)))), ((int)(((byte)(213)))));
			this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.deleteButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.deleteButton.Location = new System.Drawing.Point(180, 266);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(95, 42);
			this.deleteButton.TabIndex = 0;
			this.deleteButton.Text = "刪除紀錄";
			this.deleteButton.UseVisualStyleBackColor = false;
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
			// 
			// dateLabel
			// 
			this.dateLabel.BackColor = System.Drawing.Color.White;
			this.dateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.dateLabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.dateLabel.Location = new System.Drawing.Point(99, 71);
			this.dateLabel.Name = "dateLabel";
			this.dateLabel.Size = new System.Drawing.Size(176, 24);
			this.dateLabel.TabIndex = 3;
			this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// gradeLabel
			// 
			this.gradeLabel.BackColor = System.Drawing.Color.White;
			this.gradeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.gradeLabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.gradeLabel.Location = new System.Drawing.Point(99, 122);
			this.gradeLabel.Name = "gradeLabel";
			this.gradeLabel.Size = new System.Drawing.Size(176, 25);
			this.gradeLabel.TabIndex = 3;
			this.gradeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// categoryLabel
			// 
			this.categoryLabel.BackColor = System.Drawing.Color.White;
			this.categoryLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.categoryLabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.categoryLabel.Location = new System.Drawing.Point(99, 173);
			this.categoryLabel.Name = "categoryLabel";
			this.categoryLabel.Size = new System.Drawing.Size(176, 25);
			this.categoryLabel.TabIndex = 3;
			this.categoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = global::BSRS.Properties.Resources.sticker2;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox1.Location = new System.Drawing.Point(349, 17);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(273, 308);
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// DeleteTestForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
			this.ClientSize = new System.Drawing.Size(654, 337);
			this.Controls.Add(this.categoryLabel);
			this.Controls.Add(this.gradeLabel);
			this.Controls.Add(this.dateLabel);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.notesTextBox);
			this.Controls.Add(this.pictureBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "DeleteTestForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "紀錄瀏覽";
			this.Load += new System.EventHandler(this.DeleteTestForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox notesTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button deleteButton;
		private System.Windows.Forms.Label dateLabel;
		private System.Windows.Forms.Label gradeLabel;
		private System.Windows.Forms.Label categoryLabel;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}