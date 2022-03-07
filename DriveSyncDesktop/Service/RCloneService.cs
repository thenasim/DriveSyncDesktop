using System.Diagnostics;

namespace DriveSyncDesktop.Service;

public class RCloneService
{
    private static readonly string RClonePath = Path.Join(Application.StartupPath, "Binary", "rclone.exe");

    public RCloneService()
    {
        if (File.Exists(RClonePath) == false) throw new FileNotFoundException("RClone exe file not found.");
    }

    public int RunCommand(string arguments, ref string output)
    {
        var process = new Process();
        process.StartInfo.RedirectStandardInput = true;
        process.StartInfo.RedirectStandardOutput = true;
        process.StartInfo.RedirectStandardError = true;
        process.StartInfo.CreateNoWindow = true;

        process.StartInfo.FileName = RClonePath;
        process.StartInfo.Arguments = arguments;

        process.Start();

        output = process.StandardOutput.ReadToEnd();

        process.Kill();

        return process.ExitCode;
    }

    public bool CreateConfig(string jsonString, string command, ref string output)
    {
        jsonString = jsonString.Replace("\"", "\\\"");
        var exitCode = RunCommand($"rc --json {jsonString} {command}", ref output);

        return exitCode == 0;
    }

    public bool DeleteConfig(string remoteName, ref string output)
    {
        var exitCode = RunCommand($"config delete {remoteName}", ref output);

        return exitCode == 0;
    }

    public bool Copy(string sourceCommand, string destCommand, ref string output)
    {
        var exitCode = RunCommand($"copy {sourceCommand} {destCommand}:", ref output);

        return exitCode == 0;
    }
}