namespace DriveSyncDesktop.Models;

public class AppConfigModel
{
    public List<FolderToSync>? FolderToSyncList { get; set; } = null;
    public double? RepeatSync { get; set; } = null; // save in the config by milliseconds
}

public record FolderToSync
{
    public string FolderPath { get; set; } = string.Empty;
    public string RemoteName { get; set; } = string.Empty;
}