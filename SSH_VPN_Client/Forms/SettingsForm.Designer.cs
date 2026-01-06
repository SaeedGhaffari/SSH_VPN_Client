namespace SSH_VPN_Client
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            txt_ip = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txt_port = new TextBox();
            label3 = new Label();
            txt_username = new TextBox();
            label4 = new Label();
            txt_password = new TextBox();
            panel1 = new Panel();
            btn_cancel = new Button();
            btn_save = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txt_ip
            // 
            txt_ip.Location = new Point(13, 32);
            txt_ip.Name = "txt_ip";
            txt_ip.Size = new Size(242, 23);
            txt_ip.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 14);
            label1.Name = "label1";
            label1.Size = new Size(134, 15);
            label1.TabIndex = 1;
            label1.Text = "IP Address or Hostname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 67);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 3;
            label2.Text = "Port";
            // 
            // txt_port
            // 
            txt_port.Location = new Point(13, 85);
            txt_port.Name = "txt_port";
            txt_port.Size = new Size(242, 23);
            txt_port.TabIndex = 1;
            txt_port.KeyPress += txt_port_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 125);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 5;
            label3.Text = "Username";
            // 
            // txt_username
            // 
            txt_username.Location = new Point(13, 143);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(242, 23);
            txt_username.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 184);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 7;
            label4.Text = "Password";
            // 
            // txt_password
            // 
            txt_password.Location = new Point(13, 202);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(242, 23);
            txt_password.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txt_ip);
            panel1.Controls.Add(txt_password);
            panel1.Controls.Add(txt_port);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txt_username);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(272, 248);
            panel1.TabIndex = 8;
            // 
            // btn_cancel
            // 
            btn_cancel.BackColor = Color.White;
            btn_cancel.FlatStyle = FlatStyle.Flat;
            btn_cancel.Location = new Point(209, 276);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(75, 23);
            btn_cancel.TabIndex = 5;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = false;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.White;
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.Location = new Point(128, 276);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(75, 23);
            btn_save.TabIndex = 4;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // SettingsForm
            // 
            AcceptButton = btn_save;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btn_cancel;
            ClientSize = new Size(298, 315);
            Controls.Add(btn_save);
            Controls.Add(btn_cancel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SettingsForm";
            ShowInTaskbar = false;
            Text = "SettingsForm";
            Load += SettingsForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txt_ip;
        private Label label1;
        private Label label2;
        private TextBox txt_port;
        private Label label3;
        private TextBox txt_username;
        private Label label4;
        private TextBox txt_password;
        private Panel panel1;
        private Button btn_cancel;
        private Button btn_save;
    }
}