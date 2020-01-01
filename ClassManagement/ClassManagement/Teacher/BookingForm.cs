using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ClassManagement.Teacher {
	public partial class BookingForm : Form {
		StepSchedulerEntities db;
		List<string> rooms = null;
		public BookingForm(DateTime date, int timeIndex, int auditIndex) {
			InitializeComponent();
			db = new StepSchedulerEntities();
			rooms = db.ClassRooms.Select(x => x.Number).ToList();
			cb_time.Items.Add("9:00");          //заполнение данных на форме
			cb_time.Items.Add("10:30");
			cb_time.Items.Add("12:00");
			cb_time.Items.Add("13:30");
			cb_time.Items.Add("15:00");
			cb_time.Items.Add("16:30");
			cb_time.Items.Add("18:00");
			cb_time.Items.Add("19:30");
			cb_time.SelectedIndex = timeIndex - 1;
			cb_aud.Items.AddRange(rooms.ToArray());
			cb_aud.SelectedIndex = auditIndex;
			cb_type.Items.Add("Консультация");
			cb_type.Items.Add("Мероприятие");
			cb_type.SelectedIndex = 0;
			dateTimePicker.Value = date;
		}

		private void button_Click(object sender, EventArgs e) {
			if (dateTimePicker.Value < DateTime.Now) {//проверки
				MessageBox.Show("Нельзя бронировать на прошедшее время");
				return;
			}
			if (cb_user.Text == "") {
				MessageBox.Show("Поле \"Преподаватель\" не может быть пустым");
				return;
			}
			Requests request = new Requests();				//создание нового запроса на бронирование соответственно данным с формы
			request.ClassRoomId = cb_user.SelectedIndex;
			var teacher = db.Users.Where(x => x.Login == cb_user.Text);
			if (teacher.Count(x => true) != 1) {
				MessageBox.Show("Некорректный логин");
				return;
			}
			request.UserId = teacher.Single().UserId;
			request.ClassDate = dateTimePicker.Value;
			request.LessonNumber = cb_time.SelectedIndex;
			if (numericUD.Value < 1) {
				MessageBox.Show("");
				return;
			}
			request.CountOfVisitors = (int)numericUD.Value;
			request.EventDescription = textBox1.Text;
			db.Requests.Add(request);           //сохранение запроса в базе
			db.SaveChanges();
			MessageBox.Show("Заявка на бронирование успешно отправлена");
			Close();
		}
	}
}
