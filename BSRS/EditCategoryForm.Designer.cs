namespace BSRS
{
	partial class EditCategoryForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCategoryForm));
			this.updateButton = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.notesTextBox = new System.Windows.Forms.TextBox();
			this.categoryIdComboBox = new System.Windows.Forms.ComboBox();
			this.methodIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.methodIndexVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// updateButton
			// 
			this.updateButton.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.updateButton.FlatAppearance.BorderSize = 0;
			this.updateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BurlyWood;
			this.updateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BurlyWood;
			this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.updateButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.updateButton.Location = new System.Drawing.Point(337, 356);
			this.updateButton.Name = "updateButton";
			this.updateButton.Size = new System.Drawing.Size(75, 41);
			this.updateButton.TabIndex = 2;
			this.updateButton.Text = "修改";
			this.updateButton.UseVisualStyleBackColor = false;
			this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.Location = new System.Drawing.Point(118, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 28);
			this.label3.TabIndex = 7;
			this.label3.Text = "策略";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.White;
			this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label4.Location = new System.Drawing.Point(99, 177);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 21);
			this.label4.TabIndex = 8;
			this.label4.Text = "心情札記";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// notesTextBox
			// 
			this.notesTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
			this.notesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.notesTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.notesTextBox.Location = new System.Drawing.Point(103, 210);
			this.notesTextBox.MaxLength = 100;
			this.notesTextBox.Multiline = true;
			this.notesTextBox.Name = "notesTextBox";
			this.notesTextBox.Size = new System.Drawing.Size(266, 100);
			this.notesTextBox.TabIndex = 1;
			// 
			// categoryIdComboBox
			// 
			this.categoryIdComboBox.DataSource = this.methodIndexVMBindingSource;
			this.categoryIdComboBox.DisplayMember = "categoryName";
			this.categoryIdComboBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.categoryIdComboBox.FormattingEnabled = true;
			this.categoryIdComboBox.Location = new System.Drawing.Point(184, 64);
			this.categoryIdComboBox.Name = "categoryIdComboBox";
			this.categoryIdComboBox.Size = new System.Drawing.Size(140, 28);
			this.categoryIdComboBox.TabIndex = 0;
			// 
			// methodIndexVMBindingSource
			// 
			this.methodIndexVMBindingSource.DataSource = typeof(BSRS.Models.ViewModels.MethodIndexVM);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = global::BSRS.Properties.Resources.catstick;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox1.Location = new System.Drawing.Point(25, 131);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(405, 284);
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			// 
			// EditCategoryForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(249)))));
			this.ClientSize = new System.Drawing.Size(455, 453);
			this.Controls.Add(this.updateButton);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.notesTextBox);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.categoryIdComboBox);
			this.Controls.Add(this.label3);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "EditCategoryForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "編輯策略與心情札記";
			this.Load += new System.EventHandler(this.EditCategoryForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.methodIndexVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button updateButton;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox notesTextBox;
		private System.Windows.Forms.ComboBox categoryIdComboBox;
		private System.Windows.Forms.BindingSource methodIndexVMBindingSource;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}