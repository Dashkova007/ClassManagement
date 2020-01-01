using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ClassManagement.Admin {
	public partial class MainFormAdmin : Form {
		StepSchedulerEntities db = new StepSchedulerEntities();

		/*	 1 : принят запрос
		 *	 0 : на рассмотрении
		 *	-1 : запрос отклонен	*/

		Color busy = Color.Salmon;      //занятые аудитории помечены красным цветом
		Color free = Color.Green;       //свободные аудитории помечены зеленым цветом
		Color pretend = Color.Yellow;   //аудитории, на которые претендуют преподователи, помечены желтым цветом
		List<Requests> requests = null;
		Users user = null;
		ClassRooms rooms = null;

		int id;

		public MainFormAdmin(int id) {
			InitializeComponent();
			this.id = id;
			try {
				dataGridView1.RowCount = db.ClassRooms.Select(i => i.ClassRoomId).Max(); //К-во аудиторий по умолчанию
				var aud = db.ClassRooms.Select(n => n.Number).ToList();
				for (int i = 0; i < dataGridView1.RowCount - 1; i++) {
					dataGridView1[0, i].Value = aud[i]; //Нумерация аудиторий
				}
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
			

			var t = db.ClassRooms.Select(n => n.Number).ToList();

			for (int i = 1; i < dataGridView1.ColumnCount; i++) {
				for (int j = 0; j < dataGridView1.RowCount; j++) {
					dataGridView1[i, j].Style.BackColor = free; //По умолчанию все аудитории свободны
				}
			}

			requests = db.Requests.ToList();
			try {
				pictureBox.Image = Image.FromFile(@"images/message_old.png");
				pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}

			//public void SetCell(string value, ReservedRooms item)//получает Вид занятия в значении value (З,К,М тоисть Занятие,Консультация,Мероприятие) а в item элемент из базы данных который надо добавить в dataGridView 
			//{
			//	dataGridView1[item.Requests.LessonNumber, item.Requests.ClassRooms.Number - 1].Value = value;// присваиваем З/К/М
			//	string ToolTipString = "Преподаватель: " + item.Requests.Users.Name + " " + item.Requests.Users.Surname + " \n";
			//	ToolTipString += item.Requests.EventDescription;
			//	dataGridView1[item.Requests.LessonNumber, item.Requests.ClassRooms.Number - 1].ToolTipText = ToolTipString;//Описание аудитории ввиде комментария
			//}
			//private void RefreshDataGrid() { //Обновляет содержимое dataGridView 
			//	if (dataGridView1.InvokeRequired) {
			//		BeginInvoke(new Action(RefreshDataGrid));
			//	}
			//	else {
			//		dataGridView1.Rows.Clear();
			//		dataGridView1.RowCount = 15;
			//		for (int i = 0; i < dataGridView1.RowCount - 1; i++) {
			//			dataGridView1[0, i].Value = $"{i + 1} ауд.";
			//		}
			//		dataGridView1[0, dataGridView1.RowCount - 1].Value = "Конф. зал";
			//		for (int i = 1; i < dataGridView1.ColumnCount; i++) {
			//			for (int j = 0; j < dataGridView1.RowCount; j++) {
			//				dataGridView1[i, j].Style.BackColor = free;
			//			}
			//		}
			//		using (StepSchedulerEntities db = new StepSchedulerEntities()) {
			//			IQueryable<ReservedRooms> Querry = from t1 in db.ReservedRooms //достаем зарезервированные аудитории где дата проведения равна дате в dateTimePicker1 
			//											   join t2 in db.Requests on t1.RequestId equals t2.RequestId
			//											   where (t2.Status != -1)
			//											   select t1;
			//			foreach (ReservedRooms item in Querry) {

			//				string ShortFormatItem = item.Requests.ClassDate.ToShortDateString();
			//				string SelectedShortFormat = dateTimePicker1.Value.ToShortDateString();
			//				if (ShortFormatItem == SelectedShortFormat) {
			//					if (item.Requests.Status == 1) {
			//						dataGridView1[item.Requests.LessonNumber, item.Requests.ClassRooms.Number - 1].Style.BackColor = busy;
			//						if (item.EventType == 0) {
			//							SetCell("З", item);
			//						}
			//						if (item.EventType == 1) {
			//							SetCell("К", item);
			//						}
			//						if (item.EventType == 2) {
			//							SetCell("М", item);
			//						}
			//					}
			//					else {
			//						dataGridView1[item.Requests.LessonNumber, item.Requests.ClassRooms.Number - 1].Style.BackColor = pretend;
			//						if (item.EventType == 0) {
			//							SetCell("З", item);
			//						}
			//						if (item.EventType == 1) {
			//							SetCell("К", item);
			//						}
			//						if (item.EventType == 2) {
			//							SetCell("М", item);
			//						}
			//					}
			//				}
			//			}
			//		}
			//	}
			//}
		}

		private void занятияToolStripMenuItem_Click(object sender, EventArgs e) {
			FormViewLessons form = new FormViewLessons();
			form.Show();
		}

		private void преподавателиToolStripMenuItem_Click(object sender, EventArgs e) {
			FormViewTeacher form = new FormViewTeacher(user);
			form.Show();
		}

		private void аудиторииToolStripMenuItem_Click(object sender, EventArgs e) {
			FormViewAudience form = new FormViewAudience();
			form.Show();
		}

		private void pictureBox_Click(object sender, EventArgs e) {
			ConfirmationForm form = new ConfirmationForm();
			form.Show();
		}

		private void dateTimePicker_ValueChanged(object sender, EventArgs e) {

		}
	}
}
