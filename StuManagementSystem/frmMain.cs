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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 学生表输入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStudent fStudent = new FrmStudent();
            fStudent.Show();
        }

        private void 课程表输入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCourse fCourse = new FrmCourse();
            fCourse.Show();
        }

        private void 教师表输入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTeacher fTeacher = new FrmTeacher();
            fTeacher.Show();
        }

        private void 专业表输入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMajor fMajor = new FrmMajor();
            fMajor.Show();
        }

        private void 成绩表输入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGrade fGrade = new FrmGrade();
            fGrade.Show();
        }

        private void 学生成绩查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGradeSearch fgSearch = new FrmGradeSearch();
            fgSearch.Show();
        }

        private void 教师任课查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTeacherSearch ftSearch = new FrmTeacherSearch();
            ftSearch.Show();
        }

        private void 班级课程开设查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClassSearch fcSearch = new FrmClassSearch();
            fcSearch.Show();
        }

        private void 课程平均成绩统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAveGrade fag = new FrmAveGrade();
            fag.Show();
        }

        private void 学生成绩成绩统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAnnualGrade fag = new FrmAnnualGrade();
            fag.Show();
        }

        private void 学生成绩名次排定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCourseSort fcs = new FrmCourseSort();
            fcs.Show();
        }

        private void 学生所学课程及学分统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAllCourse fac = new FrmAllCourse();
            fac.Show();
        }

        private void 调用存储过程演示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProcedure1 pro1 = new FrmProcedure1();
            pro1.Show();
        }

        private void 调用存储过程演示2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProcedure2 pro2 = new FrmProcedure2();
            pro2.Show();
        }
    }
}
