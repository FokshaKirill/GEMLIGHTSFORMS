using System.Globalization;

namespace GEMLIGHTSFORMS
{
	public partial class ProductForm : Form
	{
		public List<User> users = new List<User>();            //☆
		public User user = new();
		public Product product;
		public Card card = new();
		public bool isMoreThan0 = true;
		public bool isNew = false;
		public bool isDeleted = false;
		public bool isSaved = false;
		public int countOfProduct = 0;

		public ProductForm(User user, Product product, bool isNew, int countOfProduct)
		{
			InitializeComponent();

			this.user = user;
			this.product = product;
			this.isNew = isNew;
			this.countOfProduct = countOfProduct;

			CheckInfo();

			foreach (TextBox box in Controls.OfType<TextBox>())
				box.TextChanged += (s, a) => { isSaved = false; };

			if (user.Admin != true)
			{
				SaveButton.Font = new Font("Avoner", SaveButton.Font.Size);
				CountTableLayout.Visible = true;
				PlusButton.MouseClick += (s, a) => { if (int.Parse(CountLabel.Text) < product.Stock) CountLabel.Text = (int.Parse(CountLabel.Text) + 1).ToString(); };
				MinusButton.MouseClick += (s, a) => { if (int.Parse(CountLabel.Text) > 0) CountLabel.Text = (int.Parse(CountLabel.Text) - 1).ToString(); };
				CountLabel.TextChanged += (s, a) => { SaveButton.Text = $"{double.Parse((product.Price * int.Parse(CountLabel.Text)).ToString().Replace(',', '.'), CultureInfo.InvariantCulture)} USD"; };
				CountLabel.Text = countOfProduct.ToString();
			}

			CountLabel.TextChanged += (s, a) => { if (product.Stock <= 0) { MessageBox.Show("Вы купили последний товар!"); isDeleted = true; DB.products.Remove(product); Dispose(); Close(); } };
			this.KeyDown += (s, a) => { if (a.KeyCode == Keys.Escape) Close(); };
		}

		private void Add_Click(object sender, EventArgs e)  //Ready
		{
			if (SaveButton.Text == "Сохранить")
			{
				isMoreThan0 = true;

				List<TextBox> textBoxes = new List<TextBox>
				{
					NameBox,
					SizeBox,
					WeightBox,
					DescriptionBox,
					MaterialBox,
					USDTextBox,
					StockBox
				};

				for (int i = 0; i < textBoxes.Count; i++)
				{
					if (textBoxes[i].Text.Replace(" ", "").Length <= 0)
					{
						isMoreThan0 = false;

						MessageBox.Show("Произошла ошибка: одно из полей пустое!");
						break;
					}
				}

				if (isMoreThan0 == true)
				{
					product.Name = NameBox.Text;
					product.Size = int.Parse(SizeBox.Text);
					product.Weight = double.Parse(WeightBox.Text);
					product.Description = DescriptionBox.Text;
					product.Material = MaterialBox.Text;
					product.Group = CategoryComboBox.Text;
					product.ImagePath = ImageBox.ImageLocation;
					product.Price = Double.Parse(USDTextBox.Text.Replace(',', '.').Replace(" ", ""), CultureInfo.InvariantCulture);
					product.Stock = int.Parse(StockBox.Text);

					string imgPath = DB.exePath + @"Data\images\CATALOGUE\" + Path.GetFileName(ImageBox.ImageLocation);

					foreach (var item in Application.OpenForms)
						if (item is CatalogueForm catalogueForm)
							catalogueForm.UpdateCatalogueItem(DB.products.IndexOf(product), product);

					if (!File.Exists(imgPath))
						File.Copy(ImageBox.ImageLocation, imgPath);

					product.ImagePath = imgPath;
					ImageBox.Load(product.ImagePath);

					isSaved = true;
				}
				else
					MessageBox.Show("Произошла ошибка: одно из полей пустое!");
			}
			else
			{
				if (user.CardNumber != "0000 0000 0000 0000")
				{
					string str = USDTextBox.Text.Replace(',', '.').Replace(" ", "").Remove(USDTextBox.Text.Length - 5, 3);

					if (card.USD > Double.Parse(str, CultureInfo.InvariantCulture))
					{
						if (product.Stock > 0)
						{
							product.Stock -= int.Parse(CountLabel.Text);
							StockBox.Text = product.Stock.ToString();
							card.USD -= Double.Parse(str, CultureInfo.InvariantCulture) * int.Parse(CountLabel.Text);

							for (int i = 0; i < DB.cards.Count; i++)
								if (DB.cards[i].Number == card.Number)
									DB.cards[i] = card;

							if (int.Parse(CountLabel.Text) > product.Stock)
								CountLabel.Text = product.Stock.ToString();
						}
						else
						{
							MessageBox.Show("Вы купили последний товар!");
							DB.products.Remove(product);
							Dispose();
						}
					}
					else
						MessageBox.Show("Произошла ошибка: на привязанной карте недостаточно денег!");
				}
				else
					MessageBox.Show("Произошла ошибка: вы не привязали карту к аккаунту!");
			}
		}

		public void CheckInfo()
		{
			//Находим карту юзера
			for (int i = 0; i < DB.cards.Count; i++)
			{
				if (DB.cards[i].Number == user.CardNumber)
				{
					card = DB.cards[i];
					break;
				}
			}

			//Меняем текста кнопок
			if (user.Admin == true)
				SaveButton.Text = "Сохранить";
			else
			{
				SaveButton.Text = product.Price.ToString().Replace(',', '.').Replace(" ", "") + " $";
				SaveButton.Size = new Size(256, 30);
				DeleteButton.Visible = false;
				USDLabel.Visible = false;
				label5.Visible = false;
				USDTextBox.Visible = false;
				ImageBox.Cursor = Cursors.Default;
			}

			//Создаём коллекцию, чтобы потом у каждого бокса менять стиль и ставить значение ReadOnly
			List<TextBox> textBoxes = new List<TextBox>
			{
				NameBox,
				SizeBox,
				WeightBox,
				DescriptionBox,
				MaterialBox,
				USDTextBox,
				StockBox
			};

			//Добавляем категории в список категорий
			CategoryComboBox.Items.Add("Кольца");
			CategoryComboBox.Items.Add("Ожерелья");
			CategoryComboBox.Items.Add("Серьги");
			CategoryComboBox.Items.Add("Браслеты");
			CategoryComboBox.Items.Add("Броши и булавки");
			CategoryComboBox.Items.Add("Цепи");

			//Если у продукта нет изображения, ставим дефолт
			if (product.ImagePath == "")
				product.ImagePath = DB.exePath + @"Data\images\CATALOGUE\default.png";

			//Загружаем в боксы данные продукта
			ImageBox.ImageLocation = product.ImagePath;
			NameBox.Text = product.Name;
			SizeBox.Text = product.Size.ToString();
			WeightBox.Text = product.Weight.ToString();
			DescriptionBox.Text = product.Description;
			MaterialBox.Text = product.Material;
			ArticolLabel.Text = product.Articol;
			CategoryComboBox.Text = product.Group;
			USDTextBox.Text = product.Price.ToString();
			StockBox.Text = product.Stock.ToString();

			//Меняем стиль боксов и ставим значение ReadOnly
			if (user.Admin == false)
			{
				TextBox categoryLabel = new TextBox();
				categoryLabel.Text = CategoryComboBox.Text;
				categoryLabel.Font = NameBox.Font;
				categoryLabel.Bounds = CategoryComboBox.Bounds;
				categoryLabel.Location = new Point(categoryLabel.Bounds.X + 4, categoryLabel.Bounds.Y);
				categoryLabel.BackColor = Color.White;
				categoryLabel.ForeColor = Color.Black;
				categoryLabel.ReadOnly = true;
				categoryLabel.BorderStyle = BorderStyle.None;
				Controls.Add(categoryLabel);

				CategoryComboBox.Visible = false;

				for (int i = 0; i < textBoxes.Count; i++)
				{
					textBoxes[i].ReadOnly = true;
					textBoxes[i].BorderStyle = BorderStyle.None;
					textBoxes[i].BackColor = Color.White;
					textBoxes[i].ForeColor = Color.Black;

					if (textBoxes[i] != DescriptionBox)
						textBoxes[i].Text = " " + textBoxes[i].Text;

					if (textBoxes[i] == USDTextBox)
						USDTextBox.Text += " USD";
				}
			}

			//Меняем стиль ComboBox и ставим значение ReadOnly
			if (isNew == false)
			{
				CategoryComboBox.Enabled = false;
				CategoryComboBox.BackColor = Color.White;
				CategoryComboBox.ForeColor = Color.Black;
				CategoryComboBox.DropDownStyle = ComboBoxStyle.Simple;
			}
		}

		private void ImageBox_Click(object sender, EventArgs e)
		{
			if (user.Admin == true)
			{
				OpenFileDialog fdlg = new OpenFileDialog();
				fdlg.Title = "C# Диалоговое окно загрузки изображения";
				fdlg.InitialDirectory = @"c:\";
				fdlg.Filter = "Image Files(*.jpeg;*.png;*.jpg)|*.jpeg;*.png;*.jpg";
				fdlg.FilterIndex = 2;
				fdlg.RestoreDirectory = true;

				if (fdlg.ShowDialog() == DialogResult.OK)
					ImageBox.Load(fdlg.FileName);
			}
		}

		private void DeleteButton_Click(object sender, EventArgs e)
		{
			if (user.Admin == true)
			{
				isDeleted = true;
				DB.products.Remove(product);
				Close();
			}
		}

		private void USDTextBox_TextChanged(object sender, EventArgs e)
		{
			if (USDTextBox.Text.Length > 0)
			{
				int startPos = USDTextBox.SelectionStart;

				if ((USDTextBox.Text[^1] < '0' || USDTextBox.Text[^1] > '9') && USDTextBox.Text[^1] != ',')
					USDTextBox.Text = USDTextBox.Text.Remove(USDTextBox.Text.Length - 1);

				USDTextBox.SelectionStart = startPos;
			}
		}

		private void DescriptionBox_TextChanged(object sender, EventArgs e)
		{
			isSaved = false;

			int posTemp = DescriptionBox.SelectionStart;

			if (DescriptionBox.Text.Contains("\r\n"))
			{
				DescriptionBox.Text = DescriptionBox.Text.Replace("\r\n", ". ");
				DescriptionBox.SelectionStart = posTemp + 2;
			}
		}

		private void AddToCartB_Click(object sender, EventArgs e)
		{
			DB.RefreshCartsList(DB.pathCarts);

			foreach (var c in DB.carts)
				if (c.Username == user.Username)
					if (!c.ProductsList.Contains(product) && product.Stock > 0)
						c.ProductsList.Add(product);

			DB.RewriteCartsFile(DB.pathCarts);
		}

		private void SizeBox_TextChanged(object sender, EventArgs e)
		{
			if (SizeBox.Text.Length > 0)
			{
				int startPos = SizeBox.SelectionStart;

				if (SizeBox.Text[^1] < '0' || SizeBox.Text[^1] > '9')
					SizeBox.Text = SizeBox.Text.Remove(SizeBox.Text.Length - 1);

				SizeBox.SelectionStart = startPos;
			}
		}

		private void WeightBox_TextChanged(object sender, EventArgs e)
		{
			if (WeightBox.Text.Length > 0)
			{
				int startPos = WeightBox.SelectionStart;

				if ((WeightBox.Text[^1] < '0' || WeightBox.Text[^1] > '9') && WeightBox.Text[^1] != ',')
					WeightBox.Text = WeightBox.Text.Remove(WeightBox.Text.Length - 1);

				WeightBox.SelectionStart = startPos;
			}
		}

		private void StockBox_TextChanged(object sender, EventArgs e)
		{
			if (StockBox.Text.Length > 0)
			{
				int startPos = StockBox.SelectionStart;

				if (StockBox.Text[^1] < '0' || StockBox.Text[^1] > '9')
					StockBox.Text = StockBox.Text.Remove(StockBox.Text.Length - 1);

				StockBox.SelectionStart = startPos;
			}
		}
	}
}