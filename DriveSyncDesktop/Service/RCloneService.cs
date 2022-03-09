using System.Diagnostics;

namespace DriveSyncDesktop.Service;

public class RCloneService
{
    private static readonly string RClonePath = Path.Join(Application.StartupPath, "Binary", "rclone.exe");

    private static Process GetProcess(string arguments)
    {
        var process = new Process();
        process.StartInfo.RedirectStandardInput = true;
        process.StartInfo.RedirectStandardOutput = true;
        process.StartInfo.RedirectStandardError = true;
        process.StartInfo.CreateNoWindow = true;

        process.StartInfo.FileName = RClonePath;
        process.StartInfo.Arguments = arguments;

        return process;
    }

    public static int RunCommand(string arguments, out string output)
    {
        var process = GetProcess(arguments);
        process.Start();

        output = process.StandardOutput.ReadToEnd();

        process.WaitForExit();
        return process.ExitCode;
    }

    public static Process RunHttpServer()
    {
        var process = GetProcess($"rcd --rc-no-auth");
        process.Start();

        return process;
    }

    public static bool CreateConfig(string jsonString, out string output)
    {
        jsonString = jsonString.Replace("\"", "\\\"");
        var exitCode = RunCommand($"rc --json {jsonString} config/create", out output);

        return exitCode == 0;
    }

    public static bool DeleteConfig(string remoteName, out string output)
    {
        var exitCode = RunCommand($"config delete {remoteName}", out output);

        return exitCode == 0;
    }

    public static bool ListDirectories(string remoteName, out string output, string remotePath = "")
    {
        var exitCode = RunCommand($"lsjson \"{remoteName}:{remotePath}\"", out output);

        return exitCode == 0;
    }

    public static bool Copy(string sourceCommand, string destCommand, out string output, string remotePath = "")
    {
        var command = $"copy \"{sourceCommand}\" \"{destCommand}:{remotePath}\"";
        var exitCode = RunCommand(command, out output);

        return exitCode != 0;
    }
}