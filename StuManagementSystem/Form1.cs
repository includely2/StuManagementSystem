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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPwd.Text == "")
                MessageBox.Show("用户名或密码不能为空！", "提示", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            else
            {
                frmMain fmain = new frmMain();
                fmain.Show();
                this.Hide();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
