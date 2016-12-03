using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace DemosNotas
{
	public partial class DemosNotasPage : ContentPage
	{
		private AzureService Client;
		public ObservableCollection<Note> Items { get; set; }
		public Command RefreshCommand { get; set; }

		public DemosNotasPage()
		{
			Items = new ObservableCollection<Note>();
			RefreshCommand = new Command(() => Load());
			Client = new AzureService();
			InitializeComponent();
		}

		public async void Load() 
		{
			IsBusy = true;
			Items.Clear();
			var result = await Client.GetNotes();

			foreach (var item in result)
			{
				Items.Add(item);
			}

			IsBusy = false;
		}
	}
}
