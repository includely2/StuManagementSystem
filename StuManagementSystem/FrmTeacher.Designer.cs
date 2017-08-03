namespace StuManagementSystem
{
    partial class FrmTeacher
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
            this.Gbox = new System.Windows.Forms.GroupBox();
            this.txtTphone = new System.Windows.Forms.TextBox();
            this.laTphone = new System.Windows.Forms.Label();
            this.laTrank = new System.Windows.Forms.Label();
            this.laTage = new System.Windows.Forms.Label();
            this.txtTrank = new System.Windows.Forms.TextBox();
            this.txtTage = new System.Windows.Forms.TextBox();
            this.txtTno = new System.Windows.Forms.TextBox();
            this.txtTname = new System.Windows.Forms.TextBox();
            this.rabtnF = new System.Windows.Forms.RadioButton();
            this.rabtnM = new System.Windows.Forms.RadioButton();
            this.laTsex = new System.Windows.Forms.Label();
            this.laSname = new System.Windows.Forms.Label();
            this.laTno = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.dataGView = new System.Windows.Forms.DataGridView();
            this.Gbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(370, 276);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(578, 276);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "退出";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(475, 276);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 4;
            this.btnChange.Text = "保存";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // Gbox
            // 
            this.Gbox.Controls.Add(this.txtTphone);
            this.Gbox.Controls.Add(this.laTphone);
            this.Gbox.Controls.Add(this.laTrank);
            this.Gbox.Controls.Add(this.laTage);
            this.Gbox.Controls.Add(this.txtTrank);
            this.Gbox.Controls.Add(this.txtTage);
            this.Gbox.Controls.Add(this.txtTno);
            this.Gbox.Controls.Add(this.txtTname);
            this.Gbox.Controls.Add(this.rabtnF);
            this.Gbox.Controls.Add(this.rabtnM);
            this.Gbox.Controls.Add(this.laTsex);
            this.Gbox.Controls.Add(this.laSname);
            this.Gbox.Controls.Add(this.laTno);
            this.Gbox.Controls.Add(this.btnInsert);
            this.Gbox.Location = new System.Drawing.Point(49, 12);
            this.Gbox.Name = "Gbox";
            this.Gbox.Size = new System.Drawing.Size(569, 107);
            this.Gbox.TabIndex = 7;
            this.Gbox.TabStop = false;
            // 
            // txtTphone
            // 
            this.txtTphone.Location = new System.Drawing.Point(251, 76);
            this.txtTphone.Name = "txtTphone";
            this.txtTphone.Size = new System.Drawing.Size(114, 21);
            this.txtTphone.TabIndex = 19;
            // 
            // laTphone
            // 
            this.laTphone.AutoSize = true;
            this.laTphone.Location = new System.Drawing.Point(194, 80);
            this.laTphone.Name = "laTphone";
            this.laTphone.Size = new System.Drawing.Size(53, 12);
            this.laTphone.TabIndex = 16;
            this.laTphone.Text = "联系电话";
            // 
            // laTrank
            // 
            this.laTrank.AutoSize = true;
            this.laTrank.Location = new System.Drawing.Point(12, 79);
            this.laTrank.Name = "laTrank";
            this.laTrank.Size = new System.Drawing.Size(29, 12);
            this.laTrank.TabIndex = 15;
            this.laTrank.Text = "职称";
            // 
            // laTage
            // 
            this.laTage.AutoSize = true;
            this.laTage.Location = new System.Drawing.Point(216, 48);
            this.laTage.Name = "laTage";
            this.laTage.Size = new System.Drawing.Size(29, 12);
            this.laTage.TabIndex = 10;
            this.laTage.Text = "年龄";
            // 
            // txtTrank
            // 
            this.txtTrank.Location = new System.Drawing.Point(44, 75);
            this.txtTrank.Name = "txtTrank";
            this.txtTrank.Size = new System.Drawing.Size(112, 21);
            this.txtTrank.TabIndex = 9;
            // 
            // txtTage
            // 
            this.txtTage.Location = new System.Drawing.Point(251, 45);
            this.txtTage.Name = "txtTage";
            this.txtTage.Size = new System.Drawing.Size(39, 21);
            this.txtTage.TabIndex = 8;
            // 
            // txtTno
            // 
            this.txtTno.Location = new System.Drawing.Point(64, 16);
            this.txtTno.Name = "txtTno";
            this.txtTno.Size = new System.Drawing.Size(48, 21);
            this.txtTno.TabIndex = 7;
            // 
            // txtTname
            // 
            this.txtTname.Location = new System.Drawing.Point(251, 15);
            this.txtTname.Name = "txtTname";
            this.txtTname.Size = new System.Drawing.Size(76, 21);
            this.txtTname.TabIndex = 6;
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
            // laTsex
            // 
            this.laTsex.AutoSize = true;
            this.laTsex.Location = new System.Drawing.Point(10, 48);
            this.laTsex.Name = "laTsex";
            this.laTsex.Size = new System.Drawing.Size(29, 12);
            this.laTsex.TabIndex = 3;
            this.laTsex.Text = "性别";
            // 
            // laSname
            // 
            this.laSname.AutoSize = true;
            this.laSname.Location = new System.Drawing.Point(218, 20);
            this.laSname.Name = "laSname";
            this.laSname.Size = new System.Drawing.Size(29, 12);
            this.laSname.TabIndex = 2;
            this.laSname.Text = "姓名";
            // 
            // laTno
            // 
            this.laTno.AutoSize = true;
            this.laTno.Location = new System.Drawing.Point(10, 20);
            this.laTno.Name = "laTno";
            this.laTno.Size = new System.Drawing.Size(53, 12);
            this.laTno.TabIndex = 1;
            this.laTno.Text = "教师编号";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(461, 14);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "插入";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // dataGView
            // 
            this.dataGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGView.Location = new System.Drawing.Point(49, 126);
            this.dataGView.Name = "dataGView";
            this.dataGView.RowTemplate.Height = 23;
            this.dataGView.Size = new System.Drawing.Size(569, 129);
            this.dataGView.TabIndex = 8;
            // 
            // FrmTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 311);
            this.Controls.Add(this.dataGView);
            this.Controls.Add(this.Gbox);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChange);
            this.Name = "FrmTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "教师信息输入窗口";
            this.Gbox.ResumeLayout(false);
            this.Gbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.GroupBox Gbox;
        private System.Windows.Forms.TextBox txtTphone;
        private System.Windows.Forms.Label laTphone;
        private System.Windows.Forms.Label laTrank;
        private System.Windows.Forms.Label laTage;
        private System.Windows.Forms.TextBox txtTrank;
        private System.Windows.Forms.TextBox txtTage;
        private System.Windows.Forms.TextBox txtTno;
        private System.Windows.Forms.TextBox txtTname;
        private System.Windows.Forms.RadioButton rabtnF;
        private System.Windows.Forms.RadioButton rabtnM;
        private System.Windows.Forms.Label laTsex;
        private System.Windows.Forms.Label laSname;
        private System.Windows.Forms.Label laTno;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView dataGView;
    }
}