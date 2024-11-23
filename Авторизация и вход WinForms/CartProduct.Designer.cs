namespace GEMLIGHTSFORMS
{
    partial class CartProductItem
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Код, автоматически созданный конструктором компонентов

		/// <summary> 
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartProductItem));
			panel1 = new Panel();
			CloseButton = new PictureBox();
			NameLabel = new Label();
			tableLayoutPanel1 = new TableLayoutPanel();
			MinusButton = new Label();
			PlusButton = new Label();
			CountLabel = new Label();
			BuyButton = new Button();
			ItemImageBox = new PictureBox();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)CloseButton).BeginInit();
			tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)ItemImageBox).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.White;
			panel1.BorderStyle = BorderStyle.FixedSingle;
			panel1.Controls.Add(CloseButton);
			panel1.Controls.Add(NameLabel);
			panel1.Controls.Add(tableLayoutPanel1);
			panel1.Controls.Add(BuyButton);
			panel1.Controls.Add(ItemImageBox);
			panel1.Location = new Point(3, 3);
			panel1.Name = "panel1";
			panel1.Size = new Size(137, 212);
			panel1.TabIndex = 0;
			// 
			// CloseButton
			// 
			CloseButton.Image = (Image)resources.GetObject("CloseButton.Image");
			CloseButton.Location = new Point(100, 3);
			CloseButton.Name = "CloseButton";
			CloseButton.Size = new Size(32, 32);
			CloseButton.SizeMode = PictureBoxSizeMode.StretchImage;
			CloseButton.TabIndex = 6;
			CloseButton.TabStop = false;
			CloseButton.Visible = false;
			// 
			// NameLabel
			// 
			NameLabel.AutoEllipsis = true;
			NameLabel.AutoSize = true;
			NameLabel.Cursor = Cursors.Hand;
			NameLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			NameLabel.Location = new Point(14, 110);
			NameLabel.Margin = new Padding(0, 8, 0, 8);
			NameLabel.Name = "NameLabel";
			NameLabel.Size = new Size(111, 16);
			NameLabel.TabIndex = 5;
			NameLabel.Text = "Тестовый тесто";
			NameLabel.TextChanged += NameLabel_TextChanged;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.BackColor = Color.Silver;
			tableLayoutPanel1.ColumnCount = 3;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
			tableLayoutPanel1.Controls.Add(MinusButton, 2, 0);
			tableLayoutPanel1.Controls.Add(PlusButton, 0, 0);
			tableLayoutPanel1.Controls.Add(CountLabel, 1, 0);
			tableLayoutPanel1.Location = new Point(14, 137);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 1;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Size = new Size(108, 33);
			tableLayoutPanel1.TabIndex = 4;
			// 
			// MinusButton
			// 
			MinusButton.AutoSize = true;
			MinusButton.BackColor = Color.Silver;
			MinusButton.Cursor = Cursors.Hand;
			MinusButton.Dock = DockStyle.Fill;
			MinusButton.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			MinusButton.ForeColor = SystemColors.ControlDarkDark;
			MinusButton.Location = new Point(74, 0);
			MinusButton.Name = "MinusButton";
			MinusButton.Size = new Size(31, 33);
			MinusButton.TabIndex = 3;
			MinusButton.Text = "-";
			MinusButton.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// PlusButton
			// 
			PlusButton.AutoSize = true;
			PlusButton.BackColor = Color.Silver;
			PlusButton.Cursor = Cursors.Hand;
			PlusButton.Dock = DockStyle.Fill;
			PlusButton.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			PlusButton.ForeColor = SystemColors.ControlDarkDark;
			PlusButton.Location = new Point(3, 0);
			PlusButton.Name = "PlusButton";
			PlusButton.Size = new Size(29, 33);
			PlusButton.TabIndex = 2;
			PlusButton.Text = "+";
			PlusButton.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// CountLabel
			// 
			CountLabel.AutoSize = true;
			CountLabel.BackColor = Color.Silver;
			CountLabel.Dock = DockStyle.Fill;
			CountLabel.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			CountLabel.ForeColor = SystemColors.ControlDarkDark;
			CountLabel.Location = new Point(38, 0);
			CountLabel.Name = "CountLabel";
			CountLabel.Size = new Size(30, 33);
			CountLabel.TabIndex = 4;
			CountLabel.Text = "1";
			CountLabel.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// BuyButton
			// 
			BuyButton.BackColor = Color.FromArgb(222, 0, 43);
			BuyButton.Cursor = Cursors.Hand;
			BuyButton.FlatAppearance.BorderColor = Color.Black;
			BuyButton.FlatStyle = FlatStyle.Flat;
			BuyButton.Font = new Font("Avoner", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
			BuyButton.ForeColor = Color.White;
			BuyButton.Location = new Point(3, 176);
			BuyButton.Name = "BuyButton";
			BuyButton.Size = new Size(128, 30);
			BuyButton.TabIndex = 1;
			BuyButton.Text = "14,99 USD";
			BuyButton.UseVisualStyleBackColor = false;
			// 
			// ItemImageBox
			// 
			ItemImageBox.Cursor = Cursors.Hand;
			ItemImageBox.Location = new Point(20, 3);
			ItemImageBox.MaximumSize = new Size(128, 128);
			ItemImageBox.MinimumSize = new Size(96, 96);
			ItemImageBox.Name = "ItemImageBox";
			ItemImageBox.Size = new Size(96, 96);
			ItemImageBox.SizeMode = PictureBoxSizeMode.StretchImage;
			ItemImageBox.TabIndex = 0;
			ItemImageBox.TabStop = false;
			// 
			// CartProductItem
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			Controls.Add(panel1);
			Name = "CartProductItem";
			Size = new Size(143, 220);
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)CloseButton).EndInit();
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)ItemImageBox).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
        private Button BuyButton;
        private PictureBox ItemImageBox;
        private Label MinusButton;
        private Label PlusButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Label CountLabel;
        private Label NameLabel;
        private PictureBox CloseButton;
    }
}
