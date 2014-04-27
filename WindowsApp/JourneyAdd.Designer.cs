namespace WindowsApp
{
    partial class JourneyAdd
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
            this.cmbRoute = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTime = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCoach = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtboxRoute = new System.Windows.Forms.TextBox();
            this.txtboxTime = new System.Windows.Forms.TextBox();
            this.txtboxCoach = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbRoute
            // 
            this.cmbRoute.FormattingEnabled = true;
            this.cmbRoute.Location = new System.Drawing.Point(12, 49);
            this.cmbRoute.Name = "cmbRoute";
            this.cmbRoute.Size = new System.Drawing.Size(121, 21);
            this.cmbRoute.TabIndex = 0;
            this.cmbRoute.SelectedValueChanged += new System.EventHandler(this.cmbRoute_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select a route";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "+";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "+";
            // 
            // cmbTime
            // 
            this.cmbTime.FormattingEnabled = true;
            this.cmbTime.Location = new System.Drawing.Point(160, 48);
            this.cmbTime.Name = "cmbTime";
            this.cmbTime.Size = new System.Drawing.Size(121, 21);
            this.cmbTime.TabIndex = 4;
            this.cmbTime.SelectedValueChanged += new System.EventHandler(this.cmbTime_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "an operation time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "+";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(287, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "+";
            // 
            // cmbCoach
            // 
            this.cmbCoach.FormattingEnabled = true;
            this.cmbCoach.Location = new System.Drawing.Point(307, 48);
            this.cmbCoach.Name = "cmbCoach";
            this.cmbCoach.Size = new System.Drawing.Size(121, 21);
            this.cmbCoach.TabIndex = 8;
            this.cmbCoach.SelectedValueChanged += new System.EventHandler(this.cmbCoach_SelectedValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(347, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "a coach";
            // 
            // txtboxRoute
            // 
            this.txtboxRoute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxRoute.Location = new System.Drawing.Point(13, 77);
            this.txtboxRoute.Multiline = true;
            this.txtboxRoute.Name = "txtboxRoute";
            this.txtboxRoute.ReadOnly = true;
            this.txtboxRoute.Size = new System.Drawing.Size(120, 126);
            this.txtboxRoute.TabIndex = 10;
            // 
            // txtboxTime
            // 
            this.txtboxTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxTime.Location = new System.Drawing.Point(160, 77);
            this.txtboxTime.Multiline = true;
            this.txtboxTime.Name = "txtboxTime";
            this.txtboxTime.ReadOnly = true;
            this.txtboxTime.Size = new System.Drawing.Size(120, 126);
            this.txtboxTime.TabIndex = 11;
            // 
            // txtboxCoach
            // 
            this.txtboxCoach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxCoach.Location = new System.Drawing.Point(308, 77);
            this.txtboxCoach.Multiline = true;
            this.txtboxCoach.Name = "txtboxCoach";
            this.txtboxCoach.ReadOnly = true;
            this.txtboxCoach.Size = new System.Drawing.Size(120, 126);
            this.txtboxCoach.TabIndex = 12;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(13, 210);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(415, 23);
            this.btnCreate.TabIndex = 13;
            this.btnCreate.Text = "Create Journey!";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // JourneyAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 245);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtboxCoach);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtboxTime);
            this.Controls.Add(this.txtboxRoute);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbCoach);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbRoute);
            this.Name = "JourneyAdd";
            this.Text = "Add a new journey";
            this.Load += new System.EventHandler(this.JourneyAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRoute;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCoach;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtboxRoute;
        private System.Windows.Forms.TextBox txtboxTime;
        private System.Windows.Forms.TextBox txtboxCoach;
        private System.Windows.Forms.Button btnCreate;
    }
}