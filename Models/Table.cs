using System;
using System.Text.Json.Serialization;

namespace CronicleDotnetSDK.Models
{
	public class Table
	{
        [JsonPropertyName("title")]
		public string Title { get; set; } = string.Empty;
        [JsonPropertyName("header")]
		public List<string> Header { get; set; } = new List<string>();
        [JsonPropertyName("rows")]
		public List<List<string>> Rows { get; set; } = new List<List<string>>();
        [JsonPropertyName("caption")]
		public string Caption { get; set; } = string.Empty;
	}
}

