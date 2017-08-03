namespace StuManagementSystem
{
    partial class FrmGrade
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
            this.dataGView = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.Gbox = new System.Windows.Forms.GroupBox();
            this.txtGscore = new System.Windows.Forms.TextBox();
            this.txtCno = new System.Windows.Forms.TextBox();
            this.txtSno = new System.Windows.Forms.TextBox();
            this.laGscore = new System.Windows.Forms.Label();
            this.laCno = new System.Windows.Forms.Label();
            this.laSno = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).BeginInit();
            this.Gbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGView
            // 
            this.dataGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGView.Location = new System.Drawing.Point(45, 79);
            this.dataGView.Name = "dataGView";
            this.dataGView.RowTemplate.Height = 23;
            this.dataGView.Size = new System.Drawing.Size(528, 163);
            this.dataGView.TabIndex = 8;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(327, 274);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(431, 274);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 6;
            this.btnChange.Text = "保存";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(533, 274);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "退出";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Gbox
            // 
            this.Gbox.Controls.Add(this.txtGscore);
            this.Gbox.Controls.Add(this.txtCno);
            this.Gbox.Controls.Add(this.txtSno);
            this.Gbox.Controls.Add(this.laGscore);
            this.Gbox.Controls.Add(this.laCno);
            this.Gbox.Controls.Add(this.laSno);
            this.Gbox.Controls.Add(this.btnInsert);
            this.Gbox.Location = new System.Drawing.Point(45, 12);
            this.Gbox.Name = "Gbox";
            this.Gbox.Size = new System.Drawing.Size(528, 61);
            this.Gbox.TabIndex = 9;
            this.Gbox.TabStop = false;
            // 
            // txtGscore
            // 
            this.txtGscore.Location = new System.Drawing.Point(297, 20);
            this.txtGscore.Name = "txtGscore";
            this.txtGscore.Size = new System.Drawing.Size(41, 21);
            this.txtGscore.TabIndex = 10;
            // 
            // txtCno
            // 
            this.txtCno.Location = new System.Drawing.Point(206, 20);
            this.txtCno.Name = "txtCno";
            this.txtCno.Size = new System.Drawing.Size(38, 21);
            this.txtCno.TabIndex = 7;
            // 
            // txtSno
            // 
            this.txtSno.Location = new System.Drawing.Point(50, 21);
            this.txtSno.Name = "txtSno";
            this.txtSno.Size = new System.Drawing.Size(64, 21);
            this.txtSno.TabIndex = 6;
            // 
            // laGscore
            // 
            this.laGscore.AutoSize = true;
            this.laGscore.Location = new System.Drawing.Point(268, 24);
            this.laGscore.Name = "laGscore";
            this.laGscore.Size = new System.Drawing.Size(29, 12);
            this.laGscore.TabIndex = 5;
            this.laGscore.Text = "分数";
            // 
            // laCno
            // 
            this.laCno.AutoSize = true;
            this.laCno.Location = new System.Drawing.Point(152, 25);
            this.laCno.Name = "laCno";
            this.laCno.Size = new System.Drawing.Size(53, 12);
            this.laCno.TabIndex = 2;
            this.laCno.Text = "课程编号";
            // 
            // laSno
            // 
            this.laSno.AutoSize = true;
            this.laSno.Location = new System.Drawing.Point(19, 25);
            this.laSno.Name = "laSno";
            this.laSno.Size = new System.Drawing.Size(29, 12);
            this.laSno.TabIndex = 1;
            this.laSno.Text = "学号";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(423, 20);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "插入";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // FrmGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 309);
            this.Controls.Add(this.Gbox);
            this.Controls.Add(this.dataGView);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnCancel);
            this.Name = "FrmGrade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "成绩信息输入窗口";
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).EndInit();
            this.Gbox.ResumeLayout(false);
            this.Gbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGView;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox Gbox;
        private System.Windows.Forms.TextBox txtGscore;
        private System.Windows.Forms.TextBox txtCno;
        private System.Windows.Forms.TextBox txtSno;
        private System.Windows.Forms.Label laGscore;
        private System.Windows.Forms.Label laCno;
        private System.Windows.Forms.Label laSno;
        private System.Windows.Forms.Button btnInsert;
    }
}