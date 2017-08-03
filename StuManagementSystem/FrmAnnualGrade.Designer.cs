namespace StuManagementSystem
{
    partial class FrmAnnualGrade
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
            this.gbox = new System.Windows.Forms.GroupBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtSno = new System.Windows.Forms.TextBox();
            this.laSno = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.laYear = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.dataGView = new System.Windows.Forms.DataGridView();
            this.laAvgGrade = new System.Windows.Forms.Label();
            this.txtAvgGrade = new System.Windows.Forms.TextBox();
            this.gbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).BeginInit();
            this.SuspendLayout();
            // 
            // gbox
            // 
            this.gbox.Controls.Add(this.laYear);
            this.gbox.Controls.Add(this.txtYear);
            this.gbox.Controls.Add(this.txtSno);
            this.gbox.Controls.Add(this.laSno);
            this.gbox.Controls.Add(this.btnSearch);
            this.gbox.Location = new System.Drawing.Point(39, 3);
            this.gbox.Name = "gbox";
            this.gbox.Size = new System.Drawing.Size(401, 100);
            this.gbox.TabIndex = 0;
            this.gbox.TabStop = false;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(183, 39);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(56, 21);
            this.txtYear.TabIndex = 3;
            // 
            // txtSno
            // 
            this.txtSno.Location = new System.Drawing.Point(52, 39);
            this.txtSno.Name = "txtSno";
            this.txtSno.Size = new System.Drawing.Size(57, 21);
            this.txtSno.TabIndex = 2;
            // 
            // laSno
            // 
            this.laSno.AutoSize = true;
            this.laSno.Location = new System.Drawing.Point(23, 43);
            this.laSno.Name = "laSno";
            this.laSno.Size = new System.Drawing.Size(29, 12);
            this.laSno.TabIndex = 1;
            this.laSno.Text = "学号";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(296, 38);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // laYear
            // 
            this.laYear.AutoSize = true;
            this.laYear.Location = new System.Drawing.Point(153, 43);
            this.laYear.Name = "laYear";
            this.laYear.Size = new System.Drawing.Size(29, 12);
            this.laYear.TabIndex = 4;
            this.laYear.Text = "学年";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(394, 226);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "返回";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dataGView
            // 
            this.dataGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGView.Location = new System.Drawing.Point(39, 109);
            this.dataGView.Name = "dataGView";
            this.dataGView.RowTemplate.Height = 23;
            this.dataGView.Size = new System.Drawing.Size(401, 108);
            this.dataGView.TabIndex = 2;
            // 
            // laAvgGrade
            // 
            this.laAvgGrade.AutoSize = true;
            this.laAvgGrade.Location = new System.Drawing.Point(39, 231);
            this.laAvgGrade.Name = "laAvgGrade";
            this.laAvgGrade.Size = new System.Drawing.Size(77, 12);
            this.laAvgGrade.TabIndex = 3;
            this.laAvgGrade.Text = "学年平均成绩";
            // 
            // txtAvgGrade
            // 
            this.txtAvgGrade.Location = new System.Drawing.Point(117, 227);
            this.txtAvgGrade.Name = "txtAvgGrade";
            this.txtAvgGrade.Size = new System.Drawing.Size(31, 21);
            this.txtAvgGrade.TabIndex = 4;
            // 
            // FrmAnnualGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 261);
            this.Controls.Add(this.txtAvgGrade);
            this.Controls.Add(this.laAvgGrade);
            this.Controls.Add(this.dataGView);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gbox);
            this.Name = "FrmAnnualGrade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生学年成绩统计";
            this.gbox.ResumeLayout(false);
            this.gbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbox;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtSno;
        private System.Windows.Forms.Label laSno;
        private System.Windows.Forms.Label laYear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dataGView;
        private System.Windows.Forms.Label laAvgGrade;
        private System.Windows.Forms.TextBox txtAvgGrade;
    }
}