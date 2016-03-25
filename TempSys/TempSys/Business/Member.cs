using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempSys.Business
{
    class Member
    {
        #region 属性
        //员工名称
        public string memberName { get; set; }
        //性别
        public string memberSex { get; set; }
        //员工地址
        public string memberAddress { get; set; }
        //员工身份证号
        public string memberId { get; set; }
        //员工手机号
        public string memberPhone { get; set; }
        //员工邮箱
        public string memberEmail { get; set; }
        //员工岗位
        public string memberWork { get; set; }
        //员工状态 
        public string memberStatus { get; set; }
        //入职日期
        public DateTime memberJoinTime { get; set; }
        //离职日期
        public DateTime memberQuitTime { get; set; }
        //批准入职日期
        public DateTime memberAgreeJoinTime { get; set; }
        //所属部门
        public string memberPartment { get; set; }

        #endregion

        //获取符合条件的员工
        public List<Member> getSelectMember(bool showQuit,string name)
        {
            string sql = "select * from Member ";
            if(name != "")
            {
                sql += "where (member_name like '" + name + "%')";
            }
            if(!showQuit)
            {
                if(name != "")
                {
                    sql += " and (member_status='在职')";
                }
                else
                {
                    sql += "where (member_status='在职')";
                }
            }
            DataTable memberTable = StaticValue.SelectTable(sql);
            List<Member> members = new List<Member>();
            foreach (DataRow objRow in memberTable.Rows)
            {
                members.Add(this.setMemeberValueForRow(objRow));
            }
            return members;
        }

        //单条员工赋值
        private Member setMemeberValueForRow(DataRow row)
        {
            Member member = new Member();
            member.memberName = row["member_name"].ToString();
            member.memberSex = row["member_sex"].ToString();
            member.memberAddress = row["member_address"].ToString();
            member.memberId = row["member_IDCard"].ToString();
            member.memberPhone = row["member_phone"].ToString();
            member.memberEmail = row["member_email"].ToString();
            member.memberWork = row["member_job"].ToString();
            member.memberStatus = row["member_status"].ToString();
            return member;
        }

    }

}
