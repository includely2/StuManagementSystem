namespace StuManagementSystem
{
    partial class FrmAveGrade
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.laCno = new System.Windows.Forms.Label();
            this.txtCno = new System.Windows.Forms.TextBox();
            this.laCname = new System.Windows.Forms.Label();
            this.laAvgGrade = new System.Windows.Forms.Label();
            this.txtCname = new System.Windows.Forms.TextBox();
            this.txtAvgGrade = new System.Windows.Forms.TextBox();
            this.gbox = new System.Windows.Forms.GroupBox();
            this.gbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(145, 41);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(197, 226);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "返回";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // laCno
            // 
            this.laCno.AutoSize = true;
            this.laCno.Location = new System.Drawing.Point(21, 47);
            this.laCno.Name = "laCno";
            this.laCno.Size = new System.Drawing.Size(53, 12);
            this.laCno.TabIndex = 2;
            this.laCno.Text = "课程编号";
            // 
            // txtCno
            // 
            this.txtCno.Location = new System.Drawing.Point(74, 42);
            this.txtCno.Name = "txtCno";
            this.txtCno.Size = new System.Drawing.Size(39, 21);
            this.txtCno.TabIndex = 3;
            // 
            // laCname
            // 
            this.laCname.AutoSize = true;
            this.laCname.Location = new System.Drawing.Point(56, 150);
            this.laCname.Name = "laCname";
            this.laCname.Size = new System.Drawing.Size(53, 12);
            this.laCname.TabIndex = 4;
            this.laCname.Text = "课程名称";
            // 
            // laAvgGrade
            // 
            this.laAvgGrade.AutoSize = true;
            this.laAvgGrade.Location = new System.Drawing.Point(56, 181);
            this.laAvgGrade.Name = "laAvgGrade";
            this.laAvgGrade.Size = new System.Drawing.Size(53, 12);
            this.laAvgGrade.TabIndex = 5;
            this.laAvgGrade.Text = "平均成绩";
            // 
            // txtCname
            // 
            this.txtCname.Location = new System.Drawing.Point(124, 144);
            this.txtCname.Name = "txtCname";
            this.txtCname.Size = new System.Drawing.Size(100, 21);
            this.txtCname.TabIndex = 6;
            // 
            // txtAvgGrade
            // 
            this.txtAvgGrade.Location = new System.Drawing.Point(124, 177);
            this.txtAvgGrade.Name = "txtAvgGrade";
            this.txtAvgGrade.Size = new System.Drawing.Size(100, 21);
            this.txtAvgGrade.TabIndex = 7;
            // 
            // gbox
            // 
            this.gbox.Controls.Add(this.btnSearch);
            this.gbox.Controls.Add(this.laCno);
            this.gbox.Controls.Add(this.txtCno);
            this.gbox.Location = new System.Drawing.Point(23, 15);
            this.gbox.Name = "gbox";
            this.gbox.Size = new System.Drawing.Size(237, 100);
            this.gbox.TabIndex = 8;
            this.gbox.TabStop = false;
            // 
            // FrmAveGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.gbox);
            this.Controls.Add(this.txtAvgGrade);
            this.Controls.Add(this.txtCname);
            this.Controls.Add(this.laAvgGrade);
            this.Controls.Add(this.laCname);
            this.Controls.Add(this.btnExit);
            this.Name = "FrmAveGrade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "课程平均成绩统计";
            this.gbox.ResumeLayout(false);
            this.gbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label laCno;
        private System.Windows.Forms.TextBox txtCno;
        private System.Windows.Forms.Label laCname;
        private System.Windows.Forms.Label laAvgGrade;
        private System.Windows.Forms.TextBox txtCname;
        private System.Windows.Forms.TextBox txtAvgGrade;
        private System.Windows.Forms.GroupBox gbox;
    }
}