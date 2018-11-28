namespace FileToImage {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.button1 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(249, 81);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(255, 255);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(23, 298);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(122, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Choose file...";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.comboBox1);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.numericUpDown1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Location = new System.Drawing.Point(38, 81);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(171, 380);
			this.panel1.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(38, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(144, 26);
			this.label1.TabIndex = 3;
			this.label1.Text = "File To Image";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(20, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Image samples:";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(23, 82);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
			this.numericUpDown1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
			this.numericUpDown1.TabIndex = 4;
			this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(20, 115);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Blending mode:";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Multiply",
            "Overlay",
            "Screen",
            "Linear Dodge"});
			this.comboBox1.Location = new System.Drawing.Point(23, 131);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(20, 20);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(59, 17);
			this.label4.TabIndex = 4;
			this.label4.Text = "Settings";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(23, 328);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(122, 23);
			this.button2.TabIndex = 7;
			this.button2.Text = "Generate image";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(249, 370);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(255, 23);
			this.button3.TabIndex = 4;
			this.button3.Text = "Save image...";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// label5
			// 
			this.label5.AutoEllipsis = true;
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(249, 432);
			this.label5.MaximumSize = new System.Drawing.Size(250, 25);
			this.label5.MinimumSize = new System.Drawing.Size(250, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(250, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "No file selected";
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(250, 400);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(252, 23);
			this.progressBar1.Step = 1;
			this.progressBar1.TabIndex = 6;
			this.progressBar1.Value = 100;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(545, 503);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "File To Image";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ProgressBar progressBar1;
	}
}

