using ClassManagement.Admin;
using ClassManagement.Teacher;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassManagement {
	public partial class LoginForm : Form {
		StepSchedulerEntities db = null; // наша модель
		List<Users> users = null;
		public string userLogin = null;
		public LoginForm() {
			InitializeComponent();
			tb_password.PasswordChar = '*';
			db = new StepSchedulerEntities();// инициализация 

			tb_login.MaxLength = 20;
			tb_password.MaxLength = 20;

			Task task = Task.Run(() => {
				try {
					users = db.Users.ToList();
				}
				catch (Exception) { }
			});

			//События
			tb_password.KeyDown += tb_password_KeyDown;
			tb_login.KeyDown += tb_password_KeyDown;


			try {
				pb_login.Image = Image.FromFile(@"images/loginBg.jpg");
				pb_login.SizeMode = PictureBoxSizeMode.Zoom;
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
			bt_enter.BackColor = Color.FromArgb(51, 204, 102);
		}

		public void LogIn(StepSchedulerEntities db, string login, string password) {
			Regex regex = new Regex("^[a-zA-Z0-9]+([._]?[a-zA-Z0-9]+){2}$");

			string input_login = tb_login.Text;
			string input_password = tb_password.Text;

			//Если логин и пароль прошли валидацию
			if (regex.Match(input_login).Success && regex.Match(input_password).Success) {

				if (tb_login.InvokeRequired) {
					//BeginInvoke(new Action(RefreshTxtBox));
					RefreshTxtBox();
				}
				if (tb_password.InvokeRequired) {
					//BeginInvoke(new Action(RefreshTxtBox));
					RefreshTxtBox();
				}

				//ADMIN
				int corect_login = users.Where(user => user.Login == input_login).Count();
				if (corect_login == 1) {
					var corect_password = users.Where(user => user.Login == input_login).Where(user => user.Password == input_password.ToString()).Count();
					var isAdmin = users.Where(u => u.Login == input_login).Select(u => u.IsAdmin).FirstOrDefault();
					int id = db.Users.Where(g => g.Login == input_login).FirstOrDefault().UserId;
					if (corect_password == 1) {
						this.DialogResult = DialogResult.OK;
						userLogin = input_login;
						if (Convert.ToBoolean(isAdmin)) {
							if (this.InvokeRequired) {
								BeginInvoke(new Action(MakeNonVisible));
							}
							MainFormAdmin form = new MainFormAdmin(id);
							form.Show();
						}
						else {
							MainFormTeacher form = new MainFormTeacher(id);
							form.Show();
							if (this.InvokeRequired) {
								BeginInvoke(new Action(MakeNonVisible));
							}
						}
					}
					else {
						tb_password.BackColor = Color.PaleVioletRed;
						MessageBox.Show("Incorrect password");
					}
				}
				else {
					tb_login.BackColor = Color.PaleVioletRed;
					MessageBox.Show("Incorrect username");
				}
			}
			else {
				if (!regex.Match(input_password).Success) {
					tb_password.BackColor = Color.PaleVioletRed;
				}
				if (!regex.Match(input_login).Success) {
					tb_login.BackColor = Color.PaleVioletRed;
				}
			}
		}

		private void MakeNonVisible() {
			Visible = false;
		}

		private void RefreshTxtBox() {
			tb_login.BackColor = Color.White;
			tb_password.BackColor = Color.White;
		}

		private void bt_enter_Click(object sender, EventArgs e) {
			LogIn(db, tb_login.Text, tb_password.Text);
		}

		private void tb_password_KeyDown(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Enter) {
				LogIn(db, tb_login.Text, tb_password.Text);
			}
		}
	}
}
