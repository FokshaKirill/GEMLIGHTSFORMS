using System.Globalization;

namespace GEMLIGHTSFORMS
{
	public partial class CartProductItem : UserControl
	{
		public Product product = new();
		public User user = new();

		public CartProductItem(Product product, User user)
		{
			InitializeComponent();
			this.product = product;
			this.user = user;

			NameLabel.Text = product.Name;
			ItemImageBox.ImageLocation = product.ImagePath;
			BuyButton.Text = $"{double.Parse(product.Price.ToString().Replace(',', '.'), CultureInfo.InvariantCulture)} USD";

			BuyButton.MouseClick += (s, a) => { EditProduct(); };
			NameLabel.MouseClick += (s, a) => { EditProduct(); };
			ItemImageBox.MouseClick += (s, a) => { EditProduct(); };
			PlusButton.MouseClick += (s, a) => { if (int.Parse(CountLabel.Text) < product.Stock) CountLabel.Text = (int.Parse(CountLabel.Text) + 1).ToString(); };
			MinusButton.MouseClick += (s, a) => { if (int.Parse(CountLabel.Text) > 0) CountLabel.Text = (int.Parse(CountLabel.Text) - 1).ToString(); };
			CountLabel.TextChanged += (s, a) => { BuyButton.Text = $"{double.Parse((product.Price * int.Parse(CountLabel.Text)).ToString().Replace(',', '.'), CultureInfo.InvariantCulture)} USD"; };
			CloseButton.MouseEnter += (s, a) => { CloseButton.Load(DB.exePath + @"Data\images\close2.jpg"); };
			CloseButton.MouseLeave += (s, a) => { CloseButton.Load(DB.exePath + @"Data\images\close1.jpg"); };
			CloseButton.Click += (s, a) => { foreach (var c in DB.carts) if (user.Username == c.Username) c.ProductsList.Remove(product); Dispose(); };
			BuyButton.MouseEnter += (s, a) => { CloseButton.Visible = true; };
			NameLabel.MouseEnter += (s, a) => { CloseButton.Visible = true; };
			ItemImageBox.MouseEnter += (s, a) => { CloseButton.Visible = true; };
			PlusButton.MouseEnter += (s, a) => { CloseButton.Visible = true; };
			MinusButton.MouseEnter += (s, a) => { CloseButton.Visible = true; };
			CountLabel.MouseEnter += (s, a) => { CloseButton.Visible = true; };
			panel1.MouseEnter += (s, a) => { CloseButton.Visible = true; };
			panel1.MouseLeave += (s, a) => { CloseButton.Visible = true; };
			this.MouseLeave += (s, a) => { CloseButton.Visible = false; };
			this.Disposed += (s, a) => { DB.RewriteCartsFile(DB.pathCarts); };
		}

		private void EditProduct()
		{
			bool isNew = false;
			ProductForm productForm = new(user, product, isNew, int.Parse(CountLabel.Text));

			productForm.FormClosing += (sender1, e1) =>
			{
				foreach (var item in Application.OpenForms)
				{
					if (item is CatalogueForm catalogueForm)
					{
						if (productForm.isMoreThan0 == true && productForm.isDeleted == false)
						{
							product = productForm.product;

							DB.RewriteProductsFile(DB.pathCatalogue);

							if (productForm.product.Stock <= 0)
								Dispose();

							catalogueForm.UpdateCatalogueItem(DB.products.IndexOf(product), productForm.product);
							DB.RewriteCardsFile(DB.pathCards);
							catalogueForm.CheckInfo();

							return;
						}
						if (productForm.isDeleted == true)
						{
							Dispose();
							DB.RewriteProductsFile(DB.pathCatalogue);
							DB.RewriteCartsFile(DB.pathCarts);
							catalogueForm.LoadData("");
							catalogueForm.CheckInfo();

							return;
						}
					}
				}
			};

			productForm.ShowDialog();
		}

		private void NameLabel_TextChanged(object sender, EventArgs e)
		{
			if (NameLabel.Text.Length > 13)
				NameLabel.Text = NameLabel.Text.Remove(NameLabel.Text.Length - 1, 1);
		}
	}
}
