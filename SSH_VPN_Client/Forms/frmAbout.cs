using SSH_VPN_Client.Properties;
using System.Text;

namespace SSH_VPN_Client;

public partial class frmAbout : Form
{
    public frmAbout()
    {
        InitializeComponent();
    }

    private void _btnClose_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.OK;
    }
    private void frmAbout_Load(object sender, EventArgs e)
    {
        StringBuilder sb = new StringBuilder();

        sb.Append("It’s completely free and made for personal use.");
        sb.Append(Environment.NewLine + Environment.NewLine);
        sb.Append("If you’d like to improve it, add features, or just explore the code, you’re very welcome to check out the project on GitHub.");
        sb.Append(Environment.NewLine + Environment.NewLine);
        sb.Append("Hope for a free and open internet.");

        _labAbout.Text = sb.ToString();
        _picAbout.Image = Resources.ssh_proxy;
        _picGithub.Image = Resources.github;
    }
    private void _lnkGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
        {
            FileName = _lnkGithub.Text,
            UseShellExecute = true
        });
    }
}
