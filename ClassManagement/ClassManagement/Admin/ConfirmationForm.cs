using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassManagement.Admin {
	public partial class ConfirmationForm : Form {
		StepSchedulerEntities db = null;
		List<Requests> requests;
		public ConfirmationForm() {
			InitializeComponent();
			db = new StepSchedulerEntities();
			cmB_teacher.DataSource = null;
			cmB_categories.Items.AddRange(new string[] { "Занятие", "Консультауия", "Меорприятие" }); //инициализация содержимого cmB_categories
			cmB_couples.DataSource = null;
			cmB_couples.Items.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8" });  //инициализация содержимого cmB_couples
			dgv_notification.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			requests = db.Requests.ToList();
			UpdateList();
		}

		private void UpdateList() {
			var list = requests.Where(w => w.Status != 0).Select(q => new {
				Дата_занятия = q.ClassDate,
				Номер_пары = q.LessonNumber,
				Количество_студентов = q.CountOfVisitors,
				Номер_аудитории = db.ClassRooms.Where(n => n.ClassRoomId == q.ClassRoomId).FirstOrDefault().Number,
				Преподователь = db.Users.Where(u => u.UserId == q.UserId).Select(c => c.Surname + " " + c.Name).FirstOrDefault(),
				Статус = (q.Status == 1) ? "подтверждено" : "отклонено"
			}).ToList();

			dgv_story.DataSource = null;
			dgv_story.DataSource = list;
		}

		private void chB_teacher_CheckedChanged(object sender, EventArgs e) {
			if (chB_teacher.Checked) {
				cmB_categories.Enabled = false;
				dateTimePicker1.Enabled = false; ;
				cmB_teacher.Enabled = true;
				cmB_couples.Enabled = false;
				db.Users.Load();
				cmB_teacher.DataSource = db.Users.Local.ToList();
				cmB_teacher.DisplayMember = "SurName";
				cmB_teacher.ValueMember = "UserId";
			}
		}

		private void chB_categories_CheckedChanged(object sender, EventArgs e) {
			if (chB_categories.Checked) {
				cmB_categories.Enabled = true;
				cmB_couples.Enabled = false;
				dateTimePicker1.Enabled = false;
				cmB_teacher.Enabled = false;
				db.ReservedRooms.Load();
			}
		}

		private void chB_date_CheckedChanged(object sender, EventArgs e) {
			if (chB_date.Checked) {
				cmB_couples.Enabled = false;
				cmB_categories.Enabled = false;
				dateTimePicker1.Enabled = true;
				cmB_teacher.Enabled = false;
				dateTimePicker1.Value = DateTime.Now.Date;
			}
		}

		private void chB_couples_CheckedChanged(object sender, EventArgs e) {
			if (chB_couples.Checked) {
				cmB_couples.Enabled = true;
				cmB_categories.Enabled = false;
				dateTimePicker1.Enabled = false;
				cmB_teacher.Enabled = false;
			}
		}

		private void bt_filter_Click(object sender, EventArgs e) {
			if (chB_teacher.Checked) {
				SearchTeachers();
			}
			if (chB_categories.Checked) {
				SearchCategories();
			}
			if (chB_date.Checked) {
				SearchDate();
			}
			if (chB_couples.Checked) {
				SearchCouples();
			};
			UpdateList();
		}

		private void SearchTeachers() {
			if (cmB_teacher.SelectedIndex != -1) {
				int id = Convert.ToInt32(cmB_teacher.SelectedValue);
				requests = requests.Where(x => x.UserId == id).ToList();
			}
		}

		private void SearchCategories() {
			if (cmB_categories.SelectedIndex != -1) {
				requests = (from req in db.Requests
										join rr in db.ReservedRooms on req.RequestId equals rr.RequestId
										where rr.EventType == cmB_categories.SelectedIndex
										select req).ToList();
			}
		}

		private void SearchDate() {
			requests = requests.Where(x => x.ClassDate == dateTimePicker1.Value.Date).ToList();
		}

		private void SearchCouples() {
			if (cmB_couples.SelectedIndex != -1) {
				requests = requests.Where(x => x.LessonNumber == cmB_couples.SelectedIndex + 1).ToList();
			}
		}

		private void ConfirmationForm_Load(object sender, EventArgs e) {
			saveLoad_Queries();
		}

		private void saveLoad_Queries() { //сохранение и обновление данных в базе и гридвью
			DateTime nowDate = DateTime.Now;
			db.SaveChanges();
			// получаем сам запрос     
			var list = (from req in requests
									join us in db.Users on req.UserId equals us.UserId
									join clas in db.ClassRooms on req.ClassRoomId equals clas.ClassRoomId
									where req.ClassDate > nowDate
									select new { req.RequestId, req.ClassDate, req.LessonNumber, req.CountOfVisitors, clas.ClassRoomId, UserName = us.Name + " " + us.Surname, req.Status }).ToList();
			dgv_notification.DataSource = list;
		}

		private void bt_reject_Click(object sender, EventArgs e) {
			for (int i = 0; i < dgv_notification.SelectedRows.Count; i++) {
				//получаем id нашей записи(нашего запроса)
				int id = Convert.ToInt32(dgv_notification[0, dgv_notification.SelectedRows[i].Index].Value);
				// получаем сам запрос
				var selReq = requests.Where(r => r.RequestId == id).FirstOrDefault();
				selReq.Status = 0;
				saveLoad_Queries();
			}
		}

		private void bt_confirm_Click(object sender, EventArgs e) {
			for (int i = 0; i < dgv_notification.SelectedRows.Count; i++) {
				//получаем id нашей записи(нашего запроса)
				int id = Convert.ToInt32(dgv_notification[0, dgv_notification.SelectedRows[i].Index].Value);
				// получаем сам запрос
				var selReq = requests.Where(r => r.RequestId == id).FirstOrDefault();
				selReq.Status = 1;
				saveLoad_Queries();
			}
		}
	}
}
