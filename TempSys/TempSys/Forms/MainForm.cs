using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempSys.Forms
{
    public partial class SystemForm : MetroForm
    {
        private LoginControl setControl;
        private MainMenuControls sysMenus;
        public SystemForm()
        {
            InitializeComponent();
            this.StyleManager = styMain;
            this.WindowState = FormWindowState.Maximized;
            //初始化登录主界面
            setControl = new LoginControl(this);
            //监听设置界面显示隐藏的回调
            setControl.hideEvent += onSettingToggle;
            //监听设置界面关闭时的回调
            setControl.Closed += onSettingClosed;
            setControl.swipe(true);

        }

        #region 登录设置界面相关
        private void btn_setting_Click(object sender, EventArgs e)
        {
            btn_setting.Visible = false;
            sys_close.Visible = false;
            setControl.showSettings();
        }

        //设置界面设置标签隐藏显示
        public void onSettingToggle(object sender, EventArgs e)
        {
            btn_setting.Visible = true;
            sys_close.Visible = true;
        }

        //关闭显示界面
        public void onSettingClosed(object sender, EventArgs e)
        {
            btn_setting.Visible = false;
            sysMenus = new MainMenuControls(this);
            sysMenus.swipe(true);
        }

        #endregion


        //退出系统
        private void sys_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
