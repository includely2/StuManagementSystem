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
    public partial class FrmGrade : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        protected void SetBind()
        {
            try
            {
                sql = "select liyy_Grades.lyy_Sno as 学号,lyy_Sname as 学生姓名,lyy_Cname as 课程名称,lyy_Gscore as 分数,liyy_Grades.lyy_Cterm as 开课学期,lyy_Tname as 任课教师 from liyy_Grades,liyy_Teachers,liyy_Courses,liyy_Students where liyy_Grades.lyy_Tno = liyy_Teachers.lyy_Tno and liyy_Grades.lyy_Sno = liyy_Students.lyy_Sno and liyy_Grades.lyy_Cno = liyy_Courses.lyy_Cno";
                con.BindDataGridView(dataGView, sql);
                dataGView.Columns[0].ReadOnly = true;
                dataGView.Columns[1].ReadOnly = true;
                dataGView.Columns[2].ReadOnly = true;
                dataGView.Columns[4].ReadOnly = true;
                dataGView.Columns[5].ReadOnly = true;
                dataGView.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
        public FrmGrade()
        {
            InitializeComponent();
            SetBind();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "select lyy_Tno from liyy_Courses where lyy_Cno = '" + txtCno.Text + "'";
                ds = con.Getds(sql);
                string Tno = ds.Tables[0].Rows[0][0].ToString();
                sql = "select lyy_Cterm from liyy_Courses where lyy_Cno = '" + txtCno.Text + "'";
                ds = con.Getds(sql);
                string Cterm = ds.Tables[0].Rows[0][0].ToString();
                sql = "insert into liyy_Grades values('" + txtGscore.Text
                    + "','" + txtSno.Text
                    + "','" + Cterm
                    + "','" + txtCno.Text
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
                    string Gscore = dataGView.CurrentRow.Cells[3].Value.ToString();
                    sql = "delete from liyy_Grades where lyy_Gscore = '" + Gscore + "'";
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
            string Gscore = dataGView.CurrentRow.Cells[3].Value.ToString();
            string Sno = dataGView.CurrentRow.Cells[0].Value.ToString();
            string Cname = dataGView.CurrentRow.Cells[2].Value.ToString();
            try
            {
                sql = "select lyy_Cno from liyy_Courses where lyy_Cname = '" + Cname + "'";
                ds = con.Getds(sql);
                string Cno = ds.Tables[0].Rows[0][0].ToString();
                sql = "update liyy_Grades set lyy_Gscore = '" + Gscore
                    + "' where lyy_Cno = '" + Cno + "' and lyy_Sno = '" + Sno + "'";
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
    }
}
