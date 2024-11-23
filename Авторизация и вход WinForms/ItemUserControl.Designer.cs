namespace GEMLIGHTSFORMS
{
    partial class ItemUserControl
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
            components = new System.ComponentModel.Container();
            BuyButtonB = new Button();
            ItemImage = new PictureBox();
            ArticolLabel = new Label();
            ItemPanel = new Panel();
            NameLabel = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)ItemImage).BeginInit();
            ItemPanel.SuspendLayout();
            SuspendLayout();
            // 
            // BuyButtonB
            // 
            BuyButtonB.BackColor = Color.FromArgb(222, 0, 43);
            BuyButtonB.Cursor = Cursors.Hand;
            BuyButtonB.FlatAppearance.BorderColor = Color.Black;
            BuyButtonB.FlatStyle = FlatStyle.Flat;
            BuyButtonB.Font = new Font("Century Gothic", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            BuyButtonB.ForeColor = Color.White;
            BuyButtonB.Location = new Point(14, 246);
            BuyButtonB.Margin = new Padding(4, 4, 4, 8);
            BuyButtonB.MaximumSize = new Size(128, 60);
            BuyButtonB.MinimumSize = new Size(100, 50);
            BuyButtonB.Name = "BuyButtonB";
            BuyButtonB.Size = new Size(128, 50);
            BuyButtonB.TabIndex = 0;
            BuyButtonB.Text = "Купить";
            BuyButtonB.UseVisualStyleBackColor = false;
            // 
            // ItemImage
            // 
            ItemImage.BorderStyle = BorderStyle.FixedSingle;
            ItemImage.Cursor = Cursors.Hand;
            ItemImage.Location = new Point(42, 15);
            ItemImage.Margin = new Padding(32, 5, 8, 5);
            ItemImage.MaximumSize = new Size(128, 128);
            ItemImage.MinimumSize = new Size(128, 128);
            ItemImage.Name = "ItemImage";
            ItemImage.Size = new Size(128, 128);
            ItemImage.SizeMode = PictureBoxSizeMode.StretchImage;
            ItemImage.TabIndex = 1;
            ItemImage.TabStop = false;
            // 
            // ArticolLabel
            // 
            ArticolLabel.AutoSize = true;
            ArticolLabel.Font = new Font("Avoner", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            ArticolLabel.ForeColor = Color.Gray;
            ArticolLabel.Location = new Point(13, 226);
            ArticolLabel.Margin = new Padding(0);
            ArticolLabel.Name = "ArticolLabel";
            ArticolLabel.Size = new Size(51, 13);
            ArticolLabel.TabIndex = 3;
            ArticolLabel.Text = "000001";
            // 
            // ItemPanel
            // 
            ItemPanel.BackColor = Color.White;
            ItemPanel.BorderStyle = BorderStyle.FixedSingle;
            ItemPanel.Controls.Add(NameLabel);
            ItemPanel.Controls.Add(BuyButtonB);
            ItemPanel.Controls.Add(ArticolLabel);
            ItemPanel.Controls.Add(ItemImage);
            ItemPanel.Location = new Point(10, 10);
            ItemPanel.Margin = new Padding(10, 10, 10, 15);
            ItemPanel.Name = "ItemPanel";
            ItemPanel.Padding = new Padding(10, 10, 5, 10);
            ItemPanel.Size = new Size(214, 316);
            ItemPanel.TabIndex = 4;
            // 
            // NameLabel
            // 
            NameLabel.BackColor = Color.White;
            NameLabel.BorderStyle = BorderStyle.None;
            NameLabel.Cursor = Cursors.Hand;
            NameLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            NameLabel.ForeColor = Color.Black;
            NameLabel.Location = new Point(13, 151);
            NameLabel.Multiline = true;
            NameLabel.Name = "NameLabel";
            NameLabel.ReadOnly = true;
            NameLabel.Size = new Size(186, 72);
            NameLabel.TabIndex = 5;
            NameLabel.Text = "Крутое колечко";
            NameLabel.TextAlign = HorizontalAlignment.Center;
            NameLabel.MouseEnter += NameLabel_MouseEnter;
            NameLabel.MouseLeave += NameLabel_MouseLeave;
            // 
            // ItemUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(ItemPanel);
            Name = "ItemUserControl";
            Size = new Size(234, 340);
            ((System.ComponentModel.ISupportInitialize)ItemImage).EndInit();
            ItemPanel.ResumeLayout(false);
            ItemPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public Button BuyButtonB;
        public PictureBox ItemImage;
        public TextBox NameLabel;
        public Label ArticolLabel;
        private Panel ItemPanel;
        private System.Windows.Forms.Timer timer1;
    }
}
