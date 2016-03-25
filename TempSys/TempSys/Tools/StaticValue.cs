using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Security.Cryptography;
using XLuSharpLibrary.DbAccess;
using System.Data.SqlClient;
using MetroFramework.Controls;
using System.IO;
using MetroFramework;

namespace TempSys.Business
{
    /// <summary>全局静态数据。</summary>
    public static class StaticValue
    {
        public static string g_strNewPayId = "";

        /// <summary>处理DataTable中重复的数据。</summary>
        /// <param name="dt">需要处理的DataTable</param>
        /// <param name="colname">作为判断重复数据的字段(字段名)</param>
        /// <returns></returns>
        public static DataTable GetDistinctTable(DataTable dt, string colname)
        {
            DataView dv = dt.DefaultView;
            DataTable dtCardNo = dv.ToTable(true, colname);
            DataTable dtPoint = new DataTable();
            dtPoint = dv.ToTable();
            dtPoint.Clear();
            for (int i = 0; i < dtCardNo.Rows.Count; i++)
            {
                DataRow dr = dt.Select(colname + "='" + dtCardNo.Rows[i][0].ToString() + "'")[0];
                dtPoint.Rows.Add(dr.ItemArray);
            }
            return dtPoint;
        }

        /// <summary>查询数据。</summary>
        /// <param name="sql">查询SQL</param>
        /// <returns></returns>
        public static DataTable SelectTable(string sql)
        {
            DataTable objDataTable = new DataTable();
            new SQLHelper().ExecuteSql(sql, out objDataTable);
            return objDataTable;
        }

        /// <summary>为 DataGridView 添加行号。</summary>
        public static void ShowRows_DataGridView_RowPostPaint(DataGridView dgv, object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, dgv.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dgv.RowHeadersDefaultCellStyle.Font, rectangle, dgv.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }
        //打印报表 
        public static void printDataGrid(MetroGrid grid)
        {
            
        }


        ///<summary> 导出报表 </summary>
        public static bool exportExcel(MetroGrid grid)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Excel files (*.xls)|*.xls";
            saveDialog.FilterIndex = 0;
            saveDialog.RestoreDirectory = true;
            saveDialog.CreatePrompt = true;
            saveDialog.Title = "导出Excel文件到";
            saveDialog.ShowDialog();
            if (saveDialog.FileName == "")
                return false;

            Stream stream;
            stream = saveDialog.OpenFile();
            StreamWriter sw = new StreamWriter(stream,System.Text.Encoding.GetEncoding("gb2312"));
            string str = "";
            try
            {
                //字段
                for (int i = 0; i < grid.ColumnCount; i++)
                {
                    if(i > 0)
                    {
                        str += "\t";
                    }
                    str += grid.Columns[i].HeaderText;
                }
                sw.WriteLine(str);
                //内容
                for (int i = 0; i < grid.Rows.Count; i++ )
                {
                    string tempstr = "";
                    for(int j = 0 ; j < grid.Columns.Count;j++)
                    {
                        if (j > 0) tempstr += "\t";
                        if(grid.Rows[i].Cells[j].Value != null)
                        {
                            tempstr += grid.Rows[i].Cells[j].Value.ToString();
                        }
                        else
                        {
                            tempstr += "";
                        }
                    }
                    sw.WriteLine(tempstr);
                }
                sw.Close();
                stream.Close();
                return true;
            }
            catch(Exception err)
            {
                return false;
            }

            finally
            {
                sw.Close();
                stream.Close();
            }

        }

    }
}
