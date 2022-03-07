using Microsoft.Win32;

namespace DriveSyncDesktop.Utils;

public class StartupUtils
{
    private const string ApplicationName = "DriveSyncDesktop";
    private const string Run = "Software\\Microsoft\\Windows\\CurrentVersion\\Run";

    public static bool Get()
    {
        var rk = Registry.CurrentUser.OpenSubKey(Run, true);

        var result = rk?.GetValue(ApplicationName);

        return result != null;
    }

    public static bool Add()
    {
        var rk = Registry.CurrentUser.OpenSubKey(Run, true);

        if (rk == null) return false;

        rk.SetValue(ApplicationName, Application.ExecutablePath);
        return true;
    }

    public static bool Remove()
    {
        var rk = Registry.CurrentUser.OpenSubKey(Run, true);

        if (rk == null) return false;

        rk.DeleteValue(ApplicationName, false);
        return true;
    }
}