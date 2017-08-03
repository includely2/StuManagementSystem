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
    public partial class FrmProcedure1 : Form
    {
        public FrmProcedure1()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "exec delete_student '" + txtYear.Text + "'";
                sqlConnect conn = new sqlConnect();
                int i = conn.OperateData(sql);
                if (i > 0)
                    MessageBox.Show("已删除相关记录！","提示",MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                else
                    MessageBox.Show("没有可删除的记录！", "提示", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
            catch {
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
