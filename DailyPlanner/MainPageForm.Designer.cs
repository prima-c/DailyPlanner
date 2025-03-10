namespace DailyPlanner
{
    partial class MainPageForm
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch3 = new System.Windows.Forms.Label();
            this.lblTitle3 = new System.Windows.Forms.Label();
            this.lblSelectInst3 = new System.Windows.Forms.Label();
            this.btnLogOut3 = new System.Windows.Forms.Button();
            this.btnChangePwd3 = new System.Windows.Forms.Button();
            this.btnAddEvent3 = new System.Windows.Forms.Button();
            this.btnSeeEvents3 = new System.Windows.Forms.Button();
            this.btnSeeDay3 = new System.Windows.Forms.Button();
            this.btnSeeWeek3 = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(42, 157);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(312, 20);
            this.txtSearch.TabIndex = 31;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtPwd_TextChanged);
            // 
            // lblSearch3
            // 
            this.lblSearch3.AutoSize = true;
            this.lblSearch3.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSearch3.Location = new System.Drawing.Point(37, 119);
            this.lblSearch3.Name = "lblSearch3";
            this.lblSearch3.Size = new System.Drawing.Size(125, 30);
            this.lblSearch3.TabIndex = 28;
            this.lblSearch3.Text = "Search:";
            // 
            // lblTitle3
            // 
            this.lblTitle3.AutoSize = true;
            this.lblTitle3.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitle3.Location = new System.Drawing.Point(1, 35);
            this.lblTitle3.Name = "lblTitle3";
            this.lblTitle3.Size = new System.Drawing.Size(399, 50);
            this.lblTitle3.TabIndex = 25;
            this.lblTitle3.Text = "Daily Planner";
            // 
            // lblSelectInst3
            // 
            this.lblSelectInst3.AutoSize = true;
            this.lblSelectInst3.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectInst3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSelectInst3.Location = new System.Drawing.Point(78, 236);
            this.lblSelectInst3.Name = "lblSelectInst3";
            this.lblSelectInst3.Size = new System.Drawing.Size(237, 30);
            this.lblSelectInst3.TabIndex = 32;
            this.lblSelectInst3.Text = "Select action:";
            // 
            // btnLogOut3
            // 
            this.btnLogOut3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLogOut3.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLogOut3.Location = new System.Drawing.Point(42, 594);
            this.btnLogOut3.Name = "btnLogOut3";
            this.btnLogOut3.Size = new System.Drawing.Size(312, 45);
            this.btnLogOut3.TabIndex = 34;
            this.btnLogOut3.Text = "Log Out";
            this.btnLogOut3.UseVisualStyleBackColor = false;
            this.btnLogOut3.Click += new System.EventHandler(this.btnLogOut3_Click);
            // 
            // btnChangePwd3
            // 
            this.btnChangePwd3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnChangePwd3.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePwd3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnChangePwd3.Location = new System.Drawing.Point(42, 530);
            this.btnChangePwd3.Name = "btnChangePwd3";
            this.btnChangePwd3.Size = new System.Drawing.Size(312, 45);
            this.btnChangePwd3.TabIndex = 33;
            this.btnChangePwd3.Text = "Change Password";
            this.btnChangePwd3.UseVisualStyleBackColor = false;
            this.btnChangePwd3.Click += new System.EventHandler(this.btnChangePwd3_Click);
            // 
            // btnAddEvent3
            // 
            this.btnAddEvent3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddEvent3.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEvent3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddEvent3.Location = new System.Drawing.Point(42, 281);
            this.btnAddEvent3.Name = "btnAddEvent3";
            this.btnAddEvent3.Size = new System.Drawing.Size(146, 90);
            this.btnAddEvent3.TabIndex = 35;
            this.btnAddEvent3.Text = "Add Event";
            this.btnAddEvent3.UseVisualStyleBackColor = false;
            this.btnAddEvent3.Click += new System.EventHandler(this.btnAddEvent3_Click);
            // 
            // btnSeeEvents3
            // 
            this.btnSeeEvents3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSeeEvents3.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeeEvents3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSeeEvents3.Location = new System.Drawing.Point(208, 281);
            this.btnSeeEvents3.Name = "btnSeeEvents3";
            this.btnSeeEvents3.Size = new System.Drawing.Size(146, 90);
            this.btnSeeEvents3.TabIndex = 36;
            this.btnSeeEvents3.Text = "See Events";
            this.btnSeeEvents3.UseVisualStyleBackColor = false;
            this.btnSeeEvents3.Click += new System.EventHandler(this.btnSeeEvents3_Click);
            // 
            // btnSeeDay3
            // 
            this.btnSeeDay3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSeeDay3.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeeDay3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSeeDay3.Location = new System.Drawing.Point(42, 385);
            this.btnSeeDay3.Name = "btnSeeDay3";
            this.btnSeeDay3.Size = new System.Drawing.Size(146, 90);
            this.btnSeeDay3.TabIndex = 37;
            this.btnSeeDay3.Text = "See Day";
            this.btnSeeDay3.UseVisualStyleBackColor = false;
            this.btnSeeDay3.Click += new System.EventHandler(this.btnSeeDay3_Click);
            // 
            // btnSeeWeek3
            // 
            this.btnSeeWeek3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSeeWeek3.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeeWeek3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSeeWeek3.Location = new System.Drawing.Point(208, 385);
            this.btnSeeWeek3.Name = "btnSeeWeek3";
            this.btnSeeWeek3.Size = new System.Drawing.Size(146, 90);
            this.btnSeeWeek3.TabIndex = 38;
            this.btnSeeWeek3.Text = "See Week";
            this.btnSeeWeek3.UseVisualStyleBackColor = false;
            this.btnSeeWeek3.Click += new System.EventHandler(this.btnSeeWeek3_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSearch.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearch.Location = new System.Drawing.Point(233, 104);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(121, 45);
            this.btnSearch.TabIndex = 39;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // MainPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 706);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSeeWeek3);
            this.Controls.Add(this.btnSeeDay3);
            this.Controls.Add(this.btnSeeEvents3);
            this.Controls.Add(this.btnAddEvent3);
            this.Controls.Add(this.btnLogOut3);
            this.Controls.Add(this.btnChangePwd3);
            this.Controls.Add(this.lblSelectInst3);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch3);
            this.Controls.Add(this.lblTitle3);
            this.Name = "MainPageForm";
            this.Text = "MainPageForm";
            this.Load += new System.EventHandler(this.MainPageForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch3;
        private System.Windows.Forms.Label lblTitle3;
        private System.Windows.Forms.Label lblSelectInst3;
        private System.Windows.Forms.Button btnLogOut3;
        private System.Windows.Forms.Button btnChangePwd3;
        private System.Windows.Forms.Button btnAddEvent3;
        private System.Windows.Forms.Button btnSeeEvents3;
        private System.Windows.Forms.Button btnSeeDay3;
        private System.Windows.Forms.Button btnSeeWeek3;
        private System.Windows.Forms.Button btnSearch;
    }
}