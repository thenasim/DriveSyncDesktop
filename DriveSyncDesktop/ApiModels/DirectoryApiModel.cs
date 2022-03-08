namespace DriveSyncDesktop.ApiModels;

public class DirectoryApiModel
{
    public string Id { get; set; } = string.Empty;
    public string Path { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public bool IsDir { get; set; }
}