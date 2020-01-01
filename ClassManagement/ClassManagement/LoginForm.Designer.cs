namespace ClassManagement {
	partial class LoginForm {
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent() {
			this.pb_login = new System.Windows.Forms.PictureBox();
			this.tb_login = new System.Windows.Forms.TextBox();
			this.tb_password = new System.Windows.Forms.TextBox();
			this.bt_enter = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pb_login)).BeginInit();
			this.SuspendLayout();
			// 
			// pb_login
			// 
			this.pb_login.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pb_login.Location = new System.Drawing.Point(0, 0);
			this.pb_login.Name = "pb_login";
			this.pb_login.Size = new System.Drawing.Size(960, 540);
			this.pb_login.TabIndex = 0;
			this.pb_login.TabStop = false;
			// 
			// tb_login
			// 
			this.tb_login.Location = new System.Drawing.Point(509, 232);
			this.tb_login.Name = "tb_login";
			this.tb_login.Size = new System.Drawing.Size(200, 29);
			this.tb_login.TabIndex = 1;
			// 
			// tb_password
			// 
			this.tb_password.Location = new System.Drawing.Point(509, 304);
			this.tb_password.Name = "tb_password";
			this.tb_password.Size = new System.Drawing.Size(200, 29);
			this.tb_password.TabIndex = 2;
			this.tb_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_password_KeyDown);
			// 
			// bt_enter
			// 
			this.bt_enter.AutoSize = true;
			this.bt_enter.Location = new System.Drawing.Point(509, 353);
			this.bt_enter.Name = "bt_enter";
			this.bt_enter.Size = new System.Drawing.Size(200, 34);
			this.bt_enter.TabIndex = 3;
			this.bt_enter.Text = "Войти";
			this.bt_enter.UseVisualStyleBackColor = true;
			this.bt_enter.Click += new System.EventHandler(this.bt_enter_Click);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(960, 540);
			this.Controls.Add(this.bt_enter);
			this.Controls.Add(this.tb_password);
			this.Controls.Add(this.tb_login);
			this.Controls.Add(this.pb_login);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(6);
			this.MaximizeBox = false;
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Авторизация";
			((System.ComponentModel.ISupportInitialize)(this.pb_login)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pb_login;
		private System.Windows.Forms.TextBox tb_login;
		private System.Windows.Forms.TextBox tb_password;
		private System.Windows.Forms.Button bt_enter;
	}
}

