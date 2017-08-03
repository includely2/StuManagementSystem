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
    public partial class FrmMajor : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        protected void SetBind()
        {
            try
            {
                sql = "select lyy_Mno as 专业编号,lyy_Mname as 专业名称 from liyy_Majors";
                con.BindDataGridView(dataGView,sql);
                dataGView.Columns[0].ReadOnly = true;
                dataGView.AllowUserToAddRows = false;
            }
            catch {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
        public FrmMajor()
        {
            InitializeComponent();
            SetBind();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "insert into liyy_Majors values('" + txtMno.Text + "', '" + txtMname.Text + "')";
                con.OperateData(sql);
                SetBind();
            }
            catch {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要删除该条信息吗？", "提示",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) {
                try {
                    sql = "delete from liyy_Majors where lyy_Mno = '"
                        + dataGView.CurrentRow.Cells[0].Value.ToString() + "'";
                    con.OperateData(sql);
                    SetBind();
                    MessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch{
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
            }
            
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "update liyy_Majors set lyy_Mname = '"
                    + dataGView.CurrentRow.Cells[1].Value.ToString() + "'where lyy_Mno = '"
                    + dataGView.CurrentRow.Cells[0].Value.ToString() + "'";
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
