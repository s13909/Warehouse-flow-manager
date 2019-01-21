using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace App6
{
	public partial class App : Application
	{
		public EditInventoryPage EditInventoryPage { get; private set; }

		public App()
		{
			InitializeComponent();

			MainPage = new MainPage();
			EditInventoryPage = new EditInventoryPage();

			MainPage = new NavigationPage(new EditInventoryPage());
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
