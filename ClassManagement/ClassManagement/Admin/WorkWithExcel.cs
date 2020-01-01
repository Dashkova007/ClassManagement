using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace ClassManagement.Admin {
  public class WorkWithExcel {
    public string ExcelFileName { get; set; }
    DataTableCollection tables;
    public WorkWithExcel(string path) {
      ExcelFileName = path;
    }
    //используется для получения названия аудитории без кол-ва мест, написанного в скобках возле названия
    string get_classroom(string str) {
      return str.Remove(str.IndexOf('('));
    }
    //получение имени преподавателя из последней строки ячейки 
    string get_teacher_name(string str) {
      string[] fullname = str.Split(' ');
      string name = fullname[2];
      return name;
    }
    //получение фамилии преподавателя из последней строки ячейки 
    string get_teacher_surname(string str) {
      string[] fullname = str.Split(' ');
      string surname = fullname[1];
      return surname;
    }
    // конструктор описания мероприятия 
    string get_request_description(string[] cell) {
      StringBuilder description = new StringBuilder();
      description.AppendLine(cell[0]);
      description.AppendLine(cell[1]);
      description.AppendLine(cell[2]);
      return description.ToString();
    }
    //чтение и запись в бд из эксель файла
    public void retrieve_excel_data(string ExcelFileName) {
      using (var stream = File.Open(ExcelFileName, FileMode.Open, FileAccess.Read)) {
        // фреймворк ,позволяющий читать данные с Excel таблицы
        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream)) {
          DataSet res = reader.AsDataSet(new ExcelDataSetConfiguration() { ConfigureDataTable = (obj) => new ExcelDataTableConfiguration() { UseHeaderRow = true } });
          tables = res.Tables;
          // выбор второй(самой информативной) таблицы из Excel файла.
          DataTable dt = tables[1];
          if (dt != null) {
            using (StepSchedulerEntities db = new StepSchedulerEntities()) {
              //временные хранилища данных
              List<Requests> requests = new List<Requests>();
              List<ReservedRooms> reservedRooms = new List<ReservedRooms>();
              for (int i = 0; i < dt.Rows.Count; i++) {
                // получение номера аудитории из соответствующей колонки и обрезание до нужного вида методом get_classrom(string)
                string Classroom = (get_classroom(dt.Rows[i]["Аудитория"].ToString()));
                //получение номера пары из соответствующей колонки
                int LessnNum = Int32.Parse((dt.Rows[i]["Пара"].ToString()));
                for (int j = 0; j < dt.Columns.Count; j++) {
                  //проверка исключает пустые ячейки из Excel-файла
                  if (!string.IsNullOrEmpty(dt.Rows[i][j].ToString())) {
                    DateTime date = new DateTime();
                    //проверка является ли колнка датой (проведения занятия).
                    if (DateTime.TryParse(dt.Columns[j].ColumnName, out date)) {
                      Requests req = new Requests();
                      //разбиение ячейки с данными на 4 строки для корретного сохранения в БД
                      string[] cell = new string[4];
                      cell = dt.Rows[i][j].ToString().Split('\n');
                      req.DateRequest = DateTime.Today;
                      req.ClassDate = date;
                      req.Status = 1;
                      req.IsNew = false;
                      req.EventDescription = get_request_description(cell);
                      req.CountOfVisitors = 10;
                      req.LessonNumber = LessnNum;
                      ClassRooms classroom = db.ClassRooms.Where(cr => cr.Number == Classroom).FirstOrDefault();
                      if (classroom != null) {
                        req.ClassRoomId = classroom.ClassRoomId;
                      }
                      //else
                      //{
                      //    MessageBox.Show("Аудитория  '" +Classroom
                      //       + "' не найдена в базе данных. Операция прервана.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                      //}
                      else {
                        //for tests
                        ClassRooms new_class = new ClassRooms() {
                          Number = Classroom,
                          WorkPlacesCount = 10,
                          IsAvailable = true
                        };
                        db.ClassRooms.Add(new_class);
                        db.SaveChanges();
                        //req.ClassRoomId = new_class.ClassRoomId;
                        req.ClassRoomId = db.ClassRooms.Where(cr => cr.Number == new_class.Number).FirstOrDefault().ClassRoomId;
                      }
                      //Получение имени пользователя 
                      string teachersName = get_teacher_name(cell[3]);
                      //получение фамилии пользователя
                      string teachersSurName = get_teacher_surname(cell[3]);
                      Users user = db.Users.Where(u => u.Surname == teachersSurName && u.Name == teachersName).FirstOrDefault();
                      if (user != null) {
                        req.UserId = user.UserId;
                      }
                      //else
                      //{
                      //    MessageBox.Show("Пользователь с именем "+teachersSurName +' '+teachersName 
                      //        +" не найден в базе данных. Операция прервана." ,"Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error );
                      //}
                      else {
                        //for tests
                        Users new_user = new Users() {
                          Name = teachersName,
                          Surname = teachersSurName,
                          BirthDate = DateTime.Today,
                          Login = teachersSurName,
                          Password = "asdasdwqerq",
                          IsAdmin = false,
                          IsBlocked = false,
                        };
                        db.Users.Add(new_user);
                        db.SaveChanges();
                        req.UserId = db.Users.Where(u => u.Name == new_user.Name && u.Surname == new_user.Surname).FirstOrDefault().UserId;
                      }
                      requests.Add(req);
                    }
                  }
                }
              }
              db.Requests.AddRange(requests);
              db.SaveChanges();
              foreach (Requests item in requests) {
                var req_to_insert = db.Requests.Where(r => r.RequestId == item.RequestId).FirstOrDefault();
                db.ReservedRooms.Add(new ReservedRooms() { RequestId = item.RequestId, EventType = 0 });
              }
              db.SaveChanges();
            }
          }
        }
      }
    }
  }
}
