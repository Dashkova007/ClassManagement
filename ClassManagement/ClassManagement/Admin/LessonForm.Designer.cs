namespace ClassManagement.Admin {
	partial class LessonForm {
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
			this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.cmb_time = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cmb_classrooms = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cmb_users = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cmb_eventTypes = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.numericUD = new System.Windows.Forms.NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.richTextBox = new System.Windows.Forms.RichTextBox();
			this.button = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numericUD)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(23, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Дата";
			// 
			// dateTimePicker
			// 
			this.dateTimePicker.Location = new System.Drawing.Point(167, 21);
			this.dateTimePicker.Name = "dateTimePicker";
			this.dateTimePicker.Size = new System.Drawing.Size(200, 26);
			this.dateTimePicker.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(23, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Время";
			// 
			// cmb_time
			// 
			this.cmb_time.FormattingEnabled = true;
			this.cmb_time.Location = new System.Drawing.Point(167, 61);
			this.cmb_time.Name = "cmb_time";
			this.cmb_time.Size = new System.Drawing.Size(200, 28);
			this.cmb_time.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(23, 106);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(92, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "Аудитория";
			// 
			// cmb_classrooms
			// 
			this.cmb_classrooms.FormattingEnabled = true;
			this.cmb_classrooms.Location = new System.Drawing.Point(167, 103);
			this.cmb_classrooms.Name = "cmb_classrooms";
			this.cmb_classrooms.Size = new System.Drawing.Size(200, 28);
			this.cmb_classrooms.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(23, 148);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(132, 20);
			this.label4.TabIndex = 6;
			this.label4.Text = "Преподаватель";
			// 
			// cmb_users
			// 
			this.cmb_users.FormattingEnabled = true;
			this.cmb_users.Location = new System.Drawing.Point(167, 145);
			this.cmb_users.Name = "cmb_users";
			this.cmb_users.Size = new System.Drawing.Size(200, 28);
			this.cmb_users.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(23, 190);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(102, 20);
			this.label5.TabIndex = 8;
			this.label5.Text = "Тип занятия";
			// 
			// cmb_eventTypes
			// 
			this.cmb_eventTypes.FormattingEnabled = true;
			this.cmb_eventTypes.Location = new System.Drawing.Point(167, 187);
			this.cmb_eventTypes.Name = "cmb_eventTypes";
			this.cmb_eventTypes.Size = new System.Drawing.Size(200, 28);
			this.cmb_eventTypes.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(23, 232);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(218, 20);
			this.label6.TabIndex = 10;
			this.label6.Text = "Ожидаемое к-во студентов";
			// 
			// numericUD
			// 
			this.numericUD.Location = new System.Drawing.Point(247, 229);
			this.numericUD.Name = "numericUD";
			this.numericUD.Size = new System.Drawing.Size(120, 26);
			this.numericUD.TabIndex = 11;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(23, 274);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(113, 20);
			this.label7.TabIndex = 12;
			this.label7.Text = "Комментарий";
			// 
			// richTextBox
			// 
			this.richTextBox.Location = new System.Drawing.Point(27, 297);
			this.richTextBox.Name = "richTextBox";
			this.richTextBox.Size = new System.Drawing.Size(340, 150);
			this.richTextBox.TabIndex = 13;
			this.richTextBox.Text = "";
			// 
			// button
			// 
			this.button.AutoSize = true;
			this.button.Location = new System.Drawing.Point(167, 461);
			this.button.Name = "button";
			this.button.Size = new System.Drawing.Size(200, 30);
			this.button.TabIndex = 14;
			this.button.Text = "Подтвердить";
			this.button.UseVisualStyleBackColor = true;
			this.button.Click += new System.EventHandler(this.button_Click);
			// 
			// LessonForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(387, 512);
			this.Controls.Add(this.button);
			this.Controls.Add(this.richTextBox);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.numericUD);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.cmb_eventTypes);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cmb_users);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cmb_classrooms);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cmb_time);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dateTimePicker);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "LessonForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LessonForm";
			((System.ComponentModel.ISupportInitialize)(this.numericUD)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dateTimePicker;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmb_time;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmb_classrooms;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cmb_users;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cmb_eventTypes;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown numericUD;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.RichTextBox richTextBox;
		private System.Windows.Forms.Button button;
	}
}