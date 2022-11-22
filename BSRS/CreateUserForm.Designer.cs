namespace BSRS
{
	partial class CreateUserForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateUserForm));
			this.saveButton = new System.Windows.Forms.Button();
			this.NameTextBox = new System.Windows.Forms.TextBox();
			this.pwdTextBox = new System.Windows.Forms.TextBox();
			this.accountTextBox = new System.Windows.Forms.TextBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// saveButton
			// 
			this.saveButton.BackColor = System.Drawing.Color.White;
			this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.saveButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(191)))));
			this.saveButton.FlatAppearance.BorderSize = 2;
			this.saveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(191)))));
			this.saveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(191)))));
			this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.saveButton.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.saveButton.Location = new System.Drawing.Point(263, 286);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(70, 40);
			this.saveButton.TabIndex = 10;
			this.saveButton.Text = "註冊";
			this.saveButton.UseVisualStyleBackColor = false;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// NameTextBox
			// 
			this.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.NameTextBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.NameTextBox.Location = new System.Drawing.Point(139, 211);
			this.NameTextBox.MaxLength = 20;
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Size = new System.Drawing.Size(194, 26);
			this.NameTextBox.TabIndex = 9;
			// 
			// pwdTextBox
			// 
			this.pwdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.pwdTextBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.pwdTextBox.Location = new System.Drawing.Point(139, 151);
			this.pwdTextBox.MaxLength = 50;
			this.pwdTextBox.Name = "pwdTextBox";
			this.pwdTextBox.Size = new System.Drawing.Size(194, 26);
			this.pwdTextBox.TabIndex = 8;
			// 
			// accountTextBox
			// 
			this.accountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.accountTextBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.accountTextBox.Location = new System.Drawing.Point(139, 91);
			this.accountTextBox.MaxLength = 50;
			this.accountTextBox.Name = "accountTextBox";
			this.accountTextBox.Size = new System.Drawing.Size(194, 26);
			this.accountTextBox.TabIndex = 6;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("微軟正黑體", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label4.Location = new System.Drawing.Point(62, 155);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(44, 22);
			this.label4.TabIndex = 13;
			this.label4.Text = "密碼";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label5.Font = new System.Drawing.Font("微軟正黑體", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label5.Location = new System.Drawing.Point(62, 95);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(44, 22);
			this.label5.TabIndex = 14;
			this.label5.Text = "帳號";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(62, 215);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 22);
			this.label1.TabIndex = 15;
			this.label1.Text = "姓名";
			// 
			// CreateUserForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(243)))), ((int)(((byte)(237)))));
			this.ClientSize = new System.Drawing.Size(399, 371);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.NameTextBox);
			this.Controls.Add(this.pwdTextBox);
			this.Controls.Add(this.accountTextBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "CreateUserForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "註冊帳號";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.TextBox NameTextBox;
		private System.Windows.Forms.TextBox pwdTextBox;
		private System.Windows.Forms.TextBox accountTextBox;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
	}
}