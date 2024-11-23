namespace GEMLIGHTSFORMS
{
	public partial class Account : Form
	{
		public User user = new();
		public bool isSaved = false;

		public Account(User user)
		{
			InitializeComponent();

			this.user = user;

			textBox1.Text = user.FIO;
			textBox2.Text = user.BornDate;
			textBox4.Text = user.CardNumber;
			textBox5.Text = user.Password;
			textBox6.Text = user.Username;
			Avatar.Load(user.ImagePath);

			foreach (var item in DB.cards)
			{
				if (user.CardNumber.ToString() == item.Number && item.USD > 0)
				{
					textBox3.Text = $"{item.USD} USD";
					break;
				}
				else
					textBox3.Text = "0,00 USD";
			}

			foreach (TextBox box in Controls.OfType<TextBox>())
				box.TextChanged += (s, e) => { isSaved = false; };

			CreateItemPanel();
			this.KeyDown += (s, a) => { if (a.KeyCode == Keys.Escape) Close(); };
		}

		private void CheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked)
				textBox5.PasswordChar = '\0';
			else
				textBox5.PasswordChar = '*';
		}

		private void Save_Click(object sender, EventArgs e)
		{
			if (textBox1.TextLength > 0 && textBox2.TextLength > 0 && textBox5.TextLength > 0 && Avatar.ImageLocation.Length > 0)
			{
				DateTime dateTime = new DateTime(9999, 01, 01);

				string[] bdCheck = textBox2.Text.Split('.').ToArray();

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
					}

					if (dateTime < DateTime.Now)
					{
						isSaved = true;
						user.FIO = textBox1.Text;
						user.BornDate = textBox2.Text;
						user.Password = textBox5.Text;

						string extension = Avatar.ImageLocation.Split('.')[^1];
						string imgPath = DB.exePath + @$"Data\images\AVATARS\{user.Username}.{extension}";
						user.ImagePath = Avatar.ImageLocation;

						foreach (var item in Application.OpenForms)
							if (item is CatalogueForm catalogueForm)
								catalogueForm.CheckInfo();
						try
						{
							if (imgPath != Avatar.ImageLocation)
							{
								if (File.Exists(imgPath))
									File.Copy(Avatar.ImageLocation, imgPath, true);
								else
									File.Copy(Avatar.ImageLocation, imgPath);
							}
						}
						catch (Exception)
						{
							MessageBox.Show("Произошла ошибка: перезайдите в аккаунт и загрузите фото заново.");
						}

						string filename = imgPath;
						string dir = Path.GetDirectoryName(filename);
						string filenameWithoutExtension = Path.GetFileNameWithoutExtension(filename);

						string[] similarFiles =
							Directory.GetFiles(dir, filenameWithoutExtension + ".*")
							.Except(
								new[] { filename },
								StringComparer.OrdinalIgnoreCase)
							.ToArray();

						foreach (var similarFile in similarFiles)
							File.Delete(similarFile);

						user.ImagePath = imgPath;
						Avatar.Load(user.ImagePath);
					}
					else
						MessageBox.Show("Произошла ошибка: дата рождения введена некорректно!");
				}
				else
					MessageBox.Show("Произошла ошибка: дата рождения введена некорректно!");
			}
			else
				MessageBox.Show("Произошла ошибка: одно из полей пустое!");
		}

		private void Avatar_Click(object sender, EventArgs e)
		{
			OpenFileDialog fdlg = new()
			{
				Title = "C# Диалоговое окно загрузки изображения",
				InitialDirectory = @"c:\",
				Filter = "Image Files(*.jpeg;*.png;*.jpg)|*.jpeg;*.png;*.jpg",
				FilterIndex = 2,
				RestoreDirectory = true
			};

			if (fdlg.ShowDialog() == DialogResult.OK)
				Avatar.Load(fdlg.FileName);
		}

		public void CreateItemPanel()
		{
			DB.RefreshCartsList(DB.pathCarts);
			CartPanel.Controls.Clear();

			foreach (var c in DB.carts)
			{
				if (user.Username == c.Username)
				{
					foreach (var p in c.ProductsList)
					{
						if (p.Stock <= 0)
						{
							c.ProductsList.Remove(p);
							DB.products.Remove(p);
						}

						CartProductItem item = new(p, user);
						CartPanel.Controls.Add(item);
					}
				}
			}

			DB.RewriteProductsFile(DB.pathCatalogue);
			DB.RewriteCartsFile(DB.pathCarts);
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

			if (textBox2.Text.Length > 0)
			{
				int startPos = textBox2.SelectionStart;

				if ((textBox2.Text[^1] < '0' || textBox2.Text[^1] > '9') && textBox2.Text[^1] != '.')
					textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);

				textBox2.SelectionStart = startPos;
			}
		}
	}
}
