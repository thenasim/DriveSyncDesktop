using System.Text.Json.Serialization;

namespace DriveSyncDesktop.ApiModels;

public class CreateConfigApiModel
{
    [JsonPropertyName("name")] public string Name { get; set; } = string.Empty;
    [JsonPropertyName("type")] public string Type => "drive";

    [JsonPropertyName("parameters")] public ParameterApiModel? Parameter { get; set; }
}

public class ParameterApiModel
{
    [JsonPropertyName("root_folder_id")] public string RootFolderId { get; set; } = string.Empty;
    [JsonPropertyName("email")] public string Email { get; set; } = string.Empty;
}