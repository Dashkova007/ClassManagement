using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
//форма добавления и редактирования занятий
namespace ClassManagement.Admin {
	public partial class LessonForm : Form {
		Requests req;
		ReservedRooms room;
		public LessonForm(Requests req, ReservedRooms res) {
			InitializeComponent();
			load_comboboxes();
			this.Load += LessonForm_Load;

			this.req = req;
			this.room = res;
			cmb_eventTypes.SelectedIndex = res.EventType;
			//req.DateRequest = r.DateRequest;          
			cmb_time.SelectedIndex = req.LessonNumber - 1;
			richTextBox.Text = req.EventDescription;
			numericUD.Value = (decimal)req.CountOfVisitors;
			dateTimePicker.Value = req.ClassDate;
		}

		private async Task load_comboboxes() {
			//комбобокс мероприятий
			cmb_eventTypes.Items.AddRange(new string[] { "Занятие", "Консультация", "Мероприятие" });
			//комбобокс выбора времени проведения пары
			cmb_time.Items.AddRange(new string[] {
								"1-я пара 9:00","2-я пара 10:30","3-я пара 12:00","4-я пара 13:30",
								"5-я пара 15:00","6-я пара 16:30","7-я пара 18:00","8-я пара 19:30","9-я пара 21:00",
						});
			using (StepSchedulerEntities db = new StepSchedulerEntities()) {
				//комбобокс выбора пользователя
				cmb_users.DataSource = await (from u in db.Users select new { UserId = u.UserId, FullName = u.Surname + " " + u.Name }).OrderBy(u => u.FullName).ToListAsync();
				cmb_users.ValueMember = "UserId";
				cmb_users.DisplayMember = "FullName";
				//комбобокс выбора аудитории
				cmb_classrooms.DataSource = await (from cr in db.ClassRooms select cr).OrderBy(cr => cr.Number).ToListAsync();

				cmb_classrooms.ValueMember = "ClassRoomId";
				cmb_classrooms.DisplayMember = "Number";

				// данные комбобокса, полученные из выбранной заявки
				cmb_classrooms.SelectedValue = req.ClassRoomId;
				cmb_users.SelectedValue = (int)req.UserId;
			}
		}

		private void LessonForm_Load(object sender, EventArgs e) {
			// настройка отображения контролов
			numericUD.Increment = 1;
			numericUD.Minimum = 1;
			cmb_classrooms.DropDownStyle = ComboBoxStyle.DropDownList;
			cmb_users.DropDownStyle = ComboBoxStyle.DropDownList;
			cmb_eventTypes.DropDownStyle = ComboBoxStyle.DropDownList;
			cmb_time.DropDownStyle = ComboBoxStyle.DropDownList;
			//cmb_users.
			dateTimePicker.MinDate = DateTime.Today.AddDays(-1);
			dateTimePicker.MaxDate = DateTime.Today.AddMonths(1);
		}

		private void button_Click(object sender, EventArgs e) {
			req.ClassDate = dateTimePicker.Value;
			req.CountOfVisitors = (int)numericUD.Value;
			req.EventDescription = richTextBox.Text;
			req.IsNew = false;
			if (cmb_time.SelectedIndex != -1) {
				req.LessonNumber = cmb_time.SelectedIndex + 1;
			}
			else {
				MessageBox.Show("Выберите номер пары", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (cmb_classrooms.SelectedIndex != -1) {
				req.ClassRoomId = (int)cmb_classrooms.SelectedValue;
			}
			else {
				MessageBox.Show("Выберите аудиторию", "внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (cmb_users.SelectedIndex != -1) {
				req.UserId = (int)cmb_users.SelectedValue;
			}
			else {
				MessageBox.Show("Выберите преподавателя", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (cmb_eventTypes.SelectedIndex != -1) {
				this.room.EventType = cmb_eventTypes.SelectedIndex;
			}
			else {
				MessageBox.Show("Выберите тип события", "внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			req.Status = 1;
			this.DialogResult = DialogResult.OK;
		}
	}
}
