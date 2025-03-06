namespace DailyPlanner
{
    partial class MakeAccountForm
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
            this.lblLoginInst = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtPwd2 = new System.Windows.Forms.TextBox();
            this.btnBackLogin2 = new System.Windows.Forms.Button();
            this.txtUser2 = new System.Windows.Forms.TextBox();
            this.lblPwd2 = new System.Windows.Forms.Label();
            this.lblUser2 = new System.Windows.Forms.Label();
            this.lblMakeAccInst2 = new System.Windows.Forms.Label();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLoginInst
            // 
            this.lblLoginInst.AutoSize = true;
            this.lblLoginInst.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginInst.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLoginInst.Location = new System.Drawing.Point(82, 154);
            this.lblLoginInst.Name = "lblLoginInst";
            this.lblLoginInst.Size = new System.Drawing.Size(0, 30);
            this.lblLoginInst.TabIndex = 17;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitle.Location = new System.Drawing.Point(0, 64);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 50);
            this.lblTitle.TabIndex = 16;
            // 
            // txtPwd2
            // 
            this.txtPwd2.Location = new System.Drawing.Point(42, 444);
            this.txtPwd2.Name = "txtPwd2";
            this.txtPwd2.Size = new System.Drawing.Size(312, 20);
            this.txtPwd2.TabIndex = 24;
            // 
            // btnBackLogin2
            // 
            this.btnBackLogin2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBackLogin2.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackLogin2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBackLogin2.Location = new System.Drawing.Point(42, 533);
            this.btnBackLogin2.Name = "btnBackLogin2";
            this.btnBackLogin2.Size = new System.Drawing.Size(312, 45);
            this.btnBackLogin2.TabIndex = 23;
            this.btnBackLogin2.Text = "Back to Login";
            this.btnBackLogin2.UseVisualStyleBackColor = false;
            this.btnBackLogin2.Click += new System.EventHandler(this.btnBackLogin2_Click);
            // 
            // txtUser2
            // 
            this.txtUser2.Location = new System.Drawing.Point(42, 345);
            this.txtUser2.Name = "txtUser2";
            this.txtUser2.Size = new System.Drawing.Size(312, 20);
            this.txtUser2.TabIndex = 22;
            // 
            // lblPwd2
            // 
            this.lblPwd2.AutoSize = true;
            this.lblPwd2.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPwd2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPwd2.Location = new System.Drawing.Point(37, 400);
            this.lblPwd2.Name = "lblPwd2";
            this.lblPwd2.Size = new System.Drawing.Size(157, 30);
            this.lblPwd2.TabIndex = 21;
            this.lblPwd2.Text = "Password:";
            // 
            // lblUser2
            // 
            this.lblUser2.AutoSize = true;
            this.lblUser2.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUser2.Location = new System.Drawing.Point(37, 302);
            this.lblUser2.Name = "lblUser2";
            this.lblUser2.Size = new System.Drawing.Size(157, 30);
            this.lblUser2.TabIndex = 20;
            this.lblUser2.Text = "Username:";
            // 
            // lblMakeAccInst2
            // 
            this.lblMakeAccInst2.AutoSize = true;
            this.lblMakeAccInst2.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMakeAccInst2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMakeAccInst2.Location = new System.Drawing.Point(66, 155);
            this.lblMakeAccInst2.Name = "lblMakeAccInst2";
            this.lblMakeAccInst2.Size = new System.Drawing.Size(269, 90);
            this.lblMakeAccInst2.TabIndex = 19;
            this.lblMakeAccInst2.Text = "Enter a username\r\nand password to\r\nmake an account.";
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitle2.Location = new System.Drawing.Point(0, 64);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(399, 50);
            this.lblTitle2.TabIndex = 18;
            this.lblTitle2.Text = "Daily Planner";
            // 
            // MakeAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 706);
            this.Controls.Add(this.txtPwd2);
            this.Controls.Add(this.btnBackLogin2);
            this.Controls.Add(this.txtUser2);
            this.Controls.Add(this.lblPwd2);
            this.Controls.Add(this.lblUser2);
            this.Controls.Add(this.lblMakeAccInst2);
            this.Controls.Add(this.lblTitle2);
            this.Controls.Add(this.lblLoginInst);
            this.Controls.Add(this.lblTitle);
            this.Name = "MakeAccountForm";
            this.Text = "MakeAccountForm";
            this.Load += new System.EventHandler(this.MakeAccountForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLoginInst;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtPwd2;
        private System.Windows.Forms.Button btnBackLogin2;
        private System.Windows.Forms.TextBox txtUser2;
        private System.Windows.Forms.Label lblPwd2;
        private System.Windows.Forms.Label lblUser2;
        private System.Windows.Forms.Label lblMakeAccInst2;
        private System.Windows.Forms.Label lblTitle2;
    }
}