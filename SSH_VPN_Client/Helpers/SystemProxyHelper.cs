using Microsoft.Win32;

namespace SSH_VPN_Client.Helpers;

internal class SystemProxyHelper
{
    public void SetSystemProxy(uint port)
    {
        RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);

        registry!.SetValue("ProxyEnable", 1);
        registry.SetValue("ProxyServer", $"socks5://127.0.0.1:{port}");

        WinINetInterop.InternetSetOption(IntPtr.Zero, WinINetInterop.INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
        WinINetInterop.InternetSetOption(IntPtr.Zero, WinINetInterop.INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
    }

    public void UnSetSystemProxy()
    {
        RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);

        registry!.SetValue("ProxyEnable", 0);
        registry.SetValue("ProxyServer", "");
    }
}