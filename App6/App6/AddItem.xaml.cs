using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App6
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddItem : ContentPage

		
	{
		public StackLayout loggerLayout = new StackLayout();
		 public Entry  name, value;
		public Button sub;
		public AddItem ()
		{

			name = new Entry
			{
				Placeholder = "Name"
			};

			value = new Entry
			{
				Placeholder = "value"
			};

			sub = new Button
			{
				Text = "Submit"

			};

			loggerLayout.Children.Add(name);
			loggerLayout.Children.Add(value);
			loggerLayout.Children.Add(sub);
			InitializeComponent ();
		}
	}
}