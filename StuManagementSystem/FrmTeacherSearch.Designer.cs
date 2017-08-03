namespace StuManagementSystem
{
    partial class FrmTeacherSearch
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
            this.txtTno = new System.Windows.Forms.TextBox();
            this.laTno = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGView
            // 
            this.dataGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGView.Location = new System.Drawing.Point(23, 55);
            this.dataGView.Name = "dataGView";
            this.dataGView.RowTemplate.Height = 23;
            this.dataGView.Size = new System.Drawing.Size(417, 150);
            this.dataGView.TabIndex = 9;
            // 
            // txtTno
            // 
            this.txtTno.Location = new System.Drawing.Point(166, 17);
            this.txtTno.Name = "txtTno";
            this.txtTno.Size = new System.Drawing.Size(42, 21);
            this.txtTno.TabIndex = 8;
            // 
            // laTno
            // 
            this.laTno.AutoSize = true;
            this.laTno.Location = new System.Drawing.Point(112, 22);
            this.laTno.Name = "laTno";
            this.laTno.Size = new System.Drawing.Size(53, 12);
            this.laTno.TabIndex = 7;
            this.laTno.Text = "教师编号";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(380, 226);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "返回";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(279, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FrmTeacherSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 261);
            this.Controls.Add(this.dataGView);
            this.Controls.Add(this.txtTno);
            this.Controls.Add(this.laTno);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearch);
            this.Name = "FrmTeacherSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "教师任课查询";
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGView;
        private System.Windows.Forms.TextBox txtTno;
        private System.Windows.Forms.Label laTno;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSearch;
    }
}