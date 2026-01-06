using SSH_VPN_Client.Enums;
using SSH_VPN_Client.Helpers;

namespace SSH_VPN_Client;

public partial class SettingsForm : Form
{
    private RegistryHelper _registry = new RegistryHelper();
    private string _numericFilter = "0123456789\t\b";
    public SettingsForm()
    {
        InitializeComponent();
    }

    private void btn_save_Click(object sender, EventArgs e)
    {
        int port = 0;

        if (!int.TryParse(txt_port.Text, out port))
        {
            MessageBox.Show("Invalid port.", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        _registry.SetValue(RegistryValueNames.Host, txt_ip.Text);
        _registry.SetValue(RegistryValueNames.Port, port);
        _registry.SetValue(RegistryValueNames.Username, txt_username.Text);
        _registry.SetValue(RegistryValueNames.Password, txt_password.Text);

        this.DialogResult = DialogResult.OK;
    }
    private void SettingsForm_Load(object sender, EventArgs e)
    {
        txt_ip.Text = _registry.GetString(RegistryValueNames.Host);
        txt_username.Text = _registry.GetString(RegistryValueNames.Username);
        txt_password.Text = _registry.GetString(RegistryValueNames.Password);
        txt_port.Text = _registry.GetString(RegistryValueNames.Port);
    }
    private void btn_cancel_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
    }

    private void txt_port_KeyPress(object sender, KeyPressEventArgs e)
    {
        if(_numericFilter.IndexOf(e.KeyChar) < 0)
            e.Handled = true;
    }
}
