using System.Text.Json;
using System.Text.Json.Serialization;
using DriveSyncDesktop.Models;

namespace DriveSyncDesktop.Utils;

public class AppConfigUtils
{
    private static readonly string ConfigFilePath = Path.Join(Application.StartupPath, "config.json");

    public static bool Save(AppConfigModel appConfig, Action? myFunc = null)
    {
        JsonSerializerOptions options = new()
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            WriteIndented = true
        };

        File.WriteAllText(ConfigFilePath, JsonSerializer.Serialize(appConfig, options));

        myFunc?.Invoke();

        return File.Exists(ConfigFilePath);
    }

    public static AppConfigModel? Load(Action? myFunc = null)
    {
        try
        {
            var content = File.ReadAllText(ConfigFilePath);
            var result = JsonSerializer.Deserialize<AppConfigModel>(content);

            myFunc?.Invoke();

            return result;
        }
        catch (Exception _)
        {
            return null;
        }
    }
}