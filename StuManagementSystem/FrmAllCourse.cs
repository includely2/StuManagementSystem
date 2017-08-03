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
    public partial class FrmAllCourse : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        public FrmAllCourse()
        {
            InitializeComponent();
            txtScreditget.ReadOnly = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "select lyy_Screditget from liyy_Students where lyy_Sno = '" + txtSno.Text + "'";
                ds = con.Getds(sql);
                txtScreditget.Text = ds.Tables[0].Rows[0][0].ToString();
                sql = "select liyy_Grades.lyy_Cno as 课程编号,lyy_Cname as 课程名称,lyy_Gscore as 分数,liyy_Grades.lyy_Cterm as 开课学期 from liyy_Grades,liyy_Courses where liyy_Grades.lyy_Cno = liyy_Courses.lyy_Cno and liyy_Grades.lyy_Sno = '" + txtSno.Text + "'";
                con.BindDataGridView(dataGView, sql);
                dataGView.Columns[0].ReadOnly = true;
                dataGView.Columns[1].ReadOnly = true;
                dataGView.Columns[2].ReadOnly = true;
                dataGView.Columns[3].ReadOnly = true;
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
