using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DegreesCalculator
{
	public partial class MainPage : ContentPage
	{

        private Double celsius;
        private Double farenheit;

        public MainPage()
		{
			InitializeComponent();
            this.celsius = 0;
            this.farenheit = getFarenheit(this.celsius);
            this.updateText();
        }

        private void updateText()
        {
            labelCelsius.Text = celsius.ToString();
            labelFarenheit.Text = farenheit.ToString();
        }

        private Double getFarenheit(Double celsius) => (celsius * 1.8) + 32;

        private Double getCelsius(Double farenheit) => (farenheit - 32) / 1.8;

        private void plusCelsius_Click(object sender, EventArgs e)
        {
            this.farenheit = getFarenheit(++this.celsius);
            this.updateText();
        }

        private void plusFarenheit_Click(object sender, EventArgs e)
        {
            this.celsius = getCelsius(++this.farenheit);
            this.updateText();
        }

        private void minusCelsius_Click(object sender, EventArgs e)
        {
            this.farenheit = getFarenheit(--this.celsius);
            this.updateText();
        }

        private void minusFarenheit_Click(object sender, EventArgs e)
        {
            this.celsius = getCelsius(--this.farenheit);
            this.updateText();
        }
    }
}
