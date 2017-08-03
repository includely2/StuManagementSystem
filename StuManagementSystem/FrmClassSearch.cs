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
    public partial class FrmClassSearch : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        protected void ComBoxBind()
        {
            try
            {
                cmbMajor.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbMajor.Items.Clear();
                ds = con.Getds("select lyy_Mno,lyy_Mname from liyy_Majors");
                cmbMajor.DisplayMember = "lyy_Mname";
                cmbMajor.ValueMember = "lyy_Mno";
                cmbMajor.DataSource = ds.Tables[0];
                cmbMajor.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
        public FrmClassSearch()
        {
            InitializeComponent();
            ComBoxBind();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "select distinct liyy_Courses.lyy_Cno as 课程编号,lyy_Cname as 课程名称,liyy_Courses.lyy_Cterm as 开课学期,lyy_Ctime as 学时,lyy_Ctype as 考核性质,lyy_Ccredit as 学分 from liyy_Students, liyy_Courses, liyy_Grades where liyy_Grades.lyy_Sno = liyy_Students.lyy_Sno and liyy_Courses.lyy_Cno = liyy_Grades.lyy_Cno and liyy_Students.lyy_Mno = '" + cmbMajor.SelectedValue.ToString() + "' and liyy_Students.lyy_Sclass = '" + txtSclass.Text + "'";
                con.BindDataGridView(dataGView, sql);
                dataGView.Columns[0].ReadOnly = true;
                dataGView.Columns[1].ReadOnly = true;
                dataGView.Columns[2].ReadOnly = true;
                dataGView.Columns[3].ReadOnly = true;
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
