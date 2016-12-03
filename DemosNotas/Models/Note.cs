using System;
using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;

namespace DemosNotas
{
	[DataTable("Notes")]
	public class Note
	{
		[JsonProperty]
		public string Id { get; set; }

		[JsonProperty]
		public string Title { get; set; }

		[JsonProperty]
		public string Description { get; set; }

		[Version]
		public string AzureVersion { get; set; }

	}
}
