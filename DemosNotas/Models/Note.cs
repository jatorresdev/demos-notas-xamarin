using System;
using Microsoft.WindowsAzure.MobileServices;

namespace DemosNotas
{
	[DataTable("Notes")]
	public class Note
	{
		public string Id { get; set; }

		public string Title { get; set; }

		public string Description { get; set; }

		[Version]
		public string AzureVersion { get; set; }

	}
}
