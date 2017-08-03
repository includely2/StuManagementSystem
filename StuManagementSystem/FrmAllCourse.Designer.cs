namespace StuManagementSystem
{
    partial class FrmAllCourse
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
            this.txtScreditget = new System.Windows.Forms.TextBox();
            this.gbox = new System.Windows.Forms.GroupBox();
            this.txtSno = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.laSno = new System.Windows.Forms.Label();
            this.laScreditget = new System.Windows.Forms.Label();
            this.dataGView = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScreditget
            // 
            this.txtScreditget.Location = new System.Drawing.Point(87, 222);
            this.txtScreditget.Name = "txtScreditget";
            this.txtScreditget.Size = new System.Drawing.Size(36, 21);
            this.txtScreditget.TabIndex = 0;
            // 
            // gbox
            // 
            this.gbox.Controls.Add(this.txtSno);
            this.gbox.Controls.Add(this.btnSearch);
            this.gbox.Controls.Add(this.laSno);
            this.gbox.Location = new System.Drawing.Point(36, 11);
            this.gbox.Name = "gbox";
            this.gbox.Size = new System.Drawing.Size(375, 71);
            this.gbox.TabIndex = 1;
            this.gbox.TabStop = false;
            // 
            // txtSno
            // 
            this.txtSno.Location = new System.Drawing.Point(82, 28);
            this.txtSno.Name = "txtSno";
            this.txtSno.Size = new System.Drawing.Size(89, 21);
            this.txtSno.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(266, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // laSno
            // 
            this.laSno.AutoSize = true;
            this.laSno.Location = new System.Drawing.Point(47, 31);
            this.laSno.Name = "laSno";
            this.laSno.Size = new System.Drawing.Size(29, 12);
            this.laSno.TabIndex = 0;
            this.laSno.Text = "学号";
            // 
            // laScreditget
            // 
            this.laScreditget.AutoSize = true;
            this.laScreditget.Location = new System.Drawing.Point(34, 226);
            this.laScreditget.Name = "laScreditget";
            this.laScreditget.Size = new System.Drawing.Size(53, 12);
            this.laScreditget.TabIndex = 2;
            this.laScreditget.Text = "已修学分";
            // 
            // dataGView
            // 
            this.dataGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGView.Location = new System.Drawing.Point(36, 88);
            this.dataGView.Name = "dataGView";
            this.dataGView.RowTemplate.Height = 23;
            this.dataGView.Size = new System.Drawing.Size(375, 115);
            this.dataGView.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(373, 226);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "返回";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmAllCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 261);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dataGView);
            this.Controls.Add(this.laScreditget);
            this.Controls.Add(this.gbox);
            this.Controls.Add(this.txtScreditget);
            this.Name = "FrmAllCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生所学课程及学分统计";
            this.gbox.ResumeLayout(false);
            this.gbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtScreditget;
        private System.Windows.Forms.GroupBox gbox;
        private System.Windows.Forms.TextBox txtSno;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label laSno;
        private System.Windows.Forms.Label laScreditget;
        private System.Windows.Forms.DataGridView dataGView;
        private System.Windows.Forms.Button btnExit;
    }
}