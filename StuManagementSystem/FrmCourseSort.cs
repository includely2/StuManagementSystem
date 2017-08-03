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
    public partial class FrmCourseSort : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        public FrmCourseSort()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "select lyy_Cname as 课程名称,liyy_Grades.lyy_Sno as 学号,lyy_Sname as 姓名,lyy_Gscore as 分数 from liyy_Grades,liyy_Courses,liyy_Students where liyy_Grades.lyy_Cno = liyy_Courses.lyy_Cno and liyy_Grades.lyy_Cno = '" + txtCno.Text + "' and liyy_Grades.lyy_Sno = liyy_Students.lyy_Sno order by lyy_Gscore desc";
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
