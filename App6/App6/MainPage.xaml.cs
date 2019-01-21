using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App6
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
		private void onClick(object sender, EventArgs e)
		{
			(sender as Button).Text = "I was just clicked!";
			//Navigation.PushAsync(new EditInventoryPage());
		}

		private void onPress(object sender, EventArgs e)
		{
			(sender as Button).Text = "You pressed me!";
			Navigation.PushAsync(new EditInventoryPage());
		}
	}
}
