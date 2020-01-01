using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace ClassManagement.Admin {
	public partial class AudienceForm : Form {
		StepSchedulerEntities db = null;
		ClassRooms rooms = null;
		public AudienceForm(/*rooms*/) {
			InitializeComponent();
			db = new StepSchedulerEntities();
			this.rooms = rooms;
		}

		private void bt_add_Click(object sender, EventArgs e) {
			rooms.Number = tb_title.Text; // присваиваем значение textbox1.text к переменной number таблицы classrooms
			rooms.WorkPlacesCount = int.Parse(numericUD.Text); // присваиваем значение numericUpDown1.Text к переменной workplacescount
			rooms.Description = tb_description.Text; // присваиваем значение textbox2.text к перменной description
			DialogResult = DialogResult.OK;
		}

		private void AudienceForm_Load(object sender, EventArgs e) {
			db.ClassRooms.Load(); // загружиаем данные таблицы classrooms
			List<ClassRooms> c = db.ClassRooms.ToList<ClassRooms>(); // создаем список данных таблицы classrooms

			foreach (ClassRooms i in c) { // проходимся циклом в списке 
				if (rooms.Number == i.Number) { // находим совпадение(для редактирования)
					tb_title.Text = i.Number.ToString(); break; // присваиваем значение
				}
			}

			foreach (ClassRooms i in c) {
				if (rooms.WorkPlacesCount == i.WorkPlacesCount) { numericUD.Text = i.WorkPlacesCount.ToString(); break; }
			}

			foreach (ClassRooms i in c) {
				if (rooms.Description == i.Description) { tb_description.Text = i.Description.ToString(); break; }
			}
		}
	}
}
