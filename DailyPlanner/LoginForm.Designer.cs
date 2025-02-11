namespace DailyPlanner
{
    partial class LoginForm
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
            this.btnMakeAcc1 = new System.Windows.Forms.Button();
            this.txtPwd1 = new System.Windows.Forms.TextBox();
            this.btnLogin1 = new System.Windows.Forms.Button();
            this.txtUser1 = new System.Windows.Forms.TextBox();
            this.lblPwd1 = new System.Windows.Forms.Label();
            this.lblUser1 = new System.Windows.Forms.Label();
            this.lblLoginInst1 = new System.Windows.Forms.Label();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMakeAcc1
            // 
            this.btnMakeAcc1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnMakeAcc1.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeAcc1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMakeAcc1.Location = new System.Drawing.Point(44, 577);
            this.btnMakeAcc1.Name = "btnMakeAcc1";
            this.btnMakeAcc1.Size = new System.Drawing.Size(312, 45);
            this.btnMakeAcc1.TabIndex = 15;
            this.btnMakeAcc1.Text = "Make Account";
            this.btnMakeAcc1.UseVisualStyleBackColor = false;
            this.btnMakeAcc1.Click += new System.EventHandler(this.btnMakeAcc1_Click);
            // 
            // txtPwd1
            // 
            this.txtPwd1.Location = new System.Drawing.Point(44, 423);
            this.txtPwd1.Name = "txtPwd1";
            this.txtPwd1.Size = new System.Drawing.Size(312, 20);
            this.txtPwd1.TabIndex = 14;
            // 
            // btnLogin1
            // 
            this.btnLogin1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLogin1.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLogin1.Location = new System.Drawing.Point(44, 512);
            this.btnLogin1.Name = "btnLogin1";
            this.btnLogin1.Size = new System.Drawing.Size(312, 45);
            this.btnLogin1.TabIndex = 13;
            this.btnLogin1.Text = "Log In";
            this.btnLogin1.UseVisualStyleBackColor = false;
            this.btnLogin1.Click += new System.EventHandler(this.btnLogin1_Click);
            // 
            // txtUser1
            // 
            this.txtUser1.Location = new System.Drawing.Point(44, 324);
            this.txtUser1.Name = "txtUser1";
            this.txtUser1.Size = new System.Drawing.Size(312, 20);
            this.txtUser1.TabIndex = 12;
            // 
            // lblPwd1
            // 
            this.lblPwd1.AutoSize = true;
            this.lblPwd1.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPwd1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPwd1.Location = new System.Drawing.Point(39, 379);
            this.lblPwd1.Name = "lblPwd1";
            this.lblPwd1.Size = new System.Drawing.Size(157, 30);
            this.lblPwd1.TabIndex = 11;
            this.lblPwd1.Text = "Password:";
            // 
            // lblUser1
            // 
            this.lblUser1.AutoSize = true;
            this.lblUser1.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUser1.Location = new System.Drawing.Point(39, 281);
            this.lblUser1.Name = "lblUser1";
            this.lblUser1.Size = new System.Drawing.Size(157, 30);
            this.lblUser1.TabIndex = 10;
            this.lblUser1.Text = "Username:";
            // 
            // lblLoginInst1
            // 
            this.lblLoginInst1.AutoSize = true;
            this.lblLoginInst1.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginInst1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLoginInst1.Location = new System.Drawing.Point(84, 133);
            this.lblLoginInst1.Name = "lblLoginInst1";
            this.lblLoginInst1.Size = new System.Drawing.Size(221, 90);
            this.lblLoginInst1.TabIndex = 9;
            this.lblLoginInst1.Text = "Please log in\r\nbelow or make\r\nan account.";
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitle1.Location = new System.Drawing.Point(2, 43);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(399, 50);
            this.lblTitle1.TabIndex = 8;
            this.lblTitle1.Text = "Daily Planner";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 706);
            this.Controls.Add(this.btnMakeAcc1);
            this.Controls.Add(this.txtPwd1);
            this.Controls.Add(this.btnLogin1);
            this.Controls.Add(this.txtUser1);
            this.Controls.Add(this.lblPwd1);
            this.Controls.Add(this.lblUser1);
            this.Controls.Add(this.lblLoginInst1);
            this.Controls.Add(this.lblTitle1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMakeAcc1;
        private System.Windows.Forms.TextBox txtPwd1;
        private System.Windows.Forms.Button btnLogin1;
        private System.Windows.Forms.TextBox txtUser1;
        private System.Windows.Forms.Label lblPwd1;
        private System.Windows.Forms.Label lblUser1;
        private System.Windows.Forms.Label lblLoginInst1;
        private System.Windows.Forms.Label lblTitle1;
    }
}