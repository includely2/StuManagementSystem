namespace StuManagementSystem
{
    partial class FrmClassSearch
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
            this.laSclass = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.laMname = new System.Windows.Forms.Label();
            this.cmbMajor = new System.Windows.Forms.ComboBox();
            this.txtSclass = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGView
            // 
            this.dataGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGView.Location = new System.Drawing.Point(23, 55);
            this.dataGView.Name = "dataGView";
            this.dataGView.RowTemplate.Height = 23;
            this.dataGView.Size = new System.Drawing.Size(422, 150);
            this.dataGView.TabIndex = 9;
            // 
            // laSclass
            // 
            this.laSclass.AutoSize = true;
            this.laSclass.Location = new System.Drawing.Point(238, 22);
            this.laSclass.Name = "laSclass";
            this.laSclass.Size = new System.Drawing.Size(29, 12);
            this.laSclass.TabIndex = 7;
            this.laSclass.Text = "班级";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(383, 226);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "返回";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(320, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // laMname
            // 
            this.laMname.AutoSize = true;
            this.laMname.Location = new System.Drawing.Point(71, 22);
            this.laMname.Name = "laMname";
            this.laMname.Size = new System.Drawing.Size(29, 12);
            this.laMname.TabIndex = 10;
            this.laMname.Text = "专业";
            // 
            // cmbMajor
            // 
            this.cmbMajor.FormattingEnabled = true;
            this.cmbMajor.Location = new System.Drawing.Point(102, 19);
            this.cmbMajor.Name = "cmbMajor";
            this.cmbMajor.Size = new System.Drawing.Size(114, 20);
            this.cmbMajor.TabIndex = 11;
            // 
            // txtSclass
            // 
            this.txtSclass.Location = new System.Drawing.Point(268, 18);
            this.txtSclass.Name = "txtSclass";
            this.txtSclass.Size = new System.Drawing.Size(28, 21);
            this.txtSclass.TabIndex = 12;
            // 
            // FrmClassSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 261);
            this.Controls.Add(this.txtSclass);
            this.Controls.Add(this.cmbMajor);
            this.Controls.Add(this.laMname);
            this.Controls.Add(this.dataGView);
            this.Controls.Add(this.laSclass);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearch);
            this.Name = "FrmClassSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "班级开课查询";
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGView;
        private System.Windows.Forms.Label laSclass;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label laMname;
        private System.Windows.Forms.ComboBox cmbMajor;
        private System.Windows.Forms.TextBox txtSclass;
    }
}