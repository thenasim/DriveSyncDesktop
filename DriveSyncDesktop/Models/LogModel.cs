using System.Text.Json.Serialization;

namespace DriveSyncDesktop.Models;

public class LogModel
{
    public bool IsSynced { get; set; }
    public string? Time { get; set; }
    public string? LocalFolderPath { get; set; }
    public string? RemoteAccountName { get; set; }
    public string? RemoteFolderPath { get; set; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public LogLevel? LogLevel { get; set; }
}

public enum LogLevel
{
    Information,
    Error,
    Warning
}