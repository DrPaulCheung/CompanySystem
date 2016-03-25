using MetroFramework;
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
using TempSys.Business;

namespace TempSys
{
    public partial class MemberForm : MetroForm
    {
        public MemberForm()
        {
            InitializeComponent();
            //初始化数据
            this.updateData();
        }
        private void changeStyle()
        {
            var m = new Random();
            int next = m.Next(0, 13);
            metroStyleManager.Style = (MetroColorStyle)next;
        }
        //初始化变更员工数据
        private void updateData()
        {
            bool beShowQuitMember = this.checkbox_showquit.Checked;
            //条件查找
            string name = this.text_serarch.Text;
            List<Member> allMember = new Member().getSelectMember(beShowQuitMember,name);
            this.grid_members.AutoGenerateColumns = false;
            this.grid_members.Rows.Clear();
            foreach(Member member in allMember)
            {
                this.grid_members.Rows.Add(new object[] {member.memberName,member.memberSex,member.memberAddress,
                member.memberId,member.memberPhone,member.memberEmail,member.memberWork,member.memberStatus} );
            }
        }

        //显示或者隐藏已离职员工
        private void checkbox_showquit_CheckedChanged(object sender, EventArgs e)
        {
            this.updateData();
        }

        private void btn_findMember_Click(object sender, EventArgs e)
        {
            this.updateData();
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            var success = StaticValue.exportExcel(this.grid_members);
            if(success)
                MetroMessageBox.Show(this, "导出文件成功", "导出成功 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MetroMessageBox.Show(this, "导出文件失败", "导出失败 ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            StaticValue.printDataGrid(this.grid_members);
        }

        private void btn_addMember_Click(object sender, EventArgs e)
        {
            FormAddMember addMembe = new FormAddMember();
            addMembe.ShowDialog();
        }

    }
}
