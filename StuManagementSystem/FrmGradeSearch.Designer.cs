namespace StuManagementSystem
{
    partial class FrmGradeSearch
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
            this.laSno = new System.Windows.Forms.Label();
            this.txtSno = new System.Windows.Forms.TextBox();
            this.dataGView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(273, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(378, 226);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "返回";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // laSno
            // 
            this.laSno.AutoSize = true;
            this.laSno.Location = new System.Drawing.Point(106, 27);
            this.laSno.Name = "laSno";
            this.laSno.Size = new System.Drawing.Size(29, 12);
            this.laSno.TabIndex = 2;
            this.laSno.Text = "学号";
            // 
            // txtSno
            // 
            this.txtSno.Location = new System.Drawing.Point(137, 22);
            this.txtSno.Name = "txtSno";
            this.txtSno.Size = new System.Drawing.Size(100, 21);
            this.txtSno.TabIndex = 3;
            // 
            // dataGView
            // 
            this.dataGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGView.Location = new System.Drawing.Point(21, 60);
            this.dataGView.Name = "dataGView";
            this.dataGView.RowTemplate.Height = 23;
            this.dataGView.Size = new System.Drawing.Size(417, 150);
            this.dataGView.TabIndex = 4;
            // 
            // FrmGradeSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 261);
            this.Controls.Add(this.dataGView);
            this.Controls.Add(this.txtSno);
            this.Controls.Add(this.laSno);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearch);
            this.Name = "FrmGradeSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生成绩查询";
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label laSno;
        private System.Windows.Forms.TextBox txtSno;
        private System.Windows.Forms.DataGridView dataGView;
    }
}