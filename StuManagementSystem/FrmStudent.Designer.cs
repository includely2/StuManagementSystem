namespace StuManagementSystem
{
    partial class FrmStudent
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
            this.Gbox = new System.Windows.Forms.GroupBox();
            this.txtSclass = new System.Windows.Forms.TextBox();
            this.txtSplace = new System.Windows.Forms.TextBox();
            this.laSplace = new System.Windows.Forms.Label();
            this.laSbirthplace = new System.Windows.Forms.Label();
            this.cmbMajor = new System.Windows.Forms.ComboBox();
            this.laSclass = new System.Windows.Forms.Label();
            this.laMajor = new System.Windows.Forms.Label();
            this.laSage = new System.Windows.Forms.Label();
            this.txtSbirthplace = new System.Windows.Forms.TextBox();
            this.txtSage = new System.Windows.Forms.TextBox();
            this.txtSno = new System.Windows.Forms.TextBox();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.rabtnF = new System.Windows.Forms.RadioButton();
            this.rabtnM = new System.Windows.Forms.RadioButton();
            this.laSsex = new System.Windows.Forms.Label();
            this.laSname = new System.Windows.Forms.Label();
            this.laSno = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGView = new System.Windows.Forms.DataGridView();
            this.Gbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).BeginInit();
            this.SuspendLayout();
            // 
            // Gbox
            // 
            this.Gbox.Controls.Add(this.txtSclass);
            this.Gbox.Controls.Add(this.txtSplace);
            this.Gbox.Controls.Add(this.laSplace);
            this.Gbox.Controls.Add(this.laSbirthplace);
            this.Gbox.Controls.Add(this.cmbMajor);
            this.Gbox.Controls.Add(this.laSclass);
            this.Gbox.Controls.Add(this.laMajor);
            this.Gbox.Controls.Add(this.laSage);
            this.Gbox.Controls.Add(this.txtSbirthplace);
            this.Gbox.Controls.Add(this.txtSage);
            this.Gbox.Controls.Add(this.txtSno);
            this.Gbox.Controls.Add(this.txtSname);
            this.Gbox.Controls.Add(this.rabtnF);
            this.Gbox.Controls.Add(this.rabtnM);
            this.Gbox.Controls.Add(this.laSsex);
            this.Gbox.Controls.Add(this.laSname);
            this.Gbox.Controls.Add(this.laSno);
            this.Gbox.Controls.Add(this.btnInsert);
            this.Gbox.Location = new System.Drawing.Point(46, 12);
            this.Gbox.Name = "Gbox";
            this.Gbox.Size = new System.Drawing.Size(599, 135);
            this.Gbox.TabIndex = 0;
            this.Gbox.TabStop = false;
            // 
            // txtSclass
            // 
            this.txtSclass.Location = new System.Drawing.Point(326, 74);
            this.txtSclass.Name = "txtSclass";
            this.txtSclass.Size = new System.Drawing.Size(39, 21);
            this.txtSclass.TabIndex = 20;
            // 
            // txtSplace
            // 
            this.txtSplace.Location = new System.Drawing.Point(325, 105);
            this.txtSplace.Name = "txtSplace";
            this.txtSplace.Size = new System.Drawing.Size(114, 21);
            this.txtSplace.TabIndex = 19;
            // 
            // laSplace
            // 
            this.laSplace.AutoSize = true;
            this.laSplace.Location = new System.Drawing.Point(268, 109);
            this.laSplace.Name = "laSplace";
            this.laSplace.Size = new System.Drawing.Size(53, 12);
            this.laSplace.TabIndex = 16;
            this.laSplace.Text = "地区信息";
            // 
            // laSbirthplace
            // 
            this.laSbirthplace.AutoSize = true;
            this.laSbirthplace.Location = new System.Drawing.Point(12, 109);
            this.laSbirthplace.Name = "laSbirthplace";
            this.laSbirthplace.Size = new System.Drawing.Size(41, 12);
            this.laSbirthplace.TabIndex = 15;
            this.laSbirthplace.Text = "出生地";
            // 
            // cmbMajor
            // 
            this.cmbMajor.FormattingEnabled = true;
            this.cmbMajor.Location = new System.Drawing.Point(41, 74);
            this.cmbMajor.Name = "cmbMajor";
            this.cmbMajor.Size = new System.Drawing.Size(101, 20);
            this.cmbMajor.TabIndex = 14;
            // 
            // laSclass
            // 
            this.laSclass.AutoSize = true;
            this.laSclass.Location = new System.Drawing.Point(292, 77);
            this.laSclass.Name = "laSclass";
            this.laSclass.Size = new System.Drawing.Size(29, 12);
            this.laSclass.TabIndex = 13;
            this.laSclass.Text = "班级";
            // 
            // laMajor
            // 
            this.laMajor.AutoSize = true;
            this.laMajor.Location = new System.Drawing.Point(10, 77);
            this.laMajor.Name = "laMajor";
            this.laMajor.Size = new System.Drawing.Size(29, 12);
            this.laMajor.TabIndex = 11;
            this.laMajor.Text = "专业";
            // 
            // laSage
            // 
            this.laSage.AutoSize = true;
            this.laSage.Location = new System.Drawing.Point(291, 49);
            this.laSage.Name = "laSage";
            this.laSage.Size = new System.Drawing.Size(29, 12);
            this.laSage.TabIndex = 10;
            this.laSage.Text = "年龄";
            // 
            // txtSbirthplace
            // 
            this.txtSbirthplace.Location = new System.Drawing.Point(64, 105);
            this.txtSbirthplace.Name = "txtSbirthplace";
            this.txtSbirthplace.Size = new System.Drawing.Size(112, 21);
            this.txtSbirthplace.TabIndex = 9;
            // 
            // txtSage
            // 
            this.txtSage.Location = new System.Drawing.Point(326, 46);
            this.txtSage.Name = "txtSage";
            this.txtSage.Size = new System.Drawing.Size(39, 21);
            this.txtSage.TabIndex = 8;
            // 
            // txtSno
            // 
            this.txtSno.Location = new System.Drawing.Point(41, 16);
            this.txtSno.Name = "txtSno";
            this.txtSno.Size = new System.Drawing.Size(75, 21);
            this.txtSno.TabIndex = 7;
            // 
            // txtSname
            // 
            this.txtSname.Location = new System.Drawing.Point(326, 16);
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(76, 21);
            this.txtSname.TabIndex = 6;
            // 
            // rabtnF
            // 
            this.rabtnF.AutoSize = true;
            this.rabtnF.Location = new System.Drawing.Point(77, 47);
            this.rabtnF.Name = "rabtnF";
            this.rabtnF.Size = new System.Drawing.Size(35, 16);
            this.rabtnF.TabIndex = 5;
            this.rabtnF.TabStop = true;
            this.rabtnF.Text = "女";
            this.rabtnF.UseVisualStyleBackColor = true;
            this.rabtnF.CheckedChanged += new System.EventHandler(this.rabtnF_CheckedChanged);
            // 
            // rabtnM
            // 
            this.rabtnM.AutoSize = true;
            this.rabtnM.Location = new System.Drawing.Point(41, 47);
            this.rabtnM.Name = "rabtnM";
            this.rabtnM.Size = new System.Drawing.Size(35, 16);
            this.rabtnM.TabIndex = 4;
            this.rabtnM.TabStop = true;
            this.rabtnM.Text = "男";
            this.rabtnM.UseVisualStyleBackColor = true;
            this.rabtnM.CheckedChanged += new System.EventHandler(this.rabtnM_CheckedChanged);
            // 
            // laSsex
            // 
            this.laSsex.AutoSize = true;
            this.laSsex.Location = new System.Drawing.Point(10, 48);
            this.laSsex.Name = "laSsex";
            this.laSsex.Size = new System.Drawing.Size(29, 12);
            this.laSsex.TabIndex = 3;
            this.laSsex.Text = "性别";
            // 
            // laSname
            // 
            this.laSname.AutoSize = true;
            this.laSname.Location = new System.Drawing.Point(291, 21);
            this.laSname.Name = "laSname";
            this.laSname.Size = new System.Drawing.Size(29, 12);
            this.laSname.TabIndex = 2;
            this.laSname.Text = "姓名";
            // 
            // laSno
            // 
            this.laSno.AutoSize = true;
            this.laSno.Location = new System.Drawing.Point(10, 20);
            this.laSno.Name = "laSno";
            this.laSno.Size = new System.Drawing.Size(29, 12);
            this.laSno.TabIndex = 1;
            this.laSno.Text = "学号";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(501, 14);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "插入";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(607, 340);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "退出";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(505, 340);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 2;
            this.btnChange.Text = "保存";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(401, 340);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGView
            // 
            this.dataGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGView.Location = new System.Drawing.Point(46, 153);
            this.dataGView.Name = "dataGView";
            this.dataGView.RowTemplate.Height = 23;
            this.dataGView.Size = new System.Drawing.Size(599, 171);
            this.dataGView.TabIndex = 4;
            // 
            // FrmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 377);
            this.Controls.Add(this.dataGView);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.Gbox);
            this.Name = "FrmStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生信息输入窗口";
            this.Gbox.ResumeLayout(false);
            this.Gbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gbox;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGView;
        private System.Windows.Forms.TextBox txtSno;
        private System.Windows.Forms.TextBox txtSname;
        private System.Windows.Forms.RadioButton rabtnM;
        private System.Windows.Forms.Label laSsex;
        private System.Windows.Forms.Label laSname;
        private System.Windows.Forms.Label laSno;
        private System.Windows.Forms.TextBox txtSplace;
        private System.Windows.Forms.Label laSplace;
        private System.Windows.Forms.Label laSbirthplace;
        private System.Windows.Forms.ComboBox cmbMajor;
        private System.Windows.Forms.Label laSclass;
        private System.Windows.Forms.Label laMajor;
        private System.Windows.Forms.Label laSage;
        private System.Windows.Forms.TextBox txtSbirthplace;
        private System.Windows.Forms.TextBox txtSage;
        private System.Windows.Forms.TextBox txtSclass;
        private System.Windows.Forms.RadioButton rabtnF;
    }
}