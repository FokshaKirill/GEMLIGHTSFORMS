namespace GEMLIGHTSFORMS
{
    partial class CardForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardForm));
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			DateInput = new TextBox();
			CVVInput = new TextBox();
			pictureBox1 = new PictureBox();
			Add = new Button();
			comboBox1 = new ComboBox();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// label2
			// 
			resources.ApplyResources(label2, "label2");
			label2.Name = "label2";
			// 
			// label3
			// 
			resources.ApplyResources(label3, "label3");
			label3.Name = "label3";
			// 
			// label4
			// 
			resources.ApplyResources(label4, "label4");
			label4.Name = "label4";
			// 
			// DateInput
			// 
			resources.ApplyResources(DateInput, "DateInput");
			DateInput.Name = "DateInput";
			DateInput.TextChanged += DateInput_TextChanged;
			// 
			// CVVInput
			// 
			resources.ApplyResources(CVVInput, "CVVInput");
			CVVInput.Name = "CVVInput";
			// 
			// pictureBox1
			// 
			resources.ApplyResources(pictureBox1, "pictureBox1");
			pictureBox1.Name = "pictureBox1";
			pictureBox1.TabStop = false;
			// 
			// Add
			// 
			Add.BackColor = Color.FromArgb(222, 0, 43);
			Add.FlatAppearance.BorderColor = Color.Black;
			resources.ApplyResources(Add, "Add");
			Add.ForeColor = Color.White;
			Add.Name = "Add";
			Add.UseVisualStyleBackColor = false;
			Add.Click += Add_Click;
			// 
			// comboBox1
			// 
			comboBox1.BackColor = Color.White;
			comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
			resources.ApplyResources(comboBox1, "comboBox1");
			comboBox1.FormattingEnabled = true;
			comboBox1.Name = "comboBox1";
			// 
			// CardForm
			// 
			resources.ApplyResources(this, "$this");
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			Controls.Add(comboBox1);
			Controls.Add(Add);
			Controls.Add(pictureBox1);
			Controls.Add(CVVInput);
			Controls.Add(DateInput);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			KeyPreview = true;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "CardForm";
			ShowIcon = false;
			ShowInTaskbar = false;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label label2;
        private Label label3;
        private Label label4;
        private TextBox DateInput;
        private TextBox CVVInput;
        private PictureBox pictureBox1;
        private Button Add;
        private ComboBox comboBox1;
    }
}