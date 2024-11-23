namespace GEMLIGHTSFORMS
{
	public partial class CardForm : Form
	{
		public string cardNumb;
		public CardForm()
		{
			InitializeComponent();

			DB.RefreshCardsList(DB.pathCards);
			comboBox1.Items.Clear();

			foreach (var c in DB.cards)
				comboBox1.Items.Add(c.Number);

			KeyDown += (s, a) => { if (a.KeyCode == Keys.Escape) Close(); };
		}

		private void Add_Click(object sender, EventArgs e)
		{
			if (CVVInput.Text != "" && DateInput.Text != "" && comboBox1.Text != "")
			{
				DB.RefreshCardsList(DB.pathCards);

				for (int i = 0; i < DB.cards.Count; i++)
					if (CVVInput.Text == DB.cards[i].CVV && DateInput.Text == DB.cards[i].Date && comboBox1.Text == DB.cards[i].Number)
						cardNumb = comboBox1.Text;
			}
		}

		private void DateInput_TextChanged(object sender, EventArgs e)
		{
			int posTemp = DateInput.SelectionStart;

			if (DateInput.Text.Replace(" ", "").Length == 2 && !DateInput.Text.Contains('/'))
				DateInput.Text += "/";

			DateInput.SelectionStart = posTemp + 1;
		}
	}
}
