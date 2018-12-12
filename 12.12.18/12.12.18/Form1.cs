using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12._12._18
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void aTxtBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void plus_Click(object sender, EventArgs e)
		{
			Debug.WriteLine("Clicked button");

			Debug.WriteLine($"a Text box = {Convert.ToInt32(aTxtBox.Text)}");

			Debug.WriteLine($"b Text box = {Convert.ToInt32(bTxtBox.Text)}");

			int a = Convert.ToInt32(aTxtBox.Text);

			int b = Convert.ToInt32(bTxtBox.Text);

			int c = a + b;

			resultLbl.Text = $"result = {c}";

		}

		private void minus_Click(object sender, EventArgs e)
		{
			Debug.WriteLine("Clicked button");

			Debug.WriteLine($"a Text box = {Convert.ToInt32(aTxtBox.Text)}");

			Debug.WriteLine($"b Text box = {Convert.ToInt32(bTxtBox.Text)}");

			int a = Convert.ToInt32(aTxtBox.Text);

			int b = Convert.ToInt32(bTxtBox.Text);

			int c = a - b;

			resultLbl.Text = $"result = {c}";

		}

		private void mul_Click(object sender, EventArgs e)
		{
			Debug.WriteLine("Clicked button");

			Debug.WriteLine($"a Text box = {Convert.ToInt32(aTxtBox.Text)}");

			Debug.WriteLine($"b Text box = {Convert.ToInt32(bTxtBox.Text)}");

			int a = Convert.ToInt32(aTxtBox.Text);

			int b = Convert.ToInt32(bTxtBox.Text);

			int c = a * b;

			resultLbl.Text = $"result = {c}";

		}

		private void divide_Click(object sender, EventArgs e)
		{
			Debug.WriteLine("Clicked button");

			Debug.WriteLine($"a Text box = {Convert.ToInt32(aTxtBox.Text)}");

			Debug.WriteLine($"b Text box = {Convert.ToInt32(bTxtBox.Text)}");

			double a = Convert.ToDouble(aTxtBox.Text);

			double b = Convert.ToDouble(bTxtBox.Text);
			if (b == 0)
			{
				resultLbl.Text = "canot divide by zero";
			}
			else
			{
				double c = a / b;

				resultLbl.Text = $"result = {c}";
			}
		}
	}
}
