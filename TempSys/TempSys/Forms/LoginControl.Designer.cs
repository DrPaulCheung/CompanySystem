namespace TempSys.Forms
{
    partial class LoginControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.text_username = new MetroFramework.Controls.MetroTextBox();
            this.btn_login = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.text_password = new MetroFramework.Controls.MetroTextBox();
            this.panel_settings = new MetroFramework.Controls.MetroPanel();
            this.sys_tab = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.theme_dark = new MetroFramework.Controls.MetroRadioButton();
            this.theme_light = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.setting_flow = new System.Windows.Forms.FlowLayoutPanel();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_back = new MetroFramework.Controls.MetroLink();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_settings.SuspendLayout();
            this.sys_tab.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.Controls.Add(this.text_username);
            this.metroPanel1.Controls.Add(this.btn_login);
            this.metroPanel1.Controls.Add(this.pictureBox1);
            this.metroPanel1.Controls.Add(this.text_password);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 65);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(699, 202);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // text_username
            // 
            this.text_username.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.text_username.CustomButton.Image = null;
            this.text_username.CustomButton.Location = new System.Drawing.Point(173, 1);
            this.text_username.CustomButton.Name = "";
            this.text_username.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.text_username.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.text_username.CustomButton.TabIndex = 1;
            this.text_username.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.text_username.CustomButton.UseSelectable = true;
            this.text_username.CustomButton.Visible = false;
            this.text_username.DisplayIcon = true;
            this.text_username.Icon = global::TempSys.Properties.Resources.userinput1;
            this.text_username.Lines = new string[0];
            this.text_username.Location = new System.Drawing.Point(252, 85);
            this.text_username.MaxLength = 32767;
            this.text_username.Name = "text_username";
            this.text_username.PasswordChar = '\0';
            this.text_username.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.text_username.SelectedText = "";
            this.text_username.SelectionLength = 0;
            this.text_username.SelectionStart = 0;
            this.text_username.Size = new System.Drawing.Size(195, 23);
            this.text_username.TabIndex = 1;
            this.text_username.UseSelectable = true;
            this.text_username.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.text_username.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_login
            // 
            this.btn_login.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_login.Location = new System.Drawing.Point(311, 163);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "登录";
            this.btn_login.UseSelectable = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::TempSys.Properties.Resources.system_logo;
            this.pictureBox1.Location = new System.Drawing.Point(5, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(694, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // text_password
            // 
            this.text_password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.text_password.CustomButton.Image = null;
            this.text_password.CustomButton.Location = new System.Drawing.Point(173, 1);
            this.text_password.CustomButton.Name = "";
            this.text_password.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.text_password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.text_password.CustomButton.TabIndex = 1;
            this.text_password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.text_password.CustomButton.UseSelectable = true;
            this.text_password.CustomButton.Visible = false;
            this.text_password.DisplayIcon = true;
            this.text_password.Icon = global::TempSys.Properties.Resources.passwordinput;
            this.text_password.Lines = new string[0];
            this.text_password.Location = new System.Drawing.Point(252, 121);
            this.text_password.MaxLength = 32767;
            this.text_password.Name = "text_password";
            this.text_password.PasswordChar = '●';
            this.text_password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.text_password.SelectedText = "";
            this.text_password.SelectionLength = 0;
            this.text_password.SelectionStart = 0;
            this.text_password.Size = new System.Drawing.Size(195, 23);
            this.text_password.TabIndex = 2;
            this.text_password.UseSelectable = true;
            this.text_password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.text_password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // panel_settings
            // 
            this.panel_settings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_settings.Controls.Add(this.sys_tab);
            this.panel_settings.Controls.Add(this.panel1);
            this.panel_settings.Controls.Add(this.btn_back);
            this.panel_settings.HorizontalScrollbarBarColor = true;
            this.panel_settings.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_settings.HorizontalScrollbarSize = 10;
            this.panel_settings.Location = new System.Drawing.Point(503, 0);
            this.panel_settings.Name = "panel_settings";
            this.panel_settings.Size = new System.Drawing.Size(196, 437);
            this.panel_settings.TabIndex = 1;
            this.panel_settings.VerticalScrollbarBarColor = true;
            this.panel_settings.VerticalScrollbarHighlightOnWheel = false;
            this.panel_settings.VerticalScrollbarSize = 10;
            this.panel_settings.Visible = false;
            // 
            // sys_tab
            // 
            this.sys_tab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sys_tab.Controls.Add(this.metroTabPage1);
            this.sys_tab.Controls.Add(this.metroTabPage2);
            this.sys_tab.Location = new System.Drawing.Point(6, 48);
            this.sys_tab.Name = "sys_tab";
            this.sys_tab.SelectedIndex = 0;
            this.sys_tab.Size = new System.Drawing.Size(185, 386);
            this.sys_tab.TabIndex = 4;
            this.sys_tab.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.theme_dark);
            this.metroTabPage1.Controls.Add(this.theme_light);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.setting_flow);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Padding = new System.Windows.Forms.Padding(0, 80, 0, 0);
            this.metroTabPage1.Size = new System.Drawing.Size(177, 344);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "&主题";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // theme_dark
            // 
            this.theme_dark.AutoSize = true;
            this.theme_dark.Location = new System.Drawing.Point(85, 34);
            this.theme_dark.Name = "theme_dark";
            this.theme_dark.Size = new System.Drawing.Size(47, 15);
            this.theme_dark.TabIndex = 8;
            this.theme_dark.Text = "暗系";
            this.theme_dark.UseSelectable = true;
            this.theme_dark.CheckedChanged += new System.EventHandler(this.theme_dark_CheckedChanged);
            // 
            // theme_light
            // 
            this.theme_light.AutoSize = true;
            this.theme_light.Checked = true;
            this.theme_light.Location = new System.Drawing.Point(3, 34);
            this.theme_light.Name = "theme_light";
            this.theme_light.Size = new System.Drawing.Size(47, 15);
            this.theme_light.TabIndex = 7;
            this.theme_light.TabStop = true;
            this.theme_light.Text = "明亮";
            this.theme_light.UseSelectable = true;
            this.theme_light.CheckedChanged += new System.EventHandler(this.theme_light_CheckedChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(0, 58);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(37, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "样式";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(-2, 6);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(37, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "主题";
            // 
            // setting_flow
            // 
            this.setting_flow.BackColor = System.Drawing.Color.Transparent;
            this.setting_flow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.setting_flow.Location = new System.Drawing.Point(0, 80);
            this.setting_flow.Name = "setting_flow";
            this.setting_flow.Size = new System.Drawing.Size(177, 264);
            this.setting_flow.TabIndex = 2;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(177, 344);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "配置";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(1, 437);
            this.panel1.TabIndex = 3;
            // 
            // btn_back
            // 
            this.btn_back.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.btn_back.Image = global::TempSys.Properties.Resources.back;
            this.btn_back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_back.ImageSize = 32;
            this.btn_back.Location = new System.Drawing.Point(12, 3);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(114, 39);
            this.btn_back.TabIndex = 2;
            this.btn_back.Text = "&设置";
            this.btn_back.UseSelectable = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_settings);
            this.Controls.Add(this.metroPanel1);
            this.Name = "LoginControl";
            this.Size = new System.Drawing.Size(699, 437);
            this.Load += new System.EventHandler(this.LoginControl_Load);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_settings.ResumeLayout(false);
            this.sys_tab.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel panel_settings;
        private MetroFramework.Controls.MetroLink btn_back;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTabControl sys_tab;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.FlowLayoutPanel setting_flow;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroRadioButton theme_light;
        private MetroFramework.Controls.MetroRadioButton theme_dark;
        private MetroFramework.Controls.MetroTextBox text_password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton btn_login;
        private MetroFramework.Controls.MetroTextBox text_username;

    }
}
