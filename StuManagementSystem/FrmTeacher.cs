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
    public partial class FrmTeacher : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        private string sex;
        protected void SetBind()
        {
            try
            {
                sql = "select lyy_Tno as 教师编号,lyy_Tname as 姓名,lyy_Tsex as 性别,lyy_Tage as 年龄,lyy_Trank as 职称,lyy_Tphone as 联系电话 from liyy_Teachers";
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
        public FrmTeacher()
        {
            InitializeComponent();
            SetBind();
        }

        private void rabtnM_CheckedChanged(object sender, EventArgs e)
        {
            sex = "男";
        }

        private void rabtnF_CheckedChanged(object sender, EventArgs e)
        {
            sex = "女";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "insert into liyy_Teachers values('" + txtTno.Text
                    + "','" + txtTname.Text
                    + "','" + sex
                    + "','" + txtTage.Text
                    + "','" + txtTrank.Text
                    + "','" + txtTphone.Text
                    + "')";
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
                    string Tno = dataGView.CurrentRow.Cells[0].Value.ToString();
                    sql = "delete from liyy_Teachers where lyy_Tno = '" + Tno + "'";
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
            string Tno = dataGView.CurrentRow.Cells[0].Value.ToString();
            string Tname = dataGView.CurrentRow.Cells[1].Value.ToString();
            string Tsex = dataGView.CurrentRow.Cells[2].Value.ToString();
            string Tage = dataGView.CurrentRow.Cells[3].Value.ToString();
            string Trank = dataGView.CurrentRow.Cells[4].Value.ToString();
            string Tphone = dataGView.CurrentRow.Cells[5].Value.ToString();
            try
            {
                sql = "update liyy_Teachers set lyy_Tname = '" + Tname
                    + "',lyy_Tsex = '" + Tsex
                    + "',lyy_Tage = '" + Tage
                    + "',lyy_Trank = '" + Trank
                    + "',lyy_Tphone = '" + Tphone
                    + "' where lyy_Tno = '" + Tno + "'";
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
