using System;
using System.Windows.Forms;

namespace ClassManagement {
	public partial class LoginForm : Form {
		public LoginForm() {
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e) {
			if (textBox1.Text == "0") {
				MainFormAdmin form = new MainFormAdmin();
				form.Show();
			}
			if (textBox1.Text == "1") {
				MainFormTeacher form = new MainFormTeacher();
				form.Show();
			}
		}
	}
}
