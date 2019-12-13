using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClassManagement {
	public partial class MainFormTeacher : Form {
		/*	 1 : принят запрос
		 *	 0 : на рассмотрении
		 *	-1 : запрос отклонен	*/

		Color busy = Color.Salmon;      //занятые аудитории помечены красным цветом
		Color free = Color.Green;       //свободные аудитории помечены зеленым цветом
		Color pretend = Color.Yellow;   //аудитории, на которые претендуют преподователи, помечены желтым цветом

		Random rnd = new Random();

		public MainFormTeacher() {
			InitializeComponent();
			dataGridView1.RowCount = 15;
			for (int i = 0; i < dataGridView1.RowCount - 1; i++) {
				dataGridView1[0, i].Value = $"{i + 1} ауд.";
			}
			dataGridView1[0, dataGridView1.RowCount - 1].Value = "Конф. зал";
			for (int i = 1; i < dataGridView1.ColumnCount; i++) {
				for (int j = 0; j < dataGridView1.RowCount; j++) {
					dataGridView1[i, j].Style.BackColor = busy;
				}
			}
			int temp = rnd.Next(15);
			int r = 0, c = 1;
			while (r < 15 && c < 8) {
				if (r % 2 == 0 || c % 2 != 0) dataGridView1[c, r].Style.BackColor = free;
				else dataGridView1[c, r].Style.BackColor = pretend;
				r++; c++;
			}
		}

		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
			BookingForm form = new BookingForm();
			form.Show();
		}
	}
}
