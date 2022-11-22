namespace BSRS
{
	partial class LoginForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			this.loginButton = new System.Windows.Forms.Button();
			this.pwdTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.accountTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.createButton = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// loginButton
			// 
			this.loginButton.BackColor = System.Drawing.Color.White;
			this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.loginButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(191)))));
			this.loginButton.FlatAppearance.BorderSize = 2;
			this.loginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(191)))));
			this.loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(191)))));
			this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.loginButton.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.loginButton.Location = new System.Drawing.Point(247, 209);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(75, 39);
			this.loginButton.TabIndex = 2;
			this.loginButton.Text = "登入";
			this.loginButton.UseVisualStyleBackColor = false;
			this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
			// 
			// pwdTextBox
			// 
			this.pwdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.pwdTextBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.pwdTextBox.Location = new System.Drawing.Point(134, 141);
			this.pwdTextBox.Name = "pwdTextBox";
			this.pwdTextBox.PasswordChar = '*';
			this.pwdTextBox.Size = new System.Drawing.Size(188, 26);
			this.pwdTextBox.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(72, 144);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 22);
			this.label2.TabIndex = 11;
			this.label2.Text = "密碼";
			// 
			// accountTextBox
			// 
			this.accountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.accountTextBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.accountTextBox.Location = new System.Drawing.Point(134, 85);
			this.accountTextBox.Name = "accountTextBox";
			this.accountTextBox.Size = new System.Drawing.Size(188, 26);
			this.accountTextBox.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(72, 89);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 22);
			this.label1.TabIndex = 12;
			this.label1.Text = "帳號";
			// 
			// createButton
			// 
			this.createButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(243)))), ((int)(((byte)(237)))));
			this.createButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.createButton.FlatAppearance.BorderSize = 0;
			this.createButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.createButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.createButton.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.createButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(172)))));
			this.createButton.Location = new System.Drawing.Point(270, 285);
			this.createButton.Name = "createButton";
			this.createButton.Size = new System.Drawing.Size(52, 36);
			this.createButton.TabIndex = 3;
			this.createButton.Text = "註冊";
			this.createButton.UseVisualStyleBackColor = false;
			this.createButton.Click += new System.EventHandler(this.AddNewButton_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.label3.Location = new System.Drawing.Point(176, 297);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(91, 16);
			this.label3.TabIndex = 13;
			this.label3.Text = "還沒有帳號嗎？";
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(243)))), ((int)(((byte)(237)))));
			this.ClientSize = new System.Drawing.Size(399, 371);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.createButton);
			this.Controls.Add(this.loginButton);
			this.Controls.Add(this.pwdTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.accountTextBox);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "登入心情溫度計";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button loginButton;
		private System.Windows.Forms.TextBox pwdTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox accountTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button createButton;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Label label3;
	}
}