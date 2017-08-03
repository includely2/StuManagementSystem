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
    public partial class FrmStudent : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        private string sex;
        protected void SetBind() {
            try
            {
                sql = "select lyy_Sno as 学号,lyy_Sname as 姓名,lyy_Ssex as 性别,lyy_Sage as 年龄,lyy_Mname as 专业,lyy_Sclass as 班级,lyy_Sbirthplace as 出生地,lyy_Splace as 地区信息,lyy_Screditget as 已修学分 from liyy_Students,liyy_Majors where liyy_Students.lyy_Mno = liyy_Majors.lyy_Mno";
                ds = con.BindDataGridView(dataGView, sql);
                dataGView.Columns[0].ReadOnly = true;
                dataGView.Columns[8].ReadOnly = true;
                dataGView.AllowUserToAddRows = false;
            }
            catch {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
        protected void ComBoxBind() {
            try{
                cmbMajor.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbMajor.Items.Clear();
                ds = con.Getds("select lyy_Mno,lyy_Mname from liyy_Majors");
                cmbMajor.DisplayMember = "lyy_Mname";
                cmbMajor.ValueMember = "lyy_Mno";
                cmbMajor.DataSource = ds.Tables[0];
                cmbMajor.SelectedIndex = 0;
            }
            catch (Exception) {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
        public FrmStudent()
        {
            InitializeComponent();
            ComBoxBind();
            SetBind();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "insert into liyy_Students values('" + txtSno.Text 
                    + "','" + txtSname.Text 
                    + "','" + sex 
                    + "','" + txtSage.Text 
                    + "','" + txtSclass.Text 
                    + "','" + cmbMajor.SelectedValue.ToString() 
                    + "','" + txtSbirthplace.Text 
                    + "','" + txtSplace.Text + "',0)";
                con.OperateData(sql);
                SetBind();
            }
            catch {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void rabtnM_CheckedChanged(object sender, EventArgs e)
        {
            sex = "男";
        }

        private void rabtnF_CheckedChanged(object sender, EventArgs e)
        {
            sex = "女";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要删除该条信息吗？", "提示",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    string Sno = dataGView.CurrentRow.Cells[0].Value.ToString();
                    sql = "delete from liyy_Students where lyy_Sno = '" + Sno + "'";
                    con.OperateData(sql);
                    SetBind();
                    MessageBox.Show("删除成功！","提示",MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string Sno = dataGView.CurrentRow.Cells[0].Value.ToString();
            string Sname = dataGView.CurrentRow.Cells[1].Value.ToString();
            string Ssex = dataGView.CurrentRow.Cells[2].Value.ToString();
            string Sage = dataGView.CurrentRow.Cells[3].Value.ToString();
            string Mname = dataGView.CurrentRow.Cells[4].Value.ToString();
            string Sclass = dataGView.CurrentRow.Cells[5].Value.ToString();
            string Sbirthplace = dataGView.CurrentRow.Cells[6].Value.ToString();
            string Splace = dataGView.CurrentRow.Cells[7].Value.ToString();
            try
            {
                sql = "select lyy_Mno from liyy_Majors where lyy_Mname = '" + Mname + "'";
                ds = con.Getds(sql);
                string Mno = ds.Tables[0].Rows[0][0].ToString();
                sql = "update liyy_Students set lyy_Sname = '" +  Sname
                    + "',lyy_Ssex = '" + Ssex 
                    + "',lyy_Sage = '" + Sage
                    + "',lyy_Sclass = '" + Sclass
                    + "',lyy_Mno = '" + Mno
                    + "',lyy_Sbirthplace = '" + Sbirthplace
                    + "',lyy_Splace = '" + Splace 
                    + "' where lyy_Sno = '" + Sno + "'";
                con.OperateData(sql);
                SetBind();
            }
            catch {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
        }
    }
}
