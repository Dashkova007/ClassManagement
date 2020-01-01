using System;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ClassManagement.Admin {
	public partial class FormViewAudience : Form {
		StepSchedulerEntities db = null; // создаем объект entity framework
		ClassRooms rooms = null;
		public FormViewAudience() {
			InitializeComponent();
			tsb_show_blocked.Image = Image.FromFile(@"images/uncheck.png");
			db = new StepSchedulerEntities();
			this.rooms = rooms;
			InitAud();
		}

		private void InitAud() {
			db.ClassRooms.Load(); // при загрузке формы мы грузим таблицу classrooms
			dataGridView.DataSource = db.ClassRooms.Local.ToBindingList(); // привязываем таблицу classrooms к елементу dgv
			dataGridView.Columns["Requests"].Visible = false; // не даем таблице requests вывестись в dgv
			dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView.RowHeadersVisible = false;
		}

		private void tsb_add_Click(object sender, EventArgs e) {
			ClassRooms rooms = new ClassRooms(); // создаем объект таблицы classrooms 
			AudienceForm af = new AudienceForm(/*rooms*/); // создаем объект формы audienceform и передаем объект таблицы classrooms в этот конструктор
			if (af.ShowDialog() == DialogResult.OK) { db.ClassRooms.Add(rooms); db.SaveChanges(); }
		}

		private void tsb_edit_Click(object sender, EventArgs e) {
			if (dataGridView.SelectedRows.Count > 0) { // проверяем что хотя бы 1 строка выделена
				int index = dataGridView.SelectedRows[0].Index; // присваиваем переменной значение выделенной строки 
				int Id = 0;
				bool converted = Int32.TryParse(dataGridView[0, index].Value.ToString(), out Id);
				if (converted == false) { return; }
				ClassRooms rooms = db.ClassRooms.Find(Id); // находим запись
				AudienceForm af = new AudienceForm(/*rooms*/); // открываем форму добавления
				if (af.ShowDialog() == DialogResult.OK) // проверяем что все было сделано
				{ db.SaveChanges(); dataGridView.Refresh(); MessageBox.Show("Editted"); } // сохраняем изменения и обновляем вид dgv
			}
		}

		private void tsb_block_Click(object sender, EventArgs e) {
			if (dataGridView.SelectedRows.Count > 0) {
				int index = dataGridView.SelectedRows[0].Index;
				int Id = 0;
				bool converted = Int32.TryParse(dataGridView[0, index].Value.ToString(), out Id);
				if (converted == false) { return; }
				ClassRooms rooms = db.ClassRooms.Find(Id);
				rooms.IsAvailable = true; // меняем поле на значение "заблокировано"
				db.SaveChanges();
				dataGridView.Refresh();
				MessageBox.Show("Audience is blocked now");
			}
		}

		private void tsb_unlock_Click(object sender, EventArgs e) {
			if (dataGridView.SelectedRows.Count > 0) {
				int index = dataGridView.SelectedRows[0].Index;
				int Id = 0;
				bool converted = Int32.TryParse(dataGridView[0, index].Value.ToString(), out Id);
				if (converted == false) { return; }
				ClassRooms rooms = db.ClassRooms.Find(Id);
				rooms.IsAvailable = false; // меняем поле на значение "заблокировано"
				db.SaveChanges();
				dataGridView.Refresh();
				MessageBox.Show("Audience is unblocked now");
			}
		}

		private void tsb_show_blocked_CheckedChanged(object sender, EventArgs e) {
			if (tsb_show_blocked.Checked) {
				db = new StepSchedulerEntities();
				db.ClassRooms.Load();
				var query = db.ClassRooms.Local.Where(x => x.IsAvailable == true).ToList();
				dataGridView.DataSource = null;
				dataGridView.DataSource = query;
				dataGridView.Columns["Requests"].Visible = false;
				tsb_show_blocked.Image = Image.FromFile(@"images/check.png");
			}
			else {
				InitAud();
				tsb_show_blocked.Image = Image.FromFile(@"images/uncheck.png");
			}
		}
	}
}
