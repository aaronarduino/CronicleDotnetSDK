using System;
using System.Text.Json.Serialization;

namespace CronicleDotnetSDK.Models
{
	public class Job
	{
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;
        [JsonPropertyName("hostname")]
        public string Hostname { get; set; } = string.Empty;
        [JsonPropertyName("command")]
        public string Command { get; set; } = string.Empty;
        [JsonPropertyName("event")]
        public string Event { get; set; } = string.Empty;
        [JsonPropertyName("now")]
        public int Now { get; set; }
        [JsonPropertyName("log_file")]
        public string LogFile { get; set; } = string.Empty;
        [JsonPropertyName("params")]
        public Dictionary<string, string> Params { get; set; } = new Dictionary<string, string>();
    }
}

