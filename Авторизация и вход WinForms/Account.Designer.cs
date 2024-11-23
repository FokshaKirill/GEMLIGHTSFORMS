namespace GEMLIGHTSFORMS
{
    partial class Account
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
			Avatar = new PictureBox();
			textBox1 = new TextBox();
			label1 = new Label();
			label2 = new Label();
			textBox2 = new TextBox();
			label3 = new Label();
			textBox3 = new TextBox();
			label4 = new Label();
			textBox4 = new TextBox();
			label5 = new Label();
			textBox5 = new TextBox();
			label6 = new Label();
			textBox6 = new TextBox();
			checkBox1 = new CheckBox();
			Save = new Button();
			CartPanel = new FlowLayoutPanel();
			((System.ComponentModel.ISupportInitialize)Avatar).BeginInit();
			SuspendLayout();
			// 
			// Avatar
			// 
			Avatar.Cursor = Cursors.Hand;
			Avatar.Location = new Point(12, 12);
			Avatar.MaximumSize = new Size(256, 256);
			Avatar.MinimumSize = new Size(256, 256);
			Avatar.Name = "Avatar";
			Avatar.Size = new Size(256, 256);
			Avatar.SizeMode = PictureBoxSizeMode.StretchImage;
			Avatar.TabIndex = 0;
			Avatar.TabStop = false;
			Avatar.Click += Avatar_Click;
			// 
			// textBox1
			// 
			textBox1.Cursor = Cursors.IBeam;
			textBox1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			textBox1.Location = new Point(414, 14);
			textBox1.Name = "textBox1";
			textBox1.PlaceholderText = " Иванов Иван Иванович";
			textBox1.Size = new Size(362, 23);
			textBox1.TabIndex = 2;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(366, 16);
			label1.Name = "label1";
			label1.Size = new Size(44, 17);
			label1.TabIndex = 3;
			label1.Text = "ФИО:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(294, 47);
			label2.Name = "label2";
			label2.Size = new Size(114, 17);
			label2.TabIndex = 5;
			label2.Text = "Дата рождения:";
			// 
			// textBox2
			// 
			textBox2.Cursor = Cursors.IBeam;
			textBox2.Font = new Font("Avoner", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
			textBox2.Location = new Point(414, 45);
			textBox2.MaxLength = 10;
			textBox2.Name = "textBox2";
			textBox2.PlaceholderText = " 01.01.2000";
			textBox2.Size = new Size(362, 23);
			textBox2.TabIndex = 4;
			textBox2.TextChanged += textBox2_TextChanged;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(350, 109);
			label3.Name = "label3";
			label3.Size = new Size(60, 17);
			label3.TabIndex = 9;
			label3.Text = "Баланс:";
			// 
			// textBox3
			// 
			textBox3.Cursor = Cursors.IBeam;
			textBox3.Font = new Font("Avoner", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
			textBox3.Location = new Point(414, 107);
			textBox3.Name = "textBox3";
			textBox3.PlaceholderText = " 0.00 USD";
			textBox3.ReadOnly = true;
			textBox3.Size = new Size(362, 23);
			textBox3.TabIndex = 8;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			label4.Location = new Point(308, 78);
			label4.Name = "label4";
			label4.Size = new Size(101, 17);
			label4.TabIndex = 7;
			label4.Text = "Номер карты:";
			// 
			// textBox4
			// 
			textBox4.Cursor = Cursors.IBeam;
			textBox4.Font = new Font("Avoner", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
			textBox4.Location = new Point(414, 76);
			textBox4.Name = "textBox4";
			textBox4.PlaceholderText = " 0000 0000 0000 0000";
			textBox4.ReadOnly = true;
			textBox4.Size = new Size(362, 23);
			textBox4.TabIndex = 6;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			label5.Location = new Point(347, 171);
			label5.Name = "label5";
			label5.Size = new Size(61, 17);
			label5.TabIndex = 13;
			label5.Text = "Пароль:";
			// 
			// textBox5
			// 
			textBox5.Cursor = Cursors.IBeam;
			textBox5.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			textBox5.Location = new Point(414, 169);
			textBox5.Name = "textBox5";
			textBox5.PasswordChar = '*';
			textBox5.PlaceholderText = " Password";
			textBox5.Size = new Size(362, 23);
			textBox5.TabIndex = 12;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			label6.Location = new Point(275, 140);
			label6.Name = "label6";
			label6.Size = new Size(129, 17);
			label6.TabIndex = 11;
			label6.Text = "Имя пользователя:";
			// 
			// textBox6
			// 
			textBox6.Cursor = Cursors.IBeam;
			textBox6.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			textBox6.Location = new Point(414, 138);
			textBox6.Name = "textBox6";
			textBox6.PlaceholderText = " Username";
			textBox6.ReadOnly = true;
			textBox6.Size = new Size(362, 23);
			textBox6.TabIndex = 10;
			// 
			// checkBox1
			// 
			checkBox1.AutoSize = true;
			checkBox1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			checkBox1.Location = new Point(414, 199);
			checkBox1.Name = "checkBox1";
			checkBox1.Size = new Size(139, 21);
			checkBox1.TabIndex = 14;
			checkBox1.Text = "Показать пароль";
			checkBox1.UseVisualStyleBackColor = true;
			checkBox1.CheckedChanged += CheckBox1_CheckedChanged;
			// 
			// Save
			// 
			Save.BackColor = Color.FromArgb(222, 0, 43);
			Save.Cursor = Cursors.Hand;
			Save.FlatAppearance.BorderColor = Color.Black;
			Save.FlatStyle = FlatStyle.Flat;
			Save.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			Save.ForeColor = Color.White;
			Save.Location = new Point(414, 238);
			Save.Name = "Save";
			Save.Size = new Size(362, 30);
			Save.TabIndex = 15;
			Save.Text = "Сохранить";
			Save.UseVisualStyleBackColor = false;
			Save.Click += Save_Click;
			// 
			// CartPanel
			// 
			CartPanel.AutoScroll = true;
			CartPanel.BorderStyle = BorderStyle.FixedSingle;
			CartPanel.FlowDirection = FlowDirection.TopDown;
			CartPanel.Location = new Point(12, 274);
			CartPanel.Name = "CartPanel";
			CartPanel.Size = new Size(764, 247);
			CartPanel.TabIndex = 16;
			// 
			// Account
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(788, 533);
			Controls.Add(CartPanel);
			Controls.Add(Save);
			Controls.Add(checkBox1);
			Controls.Add(label5);
			Controls.Add(textBox5);
			Controls.Add(label6);
			Controls.Add(textBox6);
			Controls.Add(label3);
			Controls.Add(textBox3);
			Controls.Add(label4);
			Controls.Add(textBox4);
			Controls.Add(label2);
			Controls.Add(textBox2);
			Controls.Add(label1);
			Controls.Add(textBox1);
			Controls.Add(Avatar);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			KeyPreview = true;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "Account";
			ShowIcon = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "Мой аккаунт";
			((System.ComponentModel.ISupportInitialize)Avatar).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox Avatar;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox6;
        private CheckBox checkBox1;
        private Button Save;
        private FlowLayoutPanel CartPanel;
    }
}