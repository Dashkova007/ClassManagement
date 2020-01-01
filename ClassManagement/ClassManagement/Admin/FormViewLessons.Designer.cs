namespace ClassManagement.Admin {
	partial class FormViewLessons {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormViewLessons));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tsb_add = new System.Windows.Forms.ToolStripButton();
			this.tsb_edit = new System.Windows.Forms.ToolStripButton();
			this.tsb_cancel = new System.Windows.Forms.ToolStripButton();
			this.tsb_export_table = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.ts_label = new System.Windows.Forms.ToolStripLabel();
			this.ts_cmb_date_filter = new System.Windows.Forms.ToolStripComboBox();
			this.tsb_search = new System.Windows.Forms.ToolStripButton();
			this.tsb_clear_search = new System.Windows.Forms.ToolStripButton();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_add,
            this.tsb_edit,
            this.tsb_cancel,
            this.tsb_export_table,
            this.toolStripSeparator1,
            this.ts_label,
            this.ts_cmb_date_filter,
            this.tsb_search,
            this.tsb_clear_search});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(945, 28);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tsb_add
			// 
			this.tsb_add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tsb_add.Image = ((System.Drawing.Image)(resources.GetObject("tsb_add.Image")));
			this.tsb_add.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsb_add.Name = "tsb_add";
			this.tsb_add.Size = new System.Drawing.Size(83, 25);
			this.tsb_add.Text = "Добавить";
			this.tsb_add.Click += new System.EventHandler(this.tsb_add_Click);
			// 
			// tsb_edit
			// 
			this.tsb_edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tsb_edit.Image = ((System.Drawing.Image)(resources.GetObject("tsb_edit.Image")));
			this.tsb_edit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsb_edit.Name = "tsb_edit";
			this.tsb_edit.Size = new System.Drawing.Size(121, 25);
			this.tsb_edit.Text = "Редактировать";
			this.tsb_edit.Click += new System.EventHandler(this.tsb_edit_Click);
			// 
			// tsb_cancel
			// 
			this.tsb_cancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tsb_cancel.Image = ((System.Drawing.Image)(resources.GetObject("tsb_cancel.Image")));
			this.tsb_cancel.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsb_cancel.Name = "tsb_cancel";
			this.tsb_cancel.Size = new System.Drawing.Size(145, 25);
			this.tsb_cancel.Text = "Отменить занятие";
			this.tsb_cancel.Click += new System.EventHandler(this.tsb_cancel_Click);
			// 
			// tsb_export_table
			// 
			this.tsb_export_table.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tsb_export_table.Image = ((System.Drawing.Image)(resources.GetObject("tsb_export_table.Image")));
			this.tsb_export_table.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsb_export_table.Name = "tsb_export_table";
			this.tsb_export_table.Size = new System.Drawing.Size(189, 25);
			this.tsb_export_table.Text = "Экспорт эксель таблицы";
			this.tsb_export_table.Click += new System.EventHandler(this.tsb_export_table_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
			// 
			// ts_label
			// 
			this.ts_label.Name = "ts_label";
			this.ts_label.Size = new System.Drawing.Size(95, 25);
			this.ts_label.Text = "Показать за";
			// 
			// ts_cmb_date_filter
			// 
			this.ts_cmb_date_filter.Name = "ts_cmb_date_filter";
			this.ts_cmb_date_filter.Size = new System.Drawing.Size(121, 28);
			// 
			// tsb_search
			// 
			this.tsb_search.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsb_search.Image = ((System.Drawing.Image)(resources.GetObject("tsb_search.Image")));
			this.tsb_search.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsb_search.Name = "tsb_search";
			this.tsb_search.Size = new System.Drawing.Size(23, 25);
			this.tsb_search.Text = "toolStripButton1";
			this.tsb_search.Click += new System.EventHandler(this.tsb_search_Click);
			// 
			// tsb_clear_search
			// 
			this.tsb_clear_search.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tsb_clear_search.Image = ((System.Drawing.Image)(resources.GetObject("tsb_clear_search.Image")));
			this.tsb_clear_search.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsb_clear_search.Name = "tsb_clear_search";
			this.tsb_clear_search.Size = new System.Drawing.Size(128, 25);
			this.tsb_clear_search.Text = "Очистить поиск";
			this.tsb_clear_search.Click += new System.EventHandler(this.tsb_clear_search_Click);
			// 
			// dataGridView
			// 
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView.Location = new System.Drawing.Point(0, 28);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.Size = new System.Drawing.Size(945, 664);
			this.dataGridView.TabIndex = 1;
			// 
			// FormViewLessons
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(945, 692);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.toolStrip1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "FormViewLessons";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LessonsForm";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton tsb_add;
		private System.Windows.Forms.ToolStripButton tsb_edit;
		private System.Windows.Forms.ToolStripButton tsb_cancel;
		private System.Windows.Forms.ToolStripButton tsb_export_table;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripLabel ts_label;
		private System.Windows.Forms.ToolStripComboBox ts_cmb_date_filter;
		private System.Windows.Forms.ToolStripButton tsb_search;
		private System.Windows.Forms.ToolStripButton tsb_clear_search;
		private System.Windows.Forms.DataGridView dataGridView;
	}
}