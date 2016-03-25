using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempSys
{
    public partial class FormSystem : UserControl
    {
        public FormSystem()
        {
            InitializeComponent();
        }

        private void btn_member_manager_Click(object sender, EventArgs e)
        {
            MemberForm member = new MemberForm();
            if (member.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
