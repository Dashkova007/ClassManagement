using System;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassManagement.Admin {
  public partial class FormViewLessons : Form {
		public FormViewLessons() {
			InitializeComponent();
			update_list();

      try {
        tsb_search.Image = Image.FromFile(@"images/search.png");
      }
      catch (Exception ex) {
        MessageBox.Show(ex.Message);
      }

			dataGridView.AllowUserToAddRows = false;
			dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

			ts_cmb_date_filter.Items.AddRange(new string[] { "сегодня", "текущую неделю", "следующую неделю", "текущий месяц", "весь следующий месяц" });
			ts_cmb_date_filter.DropDownStyle = ComboBoxStyle.DropDownList;
		}
    #region CRUD
    //добавление
    public void InitLess() {

      Requests req = new Requests();

      ReservedRooms room = new ReservedRooms();
      req.ClassDate = DateTime.Today;
      req.DateRequest = DateTime.Today;
      LessonForm lf = new LessonForm(req, room);
      if (lf.ShowDialog() == DialogResult.OK) {
        using (StepSchedulerEntities db = new StepSchedulerEntities()) {
          try {
            db.Requests.Add(req);
            db.SaveChanges();

            room.RequestId = db.Requests.Where(r => r.RequestId == req.RequestId).FirstOrDefault().RequestId;

            db.ReservedRooms.Add(room);
            db.SaveChanges();
            update_list();
          }
          catch (Exception ex) {

            MessageBox.Show(ex.Message);
          }
        }
      }
    }
    //отмена занятия

    public void BlockLess() {
      if (dataGridView.SelectedRows.Count > 0) {
        int index = dataGridView.SelectedRows[0].Index;
        int Id;
        bool converted = Int32.TryParse(dataGridView[0, index].Value.ToString(), out Id);
        if (converted == false)
          return;
        using (StepSchedulerEntities db = new StepSchedulerEntities()) {
          try {
            Requests req = db.Requests.Where(r => r.RequestId == Id).FirstOrDefault();
            ReservedRooms res = db.ReservedRooms.Where(rr => rr.RequestId == req.RequestId).FirstOrDefault();
            // сначала удаляем запись о зарезервированной аудитории
            db.ReservedRooms.Remove(res);
            // переводим статус заявки в "отклоненная"
            req.Status = -1;
            db.SaveChanges();
            update_list();
          }
          catch (Exception ex) {
            MessageBox.Show(ex.Message);
          }
        }
      }
    }
    public void EditLess() {
      if (dataGridView.SelectedRows.Count > 0) {
        int index = dataGridView.SelectedRows[0].Index;
        int Id;
        bool converted = Int32.TryParse(dataGridView[0, index].Value.ToString(), out Id);
        if (converted == false)
          return;
        using (StepSchedulerEntities db = new StepSchedulerEntities()) {

          Requests req = db.Requests.Where(r => r.RequestId == Id).FirstOrDefault();
          ReservedRooms res = db.ReservedRooms.Where(rr => rr.RequestId == req.RequestId).FirstOrDefault();
          //изменяем заявку и запись о забронированной аудитории
          if (new LessonForm(req, res).ShowDialog() == DialogResult.OK) {
            try {
              db.SaveChanges();
              update_list();
            }
            catch (Exception ex) {
              MessageBox.Show(ex.Message);
            }
          }
        }
      }
      else {
        MessageBox.Show("Сначала выберите занятие из списка ниже", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
    }
    #endregion
    //заполнение датагрида
    private void update_list() {
      using (StepSchedulerEntities db = new StepSchedulerEntities()) {
        var list = (from rr in db.ReservedRooms
                    join req in db.Requests on rr.RequestId equals req.RequestId
                    join u in db.Users on req.UserId equals u.UserId
                    join cr in db.ClassRooms on req.ClassRoomId equals cr.ClassRoomId
                    select new {
                      req.RequestId,
                      Аудитория = cr.Number,
                      Пара = req.LessonNumber,
                      //req.DateRequest,
                      Дата = req.ClassDate,
                      Преподователь = u.Surname + " " + u.Name,
                      Description = req.EventDescription,
                      Событие = (rr.EventType == 0) ? "Занятие" : (rr.EventType == 1) ? "Консультация" : "Мероприятие"
                    }).OrderBy(d => d.Дата).ThenBy(l => l.Пара).ThenBy(c => c.Аудитория).ToList();
        dataGridView.DataSource = list;
        dataGridView.Columns["RequestId"].Visible = false;

      }
    }
    //кнопка добавления
    private void tsb_add_Click(object sender, EventArgs e) {
      InitLess();
    }
    //кнопка редактирования
    private void tsb_edit_Click(object sender, EventArgs e) {
      EditLess();
    }
    //кнопка удаления
    private void tsb_cancel_Click(object sender, EventArgs e) {
      BlockLess();
    }
    //вызов импорта эксель файла в БД
    // класс использует нугеты ExcelDataReader и ExcelDataReader.Dataset
    private void tsb_export_table_Click(object sender, EventArgs e) {
      using (OpenFileDialog dialog = new OpenFileDialog()) {
        //фильтр excel файлов
        dialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
        if (dialog.ShowDialog() == DialogResult.OK) {
          WorkWithExcel exc = new WorkWithExcel(dialog.FileName);
          exc.retrieve_excel_data(dialog.FileName);
        }
      }
    }
    //кнопка поиск возле комбобокса с датами
    private void tsb_search_Click(object sender, EventArgs e) {
      DateFiltring();
    }

    //функция фильтровки по дате
    async Task DateFiltring() {
      if (ts_cmb_date_filter.SelectedIndex != -1) {
        using (StepSchedulerEntities db = new StepSchedulerEntities()) {

          var list = await (from rr in db.ReservedRooms
                            join req in db.Requests on rr.RequestId equals req.RequestId
                            join u in db.Users on req.UserId equals u.UserId
                            join cr in db.ClassRooms on req.ClassRoomId equals cr.ClassRoomId
                            select new {
                              req.RequestId,
                              Аудитория = cr.Number,
                              Пара = req.LessonNumber,
                              //req.DateRequest,
                              Дата = req.ClassDate,
                              Преподователь = u.Surname + " " + u.Name,
                              //меняем отображение события в таблице
                              Событие = (rr.EventType == 0) ? "Занятие" : (rr.EventType == 1) ? "Консультация" : "Мероприятие"
                            }).ToListAsync();
          DateTime DateFilter = new DateTime();
          //считаем кол-во дней до следующего понедельника
          int daysUntilNextMonday = ((int)DayOfWeek.Monday - (int)DateTime.Today.DayOfWeek + 7) % 7;
          switch (ts_cmb_date_filter.SelectedIndex) {
            case 0: {
                //на сегодня
                var filteredList = list.Where(l => l.Дата == DateTime.Today).ToList();
                dataGridView.DataSource = filteredList;
                break;
              }
            case 1: {
                //По дате от сегодня до следующего понедельника
                DateFilter = DateTime.Today.AddDays(daysUntilNextMonday);
                var filteredList = list.Where(l => l.Дата < DateFilter && l.Дата >= DateTime.Today).ToList();
                dataGridView.DataSource = filteredList;
                break;
              }
            case 2: {
                //На неделю от сделующего понедельника                               
                DateFilter = DateTime.Today.AddDays(daysUntilNextMonday);
                var filteredList = list.Where(l => l.Дата >= DateFilter && l.Дата <= DateFilter.AddDays(7)).ToList();
                dataGridView.DataSource = filteredList;
                break;
              }
            case 3: {
                // на текущий месяц
                var filteredList = list.Where(l => l.Дата.Month == DateTime.Today.Month && l.Дата >= DateTime.Today).ToList();
                dataGridView.DataSource = filteredList;
                break;
              }
            case 4: {
                //на весь следующий месяц
                var filteredList = list.Where(l => l.Дата.Month == DateTime.Today.AddMonths(1).Month && l.Дата >= DateTime.Today).ToList();
                dataGridView.DataSource = filteredList;
                break;
              }
          }
          dataGridView.Columns["RequestId"].Visible = false;
        }
      }
    }

    private void tsb_clear_search_Click(object sender, EventArgs e) {
      update_list();
    }
  }
}
