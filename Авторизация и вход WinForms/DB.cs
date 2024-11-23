using System.Drawing.Drawing2D;
using System.Globalization;

namespace GEMLIGHTSFORMS
{
	public class DB
	{
		public static List<User> users = new();
		public static List<Card> cards = new();
		public static List<Product> products = new();
		public static List<Cart> carts = new();

		public static string exePath = AppDomain.CurrentDomain.BaseDirectory;     //☆
		public static string pathCards = exePath + @"Data\cards.txt";
		public static string pathDB = exePath + @"Data\DB.txt";
		public static string pathCatalogue = exePath + @"Data\catalogue.txt";
		public static string pathCarts = exePath + @"Data\carts.txt";

		public static Image ClipToCircle(Image importImage, PointF center, float radius, Color backGround)
		{
			Image exportImage = new Bitmap(importImage.Width, importImage.Height, importImage.PixelFormat);

			using (Graphics g = Graphics.FromImage(exportImage))
			{
				RectangleF r = new RectangleF(center.X - radius, center.Y - radius,
														 radius * 2, radius * 2);

				// enables smoothing of the edge of the circle (less pixelated)
				g.SmoothingMode = SmoothingMode.AntiAlias;

				// fills background color
				using (Brush br = new SolidBrush(backGround))
					g.FillRectangle(br, 0, 0, exportImage.Width, exportImage.Height);

				// adds the new ellipse & draws the image again 
				GraphicsPath path = new GraphicsPath();
				path.AddEllipse(r);
				g.SetClip(path);
				g.DrawImage(importImage, 0, 0);

				return exportImage;
			}
		}

		public static void RewriteUsersFile(string pathFile)
		{
			StreamWriter writer = new StreamWriter(pathFile, false);

			foreach (var u in users)
			{
				if (u.Admin == true)
					writer.Write("Админ");
				else
					writer.Write("Клиент");

				writer.WriteLine($" ☆ {u.FIO} ☆ {u.BornDate} ☆ {u.Username} ☆ {u.Password} ☆ {u.ImagePath} ☆ {u.CardNumber}");
			}

			writer.Close();
		}       //Перезаписывает файл с пользователями

		public static void RewriteProductsFile(string pathFile)
		{
			StreamWriter writer = new StreamWriter(pathFile, false);

			foreach (var p in products)
				writer.WriteLine($"{p.Articol} ☆ {p.Name} ☆ {p.Group} ☆ {p.Material} ☆ {p.Size} ☆ {p.Weight} ☆ {p.ImagePath} ☆ {p.Description} ☆ {Double.Parse(p.Price.ToString().Replace(',', '.'), CultureInfo.InvariantCulture)} ☆ {p.Stock}");

			writer.Close();
		}    //Перезаписывает файл с продуктами

		public static void RewriteCardsFile(string pathFile)
		{
			StreamWriter writer = new StreamWriter(pathFile, false);

			foreach (var c in cards)
				writer.WriteLine($"{c.Number} ☆ {c.Date} ☆ {c.CVV} ☆ {Double.Parse(c.USD.ToString().Replace(',', '.'), CultureInfo.InvariantCulture)}");

			writer.Close();
		}       //Перезаписывает файл с кредитными картами

		public static void RewriteCartsFile(string pathFile)
		{
			StreamWriter writer = new StreamWriter(pathFile, false);

			foreach (var u in users)
			{
				writer.Write($"{u.Username}");

				foreach (var c in carts)
				{
					if (c.Username == u.Username)
						foreach (var p in c.ProductsList)
							writer.Write($" ☆ {p.Articol}");
				}

				writer.WriteLine();
			}

			writer.Close();
		}       //Перезаписывает файл с корзинами

		public static void RefreshUsersList(string pathFile)
		{
			using StreamReader stream = new StreamReader(pathFile, true);

			DB.users.Clear();

			while (true)
			{
				var str = stream.ReadLine();

				if (str == null)
					break;

				User currentUser = new User();

				string[] data = str.Replace(" ☆ ", "☆").Split('☆');

				if (data[0] == "Админ")
					currentUser.Admin = true;
				else if (data[0] == "Клиент")
					currentUser.Admin = false;

				currentUser.FIO = data[1];
				currentUser.BornDate = data[2];
				currentUser.Username = data[3];
				currentUser.Password = data[4];
				currentUser.ImagePath = data[5];
				currentUser.CardNumber = data[6];

				DB.users.Add(currentUser);
			}
			stream.Close();
		}       //Считывает данные с файла с пользователями

		public static void RefreshProductsList(string pathFile)
		{
			using StreamReader stream = new StreamReader(pathFile, true);

			products.Clear();

			while (true)
			{
				var str = stream.ReadLine();

				if (str == null)
					break;

				Product currentProduct = new Product();

				string[] data = str.Replace(" ☆ ", "☆").Split('☆');

				currentProduct.Name = data[1];
				currentProduct.Group = data[2];
				currentProduct.Material = data[3];
				currentProduct.Size = int.Parse(data[4]);
				currentProduct.Weight = double.Parse(data[5]);
				currentProduct.ImagePath = @$"{data[6]}";
				currentProduct.Description = data[7];
				currentProduct.Price = Double.Parse(data[8].Replace(',', '.'), CultureInfo.InvariantCulture);
				currentProduct.Stock = int.Parse(data[9]);

				currentProduct.Articol = "";    //Задаем значение артикула с нуля

				if (currentProduct.Group == "Кольца")   //Добавляем в артикул уникальные индексы
					currentProduct.Articol = "RI";
				if (currentProduct.Group == "Ожерелья")
					currentProduct.Articol = "CO";
				if (currentProduct.Group == "Серьги")
					currentProduct.Articol = "EA";
				if (currentProduct.Group == "Броши и булавки")
					currentProduct.Articol = "BR";
				if (currentProduct.Group == "Браслеты")
					currentProduct.Articol = "AN";
				if (currentProduct.Group == "Цепи")
					currentProduct.Articol = "CH";

				int count0 = (4 - products.Count.ToString().Length);
				for (int i = 0; i < count0; i++)                        //Добавляет нули в начало артикула
					currentProduct.Articol += "0";

				currentProduct.Articol += (products.Count + 1).ToString();

				products.Add(currentProduct);
			}

			stream.Close();
		}    //Считывает данные с файла с продуктами

		public static void RefreshCardsList(string pathFile)
		{
			using StreamReader stream = new StreamReader(pathFile, true);

			cards.Clear();

			while (true)
			{
				var str = stream.ReadLine();

				if (str == null)
					break;

				Card currentCard = new Card();

				string[] data = str.Replace(" ☆ ", "☆").Split('☆');

				currentCard.Number = data[0];
				currentCard.Date = data[1];
				currentCard.CVV = data[2];
				currentCard.USD = Double.Parse(data[3].ToString().Replace(',', '.'), CultureInfo.InvariantCulture);

				cards.Add(currentCard);
			}
			stream.Close();
		}       //Считывает данные с файла с кредитными картами

		public static void RefreshCartsList(string pathFile)
		{
			using StreamReader stream = new StreamReader(pathFile, true);

			carts.Clear();

			while (true)
			{
				var str = stream.ReadLine();

				if (str == null)
					break;

				Cart currentCart = new Cart();

				string[] data = str.Replace(" ☆ ", "☆").Split('☆');

				currentCart.Username = data[0];
				currentCart.ProductsList.Clear();

				for (int i = 1; i < data.Length; i++)
				{
					for (int j = 0; j < products.Count; j++)
					{
						if (data[i] == products[j].Articol)
						{
							currentCart.ProductsList.Add(products[j]);
							break;
						}
					}
				}

				carts.Add(currentCart);
			}
			stream.Close();
		}       //Считывает данные с файла с корзинами

		public static Image ResizeImage(Image imgToResize, Size size)
		{
			return new Bitmap(imgToResize, size);
		}
	}

	public class User
	{
		public string FIO = "Странник";
		public string BornDate = "???";
		public string Username = "???";
		public string Password = "???";
		public bool Admin = false;
		public string CardNumber = "";
		public string ImagePath = @"";

		public User()
		{
			FIO = "Странник";
			BornDate = "???";
			Username = "???";
			Password = "???";
			Admin = false;
			CardNumber = "0000 0000 0000 0000";
			ImagePath = DB.exePath + @"Data\images\AVATARS\default.png";
		}
	}

	public class Card
	{
		public string Number = "0000 0000 0000 0000";
		public string Date = "00/0000";
		public string CVV = "000";
		public double USD = 0;
	}

	public class Product
	{
		public string Articol = "000000";
		public string Name = "Кусочек меди";
		public string Group = "Кольца";
		public string Material = "Медь";
		public int Size = 0;
		public double Weight = 0;
		public string ImagePath = DB.exePath + @"Data\images\CATALOGUE\default.png";
		public string Description = "";
		public double Price = 10.00;
		public int Stock = 0;

		public Product()
		{
			Articol = "000000";
			Name = "Кусочек меди";
			Group = "Кольца";
			Material = "Медь";
			Size = 1;
			Weight = 1;
			ImagePath = DB.exePath + @"Data\images\CATALOGUE\default.png";
			Description = "Нет описания";
			Price = 10.00;
			Stock = 10;
		}
	}

	public class Cart
	{
		public string Username = "";
		public List<Product> ProductsList = new List<Product>();
	}
}
