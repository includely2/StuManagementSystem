namespace StuManagementSystem
{
    partial class FrmCourse
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.txtCcredit = new System.Windows.Forms.TextBox();
            this.txtTname = new System.Windows.Forms.TextBox();
            this.txtCno = new System.Windows.Forms.TextBox();
            this.txtCterm = new System.Windows.Forms.TextBox();
            this.txtCname = new System.Windows.Forms.TextBox();
            this.txtCtime = new System.Windows.Forms.TextBox();
            this.laCno = new System.Windows.Forms.Label();
            this.laCcredit = new System.Windows.Forms.Label();
            this.laCname = new System.Windows.Forms.Label();
            this.laTname = new System.Windows.Forms.Label();
            this.laCterm = new System.Windows.Forms.Label();
            this.laCtime = new System.Windows.Forms.Label();
            this.laCtype = new System.Windows.Forms.Label();
            this.Gbox = new System.Windows.Forms.GroupBox();
            this.rabtnCheck = new System.Windows.Forms.RadioButton();
            this.rabtnTest = new System.Windows.Forms.RadioButton();
            this.btnInsert = new System.Windows.Forms.Button();
            this.dataGView = new System.Windows.Forms.DataGridView();
            this.Gbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(403, 277);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(611, 277);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "退出";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(508, 277);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 4;
            this.btnChange.Text = "保存";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // txtCcredit
            // 
            this.txtCcredit.Location = new System.Drawing.Point(39, 44);
            this.txtCcredit.Name = "txtCcredit";
            this.txtCcredit.Size = new System.Drawing.Size(36, 21);
            this.txtCcredit.TabIndex = 7;
            // 
            // txtTname
            // 
            this.txtTname.Location = new System.Drawing.Point(327, 44);
            this.txtTname.Name = "txtTname";
            this.txtTname.Size = new System.Drawing.Size(98, 21);
            this.txtTname.TabIndex = 8;
            // 
            // txtCno
            // 
            this.txtCno.Location = new System.Drawing.Point(63, 15);
            this.txtCno.Name = "txtCno";
            this.txtCno.Size = new System.Drawing.Size(35, 21);
            this.txtCno.TabIndex = 9;
            // 
            // txtCterm
            // 
            this.txtCterm.Location = new System.Drawing.Point(64, 73);
            this.txtCterm.Name = "txtCterm";
            this.txtCterm.Size = new System.Drawing.Size(100, 21);
            this.txtCterm.TabIndex = 10;
            // 
            // txtCname
            // 
            this.txtCname.Location = new System.Drawing.Point(327, 16);
            this.txtCname.Name = "txtCname";
            this.txtCname.Size = new System.Drawing.Size(98, 21);
            this.txtCname.TabIndex = 11;
            // 
            // txtCtime
            // 
            this.txtCtime.Location = new System.Drawing.Point(128, 44);
            this.txtCtime.Name = "txtCtime";
            this.txtCtime.Size = new System.Drawing.Size(36, 21);
            this.txtCtime.TabIndex = 12;
            // 
            // laCno
            // 
            this.laCno.AutoSize = true;
            this.laCno.Location = new System.Drawing.Point(8, 20);
            this.laCno.Name = "laCno";
            this.laCno.Size = new System.Drawing.Size(53, 12);
            this.laCno.TabIndex = 13;
            this.laCno.Text = "课程编号";
            // 
            // laCcredit
            // 
            this.laCcredit.AutoSize = true;
            this.laCcredit.Location = new System.Drawing.Point(8, 47);
            this.laCcredit.Name = "laCcredit";
            this.laCcredit.Size = new System.Drawing.Size(29, 12);
            this.laCcredit.TabIndex = 14;
            this.laCcredit.Text = "学分";
            // 
            // laCname
            // 
            this.laCname.AutoSize = true;
            this.laCname.Location = new System.Drawing.Point(273, 21);
            this.laCname.Name = "laCname";
            this.laCname.Size = new System.Drawing.Size(53, 12);
            this.laCname.TabIndex = 15;
            this.laCname.Text = "课程名称";
            // 
            // laTname
            // 
            this.laTname.AutoSize = true;
            this.laTname.Location = new System.Drawing.Point(271, 48);
            this.laTname.Name = "laTname";
            this.laTname.Size = new System.Drawing.Size(53, 12);
            this.laTname.TabIndex = 16;
            this.laTname.Text = "任课教师";
            // 
            // laCterm
            // 
            this.laCterm.AutoSize = true;
            this.laCterm.Location = new System.Drawing.Point(8, 76);
            this.laCterm.Name = "laCterm";
            this.laCterm.Size = new System.Drawing.Size(53, 12);
            this.laCterm.TabIndex = 17;
            this.laCterm.Text = "开课学期";
            // 
            // laCtime
            // 
            this.laCtime.AutoSize = true;
            this.laCtime.Location = new System.Drawing.Point(98, 48);
            this.laCtime.Name = "laCtime";
            this.laCtime.Size = new System.Drawing.Size(29, 12);
            this.laCtime.TabIndex = 18;
            this.laCtime.Text = "学时";
            // 
            // laCtype
            // 
            this.laCtype.AutoSize = true;
            this.laCtype.Location = new System.Drawing.Point(271, 76);
            this.laCtype.Name = "laCtype";
            this.laCtype.Size = new System.Drawing.Size(53, 12);
            this.laCtype.TabIndex = 19;
            this.laCtype.Text = "考核性质";
            // 
            // Gbox
            // 
            this.Gbox.Controls.Add(this.rabtnCheck);
            this.Gbox.Controls.Add(this.rabtnTest);
            this.Gbox.Controls.Add(this.btnInsert);
            this.Gbox.Controls.Add(this.laCno);
            this.Gbox.Controls.Add(this.txtCtime);
            this.Gbox.Controls.Add(this.laCcredit);
            this.Gbox.Controls.Add(this.txtCterm);
            this.Gbox.Controls.Add(this.laCtype);
            this.Gbox.Controls.Add(this.txtTname);
            this.Gbox.Controls.Add(this.txtCname);
            this.Gbox.Controls.Add(this.laTname);
            this.Gbox.Controls.Add(this.txtCcredit);
            this.Gbox.Controls.Add(this.laCterm);
            this.Gbox.Controls.Add(this.laCtime);
            this.Gbox.Controls.Add(this.txtCno);
            this.Gbox.Controls.Add(this.laCname);
            this.Gbox.Location = new System.Drawing.Point(51, 21);
            this.Gbox.Name = "Gbox";
            this.Gbox.Size = new System.Drawing.Size(597, 107);
            this.Gbox.TabIndex = 20;
            this.Gbox.TabStop = false;
            // 
            // rabtnCheck
            // 
            this.rabtnCheck.AutoSize = true;
            this.rabtnCheck.Location = new System.Drawing.Point(375, 74);
            this.rabtnCheck.Name = "rabtnCheck";
            this.rabtnCheck.Size = new System.Drawing.Size(47, 16);
            this.rabtnCheck.TabIndex = 22;
            this.rabtnCheck.TabStop = true;
            this.rabtnCheck.Text = "考查";
            this.rabtnCheck.UseVisualStyleBackColor = true;
            this.rabtnCheck.CheckedChanged += new System.EventHandler(this.rabtnCheck_CheckedChanged);
            // 
            // rabtnTest
            // 
            this.rabtnTest.AutoSize = true;
            this.rabtnTest.Location = new System.Drawing.Point(330, 74);
            this.rabtnTest.Name = "rabtnTest";
            this.rabtnTest.Size = new System.Drawing.Size(47, 16);
            this.rabtnTest.TabIndex = 21;
            this.rabtnTest.TabStop = true;
            this.rabtnTest.Text = "考试";
            this.rabtnTest.UseVisualStyleBackColor = true;
            this.rabtnTest.CheckedChanged += new System.EventHandler(this.rabtnTest_CheckedChanged);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(505, 15);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 20;
            this.btnInsert.Text = "插入";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // dataGView
            // 
            this.dataGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGView.Location = new System.Drawing.Point(51, 134);
            this.dataGView.Name = "dataGView";
            this.dataGView.RowTemplate.Height = 23;
            this.dataGView.Size = new System.Drawing.Size(597, 121);
            this.dataGView.TabIndex = 21;
            // 
            // FrmCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 312);
            this.Controls.Add(this.dataGView);
            this.Controls.Add(this.Gbox);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChange);
            this.Name = "FrmCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "课程信息输入窗口";
            this.Gbox.ResumeLayout(false);
            this.Gbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.TextBox txtCcredit;
        private System.Windows.Forms.TextBox txtTname;
        private System.Windows.Forms.TextBox txtCno;
        private System.Windows.Forms.TextBox txtCterm;
        private System.Windows.Forms.TextBox txtCname;
        private System.Windows.Forms.TextBox txtCtime;
        private System.Windows.Forms.Label laCno;
        private System.Windows.Forms.Label laCcredit;
        private System.Windows.Forms.Label laCname;
        private System.Windows.Forms.Label laTname;
        private System.Windows.Forms.Label laCterm;
        private System.Windows.Forms.Label laCtime;
        private System.Windows.Forms.Label laCtype;
        private System.Windows.Forms.GroupBox Gbox;
        private System.Windows.Forms.DataGridView dataGView;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.RadioButton rabtnCheck;
        private System.Windows.Forms.RadioButton rabtnTest;
    }
}