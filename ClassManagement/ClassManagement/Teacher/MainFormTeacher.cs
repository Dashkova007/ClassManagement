using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassManagement.Teacher {
	public partial class MainFormTeacher : Form {
		StepSchedulerEntities db = new StepSchedulerEntities();
		List<Requests> requests = null;
		int id;
		/*	 1 : принят запрос
		 *	 0 : на рассмотрении
		 *	-1 : запрос отклонен	*/

		Color busy = Color.Salmon;      //занятые аудитории помечены красным цветом
		Color free = Color.Green;       //свободные аудитории помечены зеленым цветом
		Color pretend = Color.Yellow;   //аудитории, на которые претендуют преподователи, помечены желтым цветом
		public MainFormTeacher(int id) {
			InitializeComponent();
			this.id = id;
			dataGridView.RowCount = db.ClassRooms.Select(i => i.ClassRoomId).Max(); //К-во аудиторий по умолчанию
			var aud = db.ClassRooms.Select(n => n.Number).ToList();
			for (int i = 0; i < dataGridView.RowCount - 1; i++) {
				dataGridView[0, i].Value = aud[i]; //Нумерация аудиторий
			}

			var t = db.ClassRooms.Select(n => n.Number).ToList();

			for (int i = 1; i < dataGridView.ColumnCount; i++) {
				for (int j = 0; j < dataGridView.RowCount; j++) {
					dataGridView[i, j].Style.BackColor = free; //По умолчанию все аудитории свободны
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

			OutputDate(dateTimePicker.Value);
		}

		private void OutputDate(DateTime value) {
			try {
				using (StepSchedulerEntities db = new StepSchedulerEntities()) {
					IQueryable<ReservedRooms> Querry = from rr in db.ReservedRooms //достаем информцию о аудиториям по дате
																						 join r in db.Requests on rr.RequestId equals r.RequestId
																						 where (r.Status != -1)
																						 select rr;
					foreach (ReservedRooms item in Querry) {
						string ShortFormatItem = item.Requests.ClassDate.ToShortDateString();
						string SelectedShortFormat = value.ToShortDateString();
						if (ShortFormatItem == SelectedShortFormat) {

							int id = db.ClassRooms.Where(n => n.Number == item.Requests.ClassRooms.Number).FirstOrDefault().ClassRoomId;
							switch (item.Requests.Status) {

								case -1: dataGridView[item.Requests.LessonNumber, id].Style.BackColor = free; break;
								case 0: dataGridView[item.Requests.LessonNumber, id].Style.BackColor = pretend; break;
								case 1: dataGridView[item.Requests.LessonNumber, id].Style.BackColor = busy; break;
								default: break;
							}
						}
					}
				}
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
			DateTime date = dateTimePicker.Value;
			int timeIndex = dataGridView.CurrentCell.ColumnIndex;
			int auditIndex = dataGridView.CurrentCell.RowIndex;
			BookingForm form = new BookingForm(date, timeIndex, auditIndex);
			form.Show();
		}

		private void dateTimePicker_ValueChanged(object sender, EventArgs e) {
			OutputDate(dateTimePicker.Value);
		}

		private void pictureBox_Click(object sender, EventArgs e) {
			PersonalForm form = new PersonalForm(id);
			form.Show();
		}
	}
}
