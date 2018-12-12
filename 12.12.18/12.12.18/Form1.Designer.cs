namespace _12._12._18
{
	partial class Form1
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
			this.aTxtBox = new System.Windows.Forms.TextBox();
			this.bTxtBox = new System.Windows.Forms.TextBox();
			this.resultLbl = new System.Windows.Forms.Label();
			this.plus = new System.Windows.Forms.Button();
			this.minus = new System.Windows.Forms.Button();
			this.mul = new System.Windows.Forms.Button();
			this.divide = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// aTxtBox
			// 
			this.aTxtBox.Location = new System.Drawing.Point(87, 50);
			this.aTxtBox.Name = "aTxtBox";
			this.aTxtBox.Size = new System.Drawing.Size(100, 20);
			this.aTxtBox.TabIndex = 0;
			this.aTxtBox.TextChanged += new System.EventHandler(this.aTxtBox_TextChanged);
			// 
			// bTxtBox
			// 
			this.bTxtBox.Location = new System.Drawing.Point(87, 119);
			this.bTxtBox.Name = "bTxtBox";
			this.bTxtBox.Size = new System.Drawing.Size(100, 20);
			this.bTxtBox.TabIndex = 1;
			// 
			// resultLbl
			// 
			this.resultLbl.AutoSize = true;
			this.resultLbl.Location = new System.Drawing.Point(119, 194);
			this.resultLbl.Name = "resultLbl";
			this.resultLbl.Size = new System.Drawing.Size(38, 13);
			this.resultLbl.TabIndex = 2;
			this.resultLbl.Text = "result?";
			// 
			// plus
			// 
			this.plus.Location = new System.Drawing.Point(91, 80);
			this.plus.Name = "plus";
			this.plus.Size = new System.Drawing.Size(25, 23);
			this.plus.TabIndex = 3;
			this.plus.Text = "+";
			this.plus.UseVisualStyleBackColor = true;
			this.plus.Click += new System.EventHandler(this.plus_Click);
			// 
			// minus
			// 
			this.minus.Location = new System.Drawing.Point(122, 80);
			this.minus.Name = "minus";
			this.minus.Size = new System.Drawing.Size(25, 23);
			this.minus.TabIndex = 4;
			this.minus.Text = "-";
			this.minus.UseVisualStyleBackColor = true;
			this.minus.Click += new System.EventHandler(this.minus_Click);
			// 
			// mul
			// 
			this.mul.Location = new System.Drawing.Point(153, 80);
			this.mul.Name = "mul";
			this.mul.Size = new System.Drawing.Size(25, 23);
			this.mul.TabIndex = 5;
			this.mul.Text = "*";
			this.mul.UseVisualStyleBackColor = true;
			this.mul.Click += new System.EventHandler(this.mul_Click);
			// 
			// divide
			// 
			this.divide.Location = new System.Drawing.Point(184, 80);
			this.divide.Name = "divide";
			this.divide.Size = new System.Drawing.Size(24, 23);
			this.divide.TabIndex = 6;
			this.divide.Text = "/";
			this.divide.UseVisualStyleBackColor = true;
			this.divide.Click += new System.EventHandler(this.divide_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.divide);
			this.Controls.Add(this.mul);
			this.Controls.Add(this.minus);
			this.Controls.Add(this.plus);
			this.Controls.Add(this.resultLbl);
			this.Controls.Add(this.bTxtBox);
			this.Controls.Add(this.aTxtBox);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox aTxtBox;
		private System.Windows.Forms.TextBox bTxtBox;
		private System.Windows.Forms.Label resultLbl;
		private System.Windows.Forms.Button plus;
		private System.Windows.Forms.Button minus;
		private System.Windows.Forms.Button mul;
		private System.Windows.Forms.Button divide;
	}
}

