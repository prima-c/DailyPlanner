namespace DailyPlanner
{
    partial class SeeEventsForm
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
            this.btnChangeDate5 = new System.Windows.Forms.Button();
            this.btnMainPage6 = new System.Windows.Forms.Button();
            this.lblTitle6 = new System.Windows.Forms.Label();
            this.lblUpcomingEvents6 = new System.Windows.Forms.Label();
            this.cmbEventList6 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnChangeDate5
            // 
            this.btnChangeDate5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnChangeDate5.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeDate5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnChangeDate5.Location = new System.Drawing.Point(41, 141);
            this.btnChangeDate5.Name = "btnChangeDate5";
            this.btnChangeDate5.Size = new System.Drawing.Size(0, 0);
            this.btnChangeDate5.TabIndex = 70;
            this.btnChangeDate5.Text = "Date";
            this.btnChangeDate5.UseVisualStyleBackColor = false;
            // 
            // btnMainPage6
            // 
            this.btnMainPage6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnMainPage6.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainPage6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMainPage6.Location = new System.Drawing.Point(41, 607);
            this.btnMainPage6.Name = "btnMainPage6";
            this.btnMainPage6.Size = new System.Drawing.Size(312, 45);
            this.btnMainPage6.TabIndex = 63;
            this.btnMainPage6.Text = "Main Page";
            this.btnMainPage6.UseVisualStyleBackColor = false;
            this.btnMainPage6.Click += new System.EventHandler(this.btnMainPage6_Click);
            // 
            // lblTitle6
            // 
            this.lblTitle6.AutoSize = true;
            this.lblTitle6.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitle6.Location = new System.Drawing.Point(0, 55);
            this.lblTitle6.Name = "lblTitle6";
            this.lblTitle6.Size = new System.Drawing.Size(399, 50);
            this.lblTitle6.TabIndex = 62;
            this.lblTitle6.Text = "Daily Planner";
            // 
            // lblUpcomingEvents6
            // 
            this.lblUpcomingEvents6.AutoSize = true;
            this.lblUpcomingEvents6.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpcomingEvents6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUpcomingEvents6.Location = new System.Drawing.Point(52, 274);
            this.lblUpcomingEvents6.Name = "lblUpcomingEvents6";
            this.lblUpcomingEvents6.Size = new System.Drawing.Size(301, 60);
            this.lblUpcomingEvents6.TabIndex = 71;
            this.lblUpcomingEvents6.Text = "Select an upcoming\r\nevent to view:";
            // 
            // cmbEventList6
            // 
            this.cmbEventList6.FormattingEnabled = true;
            this.cmbEventList6.Items.AddRange(new object[] {
            "Meeting",
            "Appointment",
            "Exam",
            "Deadline"});
            this.cmbEventList6.Location = new System.Drawing.Point(84, 365);
            this.cmbEventList6.Name = "cmbEventList6";
            this.cmbEventList6.Size = new System.Drawing.Size(226, 21);
            this.cmbEventList6.TabIndex = 88;
            this.cmbEventList6.SelectedIndexChanged += new System.EventHandler(this.cmbEventList6_SelectedIndexChanged);
            // 
            // SeeEventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 706);
            this.Controls.Add(this.cmbEventList6);
            this.Controls.Add(this.lblUpcomingEvents6);
            this.Controls.Add(this.btnChangeDate5);
            this.Controls.Add(this.btnMainPage6);
            this.Controls.Add(this.lblTitle6);
            this.Name = "SeeEventsForm";
            this.Text = "SeeEventsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChangeDate5;
        private System.Windows.Forms.Button btnMainPage6;
        private System.Windows.Forms.Label lblTitle6;
        private System.Windows.Forms.Label lblUpcomingEvents6;
        private System.Windows.Forms.ComboBox cmbEventList6;
    }
}