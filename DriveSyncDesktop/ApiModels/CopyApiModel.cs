using System.Text.Json.Serialization;

namespace DriveSyncDesktop.ApiModels;

public class CopyApiModel
{
    [JsonPropertyName("srcFs")] public string? Source { get; set; }
    [JsonPropertyName("dstFs")] public string? Destination { get; set; }
}