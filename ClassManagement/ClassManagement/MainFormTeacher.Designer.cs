namespace ClassManagement {
	partial class MainFormTeacher {
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
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.ColumnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnTime_9_00 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnTime_10_30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnTime_12_00 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnTime_13_30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnTime_15_00 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnTime_16_30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnTime_18_00 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnTime_19_30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(12, 12);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
			this.dateTimePicker1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(218, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "У вас";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(272, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(30, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "0";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(308, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(156, 16);
			this.label3.TabIndex = 3;
			this.label3.Text = "новых уведомлений";
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNumber,
            this.ColumnTime_9_00,
            this.ColumnTime_10_30,
            this.ColumnTime_12_00,
            this.ColumnTime_13_30,
            this.ColumnTime_15_00,
            this.ColumnTime_16_30,
            this.ColumnTime_18_00,
            this.ColumnTime_19_30});
			this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dataGridView1.Location = new System.Drawing.Point(12, 40);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(553, 375);
			this.dataGridView1.TabIndex = 4;
			this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
			// 
			// ColumnNumber
			// 
			this.ColumnNumber.HeaderText = "№";
			this.ColumnNumber.Name = "ColumnNumber";
			this.ColumnNumber.ReadOnly = true;
			// 
			// ColumnTime_9_00
			// 
			this.ColumnTime_9_00.HeaderText = "9:00";
			this.ColumnTime_9_00.Name = "ColumnTime_9_00";
			this.ColumnTime_9_00.ReadOnly = true;
			this.ColumnTime_9_00.Width = 50;
			// 
			// ColumnTime_10_30
			// 
			this.ColumnTime_10_30.HeaderText = "10:30";
			this.ColumnTime_10_30.Name = "ColumnTime_10_30";
			this.ColumnTime_10_30.ReadOnly = true;
			this.ColumnTime_10_30.Width = 50;
			// 
			// ColumnTime_12_00
			// 
			this.ColumnTime_12_00.HeaderText = "12:00";
			this.ColumnTime_12_00.Name = "ColumnTime_12_00";
			this.ColumnTime_12_00.ReadOnly = true;
			this.ColumnTime_12_00.Width = 50;
			// 
			// ColumnTime_13_30
			// 
			this.ColumnTime_13_30.HeaderText = "13:30";
			this.ColumnTime_13_30.Name = "ColumnTime_13_30";
			this.ColumnTime_13_30.ReadOnly = true;
			this.ColumnTime_13_30.Width = 50;
			// 
			// ColumnTime_15_00
			// 
			this.ColumnTime_15_00.HeaderText = "15:00";
			this.ColumnTime_15_00.Name = "ColumnTime_15_00";
			this.ColumnTime_15_00.ReadOnly = true;
			this.ColumnTime_15_00.Width = 50;
			// 
			// ColumnTime_16_30
			// 
			this.ColumnTime_16_30.HeaderText = "16:30";
			this.ColumnTime_16_30.Name = "ColumnTime_16_30";
			this.ColumnTime_16_30.ReadOnly = true;
			this.ColumnTime_16_30.Width = 50;
			// 
			// ColumnTime_18_00
			// 
			this.ColumnTime_18_00.HeaderText = "18:00";
			this.ColumnTime_18_00.Name = "ColumnTime_18_00";
			this.ColumnTime_18_00.ReadOnly = true;
			this.ColumnTime_18_00.Width = 50;
			// 
			// ColumnTime_19_30
			// 
			this.ColumnTime_19_30.HeaderText = "19:30";
			this.ColumnTime_19_30.Name = "ColumnTime_19_30";
			this.ColumnTime_19_30.ReadOnly = true;
			this.ColumnTime_19_30.Width = 50;
			// 
			// MainFormTeacher
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(569, 426);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dateTimePicker1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainFormTeacher";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Главная";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTime_9_00;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTime_10_30;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTime_12_00;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTime_13_30;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTime_15_00;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTime_16_30;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTime_18_00;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTime_19_30;
	}
}