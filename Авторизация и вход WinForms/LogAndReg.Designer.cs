namespace GEMLIGHTSFORMS
{
    partial class LogIn
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
			LogAndAutorization = new TabControl();
			Log = new TabPage();
			checkBox1 = new CheckBox();
			LogButton = new Button();
			PasswordInput = new TextBox();
			PasswordLabel = new Label();
			UsernameInput = new TextBox();
			UsernameLabel = new Label();
			Reg = new TabPage();
			label5 = new Label();
			label2 = new Label();
			AdmCheck = new TextBox();
			label4 = new Label();
			label3 = new Label();
			label1 = new Label();
			RegButton = new Button();
			FIOInput = new TextBox();
			BornDateInput = new TextBox();
			UsernameInput2 = new TextBox();
			PasswordInput2 = new TextBox();
			pictureBox1 = new PictureBox();
			BrandName = new Label();
			label6 = new Label();
			label7 = new Label();
			checkBox2 = new CheckBox();
			LogAndAutorization.SuspendLayout();
			Log.SuspendLayout();
			Reg.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// LogAndAutorization
			// 
			LogAndAutorization.Controls.Add(Log);
			LogAndAutorization.Controls.Add(Reg);
			LogAndAutorization.Location = new Point(12, 164);
			LogAndAutorization.Name = "LogAndAutorization";
			LogAndAutorization.SelectedIndex = 0;
			LogAndAutorization.Size = new Size(418, 346);
			LogAndAutorization.TabIndex = 7;
			// 
			// Log
			// 
			Log.BackColor = Color.White;
			Log.Controls.Add(checkBox1);
			Log.Controls.Add(LogButton);
			Log.Controls.Add(PasswordInput);
			Log.Controls.Add(PasswordLabel);
			Log.Controls.Add(UsernameInput);
			Log.Controls.Add(UsernameLabel);
			Log.Location = new Point(4, 24);
			Log.Name = "Log";
			Log.Padding = new Padding(3);
			Log.Size = new Size(410, 318);
			Log.TabIndex = 0;
			Log.Text = "Вход";
			// 
			// checkBox1
			// 
			checkBox1.AutoSize = true;
			checkBox1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			checkBox1.Location = new Point(6, 190);
			checkBox1.Name = "checkBox1";
			checkBox1.Size = new Size(139, 21);
			checkBox1.TabIndex = 15;
			checkBox1.Text = "Показать пароль";
			checkBox1.UseVisualStyleBackColor = true;
			checkBox1.CheckedChanged += checkBox1_CheckedChanged;
			// 
			// LogButton
			// 
			LogButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			LogButton.BackColor = Color.FromArgb(222, 0, 43);
			LogButton.Cursor = Cursors.Hand;
			LogButton.FlatAppearance.BorderColor = Color.Black;
			LogButton.FlatStyle = FlatStyle.Flat;
			LogButton.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			LogButton.ForeColor = Color.White;
			LogButton.Location = new Point(6, 281);
			LogButton.Name = "LogButton";
			LogButton.Size = new Size(398, 30);
			LogButton.TabIndex = 11;
			LogButton.Text = "Вход";
			LogButton.UseVisualStyleBackColor = false;
			LogButton.Click += LogButton_Click;
			// 
			// PasswordInput
			// 
			PasswordInput.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			PasswordInput.Cursor = Cursors.IBeam;
			PasswordInput.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			PasswordInput.Location = new Point(6, 161);
			PasswordInput.MaxLength = 30;
			PasswordInput.Name = "PasswordInput";
			PasswordInput.PasswordChar = '*';
			PasswordInput.PlaceholderText = " Password";
			PasswordInput.Size = new Size(398, 23);
			PasswordInput.TabIndex = 10;
			// 
			// PasswordLabel
			// 
			PasswordLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			PasswordLabel.AutoSize = true;
			PasswordLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			PasswordLabel.Location = new Point(174, 138);
			PasswordLabel.Margin = new Padding(3, 5, 3, 1);
			PasswordLabel.Name = "PasswordLabel";
			PasswordLabel.Size = new Size(57, 17);
			PasswordLabel.TabIndex = 9;
			PasswordLabel.Text = "Пароль";
			// 
			// UsernameInput
			// 
			UsernameInput.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			UsernameInput.Cursor = Cursors.IBeam;
			UsernameInput.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			UsernameInput.Location = new Point(6, 106);
			UsernameInput.MaxLength = 30;
			UsernameInput.Name = "UsernameInput";
			UsernameInput.PlaceholderText = " Username";
			UsernameInput.Size = new Size(398, 23);
			UsernameInput.TabIndex = 8;
			// 
			// UsernameLabel
			// 
			UsernameLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			UsernameLabel.AutoSize = true;
			UsernameLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			UsernameLabel.Location = new Point(146, 83);
			UsernameLabel.Margin = new Padding(3, 5, 3, 1);
			UsernameLabel.Name = "UsernameLabel";
			UsernameLabel.Size = new Size(125, 17);
			UsernameLabel.TabIndex = 7;
			UsernameLabel.Text = "Имя пользователя";
			// 
			// Reg
			// 
			Reg.Controls.Add(checkBox2);
			Reg.Controls.Add(label5);
			Reg.Controls.Add(label2);
			Reg.Controls.Add(AdmCheck);
			Reg.Controls.Add(label4);
			Reg.Controls.Add(label3);
			Reg.Controls.Add(label1);
			Reg.Controls.Add(RegButton);
			Reg.Controls.Add(FIOInput);
			Reg.Controls.Add(BornDateInput);
			Reg.Controls.Add(UsernameInput2);
			Reg.Controls.Add(PasswordInput2);
			Reg.Location = new Point(4, 24);
			Reg.Name = "Reg";
			Reg.Padding = new Padding(3);
			Reg.Size = new Size(410, 318);
			Reg.TabIndex = 1;
			Reg.Text = "Регистрация";
			Reg.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			label5.AutoSize = true;
			label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			label5.Location = new Point(121, 221);
			label5.Name = "label5";
			label5.Size = new Size(176, 17);
			label5.TabIndex = 26;
			label5.Text = "Пароль Администратора";
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			label2.AutoSize = true;
			label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(171, 150);
			label2.Name = "label2";
			label2.Size = new Size(57, 17);
			label2.TabIndex = 25;
			label2.Text = "Пароль";
			// 
			// AdmCheck
			// 
			AdmCheck.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			AdmCheck.Cursor = Cursors.IBeam;
			AdmCheck.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			AdmCheck.Location = new Point(6, 240);
			AdmCheck.Name = "AdmCheck";
			AdmCheck.PlaceholderText = " ???";
			AdmCheck.Size = new Size(398, 23);
			AdmCheck.TabIndex = 24;
			// 
			// label4
			// 
			label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			label4.AutoSize = true;
			label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			label4.Location = new Point(181, 3);
			label4.Name = "label4";
			label4.Size = new Size(40, 17);
			label4.TabIndex = 23;
			label4.Text = "ФИО";
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			label3.AutoSize = true;
			label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(154, 52);
			label3.Name = "label3";
			label3.Size = new Size(110, 17);
			label3.TabIndex = 22;
			label3.Text = "Дата рождения";
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			label1.AutoSize = true;
			label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(145, 101);
			label1.Name = "label1";
			label1.Size = new Size(125, 17);
			label1.TabIndex = 20;
			label1.Text = "Имя пользователя";
			// 
			// RegButton
			// 
			RegButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			RegButton.BackColor = Color.FromArgb(222, 0, 43);
			RegButton.Cursor = Cursors.Hand;
			RegButton.FlatAppearance.BorderColor = Color.Black;
			RegButton.FlatStyle = FlatStyle.Flat;
			RegButton.Font = new Font("Avoner", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
			RegButton.ForeColor = Color.White;
			RegButton.Location = new Point(6, 282);
			RegButton.Name = "RegButton";
			RegButton.Size = new Size(398, 30);
			RegButton.TabIndex = 19;
			RegButton.Text = "Регистрация";
			RegButton.UseVisualStyleBackColor = false;
			RegButton.Click += RegButton_Click;
			// 
			// FIOInput
			// 
			FIOInput.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			FIOInput.Cursor = Cursors.IBeam;
			FIOInput.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			FIOInput.Location = new Point(6, 22);
			FIOInput.MaxLength = 30;
			FIOInput.Name = "FIOInput";
			FIOInput.PlaceholderText = " Иванов Иван Иванович";
			FIOInput.Size = new Size(398, 23);
			FIOInput.TabIndex = 18;
			// 
			// BornDateInput
			// 
			BornDateInput.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			BornDateInput.Cursor = Cursors.IBeam;
			BornDateInput.Font = new Font("Avoner", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
			BornDateInput.Location = new Point(6, 71);
			BornDateInput.MaxLength = 10;
			BornDateInput.Name = "BornDateInput";
			BornDateInput.PlaceholderText = " 01.01.2000";
			BornDateInput.Size = new Size(398, 23);
			BornDateInput.TabIndex = 17;
			BornDateInput.TextChanged += BornDateInput_TextChanged;
			// 
			// UsernameInput2
			// 
			UsernameInput2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			UsernameInput2.Cursor = Cursors.IBeam;
			UsernameInput2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			UsernameInput2.Location = new Point(6, 120);
			UsernameInput2.MaxLength = 30;
			UsernameInput2.Name = "UsernameInput2";
			UsernameInput2.PlaceholderText = " Username";
			UsernameInput2.Size = new Size(398, 23);
			UsernameInput2.TabIndex = 15;
			// 
			// PasswordInput2
			// 
			PasswordInput2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			PasswordInput2.Cursor = Cursors.IBeam;
			PasswordInput2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			PasswordInput2.Location = new Point(6, 169);
			PasswordInput2.MaxLength = 30;
			PasswordInput2.Name = "PasswordInput2";
			PasswordInput2.PasswordChar = '*';
			PasswordInput2.PlaceholderText = " Password";
			PasswordInput2.Size = new Size(398, 23);
			PasswordInput2.TabIndex = 16;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(12, 12);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(146, 146);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 8;
			pictureBox1.TabStop = false;
			pictureBox1.Paint += pictureBox1_Paint;
			// 
			// BrandName
			// 
			BrandName.Anchor = AnchorStyles.None;
			BrandName.AutoSize = true;
			BrandName.Font = new Font("Avoner", 32.25F, FontStyle.Bold, GraphicsUnit.Point);
			BrandName.ForeColor = Color.FromArgb(238, 55, 78);
			BrandName.Location = new Point(161, 8);
			BrandName.Margin = new Padding(0);
			BrandName.Name = "BrandName";
			BrandName.Size = new Size(272, 52);
			BrandName.TabIndex = 9;
			BrandName.Text = "GEMLIGHTS";
			// 
			// label6
			// 
			label6.Anchor = AnchorStyles.None;
			label6.AutoSize = true;
			label6.Font = new Font("Avoner", 32.25F, FontStyle.Bold, GraphicsUnit.Point);
			label6.ForeColor = Color.FromArgb(238, 55, 78);
			label6.Location = new Point(161, 60);
			label6.Margin = new Padding(0, 2, 0, 2);
			label6.Name = "label6";
			label6.Size = new Size(272, 52);
			label6.TabIndex = 10;
			label6.Text = "GEMLIGHTS";
			// 
			// label7
			// 
			label7.Anchor = AnchorStyles.None;
			label7.AutoSize = true;
			label7.Font = new Font("Avoner", 32.25F, FontStyle.Bold, GraphicsUnit.Point);
			label7.ForeColor = Color.FromArgb(238, 55, 78);
			label7.Location = new Point(161, 112);
			label7.Margin = new Padding(0);
			label7.Name = "label7";
			label7.Size = new Size(272, 52);
			label7.TabIndex = 11;
			label7.Text = "GEMLIGHTS";
			// 
			// checkBox2
			// 
			checkBox2.AutoSize = true;
			checkBox2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			checkBox2.Location = new Point(6, 198);
			checkBox2.Name = "checkBox2";
			checkBox2.Size = new Size(139, 21);
			checkBox2.TabIndex = 16;
			checkBox2.Text = "Показать пароль";
			checkBox2.UseVisualStyleBackColor = true;
			checkBox2.CheckedChanged += checkBox2_CheckedChanged;
			// 
			// LogIn
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(440, 521);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(BrandName);
			Controls.Add(pictureBox1);
			Controls.Add(LogAndAutorization);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "LogIn";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "GEMLIGHTS";
			LogAndAutorization.ResumeLayout(false);
			Log.ResumeLayout(false);
			Log.PerformLayout();
			Reg.ResumeLayout(false);
			Reg.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private TabControl LogAndAutorization;
        private TabPage Log;
        private TextBox UsernameInput;
        private Label UsernameLabel;
        private TextBox PasswordInput;
        private Label PasswordLabel;
        private Button LogButton;
        private TabPage Reg;
        private Label label5;
        private Label label2;
        private TextBox AdmCheck;
        private Label label4;
        private Label label3;
        private Label label1;
        private Button RegButton;
        private TextBox FIOInput;
        private TextBox BornDateInput;
        private TextBox UsernameInput2;
        private TextBox PasswordInput2;
        private PictureBox pictureBox1;
        private Label BrandName;
        private Label label6;
        private Label label7;
		private CheckBox checkBox1;
		private CheckBox checkBox2;
	}
}