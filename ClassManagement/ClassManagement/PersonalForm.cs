using System.Windows.Forms;

namespace ClassManagement {
	public partial class PersonalForm : Form {
		string[] vs = { "Все запросы", "Подтвержденные", "Отклоненные" };
		public PersonalForm() {
			InitializeComponent();
			comboBox1.Items.Add(vs);
			comboBox1.SelectedIndex = 0;
		}
	}
}
