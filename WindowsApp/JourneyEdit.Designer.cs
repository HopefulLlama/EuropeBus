namespace WindowsApp
{
    partial class JourneyEdit
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtboxCoach = new System.Windows.Forms.TextBox();
            this.txtboxTime = new System.Windows.Forms.TextBox();
            this.txtboxRoute = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCoach = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTime = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbRoute = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtboxOriginalRoute = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtboxOriginalTime = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtboxOriginalCoach = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(26, 255);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(415, 23);
            this.btnEdit.TabIndex = 26;
            this.btnEdit.Text = "Edit Journey!";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtboxCoach
            // 
            this.txtboxCoach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxCoach.Location = new System.Drawing.Point(321, 122);
            this.txtboxCoach.Multiline = true;
            this.txtboxCoach.Name = "txtboxCoach";
            this.txtboxCoach.ReadOnly = true;
            this.txtboxCoach.Size = new System.Drawing.Size(120, 126);
            this.txtboxCoach.TabIndex = 25;
            // 
            // txtboxTime
            // 
            this.txtboxTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxTime.Location = new System.Drawing.Point(173, 122);
            this.txtboxTime.Multiline = true;
            this.txtboxTime.Name = "txtboxTime";
            this.txtboxTime.ReadOnly = true;
            this.txtboxTime.Size = new System.Drawing.Size(120, 126);
            this.txtboxTime.TabIndex = 24;
            // 
            // txtboxRoute
            // 
            this.txtboxRoute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxRoute.Location = new System.Drawing.Point(26, 122);
            this.txtboxRoute.Multiline = true;
            this.txtboxRoute.Name = "txtboxRoute";
            this.txtboxRoute.ReadOnly = true;
            this.txtboxRoute.Size = new System.Drawing.Size(120, 126);
            this.txtboxRoute.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(360, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "a coach";
            // 
            // cmbCoach
            // 
            this.cmbCoach.FormattingEnabled = true;
            this.cmbCoach.Location = new System.Drawing.Point(320, 93);
            this.cmbCoach.Name = "cmbCoach";
            this.cmbCoach.Size = new System.Drawing.Size(121, 21);
            this.cmbCoach.TabIndex = 21;
            this.cmbCoach.SelectedValueChanged += new System.EventHandler(this.cmbCoach_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(300, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "+";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "an operation time";
            // 
            // cmbTime
            // 
            this.cmbTime.FormattingEnabled = true;
            this.cmbTime.Location = new System.Drawing.Point(173, 93);
            this.cmbTime.Name = "cmbTime";
            this.cmbTime.Size = new System.Drawing.Size(121, 21);
            this.cmbTime.TabIndex = 18;
            this.cmbTime.SelectedValueChanged += new System.EventHandler(this.cmbTime_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "+";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Select a journey";
            // 
            // cmbRoute
            // 
            this.cmbRoute.FormattingEnabled = true;
            this.cmbRoute.Location = new System.Drawing.Point(25, 94);
            this.cmbRoute.Name = "cmbRoute";
            this.cmbRoute.Size = new System.Drawing.Size(121, 21);
            this.cmbRoute.TabIndex = 14;
            this.cmbRoute.SelectedValueChanged += new System.EventHandler(this.cmbRoute_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Original Route";
            // 
            // txtboxOriginalRoute
            // 
            this.txtboxOriginalRoute.Location = new System.Drawing.Point(106, 10);
            this.txtboxOriginalRoute.Name = "txtboxOriginalRoute";
            this.txtboxOriginalRoute.ReadOnly = true;
            this.txtboxOriginalRoute.Size = new System.Drawing.Size(40, 20);
            this.txtboxOriginalRoute.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(170, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Original Time";
            // 
            // txtboxOriginalTime
            // 
            this.txtboxOriginalTime.Location = new System.Drawing.Point(244, 10);
            this.txtboxOriginalTime.Name = "txtboxOriginalTime";
            this.txtboxOriginalTime.ReadOnly = true;
            this.txtboxOriginalTime.Size = new System.Drawing.Size(50, 20);
            this.txtboxOriginalTime.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(318, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Original Coach";
            // 
            // txtboxOriginalCoach
            // 
            this.txtboxOriginalCoach.Location = new System.Drawing.Point(401, 13);
            this.txtboxOriginalCoach.Name = "txtboxOriginalCoach";
            this.txtboxOriginalCoach.ReadOnly = true;
            this.txtboxOriginalCoach.Size = new System.Drawing.Size(40, 20);
            this.txtboxOriginalCoach.TabIndex = 32;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(465, 293);
            this.shapeContainer1.TabIndex = 36;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 13;
            this.lineShape1.X2 = 452;
            this.lineShape1.Y1 = 41;
            this.lineShape1.Y2 = 41;
            // 
            // JourneyEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 293);
            this.Controls.Add(this.txtboxOriginalCoach);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtboxOriginalTime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtboxOriginalRoute);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtboxCoach);
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
            this.Controls.Add(this.shapeContainer1);
            this.Name = "JourneyEdit";
            this.Text = "Edit Journey";
            this.Load += new System.EventHandler(this.JourneyEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtboxCoach;
        private System.Windows.Forms.TextBox txtboxTime;
        private System.Windows.Forms.TextBox txtboxRoute;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbCoach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRoute;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtboxOriginalRoute;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtboxOriginalTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtboxOriginalCoach;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}