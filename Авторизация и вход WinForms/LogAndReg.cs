namespace GEMLIGHTSFORMS
{
	public partial class LogIn : Form
	{
		public LogIn()
		{
			InitializeComponent();

			//Закрывает предыдущие формы
			for (int i = Application.OpenForms.Count - 1; i > 0; i--)
				if (Application.OpenForms[i] != this)
					Application.OpenForms[i].Close();
		}

		private void LogButton_Click(object sender, EventArgs e)
		{
			if (UsernameInput.Text != "" && PasswordInput.Text != "")
			{
				DB.RefreshUsersList(DB.pathDB);
				CompareLogIn();
			}
			else
				MessageBox.Show("Произошла ошибка: Одно из полей пустое.");
		}

		private void RegButton_Click(object sender, EventArgs e)
		{
			bool isExist = false;

			if (UsernameInput2.Text != "" && PasswordInput2.Text != "" && FIOInput.Text != "" && BornDateInput.Text != "")
			{
				isExist = Compare(isExist);

				Registration(isExist);
			}
			else
				MessageBox.Show("Произошла ошибка: Одно из полей пустое.");
		}

		private void pictureBox1_Paint(object sender, PaintEventArgs e)
		{
			ControlPaint.DrawBorder(e.Graphics, pictureBox1.ClientRectangle, Color.FromArgb(238, 55, 78), ButtonBorderStyle.Solid);
		}

		#region Methods
		public void CompareLogIn()
		{
			bool success = false;

			for (int i = 0; i < DB.users.Count; i++)
			{
				if (DB.users[i].Username == UsernameInput.Text && DB.users[i].Password == PasswordInput.Text)
				{
					MessageBox.Show("Вход успешно выполнен!");
					success = true;

					CatalogueForm form3 = new CatalogueForm(DB.users[i]);
					form3.Show();
					Hide();
				}
			}

			if (success == false)
				MessageBox.Show("Произошла ошибка: Введён неверный логин или пароль.");
		}

		public void Registration(bool isExist)
		{
			if (isExist == false)
			{
				DateTime dateTime;

				string[] bdCheck = BornDateInput.Text.Split('.').ToArray();

				if (bdCheck.Length == 3)
				{
					if (bdCheck[0].Length == 2 && bdCheck[1].Length == 2 && bdCheck[2].Length <= 4 && bdCheck[2].Length > 0)
					{
						try
						{
							dateTime = new DateTime(int.Parse(bdCheck[2]), int.Parse(bdCheck[1]), int.Parse(bdCheck[0]));
						}
						catch (Exception)
						{
							MessageBox.Show("Произошла ошибка: дата рождения введена некорректно!");
							return;
						}

						if (dateTime < DateTime.Now)
						{
							MessageBox.Show("Регистрация прошла успешна!");

							User user = new User();

							user.FIO = FIOInput.Text;
							user.BornDate = BornDateInput.Text;
							user.Username = UsernameInput2.Text;
							user.Password = PasswordInput2.Text;

							if (AdmCheck.Text == "Adminka")
								user.Admin = true;
							else
								user.Admin = false;

							DB.users.Add(user);

							DB.RewriteUsersFile(DB.pathDB);
						}
						else
							MessageBox.Show("Произошла ошибка: дата рождения введена некорректно!");
					}
					else
						MessageBox.Show("Произошла ошибка: дата рождения введена некорректно!");
				}
				else
					MessageBox.Show("Произошла ошибка: дата рождения введена некорректно!");
			}
			else
				MessageBox.Show("Произошла ошибка: такой пользователь уже существует!");
		}

		public bool Compare(bool isExist)
		{
			DB.RefreshUsersList(DB.pathDB);

			for (int i = 0; i < DB.users.Count; i++)
				if (DB.users[i].Username == UsernameInput2.Text)
					isExist = true;

			return isExist;
		}
		#endregion

		private void BornDateInput_TextChanged(object sender, EventArgs e)
		{
			if (BornDateInput.Text.Length > 0)
			{
				int startPos = BornDateInput.SelectionStart;

				if ((BornDateInput.Text[^1] < '0' || BornDateInput.Text[^1] > '9') && BornDateInput.Text[^1] != '.')
					BornDateInput.Text = BornDateInput.Text.Remove(BornDateInput.Text.Length - 1);

				BornDateInput.SelectionStart = startPos;
			}
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked)
				PasswordInput.PasswordChar = '\0';
			else
				PasswordInput.PasswordChar = '*';
		}

		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox2.Checked)
				PasswordInput2.PasswordChar = '\0';
			else
				PasswordInput2.PasswordChar = '*';
		}
	}
}
