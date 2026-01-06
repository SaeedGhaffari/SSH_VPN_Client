namespace SSH_VPN_Client
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            if (disposing && _sshClient.IsConnected)
            {
                Disconnect(true);
            }

            base.Dispose(disposing);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                HideMe();
            }

            base.OnFormClosing(e);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            _btnConnect = new Button();
            lblStatus = new Label();
            timer_check_status = new System.Windows.Forms.Timer(components);
            notifyIcon1 = new NotifyIcon(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            _mnuHideShow = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            _mnuNotifyConnect = new ToolStripMenuItem();
            _mnuNotifyDisconnect = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripSeparator();
            _mnuNotifySettings = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripSeparator();
            _mnuNotifyExit = new ToolStripMenuItem();
            panel1 = new Panel();
            menuStrip1 = new MenuStrip();
            _mnuFile = new ToolStripMenuItem();
            _mnuSettings = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            _mnuExit = new ToolStripMenuItem();
            _mnuOptions = new ToolStripMenuItem();
            _mnuSetSystemProxy = new ToolStripMenuItem();
            _mnuHelp = new ToolStripMenuItem();
            _mnuAbout = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            _labProxyAddress = new ToolStripStatusLabel();
            contextMenuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // _btnConnect
            // 
            _btnConnect.Location = new Point(13, 61);
            _btnConnect.Name = "_btnConnect";
            _btnConnect.Size = new Size(265, 85);
            _btnConnect.TabIndex = 0;
            _btnConnect.Text = "Connect";
            _btnConnect.UseVisualStyleBackColor = true;
            _btnConnect.Click += _btnConnect_Click;
            // 
            // lblStatus
            // 
            lblStatus.BackColor = Color.FromArgb(255, 192, 192);
            lblStatus.Location = new Point(13, 15);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(265, 34);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "Disconnected";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // notifyIcon1
            // 
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "SSH VPN";
            notifyIcon1.Visible = true;
            notifyIcon1.DoubleClick += _mnuHideShow_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { _mnuHideShow, toolStripMenuItem3, _mnuNotifyConnect, _mnuNotifyDisconnect, toolStripMenuItem5, _mnuNotifySettings, toolStripMenuItem4, _mnuNotifyExit });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(143, 132);
            // 
            // _mnuHideShow
            // 
            _mnuHideShow.Name = "_mnuHideShow";
            _mnuHideShow.Size = new Size(142, 22);
            _mnuHideShow.Text = "Hide\\Show";
            _mnuHideShow.Click += _mnuHideShow_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(139, 6);
            // 
            // _mnuNotifyConnect
            // 
            _mnuNotifyConnect.Name = "_mnuNotifyConnect";
            _mnuNotifyConnect.Size = new Size(142, 22);
            _mnuNotifyConnect.Text = "Connect...";
            // 
            // _mnuNotifyDisconnect
            // 
            _mnuNotifyDisconnect.Name = "_mnuNotifyDisconnect";
            _mnuNotifyDisconnect.Size = new Size(142, 22);
            _mnuNotifyDisconnect.Text = "Disconnect...";
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(139, 6);
            // 
            // _mnuNotifySettings
            // 
            _mnuNotifySettings.Name = "_mnuNotifySettings";
            _mnuNotifySettings.Size = new Size(142, 22);
            _mnuNotifySettings.Text = "Settings...";
            _mnuNotifySettings.Click += _mnuSettings_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(139, 6);
            // 
            // _mnuNotifyExit
            // 
            _mnuNotifyExit.Name = "_mnuNotifyExit";
            _mnuNotifyExit.Size = new Size(142, 22);
            _mnuNotifyExit.Text = "Exit...";
            _mnuNotifyExit.Click += _mnuExit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblStatus);
            panel1.Controls.Add(_btnConnect);
            panel1.Location = new Point(12, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(293, 161);
            panel1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { _mnuFile, _mnuOptions, _mnuHelp });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(317, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // _mnuFile
            // 
            _mnuFile.DropDownItems.AddRange(new ToolStripItem[] { _mnuSettings, toolStripMenuItem1, _mnuExit });
            _mnuFile.Name = "_mnuFile";
            _mnuFile.Size = new Size(37, 20);
            _mnuFile.Text = "&File";
            // 
            // _mnuSettings
            // 
            _mnuSettings.Name = "_mnuSettings";
            _mnuSettings.Size = new Size(125, 22);
            _mnuSettings.Text = "&Settings...";
            _mnuSettings.Click += _mnuSettings_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(122, 6);
            // 
            // _mnuExit
            // 
            _mnuExit.Name = "_mnuExit";
            _mnuExit.Size = new Size(125, 22);
            _mnuExit.Text = "E&xit...";
            _mnuExit.Click += _mnuExit_Click;
            // 
            // _mnuOptions
            // 
            _mnuOptions.DropDownItems.AddRange(new ToolStripItem[] { _mnuSetSystemProxy });
            _mnuOptions.Name = "_mnuOptions";
            _mnuOptions.Size = new Size(61, 20);
            _mnuOptions.Text = "Options";
            // 
            // _mnuSetSystemProxy
            // 
            _mnuSetSystemProxy.CheckOnClick = true;
            _mnuSetSystemProxy.Name = "_mnuSetSystemProxy";
            _mnuSetSystemProxy.Size = new Size(164, 22);
            _mnuSetSystemProxy.Text = "Set System Proxy";
            _mnuSetSystemProxy.CheckedChanged += _mnuSetSystemProxy_CheckedChanged;
            // 
            // _mnuHelp
            // 
            _mnuHelp.DropDownItems.AddRange(new ToolStripItem[] { _mnuAbout });
            _mnuHelp.Name = "_mnuHelp";
            _mnuHelp.Size = new Size(44, 20);
            _mnuHelp.Text = "Help";
            // 
            // _mnuAbout
            // 
            _mnuAbout.Name = "_mnuAbout";
            _mnuAbout.Size = new Size(107, 22);
            _mnuAbout.Text = "About";
            _mnuAbout.Click += _mnuAbout_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, _labProxyAddress });
            statusStrip1.Location = new Point(0, 207);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(317, 22);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(88, 17);
            toolStripStatusLabel1.Text = "Proxy Address: ";
            // 
            // _labProxyAddress
            // 
            _labProxyAddress.Name = "_labProxyAddress";
            _labProxyAddress.Size = new Size(22, 17);
            _labProxyAddress.Text = "---";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 229);
            Controls.Add(statusStrip1);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "frmMain";
            Text = "SSH VPN Client";
            Load += frmMain_Load;
            Resize += frmMain_Resize;
            contextMenuStrip1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button _btnConnect;
        private Label lblStatus;
        private System.Windows.Forms.Timer timer_check_status;
        private NotifyIcon notifyIcon1;
        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem _mnuFile;
        private ToolStripMenuItem _mnuSettings;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem _mnuExit;
        private ToolStripMenuItem _mnuHelp;
        private ToolStripMenuItem _mnuOptions;
        private ToolStripMenuItem _mnuSetSystemProxy;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel _labProxyAddress;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem _mnuHideShow;
        private ToolStripMenuItem _mnuNotifyExit;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem _mnuNotifySettings;
        private ToolStripSeparator toolStripMenuItem4;
        private ToolStripMenuItem _mnuNotifyConnect;
        private ToolStripMenuItem _mnuNotifyDisconnect;
        private ToolStripSeparator toolStripMenuItem5;
        private ToolStripMenuItem _mnuAbout;
    }
}
