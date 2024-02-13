using System;
using System.Text.Json.Serialization;

namespace CronicleDotnetSDK.Models
{
	public class JobStatus
	{
        [JsonPropertyName("complete")]
        public int Complete { get; set; }
        [JsonPropertyName("code")]
        public int Code { get; set; }
    }
}

