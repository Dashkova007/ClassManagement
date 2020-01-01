namespace ClassManagement.Admin {
	partial class ConfirmationForm {
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tp_new_notifications = new System.Windows.Forms.TabPage();
			this.bt_confirm = new System.Windows.Forms.Button();
			this.bt_reject = new System.Windows.Forms.Button();
			this.dgv_notification = new System.Windows.Forms.DataGridView();
			this.tp_story = new System.Windows.Forms.TabPage();
			this.dgv_story = new System.Windows.Forms.DataGridView();
			this.chB_teacher = new System.Windows.Forms.CheckBox();
			this.cmB_teacher = new System.Windows.Forms.ComboBox();
			this.chB_categories = new System.Windows.Forms.CheckBox();
			this.cmB_categories = new System.Windows.Forms.ComboBox();
			this.chB_date = new System.Windows.Forms.CheckBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.chB_couples = new System.Windows.Forms.CheckBox();
			this.cmB_couples = new System.Windows.Forms.ComboBox();
			this.bt_filter = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.tabControl1.SuspendLayout();
			this.tp_new_notifications.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_notification)).BeginInit();
			this.tp_story.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_story)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tp_new_notifications);
			this.tabControl1.Controls.Add(this.tp_story);
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(730, 692);
			this.tabControl1.TabIndex = 0;
			// 
			// tp_new_notifications
			// 
			this.tp_new_notifications.BackColor = System.Drawing.SystemColors.Control;
			this.tp_new_notifications.Controls.Add(this.panel2);
			this.tp_new_notifications.Controls.Add(this.dgv_notification);
			this.tp_new_notifications.Location = new System.Drawing.Point(4, 29);
			this.tp_new_notifications.Name = "tp_new_notifications";
			this.tp_new_notifications.Padding = new System.Windows.Forms.Padding(3);
			this.tp_new_notifications.Size = new System.Drawing.Size(722, 659);
			this.tp_new_notifications.TabIndex = 0;
			this.tp_new_notifications.Text = "Новые уведомления";
			// 
			// bt_confirm
			// 
			this.bt_confirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.bt_confirm.AutoSize = true;
			this.bt_confirm.Location = new System.Drawing.Point(513, 7);
			this.bt_confirm.Name = "bt_confirm";
			this.bt_confirm.Size = new System.Drawing.Size(200, 30);
			this.bt_confirm.TabIndex = 2;
			this.bt_confirm.Text = "Подтвердить";
			this.bt_confirm.UseVisualStyleBackColor = true;
			this.bt_confirm.Click += new System.EventHandler(this.bt_confirm_Click);
			// 
			// bt_reject
			// 
			this.bt_reject.AutoSize = true;
			this.bt_reject.Location = new System.Drawing.Point(5, 7);
			this.bt_reject.Name = "bt_reject";
			this.bt_reject.Size = new System.Drawing.Size(200, 30);
			this.bt_reject.TabIndex = 1;
			this.bt_reject.Text = "Отклонить";
			this.bt_reject.UseVisualStyleBackColor = true;
			this.bt_reject.Click += new System.EventHandler(this.bt_reject_Click);
			// 
			// dgv_notification
			// 
			this.dgv_notification.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgv_notification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_notification.Location = new System.Drawing.Point(3, 3);
			this.dgv_notification.Name = "dgv_notification";
			this.dgv_notification.Size = new System.Drawing.Size(716, 610);
			this.dgv_notification.TabIndex = 0;
			// 
			// tp_story
			// 
			this.tp_story.Controls.Add(this.dgv_story);
			this.tp_story.Location = new System.Drawing.Point(4, 29);
			this.tp_story.Name = "tp_story";
			this.tp_story.Padding = new System.Windows.Forms.Padding(3);
			this.tp_story.Size = new System.Drawing.Size(694, 659);
			this.tp_story.TabIndex = 1;
			this.tp_story.Text = "История";
			this.tp_story.UseVisualStyleBackColor = true;
			// 
			// dgv_story
			// 
			this.dgv_story.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_story.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgv_story.Location = new System.Drawing.Point(3, 3);
			this.dgv_story.Name = "dgv_story";
			this.dgv_story.Size = new System.Drawing.Size(688, 653);
			this.dgv_story.TabIndex = 0;
			// 
			// chB_teacher
			// 
			this.chB_teacher.AutoSize = true;
			this.chB_teacher.Location = new System.Drawing.Point(16, 29);
			this.chB_teacher.Name = "chB_teacher";
			this.chB_teacher.Size = new System.Drawing.Size(151, 24);
			this.chB_teacher.TabIndex = 1;
			this.chB_teacher.Text = "Преподаватель";
			this.chB_teacher.UseVisualStyleBackColor = true;
			this.chB_teacher.CheckedChanged += new System.EventHandler(this.chB_teacher_CheckedChanged);
			// 
			// cmB_teacher
			// 
			this.cmB_teacher.FormattingEnabled = true;
			this.cmB_teacher.Location = new System.Drawing.Point(16, 59);
			this.cmB_teacher.Name = "cmB_teacher";
			this.cmB_teacher.Size = new System.Drawing.Size(256, 28);
			this.cmB_teacher.TabIndex = 2;
			// 
			// chB_categories
			// 
			this.chB_categories.AutoSize = true;
			this.chB_categories.Location = new System.Drawing.Point(16, 93);
			this.chB_categories.Name = "chB_categories";
			this.chB_categories.Size = new System.Drawing.Size(121, 24);
			this.chB_categories.TabIndex = 3;
			this.chB_categories.Text = "Тип занятия";
			this.chB_categories.UseVisualStyleBackColor = true;
			this.chB_categories.CheckedChanged += new System.EventHandler(this.chB_categories_CheckedChanged);
			// 
			// cmB_categories
			// 
			this.cmB_categories.FormattingEnabled = true;
			this.cmB_categories.Location = new System.Drawing.Point(16, 123);
			this.cmB_categories.Name = "cmB_categories";
			this.cmB_categories.Size = new System.Drawing.Size(256, 28);
			this.cmB_categories.TabIndex = 4;
			// 
			// chB_date
			// 
			this.chB_date.AutoSize = true;
			this.chB_date.Location = new System.Drawing.Point(16, 157);
			this.chB_date.Name = "chB_date";
			this.chB_date.Size = new System.Drawing.Size(67, 24);
			this.chB_date.TabIndex = 5;
			this.chB_date.Text = "Дата";
			this.chB_date.UseVisualStyleBackColor = true;
			this.chB_date.CheckedChanged += new System.EventHandler(this.chB_date_CheckedChanged);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(16, 187);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(256, 26);
			this.dateTimePicker1.TabIndex = 6;
			// 
			// chB_couples
			// 
			this.chB_couples.AutoSize = true;
			this.chB_couples.Location = new System.Drawing.Point(16, 219);
			this.chB_couples.Name = "chB_couples";
			this.chB_couples.Size = new System.Drawing.Size(67, 24);
			this.chB_couples.TabIndex = 7;
			this.chB_couples.Text = "Пара";
			this.chB_couples.UseVisualStyleBackColor = true;
			this.chB_couples.CheckedChanged += new System.EventHandler(this.chB_couples_CheckedChanged);
			// 
			// cmB_couples
			// 
			this.cmB_couples.FormattingEnabled = true;
			this.cmB_couples.Location = new System.Drawing.Point(16, 249);
			this.cmB_couples.Name = "cmB_couples";
			this.cmB_couples.Size = new System.Drawing.Size(256, 28);
			this.cmB_couples.TabIndex = 8;
			// 
			// bt_filter
			// 
			this.bt_filter.AutoSize = true;
			this.bt_filter.Location = new System.Drawing.Point(16, 292);
			this.bt_filter.Name = "bt_filter";
			this.bt_filter.Size = new System.Drawing.Size(125, 30);
			this.bt_filter.TabIndex = 9;
			this.bt_filter.Text = "Фильтровать";
			this.bt_filter.UseVisualStyleBackColor = true;
			this.bt_filter.Click += new System.EventHandler(this.bt_filter_Click);
			// 
			// button2
			// 
			this.button2.AutoSize = true;
			this.button2.Location = new System.Drawing.Point(147, 292);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(125, 30);
			this.button2.TabIndex = 10;
			this.button2.Text = "Сбросить";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.chB_teacher);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.cmB_teacher);
			this.panel1.Controls.Add(this.bt_filter);
			this.panel1.Controls.Add(this.chB_categories);
			this.panel1.Controls.Add(this.cmB_couples);
			this.panel1.Controls.Add(this.cmB_categories);
			this.panel1.Controls.Add(this.chB_couples);
			this.panel1.Controls.Add(this.chB_date);
			this.panel1.Controls.Add(this.dateTimePicker1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new System.Drawing.Point(736, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(286, 692);
			this.panel1.TabIndex = 11;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.panel2.Controls.Add(this.bt_reject);
			this.panel2.Controls.Add(this.bt_confirm);
			this.panel2.Location = new System.Drawing.Point(3, 615);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(716, 44);
			this.panel2.TabIndex = 3;
			// 
			// ConfirmationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1022, 692);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.tabControl1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "ConfirmationForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ConfirmationForm";
			this.Load += new System.EventHandler(this.ConfirmationForm_Load);
			this.tabControl1.ResumeLayout(false);
			this.tp_new_notifications.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgv_notification)).EndInit();
			this.tp_story.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgv_story)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tp_new_notifications;
		private System.Windows.Forms.Button bt_confirm;
		private System.Windows.Forms.Button bt_reject;
		private System.Windows.Forms.DataGridView dgv_notification;
		private System.Windows.Forms.TabPage tp_story;
		private System.Windows.Forms.DataGridView dgv_story;
		private System.Windows.Forms.CheckBox chB_teacher;
		private System.Windows.Forms.ComboBox cmB_teacher;
		private System.Windows.Forms.CheckBox chB_categories;
		private System.Windows.Forms.ComboBox cmB_categories;
		private System.Windows.Forms.CheckBox chB_date;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.CheckBox chB_couples;
		private System.Windows.Forms.ComboBox cmB_couples;
		private System.Windows.Forms.Button bt_filter;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
	}
}