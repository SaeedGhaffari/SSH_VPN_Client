namespace SSH_VPN_Client
{
    partial class frmAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            _picAbout = new PictureBox();
            panel1 = new Panel();
            label2 = new Label();
            _labAbout = new Label();
            _lnkGithub = new LinkLabel();
            _btnClose = new Button();
            panel2 = new Panel();
            _picGithub = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)_picAbout).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_picGithub).BeginInit();
            SuspendLayout();
            // 
            // _picAbout
            // 
            _picAbout.Image = Properties.Resources.ssh_proxy;
            _picAbout.Location = new Point(15, 14);
            _picAbout.Name = "_picAbout";
            _picAbout.Size = new Size(64, 64);
            _picAbout.SizeMode = PictureBoxSizeMode.StretchImage;
            _picAbout.TabIndex = 0;
            _picAbout.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(_labAbout);
            panel1.Controls.Add(_picAbout);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(376, 178);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(85, 15);
            label2.Name = "label2";
            label2.Size = new Size(127, 21);
            label2.TabIndex = 2;
            label2.Text = "SSH VPN Client";
            // 
            // _labAbout
            // 
            _labAbout.Location = new Point(85, 46);
            _labAbout.Name = "_labAbout";
            _labAbout.Size = new Size(268, 118);
            _labAbout.TabIndex = 1;
            // 
            // _lnkGithub
            // 
            _lnkGithub.AccessibleRole = AccessibleRole.SplitButton;
            _lnkGithub.AutoSize = true;
            _lnkGithub.Location = new Point(60, 19);
            _lnkGithub.Name = "_lnkGithub";
            _lnkGithub.Size = new Size(280, 15);
            _lnkGithub.TabIndex = 3;
            _lnkGithub.TabStop = true;
            _lnkGithub.Text = "https://github.com/SaeedGhaffari/SHH_VPN_Client";
            _lnkGithub.LinkClicked += _lnkGithub_LinkClicked;
            // 
            // _btnClose
            // 
            _btnClose.Location = new Point(313, 270);
            _btnClose.Name = "_btnClose";
            _btnClose.Size = new Size(75, 23);
            _btnClose.TabIndex = 2;
            _btnClose.Text = "Close";
            _btnClose.UseVisualStyleBackColor = true;
            _btnClose.Click += _btnClose_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(_picGithub);
            panel2.Controls.Add(_lnkGithub);
            panel2.Location = new Point(12, 200);
            panel2.Name = "panel2";
            panel2.Size = new Size(376, 60);
            panel2.TabIndex = 4;
            // 
            // _picGithub
            // 
            _picGithub.Image = Properties.Resources.github;
            _picGithub.Location = new Point(10, 10);
            _picGithub.Name = "_picGithub";
            _picGithub.Size = new Size(40, 40);
            _picGithub.SizeMode = PictureBoxSizeMode.StretchImage;
            _picGithub.TabIndex = 5;
            _picGithub.TabStop = false;
            // 
            // frmAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = _btnClose;
            ClientSize = new Size(400, 305);
            Controls.Add(panel2);
            Controls.Add(_btnClose);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAbout";
            ShowInTaskbar = false;
            Text = "About";
            Load += frmAbout_Load;
            ((System.ComponentModel.ISupportInitialize)_picAbout).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_picGithub).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox _picAbout;
        private Panel panel1;
        private Button _btnClose;
        private Label _labAbout;
        private LinkLabel _lnkGithub;
        private Label label2;
        private Panel panel2;
        private PictureBox _picGithub;
    }
}