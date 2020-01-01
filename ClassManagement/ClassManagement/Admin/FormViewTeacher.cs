using System;
using System.Data.Entity;
using System.Drawing;
using System.Windows.Forms;

namespace ClassManagement.Admin {
	public partial class FormViewTeacher : Form {
		StepSchedulerEntities db = null; // создаем объект entity framework
		Users user = null;

		public FormViewTeacher(Users users) {
			InitializeComponent();
			db = new StepSchedulerEntities();
			try {
				tsb_search.Image = Image.FromFile(@"images/search.png");
				tsb_show_blocked.Image = Image.FromFile(@"images/uncheck.png");
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
			this.user = users;
			InitUser();
		}

		private void InitUser() {
			db.Users.Load(); //подключаемся к базе к таб.User
			dataGridView.DataSource = null;
			dataGridView.DataSource = db.Users.Local.ToBindingList();//выводим данные в dataGrid
			dataGridView.Columns["Requests"].Visible = false;//убираем колонки таблицы Requests
			dataGridView.Columns["UserId"].Visible = false;
			dataGridView.Columns["Photo"].Visible = false;
			dataGridView.Columns["Login"].Visible = false;
			dataGridView.Columns["Password"].Visible = false;
			dataGridView.Columns["IsAdmin"].Visible = false;
			dataGridView.Columns["IsBlocked"].Visible = false;
		}

		private void tsb_add_Click(object sender, EventArgs e) {
			user = new Users();
			TeacherInfoForm form = new TeacherInfoForm(user);
			form.Show();
		}

		private void tsb_edit_Click(object sender, EventArgs e) {
			int index = dataGridView.SelectedRows[0].Index;
			int Id;
			bool converted = Int32.TryParse(dataGridView[0, index].Value.ToString(), out Id);
			if (converted == false)
				return;
			user = db.Users.Find(Id);//находим по индексу значение
			TeacherInfoForm f = new TeacherInfoForm(user);//открываем доп. форму

			if (f.ShowDialog() == DialogResult.OK) {
				db.SaveChanges();//сохраняем изменения
				dataGridView.Update();//обновляем отредактированые данные
				dataGridView.Refresh();
				MessageBox.Show("Данные отредактированные!");
			}
			else {
				MessageBox.Show("Не удалось отредактировать данные!");
			}
		}

		private void tsb_block_Click(object sender, EventArgs e) {
			if (dataGridView.SelectedRows.Count == 1) {
				int index = dataGridView.SelectedRows[0].Index;
				int Id;
				bool converted = Int32.TryParse(dataGridView[0, index].Value.ToString(), out Id);
				if (converted == false)
					return;
				user = db.Users.Find(Id);
				user.IsBlocked = true;
				db.SaveChanges();
				//выделяем пользователя красным цветом
				dataGridView.SelectedRows[0].DefaultCellStyle.BackColor = Color.Gray;

				dataGridView.Update();
				dataGridView.Refresh();
				MessageBox.Show("Пользователь заблокирован!");
			}
			else {
				MessageBox.Show("Не удалось заблокировать данные!");
			}
		}

		private void tsb_unblock_Click(object sender, EventArgs e) {

		}

		private void tsb_search_Click(object sender, EventArgs e) {

		}

		private void tsb_clear_search_Click(object sender, EventArgs e) {
			db = new StepSchedulerEntities();
			db.Users.Load(); //подключаемся к базе к таб.User
			dataGridView.DataSource = null;
			dataGridView.DataSource = db.Users.Local.ToBindingList();//выводим данные в dataGrid
			dataGridView.Columns["Requests"].Visible = false;//убираем колонки таблицы Requests           
			dataGridView.Columns["Photo"].Visible = false;
		}

		private void tsb_show_blocked_CheckedChanged(object sender, EventArgs e) {
			if (tsb_show_blocked.Checked) {
				ShowBlockTeachers();
			}
		}

		private void ShowBlockTeachers() {
			if (dataGridView.SelectedRows.Count == 1) {
				int index = dataGridView.SelectedRows[0].Index;
				int Id;
				bool converted = Int32.TryParse(dataGridView[0, index].Value.ToString(), out Id);
				if (converted == false)
					return;
				user = db.Users.Find(Id);
				user.IsBlocked = true;
				db.SaveChanges();
				//выделяем пользователя красным цветом
				dataGridView.SelectedRows[0].DefaultCellStyle.BackColor = Color.Gray;
				dataGridView.Update();
				dataGridView.Refresh();
				MessageBox.Show("Пользователь заблокирован!");
			}
			else {
				MessageBox.Show("Не удалось заблокировать данные!");
			}
		}
	}
}
