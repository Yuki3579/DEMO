namespace 美女養成大作戰
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.title = new System.Windows.Forms.Label();
			this.label_UserName = new System.Windows.Forms.Label();
			this.txt_UserName = new System.Windows.Forms.TextBox();
			this.btn_Enter = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::美女養成大作戰.Properties.Resources.pig2;
			this.pictureBox1.Location = new System.Drawing.Point(310, -13);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(344, 269);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// title
			// 
			this.title.AutoSize = true;
			this.title.Font = new System.Drawing.Font("王漢宗中仿宋繁", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.title.Location = new System.Drawing.Point(77, 45);
			this.title.Name = "title";
			this.title.Size = new System.Drawing.Size(201, 28);
			this.title.TabIndex = 1;
			this.title.Text = "美女養成大作戰";
			// 
			// label_UserName
			// 
			this.label_UserName.AutoSize = true;
			this.label_UserName.Font = new System.Drawing.Font("王漢宗中仿宋繁", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label_UserName.Location = new System.Drawing.Point(35, 113);
			this.label_UserName.Name = "label_UserName";
			this.label_UserName.Size = new System.Drawing.Size(110, 21);
			this.label_UserName.TabIndex = 2;
			this.label_UserName.Text = "您的名字：";
			// 
			// txt_UserName
			// 
			this.txt_UserName.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txt_UserName.Location = new System.Drawing.Point(151, 112);
			this.txt_UserName.Name = "txt_UserName";
			this.txt_UserName.Size = new System.Drawing.Size(164, 23);
			this.txt_UserName.TabIndex = 3;
			this.txt_UserName.Text = "胖小妹";
			// 
			// btn_Enter
			// 
			this.btn_Enter.Font = new System.Drawing.Font("王漢宗中仿宋繁", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btn_Enter.Location = new System.Drawing.Point(113, 171);
			this.btn_Enter.Name = "btn_Enter";
			this.btn_Enter.Size = new System.Drawing.Size(126, 26);
			this.btn_Enter.TabIndex = 4;
			this.btn_Enter.Text = "開始養成！";
			this.btn_Enter.UseVisualStyleBackColor = true;
			this.btn_Enter.Click += new System.EventHandler(this.btn_Enter_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(604, 251);
			this.Controls.Add(this.btn_Enter);
			this.Controls.Add(this.txt_UserName);
			this.Controls.Add(this.label_UserName);
			this.Controls.Add(this.title);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Form1";
			this.Text = "美女養成大作戰";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label title;
		private System.Windows.Forms.Label label_UserName;
		private System.Windows.Forms.TextBox txt_UserName;
		private System.Windows.Forms.Button btn_Enter;
	}
}

