namespace ClassManagement.Admin {
	partial class AudienceForm {
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
			this.label1 = new System.Windows.Forms.Label();
			this.tb_title = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.numericUD = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.tb_description = new System.Windows.Forms.TextBox();
			this.bt_add = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numericUD)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(30, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Название";
			// 
			// tb_title
			// 
			this.tb_title.Location = new System.Drawing.Point(185, 30);
			this.tb_title.Name = "tb_title";
			this.tb_title.Size = new System.Drawing.Size(200, 26);
			this.tb_title.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(30, 82);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(147, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Вместительность";
			// 
			// numericUD
			// 
			this.numericUD.Location = new System.Drawing.Point(185, 80);
			this.numericUD.Name = "numericUD";
			this.numericUD.Size = new System.Drawing.Size(200, 26);
			this.numericUD.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(30, 133);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(83, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "Описание";
			// 
			// tb_description
			// 
			this.tb_description.Location = new System.Drawing.Point(185, 130);
			this.tb_description.Multiline = true;
			this.tb_description.Name = "tb_description";
			this.tb_description.Size = new System.Drawing.Size(200, 100);
			this.tb_description.TabIndex = 5;
			// 
			// bt_add
			// 
			this.bt_add.Location = new System.Drawing.Point(185, 250);
			this.bt_add.Name = "bt_add";
			this.bt_add.Size = new System.Drawing.Size(200, 27);
			this.bt_add.TabIndex = 6;
			this.bt_add.Text = "Добавить";
			this.bt_add.UseVisualStyleBackColor = true;
			this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
			// 
			// AudienceForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(414, 299);
			this.Controls.Add(this.bt_add);
			this.Controls.Add(this.tb_description);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.numericUD);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tb_title);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.Name = "AudienceForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AudienceForm";
			this.Load += new System.EventHandler(this.AudienceForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.numericUD)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tb_title;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown numericUD;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tb_description;
		private System.Windows.Forms.Button bt_add;
	}
}