using System;
using System.Text.Json.Serialization;

namespace CronicleDotnetSDK.Models
{
	public class TableContainer
	{
        [JsonPropertyName("table")]
		public Table Table { get; set; } = default!;

		public TableContainer(Table table)
		{
			Table = table;
		}
	}
}

