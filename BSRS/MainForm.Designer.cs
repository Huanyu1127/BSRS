namespace BSRS
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.開始測驗ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.歷史紀錄ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.方法心情札記ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.量表分數細覽ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.登出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.testButton = new System.Windows.Forms.Button();
			this.recordButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.userNameLabel = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(253)))), ((int)(((byte)(236)))));
			this.menuStrip1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開始測驗ToolStripMenuItem,
            this.歷史紀錄ToolStripMenuItem,
            this.方法心情札記ToolStripMenuItem,
            this.量表分數細覽ToolStripMenuItem,
            this.登出ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 6, 0, 6);
			this.menuStrip1.Size = new System.Drawing.Size(760, 33);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 開始測驗ToolStripMenuItem
			// 
			this.開始測驗ToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.開始測驗ToolStripMenuItem.Name = "開始測驗ToolStripMenuItem";
			this.開始測驗ToolStripMenuItem.Size = new System.Drawing.Size(72, 21);
			this.開始測驗ToolStripMenuItem.Text = "開始測驗";
			this.開始測驗ToolStripMenuItem.Click += new System.EventHandler(this.開始測驗ToolStripMenuItem_Click);
			// 
			// 歷史紀錄ToolStripMenuItem
			// 
			this.歷史紀錄ToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
			this.歷史紀錄ToolStripMenuItem.Name = "歷史紀錄ToolStripMenuItem";
			this.歷史紀錄ToolStripMenuItem.Size = new System.Drawing.Size(72, 21);
			this.歷史紀錄ToolStripMenuItem.Text = "歷史紀錄";
			this.歷史紀錄ToolStripMenuItem.Click += new System.EventHandler(this.歷史紀錄ToolStripMenuItem_Click);
			// 
			// 方法心情札記ToolStripMenuItem
			// 
			this.方法心情札記ToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
			this.方法心情札記ToolStripMenuItem.Name = "方法心情札記ToolStripMenuItem";
			this.方法心情札記ToolStripMenuItem.Size = new System.Drawing.Size(72, 21);
			this.方法心情札記ToolStripMenuItem.Text = "心情札記";
			this.方法心情札記ToolStripMenuItem.Click += new System.EventHandler(this.方法心情札記ToolStripMenuItem_Click);
			// 
			// 量表分數細覽ToolStripMenuItem
			// 
			this.量表分數細覽ToolStripMenuItem.Name = "量表分數細覽ToolStripMenuItem";
			this.量表分數細覽ToolStripMenuItem.Size = new System.Drawing.Size(98, 21);
			this.量表分數細覽ToolStripMenuItem.Text = "量表分數細覽";
			this.量表分數細覽ToolStripMenuItem.Click += new System.EventHandler(this.量表分數細覽ToolStripMenuItem_Click);
			// 
			// 登出ToolStripMenuItem
			// 
			this.登出ToolStripMenuItem.Margin = new System.Windows.Forms.Padding(320, 0, 0, 0);
			this.登出ToolStripMenuItem.Name = "登出ToolStripMenuItem";
			this.登出ToolStripMenuItem.Size = new System.Drawing.Size(46, 21);
			this.登出ToolStripMenuItem.Text = "登出";
			this.登出ToolStripMenuItem.Click += new System.EventHandler(this.登出ToolStripMenuItem_Click);
			// 
			// testButton
			// 
			this.testButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(236)))));
			this.testButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.testButton.FlatAppearance.BorderSize = 0;
			this.testButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(215)))));
			this.testButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(215)))));
			this.testButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.testButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.testButton.Location = new System.Drawing.Point(419, 441);
			this.testButton.Name = "testButton";
			this.testButton.Size = new System.Drawing.Size(105, 47);
			this.testButton.TabIndex = 0;
			this.testButton.Text = "開始測驗";
			this.testButton.UseVisualStyleBackColor = false;
			this.testButton.Click += new System.EventHandler(this.testButton_Click);
			// 
			// recordButton
			// 
			this.recordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(236)))));
			this.recordButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.recordButton.FlatAppearance.BorderSize = 0;
			this.recordButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(215)))));
			this.recordButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(215)))));
			this.recordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.recordButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.recordButton.Location = new System.Drawing.Point(554, 441);
			this.recordButton.Name = "recordButton";
			this.recordButton.Size = new System.Drawing.Size(105, 47);
			this.recordButton.TabIndex = 1;
			this.recordButton.Text = "歷史紀錄";
			this.recordButton.UseVisualStyleBackColor = false;
			this.recordButton.Click += new System.EventHandler(this.recordButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(511, 97);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 24);
			this.label1.TabIndex = 3;
			this.label1.Text = "Hello ,";
			// 
			// userNameLabel
			// 
			this.userNameLabel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.userNameLabel.Location = new System.Drawing.Point(419, 120);
			this.userNameLabel.Name = "userNameLabel";
			this.userNameLabel.Size = new System.Drawing.Size(240, 73);
			this.userNameLabel.TabIndex = 4;
			this.userNameLabel.Text = "UserName";
			this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(381, 220);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(319, 159);
			this.label2.TabIndex = 6;
			this.label2.Text = "　　　　心情溫度計為簡式健康量表　　　　(Brief Symptom Rating Scale，以下簡稱BSRS-5)的俗稱，主要在作為精神症狀之篩檢表，目的在於" +
    "能夠迅速了解個人的心理照護需求，進而提供所需之心理衛生服務。與其他篩檢量表相比，心情溫度計具備有簡短、使用容易之特性，研究結果更顯示心情溫度計在社區大規模調查中" +
    "仍具有良好之信效度。";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Bell MT", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.label3.Location = new System.Drawing.Point(365, 191);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 39);
			this.label3.TabIndex = 3;
			this.label3.Text = "“";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.White;
			this.label4.Font = new System.Drawing.Font("Bell MT", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.label4.Location = new System.Drawing.Point(676, 375);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(36, 27);
			this.label4.TabIndex = 3;
			this.label4.Text = "”";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = global::BSRS.Properties.Resources.flower;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox1.Location = new System.Drawing.Point(-4, 69);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(305, 448);
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(760, 555);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.userNameLabel);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.recordButton);
			this.Controls.Add(this.testButton);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "心情溫度計主選單";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 開始測驗ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 歷史紀錄ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 量表分數細覽ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 方法心情札記ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 登出ToolStripMenuItem;
		private System.Windows.Forms.Button testButton;
		private System.Windows.Forms.Button recordButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label userNameLabel;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
	}
}