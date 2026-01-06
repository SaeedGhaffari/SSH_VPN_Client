using Microsoft.Win32;
using Renci.SshNet;
using SSH_VPN_Client.Enums;
using SSH_VPN_Client.Helpers;
using System.Net.NetworkInformation;

namespace SSH_VPN_Client;

public partial class frmMain : Form
{

    private FormStatus _formStatus = FormStatus.Disconnected;
    private SshClient _sshClient = new SshClient("0.0.0.0", 22, "0000", "0000");
    private ForwardedPortDynamic _portForwarded = null;
    private int _seconds = 0;
    private RegistryHelper _registry = new();
    private SystemProxyHelper _systemProxyHelper = new();
    private uint _proxyPort = 9000;


    public frmMain()
    {
        InitializeComponent();
    }

    private FormStatus Status
    {
        get => _formStatus;
        set
        {
            _formStatus = value;

            if (_formStatus == FormStatus.Connecting)
            {
                _btnConnect.Enabled = false;

                lblStatus.Text = "Connecting...";
                lblStatus.BackColor = Color.FromArgb(100, 255, 224, 192);

                _mnuNotifyConnect.Visible = false;

                _mnuNotifyDisconnect.Visible = true;
                _mnuNotifyDisconnect.Enabled = false;

            }
            else if (_formStatus == FormStatus.Connected)
            {
                _btnConnect.Enabled = true;
                _btnConnect.Text = "Disonnect";

                lblStatus.Text = "Connected";
                lblStatus.BackColor = Color.FromArgb(100, 192, 255, 192);

                timer_check_status.Enabled = true;
                timer_check_status.Start();

                _mnuNotifyConnect.Visible = false;

                _mnuNotifyDisconnect.Visible = true;
                _mnuNotifyDisconnect.Enabled = true;

            }
            else if (_formStatus == FormStatus.Disconnecting)
            {
                _btnConnect.Enabled = false;

                lblStatus.Text = "Disconnecting...";
                lblStatus.BackColor = Color.FromArgb(100, 255, 224, 192);

                _mnuNotifyConnect.Visible = true;
                _mnuNotifyConnect.Enabled = false;

                _mnuNotifyDisconnect.Visible = false;
            }
            else
            {
                _btnConnect.Enabled = true;
                _btnConnect.Text = "Connect";

                lblStatus.Text = "Disconnected";
                lblStatus.BackColor = Color.FromArgb(100, 255, 192, 192);

                timer_check_status.Enabled = false;
                timer_check_status.Stop();
                _seconds = 0;

                _labProxyAddress.Text = "---";

                _mnuNotifyConnect.Visible = true;
                _mnuNotifyConnect.Enabled = true;

                _mnuNotifyDisconnect.Visible = false;
            }

        }
    }


    private void Connect()
    {
        ThreadPool.QueueUserWorkItem(_ =>
        {
            try
            {
                Invoke((MethodInvoker)(() =>
                {
                    Status = FormStatus.Connecting;
                }));

                _sshClient = CreateSshClient();
                _portForwarded = new ForwardedPortDynamic(_proxyPort);

                _sshClient.Connect();
                _sshClient.AddForwardedPort(_portForwarded);
                _portForwarded.Start();

                _labProxyAddress.Text = $"socks5://localhost:{_proxyPort}";

                if (_registry.GetBool(RegistryValueNames.SetSystemProxy))
                    _systemProxyHelper.SetSystemProxy(_proxyPort);

                Invoke((MethodInvoker)(() =>
                {
                    Status = FormStatus.Connected;
                }));
            }
            catch
            {
                Invoke((MethodInvoker)(() =>
                {
                    Status = FormStatus.Disconnected;
                }));
            }
        });
    }
    private async void StartReconnect()
    {
        if (Status != FormStatus.Connected)
            return;

        Invoke((MethodInvoker)(() =>
        {
            Status = FormStatus.Disconnecting;
        }));

        await Task.Delay(3000); // wait for network stabilization

        Disconnect(true);
        Connect();
    }
    private void Disconnect(bool confirmed = false)
    {
        if (!confirmed)
        {
            DialogResult result = MessageBox.Show(
                "Do you really wish to exit? the connection will be stopped.",
                "Exit Program?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
                return;
        }

        try
        {
            Cursor.Current = Cursors.WaitCursor;

            Invoke((MethodInvoker)delegate
            {
                Status = FormStatus.Disconnecting;
            });

            _portForwarded.Stop();
            _sshClient.Disconnect();
            _systemProxyHelper.UnSetSystemProxy();

            Invoke((MethodInvoker)delegate
            {
                Status = FormStatus.Disconnected;
            });

            Cursor.Current = Cursors.Default;
        }
        catch (Exception exp)
        {
            Cursor.Current = Cursors.Default;

            DialogResult result = MessageBox.Show(
                exp.Message,
                "Error in Disconnecting",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
        finally
        {
            Cursor.Current = Cursors.Default;
        }

    }

    private SshClient CreateSshClient()
    {
        string password = _registry.GetString(RegistryValueNames.Password);
        string username = _registry.GetString(RegistryValueNames.Username);
        string ip = _registry.GetString(RegistryValueNames.Host);
        int port = _registry.GetInt(RegistryValueNames.Port);

        if (port == 0)
            port = 22;

        return new SshClient(ip, port, username, password);
    }
    private void OpenSettingsForm()
    {
        SettingsForm settingsForm = new SettingsForm();
        settingsForm.ShowDialog();
    }

    private void HideMe()
    {
        notifyIcon1.Visible = true;
        this.Hide();
    }
    private void ShowMe()
    {
        this.Show();
        this.WindowState = FormWindowState.Normal;
        this.Activate();
    }
    private void ShowOeHideMe()
    {
        if (this.Visible)
            HideMe();
        else
            ShowMe();
    }


    private void frmMain_Load(object sender, EventArgs e)
    {
        Status = FormStatus.Disconnected;

        SystemEvents.PowerModeChanged += OnPowerModeChanged;
        NetworkChange.NetworkAvailabilityChanged += OnNetworkAvailabilityChanged;

        if (!_registry.HasValue(RegistryValueNames.SetSystemProxy))
        {
            _registry.SetValue(RegistryValueNames.SetSystemProxy, true);
            _mnuSetSystemProxy.Checked = true;
        }
        else
        {
            _mnuSetSystemProxy.Checked = _registry.GetBool(RegistryValueNames.SetSystemProxy);
        }
    }
    private void frmMain_Resize(object sender, EventArgs e)
    {
        if (this.WindowState == FormWindowState.Minimized)
        {
            HideMe();
        }
    }

    private void _btnConnect_Click(object sender, EventArgs e)
    {
        if (Status == FormStatus.Connected)
        {
            Disconnect();
        }
        else if (Status == FormStatus.Disconnected)
        {
            Connect();
        }
    }
    private void timer_check_status_Tick(object sender, EventArgs e)
    {
        if (Status != FormStatus.Connected)
            return;

        if (!_sshClient.IsConnected)
        {
            lblStatus.Text = "Reconnecting...";
            StartReconnect();
            return;
        }

        _seconds++;
        lblStatus.Text = $"Connected [{TimeSpan.FromSeconds(_seconds):hh\\:mm\\:ss}]";
    }

    private void _mnuSettings_Click(object sender, EventArgs e)
    {
        if (!Visible)
            ShowMe();

        OpenSettingsForm();
    }
    private void _mnuExit_Click(object sender, EventArgs e)
    {

        var confirm = MessageBox.Show("Do you wabt to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (confirm != DialogResult.Yes)
            return;

        if (_sshClient.IsConnected)
            Disconnect();

        Application.Exit();
    }
    private void _mnuSetSystemProxy_CheckedChanged(object sender, EventArgs e)
    {
        bool setSystemProxy = _mnuSetSystemProxy.Checked;

        _registry.SetValue(RegistryValueNames.SetSystemProxy, setSystemProxy);

        if (Status != FormStatus.Connected)
            return;

        if (setSystemProxy)
            _systemProxyHelper.SetSystemProxy(_proxyPort);
        else
            _systemProxyHelper.UnSetSystemProxy();
    }
    private void _mnuHideShow_Click(object sender, EventArgs e)
    {
        ShowOeHideMe();
    }
    private void _mnuAbout_Click(object sender, EventArgs e)
    {
        frmAbout frm = new frmAbout();
        frm.ShowDialog();
    }

    private void SystemEvents_SessionEnding(object sender, SessionEndingEventArgs e)
    {
        Invoke((MethodInvoker)delegate
        {
            Status = FormStatus.Disconnected;
        });

        Application.Exit();
    }
    private void OnPowerModeChanged(object sender, PowerModeChangedEventArgs e)
    {
        if (e.Mode == PowerModes.Resume)
        {
            if (Status == FormStatus.Connected)
            {
                StartReconnect();
            }
        }
    }
    private void OnNetworkAvailabilityChanged(object sender, NetworkAvailabilityEventArgs e)
    {
        if (!e.IsAvailable)
            return;

        if (Status == FormStatus.Connected)
        {
            StartReconnect();
        }
    }

}
