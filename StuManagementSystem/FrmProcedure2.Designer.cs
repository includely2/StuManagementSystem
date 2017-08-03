namespace StuManagementSystem
{
    partial class FrmProcedure2
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.laScredit = new System.Windows.Forms.Label();
            this.txtScredit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(170, 183);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "返回";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(48, 183);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // laScredit
            // 
            this.laScredit.AutoSize = true;
            this.laScredit.Location = new System.Drawing.Point(78, 84);
            this.laScredit.Name = "laScredit";
            this.laScredit.Size = new System.Drawing.Size(29, 12);
            this.laScredit.TabIndex = 2;
            this.laScredit.Text = "学分";
            // 
            // txtScredit
            // 
            this.txtScredit.Location = new System.Drawing.Point(133, 81);
            this.txtScredit.Name = "txtScredit";
            this.txtScredit.Size = new System.Drawing.Size(58, 21);
            this.txtScredit.TabIndex = 3;
            // 
            // FrmProcedure2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtScredit);
            this.Controls.Add(this.laScredit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnExit);
            this.Name = "FrmProcedure2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "调用存储过程演示2窗口";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label laScredit;
        private System.Windows.Forms.TextBox txtScredit;
    }
}