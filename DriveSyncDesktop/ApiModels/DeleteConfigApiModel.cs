using System.Text.Json.Serialization;

namespace DriveSyncDesktop.ApiModels;

public class DeleteConfigApiModel
{
    [JsonPropertyName("name")] public string Name { get; set; } = string.Empty;
}