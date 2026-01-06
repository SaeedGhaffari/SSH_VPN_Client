using Microsoft.Win32;
using SSH_VPN_Client.Enums;

namespace SSH_VPN_Client.Helpers;

internal class RegistryHelper
{
    private readonly string KeyName = "ssh_vpn";

    private object? GetRegisteryData(string name)
    {
        using (RegistryKey key = Registry.CurrentUser.OpenSubKey(KeyName))
        {
            if (key == null)
                return "";
            else
                return key.GetValue(name);
        }
    }
    private void SetRegistryData(string name, string value)
    {
        using (RegistryKey key = Registry.CurrentUser.CreateSubKey(KeyName))
        {
            key.SetValue(name, value);

        }
    }

    public void SetValue(RegistryValueNames keyName, string value)
    {
        SetRegistryData(keyName.ToString().ToLower(), value);
    }
    public void SetValue(RegistryValueNames keyName, int value)
    {
        SetValue(keyName, value.ToString());
    }
    public void SetValue(RegistryValueNames keyName, bool value)
    {
        SetValue(keyName, value ? "true" : "false");
    }

    public string GetString(RegistryValueNames keyName)
    {
        var value = GetRegisteryData(keyName.ToString().ToLower());

        return (value != null)
            ? value.ToString()
            : string.Empty;
    }
    public int GetInt(RegistryValueNames keyName)
    {
        var value = GetRegisteryData(keyName.ToString().ToLower());

        if (value == null)
            return 0;

        int result = 0;

        int.TryParse(value.ToString(), out result);

        return result;
    }
    public bool GetBool(RegistryValueNames keyName)
    {
        var value = GetRegisteryData(keyName.ToString().ToLower());

        if(value == null)
            return false;

        return value.ToString().ToLower() == "true";
    }

    public bool HasValue(RegistryValueNames keyName)
    {
        var value = GetRegisteryData(keyName.ToString().ToLower());
        return value != null;
    }

}
