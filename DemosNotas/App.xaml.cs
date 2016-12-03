using Xamarin.Forms;

namespace DemosNotas
{
	public partial class App : Application
	{
		private DemosNotasPage _mainPage;

		public App()
		{
			_mainPage = new DemosNotas.DemosNotasPage();

			InitializeComponent();

			MainPage = _mainPage;
		}

		protected override void OnStart()
		{
			// Handle when your app starts
			_mainPage.Load();
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
