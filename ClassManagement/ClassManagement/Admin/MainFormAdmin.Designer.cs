namespace ClassManagement.Admin {
	partial class MainFormAdmin {
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
			this.panel = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.занятияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.преподавателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.аудиторииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_9_00 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_10_30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_12_00 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_13_30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_15_00 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_16_30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_18_00 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_19_30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel.SuspendLayout();
			this.menuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Controls.Add(this.label1);
			this.panel.Controls.Add(this.dateTimePicker);
			this.panel.Controls.Add(this.menuStrip);
			this.panel.Location = new System.Drawing.Point(12, 0);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(475, 122);
			this.panel.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(209, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(263, 50);
			this.label1.TabIndex = 2;
			this.label1.Text = "У вас 0 новых уведомлений";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dateTimePicker
			// 
			this.dateTimePicker.Location = new System.Drawing.Point(3, 60);
			this.dateTimePicker.Name = "dateTimePicker";
			this.dateTimePicker.Size = new System.Drawing.Size(200, 26);
			this.dateTimePicker.TabIndex = 1;
			this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
			// 
			// menuStrip
			// 
			this.menuStrip.AutoSize = false;
			this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.занятияToolStripMenuItem,
            this.преподавателиToolStripMenuItem,
            this.аудиторииToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(475, 35);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "menuStrip1";
			// 
			// занятияToolStripMenuItem
			// 
			this.занятияToolStripMenuItem.Name = "занятияToolStripMenuItem";
			this.занятияToolStripMenuItem.Size = new System.Drawing.Size(80, 31);
			this.занятияToolStripMenuItem.Text = "Занятия";
			this.занятияToolStripMenuItem.Click += new System.EventHandler(this.занятияToolStripMenuItem_Click);
			// 
			// преподавателиToolStripMenuItem
			// 
			this.преподавателиToolStripMenuItem.Name = "преподавателиToolStripMenuItem";
			this.преподавателиToolStripMenuItem.Size = new System.Drawing.Size(133, 31);
			this.преподавателиToolStripMenuItem.Text = "Преподаватели";
			this.преподавателиToolStripMenuItem.Click += new System.EventHandler(this.преподавателиToolStripMenuItem_Click);
			// 
			// аудиторииToolStripMenuItem
			// 
			this.аудиторииToolStripMenuItem.Name = "аудиторииToolStripMenuItem";
			this.аудиторииToolStripMenuItem.Size = new System.Drawing.Size(101, 31);
			this.аудиторииToolStripMenuItem.Text = "Аудитории";
			this.аудиторииToolStripMenuItem.Click += new System.EventHandler(this.аудиторииToolStripMenuItem_Click);
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
			// dataGridView1
			// 
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_number,
            this.Column_9_00,
            this.Column_10_30,
            this.Column_12_00,
            this.Column_13_30,
            this.Column_15_00,
            this.Column_16_30,
            this.Column_18_00,
            this.Column_19_30});
			this.dataGridView1.Location = new System.Drawing.Point(12, 128);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(627, 421);
			this.dataGridView1.TabIndex = 2;
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
			// MainFormAdmin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(651, 561);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.pictureBox);
			this.Controls.Add(this.panel);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "MainFormAdmin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainFormAdmin";
			this.panel.ResumeLayout(false);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel;
		private System.Windows.Forms.DateTimePicker dateTimePicker;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem занятияToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem преподавателиToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem аудиторииToolStripMenuItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.DataGridView dataGridView1;
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