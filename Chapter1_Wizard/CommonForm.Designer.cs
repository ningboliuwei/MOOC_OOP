namespace Chapter1_Wizard
{
	partial class CommonForm
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
			this.btnPrevious = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
			this.btnFinish = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnPrevious
			// 
			this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnPrevious.Location = new System.Drawing.Point(15, 349);
			this.btnPrevious.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnPrevious.Name = "btnPrevious";
			this.btnPrevious.Size = new System.Drawing.Size(87, 29);
			this.btnPrevious.TabIndex = 0;
			this.btnPrevious.Text = "上一步(&P)";
			this.btnPrevious.UseVisualStyleBackColor = true;
			this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
			// 
			// btnNext
			// 
			this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnNext.Location = new System.Drawing.Point(111, 348);
			this.btnNext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(87, 29);
			this.btnNext.TabIndex = 1;
			this.btnNext.Text = "下一步(N)";
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// btnFinish
			// 
			this.btnFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnFinish.Location = new System.Drawing.Point(367, 346);
			this.btnFinish.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnFinish.Name = "btnFinish";
			this.btnFinish.Size = new System.Drawing.Size(87, 29);
			this.btnFinish.TabIndex = 2;
			this.btnFinish.Text = "完成(&F)";
			this.btnFinish.UseVisualStyleBackColor = true;
			this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.Location = new System.Drawing.Point(273, 346);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(87, 29);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "取消(&C)";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// CommonForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(469, 392);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnFinish);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.btnPrevious);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "CommonForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "CommonForm";
			this.Load += new System.EventHandler(this.CommonForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnPrevious;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnFinish;
		private System.Windows.Forms.Button btnCancel;
	}
}