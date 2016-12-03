using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;

namespace DemosNotas
{
	public class AzureService
	{
		IMobileServiceClient Client;
		IMobileServiceTable<Note> Notes;

		public AzureService()
		{
			string MyAppServiceURL = "http://demosnotas.azurewebsites.net";
			Client = new MobileServiceClient(MyAppServiceURL);
			Notes = Client.GetTable<Note>();
		}

		public Task<IEnumerable<Note>> GetNotes()
		{
			return Notes.ToEnumerableAsync();
		}
	}
}
