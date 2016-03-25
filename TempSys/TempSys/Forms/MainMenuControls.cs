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
using MetroFramework.Forms;
using MetroFramework;

namespace TempSys.Forms
{
    public partial class MainMenuControls : pnlSlider
    {
        public MainMenuControls(Control owner):base(owner)
        {
            InitializeComponent();
            var theme = (((MetroForm)owner).StyleManager.Theme == MetroThemeStyle.Light) ? MetroThemeStyle.Light : MetroThemeStyle.Dark;
            list_menus.Theme = theme;
            panel_menus.Theme = theme;
        }
    }
}
