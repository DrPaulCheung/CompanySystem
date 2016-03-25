using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework;
using MetroFramework.Forms;
using TempSys.Business;
using Transitions;

namespace TempSys.Forms
{
    public partial class LoginControl : pnlSlider
    {
        public event EventHandler hideEvent;
        private Control parentForm = null;
        public LoginControl(Control owner) : base(owner)
        {
            InitializeComponent();
            parentForm = owner; 
            panel_settings.Enabled = false;
            panel_settings.Location = new Point(parentForm.Width,panel_settings.Location.Y);
            //初始化样式
            for(int i = 3 ; i < 13; i++)
            {
                MetroTile tile = new MetroTile();
                tile.Size = new Size(30,30);
                tile.Tag = i;
                tile.Style = (MetroColorStyle)i;
                tile.Click += changeStyle;
                setting_flow.Controls.Add(tile);
            }
        }


        public void showSettings()
        {
            panel_settings.Visible = true;
            panel_settings.Enabled = true;
            TransitionAnimationFac.swipIn(panel_settings,100,parentForm.Width - panel_settings.Width);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            panel_settings.Enabled = false;
            TransitionAnimationFac.swipOut(panel_settings, 100,  parentForm.Width );
            hideEvent(this,e);
        }

        private void changeStyle(object sender, EventArgs e)
        {
            MetroTile tile = (MetroTile)sender;
            ((MetroForm)parentForm).StyleManager.Style = (MetroColorStyle)(tile.Tag);
        }

        private void theme_light_CheckedChanged(object sender, EventArgs e)
        {
            if(theme_light.Checked)
            {
                 ((MetroForm)parentForm).StyleManager.Theme = MetroThemeStyle.Light;
            }
        }

        private void theme_dark_CheckedChanged(object sender, EventArgs e)
        {
            if (theme_dark.Checked)
            {
                ((MetroForm)parentForm).StyleManager.Theme = MetroThemeStyle.Dark;
            }
        }

        //登录账户
        private void btn_login_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.UserName = this.text_username.Text;
            user.PassWord = this.text_password.Text;
            if (user.isExistsUser())
            {
                this.swipe(false);
            }
            else
            {
                MetroMessageBox.Show(this, "用户名或者密码错误", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoginControl_Load(object sender, EventArgs e)
        {
            text_username.Focus();
        }

    }
}
