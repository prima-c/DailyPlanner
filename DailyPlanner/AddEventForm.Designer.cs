namespace DailyPlanner
{
    partial class AddEventForm
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
            this.lblCompleteFields7 = new System.Windows.Forms.Label();
            this.btnUpdateEvent7 = new System.Windows.Forms.Button();
            this.lblTitle7 = new System.Windows.Forms.Label();
            this.txtTitle7 = new System.Windows.Forms.TextBox();
            this.lblTitleDesc7 = new System.Windows.Forms.Label();
            this.lblDate7 = new System.Windows.Forms.Label();
            this.txtDate7 = new System.Windows.Forms.TextBox();
            this.lblDesc7 = new System.Windows.Forms.Label();
            this.txtDesc7 = new System.Windows.Forms.TextBox();
            this.cmbType7 = new System.Windows.Forms.ComboBox();
            this.lblType7 = new System.Windows.Forms.Label();
            this.lblStatus7 = new System.Windows.Forms.Label();
            this.cmbStatus7 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblCompleteFields7
            // 
            this.lblCompleteFields7.AutoSize = true;
            this.lblCompleteFields7.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompleteFields7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCompleteFields7.Location = new System.Drawing.Point(91, 143);
            this.lblCompleteFields7.Name = "lblCompleteFields7";
            this.lblCompleteFields7.Size = new System.Drawing.Size(221, 60);
            this.lblCompleteFields7.TabIndex = 80;
            this.lblCompleteFields7.Text = "Complete the\r\nfields below.";
            // 
            // btnUpdateEvent7
            // 
            this.btnUpdateEvent7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnUpdateEvent7.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateEvent7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdateEvent7.Location = new System.Drawing.Point(41, 607);
            this.btnUpdateEvent7.Name = "btnUpdateEvent7";
            this.btnUpdateEvent7.Size = new System.Drawing.Size(312, 45);
            this.btnUpdateEvent7.TabIndex = 73;
            this.btnUpdateEvent7.Text = "Update Event";
            this.btnUpdateEvent7.UseVisualStyleBackColor = false;
            this.btnUpdateEvent7.Click += new System.EventHandler(this.btnUpdateEvent7_Click);
            // 
            // lblTitle7
            // 
            this.lblTitle7.AutoSize = true;
            this.lblTitle7.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitle7.Location = new System.Drawing.Point(0, 55);
            this.lblTitle7.Name = "lblTitle7";
            this.lblTitle7.Size = new System.Drawing.Size(399, 50);
            this.lblTitle7.TabIndex = 72;
            this.lblTitle7.Text = "Daily Planner";
            // 
            // txtTitle7
            // 
            this.txtTitle7.Location = new System.Drawing.Point(142, 256);
            this.txtTitle7.Name = "txtTitle7";
            this.txtTitle7.Size = new System.Drawing.Size(211, 20);
            this.txtTitle7.TabIndex = 81;
            // 
            // lblTitleDesc7
            // 
            this.lblTitleDesc7.AutoSize = true;
            this.lblTitleDesc7.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleDesc7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitleDesc7.Location = new System.Drawing.Point(36, 249);
            this.lblTitleDesc7.Name = "lblTitleDesc7";
            this.lblTitleDesc7.Size = new System.Drawing.Size(109, 30);
            this.lblTitleDesc7.TabIndex = 82;
            this.lblTitleDesc7.Text = "Title:";
            // 
            // lblDate7
            // 
            this.lblDate7.AutoSize = true;
            this.lblDate7.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDate7.Location = new System.Drawing.Point(36, 372);
            this.lblDate7.Name = "lblDate7";
            this.lblDate7.Size = new System.Drawing.Size(93, 30);
            this.lblDate7.TabIndex = 84;
            this.lblDate7.Text = "Date:";
            // 
            // txtDate7
            // 
            this.txtDate7.Location = new System.Drawing.Point(127, 380);
            this.txtDate7.Name = "txtDate7";
            this.txtDate7.Size = new System.Drawing.Size(226, 20);
            this.txtDate7.TabIndex = 83;
            // 
            // lblDesc7
            // 
            this.lblDesc7.AutoSize = true;
            this.lblDesc7.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDesc7.Location = new System.Drawing.Point(36, 493);
            this.lblDesc7.Name = "lblDesc7";
            this.lblDesc7.Size = new System.Drawing.Size(93, 30);
            this.lblDesc7.TabIndex = 85;
            this.lblDesc7.Text = "Desc:";
            // 
            // txtDesc7
            // 
            this.txtDesc7.Location = new System.Drawing.Point(127, 501);
            this.txtDesc7.Name = "txtDesc7";
            this.txtDesc7.Size = new System.Drawing.Size(226, 20);
            this.txtDesc7.TabIndex = 86;
            // 
            // cmbType7
            // 
            this.cmbType7.FormattingEnabled = true;
            this.cmbType7.Items.AddRange(new object[] {
            "Meeting",
            "Appointment",
            "Exam",
            "Deadline"});
            this.cmbType7.Location = new System.Drawing.Point(127, 321);
            this.cmbType7.Name = "cmbType7";
            this.cmbType7.Size = new System.Drawing.Size(226, 21);
            this.cmbType7.TabIndex = 87;
            // 
            // lblType7
            // 
            this.lblType7.AutoSize = true;
            this.lblType7.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblType7.Location = new System.Drawing.Point(36, 313);
            this.lblType7.Name = "lblType7";
            this.lblType7.Size = new System.Drawing.Size(93, 30);
            this.lblType7.TabIndex = 88;
            this.lblType7.Text = "Type:";
            // 
            // lblStatus7
            // 
            this.lblStatus7.AutoSize = true;
            this.lblStatus7.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStatus7.Location = new System.Drawing.Point(36, 434);
            this.lblStatus7.Name = "lblStatus7";
            this.lblStatus7.Size = new System.Drawing.Size(125, 30);
            this.lblStatus7.TabIndex = 89;
            this.lblStatus7.Text = "Status:";
            // 
            // cmbStatus7
            // 
            this.cmbStatus7.FormattingEnabled = true;
            this.cmbStatus7.Items.AddRange(new object[] {
            "Not started",
            "In progress",
            "Complete",
            "Recurring"});
            this.cmbStatus7.Location = new System.Drawing.Point(167, 441);
            this.cmbStatus7.Name = "cmbStatus7";
            this.cmbStatus7.Size = new System.Drawing.Size(186, 21);
            this.cmbStatus7.TabIndex = 90;
            // 
            // AddEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 706);
            this.Controls.Add(this.cmbStatus7);
            this.Controls.Add(this.lblStatus7);
            this.Controls.Add(this.lblType7);
            this.Controls.Add(this.cmbType7);
            this.Controls.Add(this.txtDesc7);
            this.Controls.Add(this.lblDesc7);
            this.Controls.Add(this.lblDate7);
            this.Controls.Add(this.txtDate7);
            this.Controls.Add(this.lblTitleDesc7);
            this.Controls.Add(this.txtTitle7);
            this.Controls.Add(this.lblCompleteFields7);
            this.Controls.Add(this.btnUpdateEvent7);
            this.Controls.Add(this.lblTitle7);
            this.Name = "AddEventForm";
            this.Text = "AddEventForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCompleteFields7;
        private System.Windows.Forms.Button btnUpdateEvent7;
        private System.Windows.Forms.Label lblTitle7;
        private System.Windows.Forms.TextBox txtTitle7;
        private System.Windows.Forms.Label lblTitleDesc7;
        private System.Windows.Forms.Label lblDate7;
        private System.Windows.Forms.TextBox txtDate7;
        private System.Windows.Forms.Label lblDesc7;
        private System.Windows.Forms.TextBox txtDesc7;
        private System.Windows.Forms.ComboBox cmbType7;
        private System.Windows.Forms.Label lblType7;
        private System.Windows.Forms.Label lblStatus7;
        private System.Windows.Forms.ComboBox cmbStatus7;
    }
}