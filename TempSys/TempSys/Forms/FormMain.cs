using MetroFramework.Controls;
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

namespace TempSys
{
    public partial class MainForm : MetroForm
    {
        private MetroTile currentTile;
        private MetroTile lastTile;
        public MainForm()
        {
            InitializeComponent();
            var systemWindow = new FormSystem();
            systemWindow.Location = new Point(19, 19);
            FormBorderStyle = FormBorderStyle.None;

            this.mainPannel.Controls.Add(systemWindow);
            currentTile = this.btn_home;
            lastTile = currentTile;

        }

        private void menuMouseOver (object sender, MouseEventArgs e)
        {
            var btn = (MetroTile)sender;
            if(btn != currentTile)
            {
                btn.Style = MetroFramework.MetroColorStyle.Orange;
            }
        }

        private void menuMouseOut(object sender, EventArgs e)
        {
            var btn = (MetroTile)sender;
            if (btn != currentTile)
            {
                btn.Style = MetroFramework.MetroColorStyle.Teal;
            }
        }


    }
}
