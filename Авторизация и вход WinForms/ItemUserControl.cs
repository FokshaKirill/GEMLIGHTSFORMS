namespace GEMLIGHTSFORMS
{
	public partial class ItemUserControl : UserControl
	{
		public int indexItem = 0;
		public User user = new();

		public ItemUserControl(User user, int indexItem)
		{
			InitializeComponent();
			BuyButtonB.Click += (s, a) => { EditProduct(); };
			NameLabel.MouseClick += (s, a) => { EditProduct(); };
			ItemImage.MouseClick += (s, a) => { EditProduct(); };

			this.indexItem = indexItem;
			this.user = user;

			DB.RefreshProductsList(DB.pathCatalogue);

			if (DB.products.Count > 0)
			{
				if (DB.products[indexItem].ImagePath == "")
					DB.products[indexItem].ImagePath = @"C:\Users\fok6a\OneDrive\Рабочий стол\РПМ\Курсовая РПМ\GEMLIGHTS\Авторизация и вход WinForms\Data\images\CATALOGUE\default.png";

				ItemImage.ImageLocation = DB.products[indexItem].ImagePath;
				NameLabel.Text = DB.products[indexItem].Name;
				ArticolLabel.Text = DB.products[indexItem].Articol;
				ArticolLabel.Left = ItemPanel.Width / 2 - ArticolLabel.Width / 2;
				BuyButtonB.Left = ItemPanel.Width / 2 - BuyButtonB.Width / 2;
				BuyButtonB.Text = DB.products[indexItem].Price + " USD";
			}
		}

		private void EditProduct()
		{
			bool isNew = false;
			ProductForm productForm = new ProductForm(user, DB.products[indexItem], isNew, 1);

			productForm.FormClosing += (sender1, e1) =>
			{
				foreach (var item in Application.OpenForms)
				{
					if (item is CatalogueForm catalogueForm)
					{
						if (productForm.isMoreThan0 == true && productForm.isDeleted == false)
						{
							DB.products[indexItem] = productForm.product;
							DB.RewriteProductsFile(DB.pathCatalogue);
							catalogueForm.UpdateCatalogueItem(indexItem, productForm.product);
							DB.RewriteCardsFile(DB.pathCards);
							catalogueForm.CheckInfo();

							return;
						}
						if (productForm.isDeleted == true)
						{
							DB.RewriteProductsFile(DB.pathCatalogue);
							DB.RewriteCartsFile(DB.pathCarts);
							catalogueForm.LoadData("");
							catalogueForm.CheckInfo();
							Dispose();

							return;
						}
					}
				}
			};

			productForm.ShowDialog();
		}

		private void NameLabel_MouseEnter(object sender, EventArgs e)
		{
			NameLabel.ForeColor = Color.FromArgb(238, 55, 78);
		}

		private void NameLabel_MouseLeave(object sender, EventArgs e)
		{
			NameLabel.ForeColor = Color.Black;
		}
	}
}
