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
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.btnBackLogin = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblMakeAccInst = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(42, 444);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(312, 20);
            this.txtPwd.TabIndex = 24;
            // 
            // btnBackLogin
            // 
            this.btnBackLogin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBackLogin.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBackLogin.Location = new System.Drawing.Point(42, 533);
            this.btnBackLogin.Name = "btnBackLogin";
            this.btnBackLogin.Size = new System.Drawing.Size(312, 45);
            this.btnBackLogin.TabIndex = 23;
            this.btnBackLogin.Text = "Back to Login";
            this.btnBackLogin.UseVisualStyleBackColor = false;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(42, 345);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(312, 20);
            this.txtUser.TabIndex = 22;
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPwd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPwd.Location = new System.Drawing.Point(37, 400);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(157, 30);
            this.lblPwd.TabIndex = 21;
            this.lblPwd.Text = "Password:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUser.Location = new System.Drawing.Point(37, 302);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(157, 30);
            this.lblUser.TabIndex = 20;
            this.lblUser.Text = "Username:";
            // 
            // lblMakeAccInst
            // 
            this.lblMakeAccInst.AutoSize = true;
            this.lblMakeAccInst.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMakeAccInst.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMakeAccInst.Location = new System.Drawing.Point(66, 155);
            this.lblMakeAccInst.Name = "lblMakeAccInst";
            this.lblMakeAccInst.Size = new System.Drawing.Size(269, 90);
            this.lblMakeAccInst.TabIndex = 19;
            this.lblMakeAccInst.Text = "Enter a username\r\nand password to\r\nmake an account.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(0, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(399, 50);
            this.label2.TabIndex = 18;
            this.label2.Text = "Daily Planner";
            // 
            // MakeAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 706);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.btnBackLogin);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblMakeAccInst);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLoginInst);
            this.Controls.Add(this.lblTitle);
            this.Name = "MakeAccountForm";
            this.Text = "MakeAccountForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLoginInst;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Button btnBackLogin;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblMakeAccInst;
        private System.Windows.Forms.Label label2;
    }
}