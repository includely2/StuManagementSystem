namespace StuManagementSystem
{
    partial class FrmCourseSort
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dataGView = new System.Windows.Forms.DataGridView();
            this.laCno = new System.Windows.Forms.Label();
            this.txtCno = new System.Windows.Forms.TextBox();
            this.gbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).BeginInit();
            this.SuspendLayout();
            // 
            // gbox
            // 
            this.gbox.Controls.Add(this.txtCno);
            this.gbox.Controls.Add(this.laCno);
            this.gbox.Controls.Add(this.btnSearch);
            this.gbox.Location = new System.Drawing.Point(41, 9);
            this.gbox.Name = "gbox";
            this.gbox.Size = new System.Drawing.Size(343, 66);
            this.gbox.TabIndex = 0;
            this.gbox.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(247, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(337, 226);
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
            this.dataGView.Location = new System.Drawing.Point(41, 81);
            this.dataGView.Name = "dataGView";
            this.dataGView.RowTemplate.Height = 23;
            this.dataGView.Size = new System.Drawing.Size(343, 125);
            this.dataGView.TabIndex = 2;
            // 
            // laCno
            // 
            this.laCno.AutoSize = true;
            this.laCno.Location = new System.Drawing.Point(71, 26);
            this.laCno.Name = "laCno";
            this.laCno.Size = new System.Drawing.Size(53, 12);
            this.laCno.TabIndex = 1;
            this.laCno.Text = "课程编号";
            // 
            // txtCno
            // 
            this.txtCno.Location = new System.Drawing.Point(130, 23);
            this.txtCno.Name = "txtCno";
            this.txtCno.Size = new System.Drawing.Size(40, 21);
            this.txtCno.TabIndex = 2;
            // 
            // FrmCourseSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 261);
            this.Controls.Add(this.dataGView);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gbox);
            this.Name = "FrmCourseSort";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生成绩名次排定";
            this.gbox.ResumeLayout(false);
            this.gbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbox;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dataGView;
        private System.Windows.Forms.TextBox txtCno;
        private System.Windows.Forms.Label laCno;
    }
}