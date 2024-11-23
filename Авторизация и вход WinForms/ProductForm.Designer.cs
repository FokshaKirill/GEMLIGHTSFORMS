namespace GEMLIGHTSFORMS
{
    partial class ProductForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
			SaveButton = new Button();
			DeleteButton = new Button();
			SizeBox = new TextBox();
			WeightBox = new TextBox();
			label1 = new Label();
			label2 = new Label();
			NameBox = new TextBox();
			MaterialBox = new TextBox();
			label3 = new Label();
			label4 = new Label();
			label7 = new Label();
			DescriptionBox = new TextBox();
			ImageBox = new PictureBox();
			ArticolLabel = new Label();
			CategoryComboBox = new ComboBox();
			label6 = new Label();
			USDTextBox = new TextBox();
			label5 = new Label();
			USDLabel = new Label();
			label8 = new Label();
			StockBox = new TextBox();
			CountTableLayout = new TableLayoutPanel();
			MinusButton = new Label();
			PlusButton = new Label();
			CountLabel = new Label();
			AddToCartB = new Button();
			((System.ComponentModel.ISupportInitialize)ImageBox).BeginInit();
			CountTableLayout.SuspendLayout();
			SuspendLayout();
			// 
			// SaveButton
			// 
			SaveButton.BackColor = Color.FromArgb(222, 0, 43);
			SaveButton.Cursor = Cursors.Hand;
			SaveButton.FlatAppearance.BorderColor = Color.Black;
			SaveButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
			resources.ApplyResources(SaveButton, "SaveButton");
			SaveButton.ForeColor = Color.White;
			SaveButton.Name = "SaveButton";
			SaveButton.UseVisualStyleBackColor = false;
			SaveButton.Click += Add_Click;
			// 
			// DeleteButton
			// 
			DeleteButton.BackColor = Color.FromArgb(222, 0, 43);
			DeleteButton.Cursor = Cursors.Hand;
			DeleteButton.FlatAppearance.BorderColor = Color.Black;
			DeleteButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
			resources.ApplyResources(DeleteButton, "DeleteButton");
			DeleteButton.ForeColor = Color.White;
			DeleteButton.Name = "DeleteButton";
			DeleteButton.UseVisualStyleBackColor = false;
			DeleteButton.Click += DeleteButton_Click;
			// 
			// SizeBox
			// 
			SizeBox.BorderStyle = BorderStyle.FixedSingle;
			resources.ApplyResources(SizeBox, "SizeBox");
			SizeBox.Name = "SizeBox";
			SizeBox.TextChanged += SizeBox_TextChanged;
			// 
			// WeightBox
			// 
			WeightBox.BorderStyle = BorderStyle.FixedSingle;
			resources.ApplyResources(WeightBox, "WeightBox");
			WeightBox.Name = "WeightBox";
			WeightBox.TextChanged += WeightBox_TextChanged;
			// 
			// label1
			// 
			resources.ApplyResources(label1, "label1");
			label1.ForeColor = Color.Black;
			label1.Name = "label1";
			// 
			// label2
			// 
			resources.ApplyResources(label2, "label2");
			label2.ForeColor = Color.Black;
			label2.Name = "label2";
			// 
			// NameBox
			// 
			NameBox.BorderStyle = BorderStyle.FixedSingle;
			resources.ApplyResources(NameBox, "NameBox");
			NameBox.Name = "NameBox";
			// 
			// MaterialBox
			// 
			MaterialBox.BorderStyle = BorderStyle.FixedSingle;
			resources.ApplyResources(MaterialBox, "MaterialBox");
			MaterialBox.Name = "MaterialBox";
			// 
			// label3
			// 
			resources.ApplyResources(label3, "label3");
			label3.ForeColor = Color.Black;
			label3.Name = "label3";
			// 
			// label4
			// 
			resources.ApplyResources(label4, "label4");
			label4.ForeColor = Color.Black;
			label4.Name = "label4";
			// 
			// label7
			// 
			resources.ApplyResources(label7, "label7");
			label7.ForeColor = Color.Black;
			label7.Name = "label7";
			// 
			// DescriptionBox
			// 
			resources.ApplyResources(DescriptionBox, "DescriptionBox");
			DescriptionBox.Name = "DescriptionBox";
			DescriptionBox.TextChanged += DescriptionBox_TextChanged;
			// 
			// ImageBox
			// 
			ImageBox.BorderStyle = BorderStyle.FixedSingle;
			ImageBox.Cursor = Cursors.Hand;
			resources.ApplyResources(ImageBox, "ImageBox");
			ImageBox.Name = "ImageBox";
			ImageBox.TabStop = false;
			ImageBox.Click += ImageBox_Click;
			// 
			// ArticolLabel
			// 
			resources.ApplyResources(ArticolLabel, "ArticolLabel");
			ArticolLabel.ForeColor = SystemColors.ControlDark;
			ArticolLabel.Name = "ArticolLabel";
			// 
			// CategoryComboBox
			// 
			CategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			resources.ApplyResources(CategoryComboBox, "CategoryComboBox");
			CategoryComboBox.FormattingEnabled = true;
			CategoryComboBox.Name = "CategoryComboBox";
			// 
			// label6
			// 
			resources.ApplyResources(label6, "label6");
			label6.ForeColor = Color.Black;
			label6.Name = "label6";
			// 
			// USDTextBox
			// 
			USDTextBox.BorderStyle = BorderStyle.FixedSingle;
			USDTextBox.Cursor = Cursors.IBeam;
			resources.ApplyResources(USDTextBox, "USDTextBox");
			USDTextBox.Name = "USDTextBox";
			USDTextBox.TextChanged += USDTextBox_TextChanged;
			// 
			// label5
			// 
			resources.ApplyResources(label5, "label5");
			label5.ForeColor = Color.Black;
			label5.Name = "label5";
			// 
			// USDLabel
			// 
			resources.ApplyResources(USDLabel, "USDLabel");
			USDLabel.ForeColor = Color.Black;
			USDLabel.Name = "USDLabel";
			// 
			// label8
			// 
			resources.ApplyResources(label8, "label8");
			label8.ForeColor = Color.Black;
			label8.Name = "label8";
			// 
			// StockBox
			// 
			StockBox.BorderStyle = BorderStyle.FixedSingle;
			StockBox.Cursor = Cursors.IBeam;
			resources.ApplyResources(StockBox, "StockBox");
			StockBox.Name = "StockBox";
			StockBox.TextChanged += StockBox_TextChanged;
			// 
			// CountTableLayout
			// 
			CountTableLayout.BackColor = Color.Silver;
			resources.ApplyResources(CountTableLayout, "CountTableLayout");
			CountTableLayout.Controls.Add(MinusButton, 2, 0);
			CountTableLayout.Controls.Add(PlusButton, 0, 0);
			CountTableLayout.Controls.Add(CountLabel, 1, 0);
			CountTableLayout.Name = "CountTableLayout";
			// 
			// MinusButton
			// 
			resources.ApplyResources(MinusButton, "MinusButton");
			MinusButton.BackColor = Color.Silver;
			MinusButton.Cursor = Cursors.Hand;
			MinusButton.ForeColor = SystemColors.ControlDarkDark;
			MinusButton.Name = "MinusButton";
			// 
			// PlusButton
			// 
			resources.ApplyResources(PlusButton, "PlusButton");
			PlusButton.BackColor = Color.Silver;
			PlusButton.Cursor = Cursors.Hand;
			PlusButton.ForeColor = SystemColors.ControlDarkDark;
			PlusButton.Name = "PlusButton";
			// 
			// CountLabel
			// 
			resources.ApplyResources(CountLabel, "CountLabel");
			CountLabel.BackColor = Color.Silver;
			CountLabel.ForeColor = SystemColors.ControlDarkDark;
			CountLabel.Name = "CountLabel";
			// 
			// AddToCartB
			// 
			AddToCartB.BackColor = Color.FromArgb(222, 0, 43);
			AddToCartB.Cursor = Cursors.Hand;
			AddToCartB.FlatAppearance.BorderColor = Color.Black;
			AddToCartB.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
			resources.ApplyResources(AddToCartB, "AddToCartB");
			AddToCartB.ForeColor = Color.White;
			AddToCartB.Name = "AddToCartB";
			AddToCartB.UseVisualStyleBackColor = false;
			AddToCartB.Click += AddToCartB_Click;
			// 
			// ProductForm
			// 
			resources.ApplyResources(this, "$this");
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			Controls.Add(AddToCartB);
			Controls.Add(CountTableLayout);
			Controls.Add(label8);
			Controls.Add(StockBox);
			Controls.Add(USDLabel);
			Controls.Add(label5);
			Controls.Add(USDTextBox);
			Controls.Add(label6);
			Controls.Add(CategoryComboBox);
			Controls.Add(ArticolLabel);
			Controls.Add(ImageBox);
			Controls.Add(label7);
			Controls.Add(DescriptionBox);
			Controls.Add(label4);
			Controls.Add(label2);
			Controls.Add(label3);
			Controls.Add(label1);
			Controls.Add(MaterialBox);
			Controls.Add(WeightBox);
			Controls.Add(NameBox);
			Controls.Add(SizeBox);
			Controls.Add(DeleteButton);
			Controls.Add(SaveButton);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			KeyPreview = true;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "ProductForm";
			ShowIcon = false;
			((System.ComponentModel.ISupportInitialize)ImageBox).EndInit();
			CountTableLayout.ResumeLayout(false);
			CountTableLayout.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button SaveButton;
        private Button DeleteButton;
        private TextBox SizeBox;
        private TextBox WeightBox;
        private Label label1;
        private Label label2;
        private TextBox NameBox;
        private TextBox MaterialBox;
        private Label label3;
        private Label label4;
        private Label label7;
        private TextBox DescriptionBox;
        private PictureBox ImageBox;
        private Label ArticolLabel;
        private ComboBox CategoryComboBox;
        private Label label6;
        private TextBox USDTextBox;
        private Label label5;
        private Label USDLabel;
        private Label label8;
        private TextBox StockBox;
        private TableLayoutPanel CountTableLayout;
        private Label MinusButton;
        private Label PlusButton;
        private Label CountLabel;
        private Button AddToCartB;
    }
}