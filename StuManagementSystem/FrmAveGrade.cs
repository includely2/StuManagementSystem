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
    public partial class FrmAveGrade : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        public FrmAveGrade()
        {
            InitializeComponent();
            txtCname.ReadOnly = true;
            txtAvgGrade.ReadOnly = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "select lyy_Cname from liyy_Courses where lyy_Cno = '" + txtCno.Text + "'";
                ds = con.Getds(sql);
                txtCname.Text = ds.Tables[0].Rows[0][0].ToString();
                sql = "select avg(lyy_Gscore) from liyy_Grades where lyy_Cno = '" + txtCno.Text + "'";
                ds = con.Getds(sql);
                txtAvgGrade.Text = ds.Tables[0].Rows[0][0].ToString();
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
