namespace CDDA_Bars
{
	using System;
	using System.Drawing;
	using System.Windows.Forms;

	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			labelBar.BackColor = Color.Black;
		}

		private void TrackBarInput_Scroll(object sender, EventArgs e)
		{
			if (trackBarInput.Value <= 90) labelBar.ForeColor = Color.Green;
			if (trackBarInput.Value <= 80) labelBar.ForeColor = Color.Yellow;
			if (trackBarInput.Value <= 60) labelBar.ForeColor = Color.Orange;
			if (trackBarInput.Value <= 40) labelBar.ForeColor = Color.OrangeRed;
			if (trackBarInput.Value <= 20) labelBar.ForeColor = Color.Red;
			labelBar.Text = Int2Bar(trackBarInput.Value, 100, 10);
		}

		string Int2Bar(double inputValue, double maxValue, int barLenght)
		{
			double percent = inputValue / maxValue * 100;
			double halfTickLenght = 50.0 / barLenght;
			int halTickCount = (int)(percent / halfTickLenght);
			int wholeTickCount = halTickCount / 2;
			int dotsCount = barLenght - 1;

			string bar = "";
			dotsCount -= wholeTickCount; 
			for (int i = 0; i <= wholeTickCount - 1; i++)
			{
				bar += "|";
			}

			if (halTickCount - wholeTickCount * 2 >= 1)
			{
				bar += @"/";
				dotsCount--;
			}

			if (percent < halfTickLenght)
			{
				bar = ":";
				dotsCount--;
			}

			for (int i = 0; i <= dotsCount; i++)
				bar += ".";

			return bar;
		}
	}
}
