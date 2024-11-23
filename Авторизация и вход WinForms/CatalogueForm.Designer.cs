namespace GEMLIGHTSFORMS
{
    partial class CatalogueForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatalogueForm));
			productsImages = new ImageList(components);
			BrandName = new Label();
			Avatar = new PictureBox();
			AddCard = new Button();
			FIO = new Label();
			CardLabel = new Label();
			ExitButton = new Button();
			SearchBox = new TextBox();
			SearchButton = new Button();
			Catalogue2 = new FlowLayoutPanel();
			AddItemPicture = new PictureBox();
			panel3 = new Panel();
			AdmOrCli = new Label();
			panel4 = new Panel();
			label1 = new Label();
			panel2 = new Panel();
			pictureBox1 = new PictureBox();
			tableLayoutPanel1 = new TableLayoutPanel();
			SbrosButton = new Button();
			panel6 = new Panel();
			CategorySortBox = new ComboBox();
			label5 = new Label();
			panel7 = new Panel();
			label6 = new Label();
			label7 = new Label();
			SizeSortBox2 = new TextBox();
			SizeSortBox1 = new TextBox();
			panel5 = new Panel();
			label2 = new Label();
			label3 = new Label();
			PriceSortBox2 = new TextBox();
			PriceSortBox1 = new TextBox();
			FilterButton = new Button();
			pictureBox2 = new PictureBox();
			panel8 = new Panel();
			MaterialSortBox = new ComboBox();
			label8 = new Label();
			label4 = new Label();
			panel9 = new Panel();
			pictureBox5 = new PictureBox();
			pictureBox4 = new PictureBox();
			pictureBox3 = new PictureBox();
			((System.ComponentModel.ISupportInitialize)Avatar).BeginInit();
			Catalogue2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)AddItemPicture).BeginInit();
			panel3.SuspendLayout();
			panel4.SuspendLayout();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			tableLayoutPanel1.SuspendLayout();
			panel6.SuspendLayout();
			panel7.SuspendLayout();
			panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			panel8.SuspendLayout();
			panel9.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			SuspendLayout();
			// 
			// productsImages
			// 
			productsImages.ColorDepth = ColorDepth.Depth8Bit;
			productsImages.ImageSize = new Size(16, 16);
			productsImages.TransparentColor = Color.Transparent;
			// 
			// BrandName
			// 
			BrandName.Anchor = AnchorStyles.None;
			BrandName.AutoSize = true;
			BrandName.Font = new Font("Avoner", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
			BrandName.ForeColor = Color.FromArgb(238, 55, 78);
			BrandName.Location = new Point(49, 37);
			BrandName.Margin = new Padding(0);
			BrandName.Name = "BrandName";
			BrandName.Size = new Size(107, 19);
			BrandName.TabIndex = 2;
			BrandName.Text = "GEMLIGHTS";
			// 
			// Avatar
			// 
			Avatar.Anchor = AnchorStyles.None;
			Avatar.Cursor = Cursors.Hand;
			Avatar.ErrorImage = (Image)resources.GetObject("Avatar.ErrorImage");
			Avatar.Image = (Image)resources.GetObject("Avatar.Image");
			Avatar.ImageLocation = "";
			Avatar.InitialImage = (Image)resources.GetObject("Avatar.InitialImage");
			Avatar.Location = new Point(872, 6);
			Avatar.Margin = new Padding(3, 5, 3, 5);
			Avatar.MaximumSize = new Size(64, 64);
			Avatar.MinimumSize = new Size(32, 32);
			Avatar.Name = "Avatar";
			Avatar.Size = new Size(52, 52);
			Avatar.SizeMode = PictureBoxSizeMode.StretchImage;
			Avatar.TabIndex = 3;
			Avatar.TabStop = false;
			// 
			// AddCard
			// 
			AddCard.Anchor = AnchorStyles.None;
			AddCard.BackColor = Color.Transparent;
			AddCard.Cursor = Cursors.Hand;
			AddCard.FlatAppearance.BorderColor = Color.White;
			AddCard.FlatAppearance.BorderSize = 0;
			AddCard.FlatStyle = FlatStyle.Flat;
			AddCard.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
			AddCard.ForeColor = Color.Black;
			AddCard.Location = new Point(1207, 32);
			AddCard.Margin = new Padding(3, 3, 10, 3);
			AddCard.Name = "AddCard";
			AddCard.Size = new Size(25, 25);
			AddCard.TabIndex = 4;
			AddCard.Text = "+";
			AddCard.UseVisualStyleBackColor = false;
			// 
			// FIO
			// 
			FIO.Anchor = AnchorStyles.None;
			FIO.AutoSize = true;
			FIO.Cursor = Cursors.Hand;
			FIO.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			FIO.ForeColor = Color.Black;
			FIO.Location = new Point(930, 6);
			FIO.Name = "FIO";
			FIO.Size = new Size(28, 16);
			FIO.TabIndex = 5;
			FIO.Text = "FIO";
			FIO.MouseEnter += FIO_MouseEnter;
			FIO.MouseLeave += FIO_MouseLeave;
			// 
			// CardLabel
			// 
			CardLabel.Anchor = AnchorStyles.None;
			CardLabel.AutoSize = true;
			CardLabel.BackColor = Color.Transparent;
			CardLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			CardLabel.ForeColor = Color.Black;
			CardLabel.Location = new Point(930, 40);
			CardLabel.Name = "CardLabel";
			CardLabel.Size = new Size(41, 17);
			CardLabel.TabIndex = 6;
			CardLabel.Text = "Card";
			// 
			// ExitButton
			// 
			ExitButton.Anchor = AnchorStyles.None;
			ExitButton.BackColor = Color.Transparent;
			ExitButton.Cursor = Cursors.Hand;
			ExitButton.FlatAppearance.BorderColor = Color.White;
			ExitButton.FlatAppearance.BorderSize = 0;
			ExitButton.FlatStyle = FlatStyle.Flat;
			ExitButton.Font = new Font("Sitka Text", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
			ExitButton.ForeColor = Color.Black;
			ExitButton.Image = (Image)resources.GetObject("ExitButton.Image");
			ExitButton.Location = new Point(1207, 6);
			ExitButton.Margin = new Padding(3, 3, 10, 3);
			ExitButton.MaximumSize = new Size(25, 25);
			ExitButton.Name = "ExitButton";
			ExitButton.Size = new Size(25, 25);
			ExitButton.TabIndex = 8;
			ExitButton.UseVisualStyleBackColor = false;
			// 
			// SearchBox
			// 
			SearchBox.Anchor = AnchorStyles.None;
			SearchBox.BackColor = Color.White;
			SearchBox.BorderStyle = BorderStyle.FixedSingle;
			SearchBox.Cursor = Cursors.IBeam;
			SearchBox.Font = new Font("Avoner", 13.5F, FontStyle.Regular, GraphicsUnit.Point);
			SearchBox.ForeColor = Color.Black;
			SearchBox.Location = new Point(427, 18);
			SearchBox.Margin = new Padding(15, 15, 0, 15);
			SearchBox.Name = "SearchBox";
			SearchBox.PlaceholderText = " Поиск";
			SearchBox.Size = new Size(403, 29);
			SearchBox.TabIndex = 9;
			SearchBox.KeyPress += SearchBox_KeyPress;
			// 
			// SearchButton
			// 
			SearchButton.Anchor = AnchorStyles.None;
			SearchButton.BackColor = Color.Transparent;
			SearchButton.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
			SearchButton.FlatStyle = FlatStyle.Flat;
			SearchButton.ForeColor = Color.Black;
			SearchButton.Image = (Image)resources.GetObject("SearchButton.Image");
			SearchButton.Location = new Point(830, 18);
			SearchButton.Margin = new Padding(0, 0, 10, 0);
			SearchButton.Name = "SearchButton";
			SearchButton.Size = new Size(29, 29);
			SearchButton.TabIndex = 10;
			SearchButton.UseVisualStyleBackColor = false;
			// 
			// Catalogue2
			// 
			Catalogue2.AutoScroll = true;
			Catalogue2.BackColor = Color.White;
			Catalogue2.BorderStyle = BorderStyle.FixedSingle;
			Catalogue2.Controls.Add(AddItemPicture);
			Catalogue2.Location = new Point(434, 83);
			Catalogue2.Margin = new Padding(0, 4, 0, 3);
			Catalogue2.Name = "Catalogue2";
			Catalogue2.Size = new Size(980, 779);
			Catalogue2.TabIndex = 11;
			// 
			// AddItemPicture
			// 
			AddItemPicture.Cursor = Cursors.Hand;
			Catalogue2.SetFlowBreak(AddItemPicture, true);
			AddItemPicture.Image = (Image)resources.GetObject("AddItemPicture.Image");
			AddItemPicture.Location = new Point(13, 13);
			AddItemPicture.Margin = new Padding(13, 13, 13, 18);
			AddItemPicture.Name = "AddItemPicture";
			AddItemPicture.Size = new Size(214, 316);
			AddItemPicture.SizeMode = PictureBoxSizeMode.StretchImage;
			AddItemPicture.TabIndex = 15;
			AddItemPicture.TabStop = false;
			AddItemPicture.Click += pictureBox3_Click;
			AddItemPicture.MouseEnter += pictureBox3_MouseEnter;
			AddItemPicture.MouseLeave += pictureBox3_MouseLeave;
			// 
			// panel3
			// 
			panel3.BackColor = Color.White;
			panel3.BorderStyle = BorderStyle.FixedSingle;
			panel3.Controls.Add(AdmOrCli);
			panel3.Controls.Add(panel4);
			panel3.Controls.Add(panel2);
			panel3.Controls.Add(Avatar);
			panel3.Controls.Add(AddCard);
			panel3.Controls.Add(FIO);
			panel3.Controls.Add(CardLabel);
			panel3.Controls.Add(SearchButton);
			panel3.Controls.Add(SearchBox);
			panel3.Controls.Add(ExitButton);
			panel3.Location = new Point(170, -2);
			panel3.Name = "panel3";
			panel3.Size = new Size(1244, 64);
			panel3.TabIndex = 1;
			// 
			// AdmOrCli
			// 
			AdmOrCli.Anchor = AnchorStyles.None;
			AdmOrCli.AutoSize = true;
			AdmOrCli.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
			AdmOrCli.ForeColor = Color.Black;
			AdmOrCli.Location = new Point(930, 24);
			AdmOrCli.Name = "AdmOrCli";
			AdmOrCli.Size = new Size(85, 16);
			AdmOrCli.TabIndex = 16;
			AdmOrCli.Text = "AdminOrClient";
			// 
			// panel4
			// 
			panel4.BorderStyle = BorderStyle.FixedSingle;
			panel4.Controls.Add(label1);
			panel4.Location = new Point(200, 0);
			panel4.Margin = new Padding(0);
			panel4.Name = "panel4";
			panel4.Size = new Size(204, 64);
			panel4.TabIndex = 15;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.None;
			label1.AutoSize = true;
			label1.Font = new Font("Avoner", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
			label1.ForeColor = Color.Gray;
			label1.Location = new Point(17, 25);
			label1.Margin = new Padding(0);
			label1.Name = "label1";
			label1.Size = new Size(165, 13);
			label1.TabIndex = 3;
			label1.Text = "Сделай свою жизнь чуть ярче!";
			// 
			// panel2
			// 
			panel2.BorderStyle = BorderStyle.FixedSingle;
			panel2.Controls.Add(pictureBox1);
			panel2.Controls.Add(BrandName);
			panel2.Location = new Point(-1, 0);
			panel2.Margin = new Padding(0);
			panel2.Name = "panel2";
			panel2.Size = new Size(202, 64);
			panel2.TabIndex = 14;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(85, 8);
			pictureBox1.Margin = new Padding(5);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(32, 32);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 13;
			pictureBox1.TabStop = false;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
			tableLayoutPanel1.ColumnCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Controls.Add(SbrosButton, 0, 5);
			tableLayoutPanel1.Controls.Add(panel6, 0, 1);
			tableLayoutPanel1.Controls.Add(panel7, 0, 3);
			tableLayoutPanel1.Controls.Add(panel5, 0, 0);
			tableLayoutPanel1.Controls.Add(FilterButton, 0, 4);
			tableLayoutPanel1.Controls.Add(pictureBox2, 0, 6);
			tableLayoutPanel1.Controls.Add(panel8, 0, 2);
			tableLayoutPanel1.Location = new Point(170, 83);
			tableLayoutPanel1.Margin = new Padding(0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 7;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 79F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 79F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 79F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 79F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 83F));
			tableLayoutPanel1.Size = new Size(265, 779);
			tableLayoutPanel1.TabIndex = 14;
			// 
			// SbrosButton
			// 
			SbrosButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			SbrosButton.BackColor = Color.FromArgb(222, 0, 43);
			SbrosButton.FlatAppearance.BorderColor = Color.Black;
			SbrosButton.FlatStyle = FlatStyle.Flat;
			SbrosButton.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			SbrosButton.ForeColor = Color.White;
			SbrosButton.Location = new Point(4, 365);
			SbrosButton.Name = "SbrosButton";
			SbrosButton.Size = new Size(257, 31);
			SbrosButton.TabIndex = 18;
			SbrosButton.Text = "Сбросить";
			SbrosButton.UseVisualStyleBackColor = false;
			SbrosButton.Click += SbrosButton_Click;
			// 
			// panel6
			// 
			panel6.Controls.Add(CategorySortBox);
			panel6.Controls.Add(label5);
			panel6.Location = new Point(1, 81);
			panel6.Margin = new Padding(0);
			panel6.Name = "panel6";
			panel6.Size = new Size(263, 79);
			panel6.TabIndex = 14;
			// 
			// CategorySortBox
			// 
			CategorySortBox.BackColor = Color.White;
			CategorySortBox.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			CategorySortBox.FormattingEnabled = true;
			CategorySortBox.Location = new Point(10, 39);
			CategorySortBox.Name = "CategorySortBox";
			CategorySortBox.Size = new Size(243, 25);
			CategorySortBox.TabIndex = 1;
			CategorySortBox.Text = "Не выбрано";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			label5.Location = new Point(10, 15);
			label5.Margin = new Padding(10, 15, 10, 5);
			label5.Name = "label5";
			label5.Size = new Size(75, 17);
			label5.TabIndex = 0;
			label5.Text = "Категория";
			// 
			// panel7
			// 
			panel7.Controls.Add(label6);
			panel7.Controls.Add(label7);
			panel7.Controls.Add(SizeSortBox2);
			panel7.Controls.Add(SizeSortBox1);
			panel7.Location = new Point(1, 241);
			panel7.Margin = new Padding(0);
			panel7.Name = "panel7";
			panel7.Size = new Size(263, 79);
			panel7.TabIndex = 15;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			label6.Location = new Point(10, 15);
			label6.Margin = new Padding(10, 15, 10, 5);
			label6.Name = "label6";
			label6.Size = new Size(59, 17);
			label6.TabIndex = 0;
			label6.Text = "Размер";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Avoner", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
			label7.Location = new Point(122, 41);
			label7.Margin = new Padding(0);
			label7.Name = "label7";
			label7.Size = new Size(14, 16);
			label7.TabIndex = 3;
			label7.Text = "-";
			// 
			// SizeSortBox2
			// 
			SizeSortBox2.Font = new Font("Avoner", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
			SizeSortBox2.Location = new Point(139, 39);
			SizeSortBox2.Margin = new Padding(3, 10, 10, 10);
			SizeSortBox2.Name = "SizeSortBox2";
			SizeSortBox2.PlaceholderText = " до";
			SizeSortBox2.Size = new Size(114, 23);
			SizeSortBox2.TabIndex = 2;
			SizeSortBox2.TextChanged += SizeSortBox2_TextChanged;
			// 
			// SizeSortBox1
			// 
			SizeSortBox1.Font = new Font("Avoner", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
			SizeSortBox1.Location = new Point(10, 39);
			SizeSortBox1.Margin = new Padding(10, 10, 3, 10);
			SizeSortBox1.Name = "SizeSortBox1";
			SizeSortBox1.PlaceholderText = " от";
			SizeSortBox1.Size = new Size(109, 23);
			SizeSortBox1.TabIndex = 1;
			SizeSortBox1.TextChanged += SizeSortBox1_TextChanged;
			// 
			// panel5
			// 
			panel5.Controls.Add(label2);
			panel5.Controls.Add(label3);
			panel5.Controls.Add(PriceSortBox2);
			panel5.Controls.Add(PriceSortBox1);
			panel5.Location = new Point(1, 1);
			panel5.Margin = new Padding(0);
			panel5.Name = "panel5";
			panel5.Size = new Size(263, 79);
			panel5.TabIndex = 13;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(10, 15);
			label2.Margin = new Padding(10, 15, 10, 5);
			label2.Name = "label2";
			label2.Size = new Size(42, 17);
			label2.TabIndex = 0;
			label2.Text = "Цена";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Avoner", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(122, 41);
			label3.Margin = new Padding(0);
			label3.Name = "label3";
			label3.Size = new Size(14, 16);
			label3.TabIndex = 3;
			label3.Text = "-";
			// 
			// PriceSortBox2
			// 
			PriceSortBox2.Font = new Font("Avoner", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
			PriceSortBox2.Location = new Point(139, 39);
			PriceSortBox2.Margin = new Padding(3, 10, 10, 10);
			PriceSortBox2.Name = "PriceSortBox2";
			PriceSortBox2.PlaceholderText = " до";
			PriceSortBox2.Size = new Size(114, 23);
			PriceSortBox2.TabIndex = 2;
			PriceSortBox2.TextChanged += PriceSortBox2_TextChanged;
			// 
			// PriceSortBox1
			// 
			PriceSortBox1.Font = new Font("Avoner", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
			PriceSortBox1.Location = new Point(10, 39);
			PriceSortBox1.Margin = new Padding(10, 10, 3, 10);
			PriceSortBox1.Name = "PriceSortBox1";
			PriceSortBox1.PlaceholderText = " от";
			PriceSortBox1.Size = new Size(109, 23);
			PriceSortBox1.TabIndex = 1;
			PriceSortBox1.TextChanged += PriceSortBox1_TextChanged;
			// 
			// FilterButton
			// 
			FilterButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			FilterButton.BackColor = Color.FromArgb(222, 0, 43);
			FilterButton.FlatAppearance.BorderColor = Color.Black;
			FilterButton.FlatStyle = FlatStyle.Flat;
			FilterButton.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			FilterButton.ForeColor = Color.White;
			FilterButton.Location = new Point(4, 324);
			FilterButton.Name = "FilterButton";
			FilterButton.Size = new Size(257, 34);
			FilterButton.TabIndex = 17;
			FilterButton.Text = "Применить";
			FilterButton.UseVisualStyleBackColor = false;
			FilterButton.Click += button1_Click;
			// 
			// pictureBox2
			// 
			pictureBox2.Dock = DockStyle.Fill;
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(4, 403);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(257, 372);
			pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox2.TabIndex = 19;
			pictureBox2.TabStop = false;
			// 
			// panel8
			// 
			panel8.Controls.Add(MaterialSortBox);
			panel8.Controls.Add(label8);
			panel8.Location = new Point(1, 161);
			panel8.Margin = new Padding(0);
			panel8.Name = "panel8";
			panel8.Size = new Size(263, 79);
			panel8.TabIndex = 16;
			// 
			// MaterialSortBox
			// 
			MaterialSortBox.BackColor = Color.White;
			MaterialSortBox.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			MaterialSortBox.FormattingEnabled = true;
			MaterialSortBox.Items.AddRange(new object[] { "Не выбрано" });
			MaterialSortBox.Location = new Point(10, 39);
			MaterialSortBox.Name = "MaterialSortBox";
			MaterialSortBox.Size = new Size(243, 25);
			MaterialSortBox.TabIndex = 1;
			MaterialSortBox.Text = "Не выбрано";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			label8.Location = new Point(10, 15);
			label8.Margin = new Padding(10, 15, 10, 5);
			label8.Name = "label8";
			label8.Size = new Size(74, 17);
			label8.TabIndex = 0;
			label8.Text = "Материал";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			label4.ForeColor = Color.FromArgb(238, 55, 78);
			label4.Location = new Point(799, 3);
			label4.Name = "label4";
			label4.Size = new Size(440, 17);
			label4.TabIndex = 0;
			label4.Text = "inst: _keefire_          G-Mail: foksakirill@gmail.com          0 775 8-27-14";
			label4.TextAlign = ContentAlignment.MiddleRight;
			// 
			// panel9
			// 
			panel9.BorderStyle = BorderStyle.FixedSingle;
			panel9.Controls.Add(pictureBox5);
			panel9.Controls.Add(pictureBox4);
			panel9.Controls.Add(pictureBox3);
			panel9.Controls.Add(label4);
			panel9.Location = new Point(170, 61);
			panel9.Margin = new Padding(0);
			panel9.Name = "panel9";
			panel9.Size = new Size(1244, 23);
			panel9.TabIndex = 15;
			// 
			// pictureBox5
			// 
			pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
			pictureBox5.Location = new Point(1130, 1);
			pictureBox5.Margin = new Padding(0);
			pictureBox5.Name = "pictureBox5";
			pictureBox5.Size = new Size(20, 20);
			pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox5.TabIndex = 2;
			pictureBox5.TabStop = false;
			// 
			// pictureBox4
			// 
			pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
			pictureBox4.Location = new Point(902, 2);
			pictureBox4.Margin = new Padding(0);
			pictureBox4.Name = "pictureBox4";
			pictureBox4.Size = new Size(20, 20);
			pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox4.TabIndex = 1;
			pictureBox4.TabStop = false;
			// 
			// pictureBox3
			// 
			pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
			pictureBox3.Location = new Point(778, 2);
			pictureBox3.Margin = new Padding(0);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(18, 18);
			pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox3.TabIndex = 0;
			pictureBox3.TabStop = false;
			// 
			// CatalogueForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(1584, 861);
			Controls.Add(panel9);
			Controls.Add(tableLayoutPanel1);
			Controls.Add(Catalogue2);
			Controls.Add(panel3);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "CatalogueForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "GEMLIGHTS";
			((System.ComponentModel.ISupportInitialize)Avatar).EndInit();
			Catalogue2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)AddItemPicture).EndInit();
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			panel4.ResumeLayout(false);
			panel4.PerformLayout();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			tableLayoutPanel1.ResumeLayout(false);
			panel6.ResumeLayout(false);
			panel6.PerformLayout();
			panel7.ResumeLayout(false);
			panel7.PerformLayout();
			panel5.ResumeLayout(false);
			panel5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			panel8.ResumeLayout(false);
			panel8.PerformLayout();
			panel9.ResumeLayout(false);
			panel9.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			ResumeLayout(false);
		}

		private void FIO_MouseEnter(object sender, EventArgs e)
        {
            FIO.ForeColor = Color.FromArgb(238, 55, 78);
            FIO.Refresh();
        }
        private void FIO_MouseLeave(object sender, EventArgs e)
        {
            FIO.ForeColor = Color.Black;
            FIO.Refresh();
        }

        #endregion
        private Label BrandName;
        private ImageList productsImages;
        private PictureBox Avatar;
        private Button AddCard;
        private Label FIO;
        private Label CardLabel;
        private Button ExitButton;
        private TextBox SearchBox;
        private Button SearchButton;
        private FlowLayoutPanel Catalogue2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel4;
        private Label label1;
        private Label AdmOrCli;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel5;
        private Label label2;
        private Label label3;
        private TextBox PriceSortBox2;
        private TextBox PriceSortBox1;
        private Panel panel6;
        private Label label5;
        private ComboBox CategorySortBox;
        private Panel panel7;
        private Label label6;
        private Label label7;
        private TextBox SizeSortBox2;
        private TextBox SizeSortBox1;
        private Panel panel8;
        private ComboBox MaterialSortBox;
        private Label label8;
        private Button FilterButton;
        private Button SbrosButton;
        private PictureBox pictureBox2;
        private PictureBox AddItemPicture;
        private Label label4;
        private Panel panel9;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
    }
}