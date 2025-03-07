namespace DailyPlanner
{
    partial class EventForm
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
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus9 = new System.Windows.Forms.Label();
            this.lblType9 = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblDesc9 = new System.Windows.Forms.Label();
            this.lblDate9 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblTitleDesc9 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnUpdateEvent9 = new System.Windows.Forms.Button();
            this.lblTitle9 = new System.Windows.Forms.Label();
            this.lblEditFields9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Not started",
            "In progress",
            "Complete",
            "Recurring"});
            this.cboStatus.Location = new System.Drawing.Point(167, 441);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(186, 21);
            this.cboStatus.TabIndex = 3;
            // 
            // lblStatus9
            // 
            this.lblStatus9.AutoSize = true;
            this.lblStatus9.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStatus9.Location = new System.Drawing.Point(36, 434);
            this.lblStatus9.Name = "lblStatus9";
            this.lblStatus9.Size = new System.Drawing.Size(125, 30);
            this.lblStatus9.TabIndex = 102;
            this.lblStatus9.Text = "Status:";
            // 
            // lblType9
            // 
            this.lblType9.AutoSize = true;
            this.lblType9.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblType9.Location = new System.Drawing.Point(36, 313);
            this.lblType9.Name = "lblType9";
            this.lblType9.Size = new System.Drawing.Size(93, 30);
            this.lblType9.TabIndex = 101;
            this.lblType9.Text = "Type:";
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "Meeting",
            "Appointment",
            "Exam",
            "Deadline"});
            this.cboType.Location = new System.Drawing.Point(127, 321);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(226, 21);
            this.cboType.TabIndex = 1;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(127, 501);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(226, 20);
            this.txtDesc.TabIndex = 4;
            // 
            // lblDesc9
            // 
            this.lblDesc9.AutoSize = true;
            this.lblDesc9.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDesc9.Location = new System.Drawing.Point(36, 493);
            this.lblDesc9.Name = "lblDesc9";
            this.lblDesc9.Size = new System.Drawing.Size(93, 30);
            this.lblDesc9.TabIndex = 98;
            this.lblDesc9.Text = "Desc:";
            // 
            // lblDate9
            // 
            this.lblDate9.AutoSize = true;
            this.lblDate9.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDate9.Location = new System.Drawing.Point(36, 372);
            this.lblDate9.Name = "lblDate9";
            this.lblDate9.Size = new System.Drawing.Size(93, 30);
            this.lblDate9.TabIndex = 97;
            this.lblDate9.Text = "Date:";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(127, 380);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(226, 20);
            this.txtDate.TabIndex = 2;
            // 
            // lblTitleDesc9
            // 
            this.lblTitleDesc9.AutoSize = true;
            this.lblTitleDesc9.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleDesc9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitleDesc9.Location = new System.Drawing.Point(36, 249);
            this.lblTitleDesc9.Name = "lblTitleDesc9";
            this.lblTitleDesc9.Size = new System.Drawing.Size(109, 30);
            this.lblTitleDesc9.TabIndex = 95;
            this.lblTitleDesc9.Text = "Title:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(142, 256);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(211, 20);
            this.txtTitle.TabIndex = 0;
            // 
            // btnUpdateEvent9
            // 
            this.btnUpdateEvent9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnUpdateEvent9.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateEvent9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdateEvent9.Location = new System.Drawing.Point(41, 607);
            this.btnUpdateEvent9.Name = "btnUpdateEvent9";
            this.btnUpdateEvent9.Size = new System.Drawing.Size(312, 45);
            this.btnUpdateEvent9.TabIndex = 5;
            this.btnUpdateEvent9.Text = "Update Event";
            this.btnUpdateEvent9.UseVisualStyleBackColor = false;
            this.btnUpdateEvent9.Click += new System.EventHandler(this.btnUpdateEvent9_Click);
            // 
            // lblTitle9
            // 
            this.lblTitle9.AutoSize = true;
            this.lblTitle9.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitle9.Location = new System.Drawing.Point(0, 55);
            this.lblTitle9.Name = "lblTitle9";
            this.lblTitle9.Size = new System.Drawing.Size(399, 50);
            this.lblTitle9.TabIndex = 91;
            this.lblTitle9.Text = "Daily Planner";
            // 
            // lblEditFields9
            // 
            this.lblEditFields9.AutoSize = true;
            this.lblEditFields9.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditFields9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEditFields9.Location = new System.Drawing.Point(62, 143);
            this.lblEditFields9.Name = "lblEditFields9";
            this.lblEditFields9.Size = new System.Drawing.Size(285, 60);
            this.lblEditFields9.TabIndex = 104;
            this.lblEditFields9.Text = "You can edit\r\nthe fields below.";
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 706);
            this.Controls.Add(this.lblEditFields9);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.lblStatus9);
            this.Controls.Add(this.lblType9);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.lblDesc9);
            this.Controls.Add(this.lblDate9);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lblTitleDesc9);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btnUpdateEvent9);
            this.Controls.Add(this.lblTitle9);
            this.Name = "EventForm";
            this.Text = "EventForm";
            this.Load += new System.EventHandler(this.EventForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label lblStatus9;
        private System.Windows.Forms.Label lblType9;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblDesc9;
        private System.Windows.Forms.Label lblDate9;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblTitleDesc9;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnUpdateEvent9;
        private System.Windows.Forms.Label lblTitle9;
        private System.Windows.Forms.Label lblEditFields9;
    }
}