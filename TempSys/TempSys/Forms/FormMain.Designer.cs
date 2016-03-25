namespace TempSys
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.style = new MetroFramework.Components.MetroStyleManager(this.components);
            this.menuPannel = new MetroFramework.Controls.MetroPanel();
            this.btn_personal = new MetroFramework.Controls.MetroTile();
            this.btn_opeLog = new MetroFramework.Controls.MetroTile();
            this.btn_signLog = new MetroFramework.Controls.MetroTile();
            this.btn_message = new MetroFramework.Controls.MetroTile();
            this.btn_home = new MetroFramework.Controls.MetroTile();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.mainPannel = new MetroFramework.Controls.MetroPanel();
            this.pic_user = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.style)).BeginInit();
            this.menuPannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_user)).BeginInit();
            this.SuspendLayout();
            // 
            // style
            // 
            this.style.Owner = null;
            // 
            // menuPannel
            // 
            this.menuPannel.Controls.Add(this.btn_personal);
            this.menuPannel.Controls.Add(this.btn_opeLog);
            this.menuPannel.Controls.Add(this.btn_signLog);
            this.menuPannel.Controls.Add(this.btn_message);
            this.menuPannel.Controls.Add(this.btn_home);
            this.menuPannel.HorizontalScrollbarBarColor = true;
            this.menuPannel.HorizontalScrollbarHighlightOnWheel = false;
            this.menuPannel.HorizontalScrollbarSize = 12;
            this.menuPannel.Location = new System.Drawing.Point(33, 126);
            this.menuPannel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.menuPannel.Name = "menuPannel";
            this.menuPannel.Size = new System.Drawing.Size(181, 396);
            this.menuPannel.Style = MetroFramework.MetroColorStyle.Orange;
            this.menuPannel.TabIndex = 7;
            this.menuPannel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.menuPannel.UseCustomBackColor = true;
            this.menuPannel.VerticalScrollbarBarColor = true;
            this.menuPannel.VerticalScrollbarHighlightOnWheel = false;
            this.menuPannel.VerticalScrollbarSize = 13;
            // 
            // btn_personal
            // 
            this.btn_personal.ActiveControl = null;
            this.btn_personal.Location = new System.Drawing.Point(1, 279);
            this.btn_personal.Name = "btn_personal";
            this.btn_personal.Size = new System.Drawing.Size(173, 51);
            this.btn_personal.Style = MetroFramework.MetroColorStyle.Teal;
            this.btn_personal.TabIndex = 6;
            this.btn_personal.Text = "个人信息";
            this.btn_personal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_personal.UseSelectable = true;
            this.btn_personal.MouseLeave += new System.EventHandler(this.menuMouseOut);
            this.btn_personal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuMouseOver);
            // 
            // btn_opeLog
            // 
            this.btn_opeLog.ActiveControl = null;
            this.btn_opeLog.Location = new System.Drawing.Point(1, 207);
            this.btn_opeLog.Name = "btn_opeLog";
            this.btn_opeLog.Size = new System.Drawing.Size(173, 51);
            this.btn_opeLog.Style = MetroFramework.MetroColorStyle.Teal;
            this.btn_opeLog.TabIndex = 5;
            this.btn_opeLog.Text = "操作日志";
            this.btn_opeLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_opeLog.UseSelectable = true;
            this.btn_opeLog.MouseLeave += new System.EventHandler(this.menuMouseOut);
            this.btn_opeLog.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuMouseOver);
            // 
            // btn_signLog
            // 
            this.btn_signLog.ActiveControl = null;
            this.btn_signLog.Location = new System.Drawing.Point(1, 138);
            this.btn_signLog.Name = "btn_signLog";
            this.btn_signLog.Size = new System.Drawing.Size(173, 51);
            this.btn_signLog.Style = MetroFramework.MetroColorStyle.Teal;
            this.btn_signLog.TabIndex = 4;
            this.btn_signLog.Text = "登录日志 ";
            this.btn_signLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_signLog.UseSelectable = true;
            this.btn_signLog.MouseLeave += new System.EventHandler(this.menuMouseOut);
            this.btn_signLog.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuMouseOver);
            // 
            // btn_message
            // 
            this.btn_message.ActiveControl = null;
            this.btn_message.AllowDrop = true;
            this.btn_message.Location = new System.Drawing.Point(1, 64);
            this.btn_message.Name = "btn_message";
            this.btn_message.Size = new System.Drawing.Size(172, 53);
            this.btn_message.Style = MetroFramework.MetroColorStyle.Teal;
            this.btn_message.TabIndex = 3;
            this.btn_message.Text = "我的消息";
            this.btn_message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_message.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_message.UseSelectable = true;
            this.btn_message.MouseLeave += new System.EventHandler(this.menuMouseOut);
            this.btn_message.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuMouseOver);
            // 
            // btn_home
            // 
            this.btn_home.ActiveControl = null;
            this.btn_home.Location = new System.Drawing.Point(1, 2);
            this.btn_home.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(172, 51);
            this.btn_home.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_home.TabIndex = 2;
            this.btn_home.Text = "系统管理";
            this.btn_home.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_home.UseSelectable = true;
            this.btn_home.MouseLeave += new System.EventHandler(this.menuMouseOut);
            this.btn_home.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuMouseOver);
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Enabled = false;
            this.metroDateTime1.FontWeight = MetroFramework.MetroDateTimeWeight.Bold;
            this.metroDateTime1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.metroDateTime1.Location = new System.Drawing.Point(804, 43);
            this.metroDateTime1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(240, 29);
            this.metroDateTime1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroDateTime1.TabIndex = 2;
            this.metroDateTime1.UseStyleColors = true;
            // 
            // mainPannel
            // 
            this.mainPannel.HorizontalScrollbarBarColor = true;
            this.mainPannel.HorizontalScrollbarHighlightOnWheel = false;
            this.mainPannel.HorizontalScrollbarSize = 10;
            this.mainPannel.Location = new System.Drawing.Point(235, 123);
            this.mainPannel.Name = "mainPannel";
            this.mainPannel.Size = new System.Drawing.Size(814, 396);
            this.mainPannel.TabIndex = 9;
            this.mainPannel.VerticalScrollbarBarColor = true;
            this.mainPannel.VerticalScrollbarHighlightOnWheel = false;
            this.mainPannel.VerticalScrollbarSize = 10;
            // 
            // pic_user
            // 
            this.pic_user.Image = global::TempSys.Properties.Resources.logo;
            this.pic_user.Location = new System.Drawing.Point(77, 34);
            this.pic_user.Name = "pic_user";
            this.pic_user.Size = new System.Drawing.Size(76, 72);
            this.pic_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_user.TabIndex = 8;
            this.pic_user.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 585);
            this.Controls.Add(this.mainPannel);
            this.Controls.Add(this.pic_user);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.menuPannel);
            this.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(27, 70, 27, 23);
            this.Resizable = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.style)).EndInit();
            this.menuPannel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_user)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager style;
        private MetroFramework.Controls.MetroPanel menuPannel;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroTile btn_home;
        private System.Windows.Forms.PictureBox pic_user;
        private MetroFramework.Controls.MetroTile btn_message;
        private MetroFramework.Controls.MetroTile btn_signLog;
        private MetroFramework.Controls.MetroTile btn_opeLog;
        private MetroFramework.Controls.MetroTile btn_personal;
        private MetroFramework.Controls.MetroPanel mainPannel;
    }
}