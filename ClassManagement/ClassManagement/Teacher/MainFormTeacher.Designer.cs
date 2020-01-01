namespace ClassManagement.Teacher {
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label_notification = new System.Windows.Forms.Label();
			this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.Column_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_9_00 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_10_30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_12_00 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_13_30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_15_00 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_16_30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_18_00 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_19_30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label_notification);
			this.panel1.Controls.Add(this.dateTimePicker);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(475, 110);
			this.panel1.TabIndex = 0;
			// 
			// label_notification
			// 
			this.label_notification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label_notification.Location = new System.Drawing.Point(209, 33);
			this.label_notification.Name = "label_notification";
			this.label_notification.Size = new System.Drawing.Size(263, 44);
			this.label_notification.TabIndex = 1;
			this.label_notification.Text = "У вас 0 новых уведомлений";
			this.label_notification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dateTimePicker
			// 
			this.dateTimePicker.Location = new System.Drawing.Point(3, 42);
			this.dateTimePicker.Name = "dateTimePicker";
			this.dateTimePicker.Size = new System.Drawing.Size(200, 26);
			this.dateTimePicker.TabIndex = 0;
			this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
			// 
			// pictureBox
			// 
			this.pictureBox.Location = new System.Drawing.Point(493, 12);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(146, 110);
			this.pictureBox.TabIndex = 1;
			this.pictureBox.TabStop = false;
			this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
			// 
			// dataGridView
			// 
			this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_number,
            this.Column_9_00,
            this.Column_10_30,
            this.Column_12_00,
            this.Column_13_30,
            this.Column_15_00,
            this.Column_16_30,
            this.Column_18_00,
            this.Column_19_30});
			this.dataGridView.Location = new System.Drawing.Point(0, 128);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.Size = new System.Drawing.Size(651, 423);
			this.dataGridView.TabIndex = 3;
			this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
			// 
			// Column_number
			// 
			this.Column_number.HeaderText = "№";
			this.Column_number.Name = "Column_number";
			// 
			// Column_9_00
			// 
			this.Column_9_00.HeaderText = "9:00";
			this.Column_9_00.Name = "Column_9_00";
			this.Column_9_00.Width = 60;
			// 
			// Column_10_30
			// 
			this.Column_10_30.HeaderText = "10:30";
			this.Column_10_30.Name = "Column_10_30";
			this.Column_10_30.Width = 60;
			// 
			// Column_12_00
			// 
			this.Column_12_00.HeaderText = "12:00";
			this.Column_12_00.Name = "Column_12_00";
			this.Column_12_00.Width = 60;
			// 
			// Column_13_30
			// 
			this.Column_13_30.HeaderText = "13:30";
			this.Column_13_30.Name = "Column_13_30";
			this.Column_13_30.Width = 60;
			// 
			// Column_15_00
			// 
			this.Column_15_00.HeaderText = "15:00";
			this.Column_15_00.Name = "Column_15_00";
			this.Column_15_00.Width = 60;
			// 
			// Column_16_30
			// 
			this.Column_16_30.HeaderText = "16:30";
			this.Column_16_30.Name = "Column_16_30";
			this.Column_16_30.Width = 60;
			// 
			// Column_18_00
			// 
			this.Column_18_00.HeaderText = "18:00";
			this.Column_18_00.Name = "Column_18_00";
			this.Column_18_00.Width = 60;
			// 
			// Column_19_30
			// 
			this.Column_19_30.HeaderText = "19:30";
			this.Column_19_30.Name = "Column_19_30";
			this.Column_19_30.Width = 60;
			// 
			// MainFormTeacher
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(651, 551);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.pictureBox);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "MainFormTeacher";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainFormTeacher";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DateTimePicker dateTimePicker;
		private System.Windows.Forms.Label label_notification;
		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column_number;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column_9_00;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column_10_30;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column_12_00;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column_13_30;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column_15_00;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column_16_30;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column_18_00;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column_19_30;
	}
}