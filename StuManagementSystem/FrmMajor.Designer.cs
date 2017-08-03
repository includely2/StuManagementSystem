namespace StuManagementSystem
{
    partial class FrmMajor
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
            this.txtMname = new System.Windows.Forms.TextBox();
            this.txtMno = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.laMno = new System.Windows.Forms.Label();
            this.laMname = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGView = new System.Windows.Forms.DataGridView();
            this.Gbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).BeginInit();
            this.SuspendLayout();
            // 
            // Gbox
            // 
            this.Gbox.Controls.Add(this.txtMname);
            this.Gbox.Controls.Add(this.txtMno);
            this.Gbox.Controls.Add(this.btnInsert);
            this.Gbox.Controls.Add(this.laMno);
            this.Gbox.Controls.Add(this.laMname);
            this.Gbox.Location = new System.Drawing.Point(36, 12);
            this.Gbox.Name = "Gbox";
            this.Gbox.Size = new System.Drawing.Size(393, 100);
            this.Gbox.TabIndex = 0;
            this.Gbox.TabStop = false;
            // 
            // txtMname
            // 
            this.txtMname.Location = new System.Drawing.Point(188, 39);
            this.txtMname.Name = "txtMname";
            this.txtMname.Size = new System.Drawing.Size(100, 21);
            this.txtMname.TabIndex = 5;
            // 
            // txtMno
            // 
            this.txtMno.Location = new System.Drawing.Point(70, 40);
            this.txtMno.Name = "txtMno";
            this.txtMno.Size = new System.Drawing.Size(37, 21);
            this.txtMno.TabIndex = 4;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(303, 38);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "插入";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // laMno
            // 
            this.laMno.AutoSize = true;
            this.laMno.Location = new System.Drawing.Point(15, 43);
            this.laMno.Name = "laMno";
            this.laMno.Size = new System.Drawing.Size(53, 12);
            this.laMno.TabIndex = 1;
            this.laMno.Text = "专业编号";
            // 
            // laMname
            // 
            this.laMname.AutoSize = true;
            this.laMname.Location = new System.Drawing.Point(133, 43);
            this.laMname.Name = "laMname";
            this.laMname.Size = new System.Drawing.Size(53, 12);
            this.laMname.TabIndex = 2;
            this.laMname.Text = "专业名称";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(279, 287);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 1;
            this.btnChange.Text = "保存";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(382, 287);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "退出";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(174, 287);
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
            this.dataGView.Location = new System.Drawing.Point(36, 118);
            this.dataGView.Name = "dataGView";
            this.dataGView.RowTemplate.Height = 23;
            this.dataGView.Size = new System.Drawing.Size(393, 141);
            this.dataGView.TabIndex = 4;
            // 
            // FrmMajor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 320);
            this.Controls.Add(this.dataGView);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.Gbox);
            this.Name = "FrmMajor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "专业信息输入窗口";
            this.Gbox.ResumeLayout(false);
            this.Gbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gbox;
        private System.Windows.Forms.TextBox txtMname;
        private System.Windows.Forms.TextBox txtMno;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label laMno;
        private System.Windows.Forms.Label laMname;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGView;
    }
}