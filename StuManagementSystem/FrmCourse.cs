using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StuManagementSystem
{
    public partial class FrmCourse : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        private string type;
        protected void SetBind()
        {
            try
            {
                sql = "select lyy_Cno as 课程编号,lyy_Cname as 课程名称,lyy_Cterm as 开课学期,lyy_Ctime as 学时,lyy_Ctype as 考核性质,lyy_Ccredit as 学分,lyy_Tname as 任课教师 from liyy_Teachers,liyy_Courses where liyy_Teachers.lyy_Tno = liyy_Courses.lyy_Tno";
                con.BindDataGridView(dataGView, sql);
                dataGView.Columns[0].ReadOnly = true;
                dataGView.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
        public FrmCourse()
        {
            InitializeComponent();
            SetBind();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "select lyy_Tno from liyy_Teachers where lyy_Tname = '" + txtTname.Text + "'";
                ds = con.Getds(sql);
                string Tno = ds.Tables[0].Rows[0][0].ToString();
                sql = "insert into liyy_Courses values('" + txtCno.Text
                    + "','" + txtCname.Text
                    + "','" + txtCterm.Text
                    + "','" + txtCtime.Text
                    + "','" + type
                    + "','" + txtCcredit.Text 
                    + "','" + Tno + "')";
                con.OperateData(sql);
                SetBind();
            }
            catch
            {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要删除该条信息吗？", "提示",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    string Cno = dataGView.CurrentRow.Cells[0].Value.ToString();
                    sql = "delete from liyy_Courses where lyy_Cno = '" + Cno + "'";
                    con.OperateData(sql);
                    SetBind();
                    MessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string Cno = dataGView.CurrentRow.Cells[0].Value.ToString();
            string Cname = dataGView.CurrentRow.Cells[1].Value.ToString();
            string Cterm = dataGView.CurrentRow.Cells[2].Value.ToString();
            string Ctime = dataGView.CurrentRow.Cells[3].Value.ToString();
            string Ctype = dataGView.CurrentRow.Cells[4].Value.ToString();
            string Ccredit = dataGView.CurrentRow.Cells[5].Value.ToString();
            string Tname = dataGView.CurrentRow.Cells[6].Value.ToString();
            try
            {
                sql = "select lyy_Tno from liyy_Teachers where lyy_Tname = '" + Tname + "'";
                ds = con.Getds(sql);
                string Tno = ds.Tables[0].Rows[0][0].ToString();
                sql = "update liyy_Courses set lyy_Cname = '" + Cname
                    + "',lyy_Cterm = '" + Cterm
                    + "',lyy_Ctime = '" + Ctime
                    + "',lyy_Ctype = '" + Ctype
                    + "',lyy_Ccredit = '" + Ccredit
                    + "',lyy_Tno = '" + Tno
                    + "' where lyy_Cno = '" + Cno + "'";
                con.OperateData(sql);
                SetBind();
            }
            catch
            {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rabtnTest_CheckedChanged(object sender, EventArgs e)
        {
            type = "考试";
        }

        private void rabtnCheck_CheckedChanged(object sender, EventArgs e)
        {
            type = "考查";
        }
    }
}
