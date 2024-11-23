namespace GEMLIGHTSFORMS
{
	public partial class CatalogueForm : Form
	{
		private User user;

		public CatalogueForm(User user)
		{
			InitializeComponent();

			this.user = user;

			ExitButton.Image = DB.ResizeImage(ExitButton.Image, new Size(16, 16));
			SearchButton.Image = DB.ResizeImage(SearchButton.Image, new Size(16, 16));

			CheckInfo();
			LoadData(SearchBox.Text);
			CreateItemPanel();

			AddCard.Click += (s, a) => { if (AddCard.Text == "+") AddCardMethod(); else DelCardMethod(); };
			FIO.Click += (s, a) => { AccountEnter(); };
			Avatar.Click += (s, a) => { AccountEnter(); };
			ExitButton.Click += (s, a) => { LogIn logIn = new(); logIn.Show(); Hide(); };
			SearchButton.Click += (s, a) => { SbrosFilter(); LoadData(SearchBox.Text); ActiveControl = null; };
		}

		#region Unusable Methods
		private void SearchBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)13)
			{
				SbrosFilter();
				LoadData(SearchBox.Text);
				ActiveControl = null;
			}
		}

		private void PriceSortBox1_TextChanged(object sender, EventArgs e)
		{
			if (PriceSortBox1.Text.Length > 0)
			{
				int selectIndex = PriceSortBox1.SelectionStart;

				char[] str = PriceSortBox1.Text.ToCharArray();

				for (int i = 0; i < str.Length; i++)
					if (!(str[i] >= '0' && str[i] <= '9') && str[i] != '.')
						PriceSortBox1.Text = PriceSortBox1.Text.Remove(i, 1);

				PriceSortBox1.SelectionStart = selectIndex;
			}
		}

		private void PriceSortBox2_TextChanged(object sender, EventArgs e)
		{
			if (PriceSortBox2.Text.Length > 0)
			{
				int selectIndex = PriceSortBox2.SelectionStart;

				char[] str = PriceSortBox2.Text.ToCharArray();

				for (int i = 0; i < str.Length; i++)
					if (!(str[i] >= '0' && str[i] <= '9') && str[i] != '.')
						PriceSortBox2.Text = PriceSortBox2.Text.Remove(i, 1);

				PriceSortBox2.SelectionStart = selectIndex;
			}
		}

		private void SizeSortBox1_TextChanged(object sender, EventArgs e)
		{
			if (SizeSortBox1.Text.Length > 0)
			{
				int selectIndex = SizeSortBox1.SelectionStart;

				char[] str = SizeSortBox1.Text.ToCharArray();

				for (int i = 0; i < str.Length; i++)
					if (!(str[i] >= '0' && str[i] <= '9'))
						SizeSortBox1.Text = SizeSortBox1.Text.Remove(i, 1);

				SizeSortBox1.SelectionStart = selectIndex;
			}
		}

		private void SizeSortBox2_TextChanged(object sender, EventArgs e)
		{
			if (SizeSortBox2.Text.Length > 0)
			{
				int selectIndex = SizeSortBox2.SelectionStart;

				char[] str = SizeSortBox2.Text.ToCharArray();

				for (int i = 0; i < str.Length; i++)
					if (!(str[i] >= '0' && str[i] <= '9'))
						SizeSortBox2.Text = SizeSortBox2.Text.Remove(i, 1);

				SizeSortBox2.SelectionStart = selectIndex;
			}
		}
		#endregion

		public void AddCardMethod()
		{
			CardForm form4 = new CardForm();

			form4.FormClosing += (sender1, e1) =>
			{
				for (int i = 0; i < DB.cards.Count; i++)
				{
					if (form4.cardNumb == DB.cards[i].Number)
					{
						user.CardNumber = form4.cardNumb;

						DB.RewriteUsersFile(DB.pathDB);
						CheckInfo();
					}
				}
			};

			form4.Show();
		}

		public void DelCardMethod()
		{
			for (int i = 0; i < DB.users.Count; i++)
				if (DB.users[i].Username == user.Username)
					user.CardNumber = "0000 0000 0000 0000";

			DB.RewriteUsersFile(DB.pathDB);
			CheckInfo();
		}

		public void AccountEnter()
		{
			Account account = new Account(user);

			account.FormClosing += (sender1, e1) =>
			{
				if (account.isSaved == true)
				{
					user = account.user;
					DB.users.Remove(user);
					DB.users.Add(user);
					DB.RewriteUsersFile(DB.pathDB);

					CheckInfo();
				}
			};

			account.ShowDialog();
		}

		public void LoadData(string search)
		{
			List<string> categories = new List<string>();

			Catalogue2.Controls.Clear();
			MaterialSortBox.Items.Clear();
			CategorySortBox.Items.Clear();

			DB.RefreshProductsList(DB.pathCatalogue);

			for (int i = 0; i < DB.products.Count; i++)
			{
				if (DB.products[i].Name.ToLower().Contains(search.ToLower()) || DB.products[i].Articol.ToLower().Contains(search.ToLower()))   //Поиск элементов по имени. Если "", то выводятся все элементы
				{
					ItemUserControl item = new ItemUserControl(user, i);
					Catalogue2.Controls.Add(item);
				}

				categories.Add(DB.products[i].Material);
			}

			Catalogue2.Controls.Add(AddItemPicture);

			categories = categories.Distinct().ToList();
			MaterialSortBox.Items.Add("Не выбрано");
			MaterialSortBox.Items.AddRange(categories.ToArray());

			CategorySortBox.Items.Add("Не выбрано");
			CategorySortBox.Items.Add("Кольца");
			CategorySortBox.Items.Add("Ожерелья");
			CategorySortBox.Items.Add("Серьги");
			CategorySortBox.Items.Add("Броши и булавки");
			CategorySortBox.Items.Add("Браслеты");
			CategorySortBox.Items.Add("Цепи");
		}

		public void UpdateCatalogueItem(int index, Product product)
		{
			foreach (var item in Catalogue2.Controls)
			{
				if (item is ItemUserControl itemUserControl && itemUserControl.indexItem == index)
				{
					itemUserControl.NameLabel.Text = product.Name;
					itemUserControl.ArticolLabel.Text = product.Articol;
					itemUserControl.ItemImage.ImageLocation = product.ImagePath;
					itemUserControl.BuyButtonB.Text = $"{product.Price} USD";

					return;
				}
			}
		}

		public void CheckInfo()
		{
			DB.RefreshCardsList(DB.pathCards);
			DB.RefreshProductsList(DB.pathCatalogue);

			FIO.Text = user.FIO;
			Avatar.Load(user.ImagePath);

			Avatar.Image = DB.ResizeImage(Avatar.Image, new Size(64, 64));
			Avatar.Image = DB.ClipToCircle(Avatar.Image, new PointF(Avatar.Image.Width / 2, Avatar.Image.Height / 2), Avatar.Image.Width / 2, panel3.BackColor);

			if (user.CardNumber.Length <= 0 || user.CardNumber == "0000 0000 0000 0000")
			{
				CardLabel.Text = "Баланс: карта не привязана";
				AddCard.Text = "+";
			}
			else
			{
				foreach (var item in DB.cards)
					if (item.Number == user.CardNumber)
						CardLabel.Text = $"Баланс: {item.USD} USD";

				AddCard.Text = "-";
			}

			if (user.Admin == true)
			{
				AdmOrCli.Text = "Администратор"; AddItemPicture.Visible = true;
			}
			else
			{
				AdmOrCli.Text = "Клиент"; AddItemPicture.Visible = false;
			}
		}

		public void CreateItemPanel()
		{
			Catalogue2.Controls.Clear();

			for (int i = 0; i < DB.products.Count; i++)
			{
				ItemUserControl item = new ItemUserControl(user, i);

				Catalogue2.Controls.Add(item);
			}

			Catalogue2.Controls.Add(AddItemPicture);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			FilterItems(SearchBox.Text);
			Catalogue2.Controls.Add(AddItemPicture);
		}

		public void FilterItems(string search)
		{
			Catalogue2.Controls.Clear();
			DB.RefreshProductsList(DB.pathCatalogue);

			double price1, price2; string category, material; int size1, size2;

			if (PriceSortBox1.Text.Length > 0) price1 = Double.Parse(PriceSortBox1.Text.Replace(',', '.')); else price1 = 0;
			if (PriceSortBox2.Text.Length > 0) price2 = Double.Parse(PriceSortBox2.Text.Replace(',', '.')); else price2 = 9999999;
			if (SizeSortBox1.Text.Length > 0) size1 = int.Parse(SizeSortBox1.Text); else size1 = 0;
			if (SizeSortBox2.Text.Length > 0) size2 = int.Parse(SizeSortBox2.Text); else size2 = 999;
			if (CategorySortBox.Text.Length > 0 && CategorySortBox.Text != "Не выбрано") category = CategorySortBox.Text; else category = "";
			if (MaterialSortBox.Text.Length > 0 && MaterialSortBox.Text != "Не выбрано") material = MaterialSortBox.Text; else material = "";

			if (price1 < 0) PriceSortBox1.Text = "";
			if (price2 < 0) PriceSortBox2.Text = "";
			if (size1 < 0) SizeSortBox1.Text = "";
			if (size2 < 0) SizeSortBox2.Text = "";

			for (int i = 0; i < DB.products.Count; i++)
			{
				if (DB.products[i].Name.ToLower().Contains(search.ToLower()))   //Поиск элементов по имени. Если "", то выводятся все элементы
				{
					if (DB.products[i].Price >= price1 && DB.products[i].Price <= price2)
					{
						if (DB.products[i].Size >= size1 && DB.products[i].Size <= size2)
						{
							if (DB.products[i].Material.Contains(material))
							{
								if (DB.products[i].Group.Contains(category))
								{
									ItemUserControl item = new ItemUserControl(user, i);

									Catalogue2.Controls.Add(item);
								}
							}
						}
					}
				}
			}
		}

		public void SbrosFilter()
		{
			PriceSortBox1.Text = "";
			PriceSortBox2.Text = "";
			SizeSortBox1.Text = "";
			SizeSortBox2.Text = "";
			MaterialSortBox.Text = "Не выбрано";
			CategorySortBox.Text = "Не выбрано";
		}

		private void SbrosButton_Click(object sender, EventArgs e)
		{
			SbrosFilter();
			LoadData(SearchBox.Text);
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			bool isNew = true;
			ProductForm productForm = new ProductForm(this.user, new Product(), isNew, 1);

			productForm.FormClosing += (sender1, e1) =>
			{
				if (productForm.isMoreThan0 == true && productForm.isDeleted == false && productForm.isSaved == true)
				{
					DB.products.Add(productForm.product);
					DB.RewriteProductsFile(DB.pathCatalogue);

					LoadData("");
				}
			};

			productForm.ShowDialog();
		}

		private void pictureBox3_MouseEnter(object sender, EventArgs e)
		{
			AddItemPicture.Image = new Bitmap(DB.exePath + @"Data\images\addbutton2.png");
		}

		private void pictureBox3_MouseLeave(object sender, EventArgs e)
		{
			AddItemPicture.Image = new Bitmap(DB.exePath + @"Data\images\addbutton1.png");
		}
	}
}
