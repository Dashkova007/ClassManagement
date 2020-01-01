using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace ClassManagement.Admin {
	public partial class TeacherInfoForm : Form {
		StepSchedulerEntities bd = null;
		Users user = null;
		public TeacherInfoForm(Users user) {
			InitializeComponent();
			user = new Users();
			bd = new StepSchedulerEntities();
			if (user.Photo != null) {
				byte[] vs = user.Photo;
				var ms = new MemoryStream(vs);
				var bitmap = Image.FromStream(ms);
				pictureBoxPhoto.Image = bitmap;
			}

			textBoxLog.Text = user.Login;
			textBoxPassword.Text = user.Password;
			textBoxName.Text = user.Name;
			textBoxSurname.Text = user.Surname;
			textBoxMail.Text = user.E_Mail;
			textBoxCommit.Text = user.Description;
			dateTimePicker.Value = DateTime.Now.Date;
			maskedTextBox.Text = user.PhoneNumber;
		}

		private void buttonOpen_Click(object sender, EventArgs e) {
			OpenFileDialog ofd = new OpenFileDialog();
			if (ofd.ShowDialog() == DialogResult.OK) {
				try {
					string fileName = ofd.FileName;
					Image im = Image.FromFile(fileName);
					Bitmap btm = new Bitmap(im, pictureBoxPhoto.ClientSize);
					pictureBoxPhoto.Image = im;
					FileInfo fi = new FileInfo(fileName);
				}
				catch (Exception ex) {
					MessageBox.Show("Error" + ex.Message);
				}
			}
		}

		private void buttonAdd_Click(object sender, EventArgs e) {
			try {
				if (user.Photo != null) {
					Bitmap bitmap = new Bitmap(pictureBoxPhoto.Image);
					MemoryStream memory = new MemoryStream();
					bitmap.Save(memory, ImageFormat.Jpeg);
					byte[] vs = memory.ToArray();
					user.Photo = vs;
				}
				user.Login = textBoxLog.Text;
				user.Password = textBoxPassword.Text;
				user.Name = textBoxName.Text;
				user.Surname = textBoxSurname.Text;
				user.E_Mail = textBoxMail.Text;
				user.Description = textBoxCommit.Text;
				user.BirthDate = dateTimePicker.Value.Date;
				user.PhoneNumber = maskedTextBox.Text;
				if (checkBox1.Checked) {
					user.IsAdmin = true;
				}
				else
					user.IsAdmin = false;
				DialogResult = DialogResult.OK;
			}
			catch (Exception ex) {
				MessageBox.Show("Error" + ex.Message);
			}
		}
	}
}
