namespace ClassManagement.Admin {
	partial class FormViewAudience {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormViewAudience));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tsb_add = new System.Windows.Forms.ToolStripButton();
			this.tsb_edit = new System.Windows.Forms.ToolStripButton();
			this.tsb_block = new System.Windows.Forms.ToolStripButton();
			this.tsb_unlock = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.tsb_show_blocked = new System.Windows.Forms.ToolStripButton();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.AutoSize = false;
			this.toolStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_add,
            this.tsb_edit,
            this.tsb_block,
            this.tsb_unlock,
            this.toolStripSeparator1,
            this.tsb_show_blocked});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(842, 40);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tsb_add
			// 
			this.tsb_add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tsb_add.Image = ((System.Drawing.Image)(resources.GetObject("tsb_add.Image")));
			this.tsb_add.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsb_add.Name = "tsb_add";
			this.tsb_add.Size = new System.Drawing.Size(83, 37);
			this.tsb_add.Text = "Добавить";
			this.tsb_add.Click += new System.EventHandler(this.tsb_add_Click);
			// 
			// tsb_edit
			// 
			this.tsb_edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tsb_edit.Image = ((System.Drawing.Image)(resources.GetObject("tsb_edit.Image")));
			this.tsb_edit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsb_edit.Name = "tsb_edit";
			this.tsb_edit.Size = new System.Drawing.Size(121, 37);
			this.tsb_edit.Text = "Редактировать";
			this.tsb_edit.Click += new System.EventHandler(this.tsb_edit_Click);
			// 
			// tsb_block
			// 
			this.tsb_block.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tsb_block.Image = ((System.Drawing.Image)(resources.GetObject("tsb_block.Image")));
			this.tsb_block.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsb_block.Name = "tsb_block";
			this.tsb_block.Size = new System.Drawing.Size(123, 37);
			this.tsb_block.Text = "Заблокировать";
			this.tsb_block.Click += new System.EventHandler(this.tsb_block_Click);
			// 
			// tsb_unlock
			// 
			this.tsb_unlock.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tsb_unlock.Image = ((System.Drawing.Image)(resources.GetObject("tsb_unlock.Image")));
			this.tsb_unlock.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsb_unlock.Name = "tsb_unlock";
			this.tsb_unlock.Size = new System.Drawing.Size(130, 37);
			this.tsb_unlock.Text = "Разблокировать";
			this.tsb_unlock.Click += new System.EventHandler(this.tsb_unlock_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
			// 
			// tsb_show_blocked
			// 
			this.tsb_show_blocked.Checked = true;
			this.tsb_show_blocked.CheckOnClick = true;
			this.tsb_show_blocked.CheckState = System.Windows.Forms.CheckState.Checked;
			this.tsb_show_blocked.Image = ((System.Drawing.Image)(resources.GetObject("tsb_show_blocked.Image")));
			this.tsb_show_blocked.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsb_show_blocked.Name = "tsb_show_blocked";
			this.tsb_show_blocked.Size = new System.Drawing.Size(229, 37);
			this.tsb_show_blocked.Text = "Показать заблокированные";
			this.tsb_show_blocked.CheckedChanged += new System.EventHandler(this.tsb_show_blocked_CheckedChanged);
			// 
			// dataGridView
			// 
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView.Location = new System.Drawing.Point(0, 40);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.Size = new System.Drawing.Size(842, 652);
			this.dataGridView.TabIndex = 1;
			// 
			// FormViewAudience
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(842, 692);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.toolStrip1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "FormViewAudience";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormViewAudience";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton tsb_add;
		private System.Windows.Forms.ToolStripButton tsb_edit;
		private System.Windows.Forms.ToolStripButton tsb_block;
		private System.Windows.Forms.ToolStripButton tsb_unlock;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton tsb_show_blocked;
		private System.Windows.Forms.DataGridView dataGridView;
	}
}