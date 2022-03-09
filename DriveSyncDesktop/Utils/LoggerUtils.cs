using System.Text.Json;
using System.Text.Json.Serialization;
using DriveSyncDesktop.Models;

namespace DriveSyncDesktop.Utils;

public class LoggerUtils
{
    private static readonly string LoggerFolder = Path.Join(Application.StartupPath, "Logs");
    private static string TodayFileString => DateTime.Now.ToString("yyyy-MM-dd");

    public static async Task<bool> Log(LogModel logModel)
    {
        var filePath = Path.Join(LoggerFolder, $"{TodayFileString}.json");

        try
        {
            JsonSerializerOptions options = new()
            {
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                WriteIndented = true
            };

            if (Directory.Exists(LoggerFolder) == false) Directory.CreateDirectory(LoggerFolder);

            if (File.Exists(filePath))
            {
                var fileContent = await File.ReadAllTextAsync(filePath);
                var logLists = JsonSerializer.Deserialize<List<LogModel>>(fileContent);
                logLists?.Add(logModel);

                var toModifyJson = JsonSerializer.Serialize(logLists, options);
                await File.WriteAllTextAsync(filePath, toModifyJson);
            }
            else
            {
                var data = new List<LogModel> { logModel };

                var toAddJson = JsonSerializer.Serialize(data);
                await File.WriteAllTextAsync(filePath, toAddJson);
            }

            return true;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
            return false;
        }
    }

    public static async Task<List<LogModel>?> LoadTodayLogs()
    {
        var filePath = Path.Join(LoggerFolder, $"{TodayFileString}.json");

        try
        {
            if (!File.Exists(filePath)) return null;

            var fileContent = await File.ReadAllTextAsync(filePath);
            return JsonSerializer.Deserialize<List<LogModel>>(fileContent);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
            return null;
        }
    }
}
