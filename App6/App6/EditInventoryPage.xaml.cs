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
	public partial class EditInventoryPage : ContentPage
	{ 
		
        Button addButton, removeButton;
		StackLayout loggerLayout = new StackLayout();

		public static List<Button> elements = new List<Button>();

		public EditInventoryPage()
		{
			// Create the Button views and attach Clicked handlers.
			addButton = new Button
			{
				Text = "Add",
				HorizontalOptions = LayoutOptions.CenterAndExpand
			};
			addButton.Clicked += OnButtonClicked;

			removeButton = new Button
			{
				Text = "Remove",
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				IsEnabled = false
			};
			removeButton.Clicked += OnButtonClicked;

			Padding = new Thickness(5, Device.RuntimePlatform == Device.iOS ? 20 : 0, 5, 0);

			

			// Assemble the page.
			Content = new StackLayout
			{
				Children =
				{
					new StackLayout
					{
						Orientation = StackOrientation.Horizontal,
						Children =
						{
							addButton,
							removeButton
						}
					},

					new ScrollView
					{
						VerticalOptions = LayoutOptions.FillAndExpand,
						Content = loggerLayout
					}
				}
			};
		}

		void OnButtonClicked(object sender, EventArgs args)
		{
			Button button = (Button)sender;

			if (button == addButton)
			{
				// Add Label to scrollable StackLayout.
				Button b;
				b = new Button
				{
					Text = "A new item added  at " + DateTime.Now.ToString("T")
				};


				loggerLayout.Children.Add(b);

				elements.Add(b);

				Navigation.PushAsync(new AddItem());




			}
			if(button == removeButton)
			{
				// Remove topmost Label from StackLayout
				loggerLayout.Children.RemoveAt(0);
			}

			if (elements.Contains(button))
			{
				int n = loggerLayout.Children.IndexOf(button);


				Button b = (Button)loggerLayout.Children[n];

				loggerLayout.Children.RemoveAt(n);

				b.Text = "KUUUUURWAAAAA";

				loggerLayout.Children.Add(b);


			}

			// Enable "Remove" button only if children are present.
			removeButton.IsEnabled = loggerLayout.Children.Count > 0;
		}
	}


}
