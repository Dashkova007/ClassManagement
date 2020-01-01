namespace ClassManagement.Teacher {
	partial class PersonalForm {
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
			this.comboBox = new System.Windows.Forms.ComboBox();
			this.button = new System.Windows.Forms.Button();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.dgv_notifications = new System.Windows.Forms.DataGridView();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.dgv_history = new System.Windows.Forms.DataGridView();
			this.tabControl.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_notifications)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_history)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(19, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Вывести";
			// 
			// comboBox
			// 
			this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox.FormattingEnabled = true;
			this.comboBox.Location = new System.Drawing.Point(100, 20);
			this.comboBox.Name = "comboBox";
			this.comboBox.Size = new System.Drawing.Size(200, 28);
			this.comboBox.TabIndex = 1;
			this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
			// 
			// button
			// 
			this.button.AutoSize = true;
			this.button.Location = new System.Drawing.Point(306, 19);
			this.button.Name = "button";
			this.button.Size = new System.Drawing.Size(96, 30);
			this.button.TabIndex = 2;
			this.button.Text = "Отменить";
			this.button.UseVisualStyleBackColor = true;
			this.button.Click += new System.EventHandler(this.button_Click);
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabPage1);
			this.tabControl.Controls.Add(this.tabPage2);
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tabControl.Location = new System.Drawing.Point(0, 55);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(656, 504);
			this.tabControl.TabIndex = 3;
			this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.dgv_notifications);
			this.tabPage1.Location = new System.Drawing.Point(4, 29);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(648, 471);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Новые уведомления";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// dgv_notifications
			// 
			this.dgv_notifications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_notifications.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgv_notifications.Location = new System.Drawing.Point(3, 3);
			this.dgv_notifications.Name = "dgv_notifications";
			this.dgv_notifications.Size = new System.Drawing.Size(642, 465);
			this.dgv_notifications.TabIndex = 0;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.dgv_history);
			this.tabPage2.Location = new System.Drawing.Point(4, 29);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(648, 471);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "История";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// dgv_history
			// 
			this.dgv_history.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_history.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgv_history.Location = new System.Drawing.Point(3, 3);
			this.dgv_history.Name = "dgv_history";
			this.dgv_history.Size = new System.Drawing.Size(642, 465);
			this.dgv_history.TabIndex = 0;
			// 
			// PersonalForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(656, 559);
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.button);
			this.Controls.Add(this.comboBox);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "PersonalForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PersonalForm";
			this.tabControl.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgv_notifications)).EndInit();
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgv_history)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox;
		private System.Windows.Forms.Button button;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.DataGridView dgv_notifications;
		private System.Windows.Forms.DataGridView dgv_history;
	}
}