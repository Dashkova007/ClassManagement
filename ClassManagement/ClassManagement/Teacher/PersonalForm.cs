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
	public partial class PersonalForm : Form {
		StepSchedulerEntities db;
		List<Requests> requests = null;
		public PersonalForm(int id) {
			InitializeComponent();
			dgv_notifications.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgv_history.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

			//заполнение combobox выбора запросов
			comboBox.Items.Add("Все запросы");
			comboBox.Items.Add("Подтвержденные");
			comboBox.Items.Add("Отклоненные");
			comboBox.Items.Add("Ожидают ответа");

			comboBox.SelectedIndex = 0;

			Task task = Task.Run(() => {
				// подключение к бд
				try {
					db = new StepSchedulerEntities();
					requests = db.Requests.Where(u => u.UserId == id).ToList();
				}
				catch (Exception) { }
			});
			task.Wait();

			//заполнение двух datagridview
			//новых уведомлений
			FillNew();
			//истории
			FillHistory();

			dgv_notifications.RowHeadersVisible = false;
			dgv_history.RowHeadersVisible = false;
		}
		//функция для заполнения статуса словестно (вместо 1, -1)
		private string Choise(int status) {
			return (status == 1) ? " + " : (status == -1) ? " - " : "ожидают ответа";
		}

		//заполнение datagridview на вкладке новые уведомления
		private void FillNew() {

			try {
				var n = requests.Where(d => d.ClassDate > DateTime.Now.Date).Select(x => new {
					id = x.RequestId,
					Дата = x.ClassDate,
					N_пары = x.LessonNumber,
					Аудитория = (db.ClassRooms.Where(c => c.ClassRoomId == x.ClassRoomId).FirstOrDefault().Number),
					Статус = Choise((int)x.Status)
				}).ToList();

				dgv_notifications.DataSource = null;
				dgv_notifications.DataSource = n;
			}
			catch (Exception) { }

		}

		//заполнение datagridview на вкладке история
		private void FillHistory() {
			try {
				var history = requests.Where(s => s.Status != 0 && s.ClassDate < DateTime.Now.Date).
							Select(x => new {
								id = x.RequestId,
								Дата = x.ClassDate,
								N_пары = x.LessonNumber,
								Аудитория = (db.ClassRooms.Where(c => c.ClassRoomId == x.ClassRoomId).FirstOrDefault().Number),
								Статус = (x.Status == 1) ? " + " : " - "
							}).ToList();
				dgv_history.DataSource = null;
				dgv_history.DataSource = history;
			}
			catch (Exception) { }
		}

		//функция для заполнение datagridview на вкладке новые уведомления с учетом статуса
		private void GetNewListFromBD(int status) {
			try {
				var n = requests.Where(s => s.Status == status).Select(x => new {
					id = x.RequestId,
					Дата = x.ClassDate,
					N_пары = x.LessonNumber,
					Аудитория = (db.ClassRooms.Where(c => c.ClassRoomId == x.ClassRoomId).FirstOrDefault().Number),
					Статус = Choise(status)
				}).ToList();
				dgv_notifications.DataSource = null;
				dgv_notifications.DataSource = n;
			}
			catch (Exception) { }
		}

		//функция для заполнение datagridview на вкладке история с учетом статуса
		private void GetHistoryListFromBD(int status) {
			try {
				var history = requests.Where(s => s.Status == status && s.ClassDate < DateTime.Now.Date).
							Select(x => new {
								id = x.RequestId,
								Дата = x.ClassDate,
								N_пары = x.LessonNumber,
								Аудитория = (db.ClassRooms.Where(c => c.ClassRoomId == x.ClassRoomId).FirstOrDefault().Number),
								Статус = Choise(status)
							}).ToList();
				dgv_history.DataSource = null;
				dgv_history.DataSource = history;
			}
			catch (Exception) { }
		}
		//функция для вызова функций заполнения datagridview с учетом статуса
		private void comboBox_SelectedIndexChanged(object sender, EventArgs e) {
			//если выбран статус "подтвержденные"
			if (comboBox.SelectedItem.ToString() == "Подтвержденные") {
				//если выбрана вкладка новые уведомления 
				if (tabControl.SelectedIndex == 0)
					GetNewListFromBD(1);
				//если выбрана вкладка история
				else
					GetHistoryListFromBD(1);
			}
			//если выбран статус "Отклоненные"
			else if (comboBox.SelectedItem.ToString() == "Отклоненные") {
				//если выбрана вкладка новые уведомления
				if (tabControl.SelectedIndex == 0)
					GetNewListFromBD(-1);
				//если выбрана вкладка история
				else
					GetHistoryListFromBD(-1);
			}

			//если выбран статус "Ожидают ответа"
			else if (comboBox.SelectedItem.ToString() == "Ожидают ответа") {
				//если выбрана вкладка новые уведомления
				if (tabControl.SelectedIndex == 0)
					GetNewListFromBD(0);
				//если выбрана вкладка история
				else
					GetHistoryListFromBD(0);
			}

			//если выбран статус "Все запросы"
			else {
				//вызов функции заполнения datagridview на вкладке новые уведомления
				if (tabControl.SelectedIndex == 0)
					FillNew();
				//вызов функции заполнения datagridview на вкладке история
				else
					FillHistory();
			}
		}
		// обработчик кнопки отмена на вкладке новые уведомления
		private void button_Click(object sender, EventArgs e) {
			try {
				// если выбрана одна строка и статус не "отклонено"
				if (dgv_notifications.SelectedRows.Count > 0) {
					for (int i = 0; i < dgv_notifications.SelectedRows.Count; i++) {
						// получаем id нашей записи (нашего запроса)
						int id = Convert.ToInt32(dgv_notifications[0, dgv_notifications.SelectedRows[i].Index].Value);
						// получаем сам запрос
						var select = requests.Where(r => r.RequestId == id).FirstOrDefault();
						// меняем статус на "отклонено"
						select.Status = -1;
					}
					// сохраняем в бд
					db.SaveChanges();
					// перезаписываем datagridview перезаполняя его (вызываем функцию заполнения)
					FillNew();
				}
			}
			catch (Exception) { }
		}

		private void tabControl_SelectedIndexChanged(object sender, EventArgs e) {
			button.Visible = (tabControl.SelectedIndex == 0) ? true : false;
			if (tabControl.SelectedIndex == 0) {
				button.Visible = true;
				comboBox.Items.Add("Ожидают ответа");
			}
			else {
				button.Visible = false;
				comboBox.Items.Remove("Ожидают ответа");
			}
		}
	}
}
