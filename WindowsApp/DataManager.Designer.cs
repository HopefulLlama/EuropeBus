namespace WindowsApp
{
    partial class DataManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataManager));
            this.lblDataManager = new System.Windows.Forms.Label();
            this.btnJourneyLink = new System.Windows.Forms.Button();
            this.lblJourneyManager = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnRouteLink = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnCoachLink = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDataManager
            // 
            this.lblDataManager.AutoSize = true;
            this.lblDataManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataManager.Location = new System.Drawing.Point(78, 9);
            this.lblDataManager.Name = "lblDataManager";
            this.lblDataManager.Size = new System.Drawing.Size(149, 26);
            this.lblDataManager.TabIndex = 0;
            this.lblDataManager.Text = "Data Manager";
            // 
            // btnJourneyLink
            // 
            this.btnJourneyLink.Location = new System.Drawing.Point(12, 55);
            this.btnJourneyLink.Name = "btnJourneyLink";
            this.btnJourneyLink.Size = new System.Drawing.Size(268, 40);
            this.btnJourneyLink.TabIndex = 1;
            this.btnJourneyLink.Text = "Journey Manager";
            this.btnJourneyLink.UseVisualStyleBackColor = true;
            this.btnJourneyLink.Click += new System.EventHandler(this.btnJourneyLink_Click);
            // 
            // lblJourneyManager
            // 
            this.lblJourneyManager.Location = new System.Drawing.Point(12, 102);
            this.lblJourneyManager.Multiline = true;
            this.lblJourneyManager.Name = "lblJourneyManager";
            this.lblJourneyManager.Size = new System.Drawing.Size(268, 64);
            this.lblJourneyManager.TabIndex = 2;
            this.lblJourneyManager.Text = "Use the Journey Manager to view a list of all journeys. In addition, you may add," +
    " edit or delete journeys from here.  A journey is a combination of route, operat" +
    "ion time, and coach.";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 231);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 64);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Route Manager allows you to view all routes. You may manage the routes with the a" +
    "dd, edit and delete functions capabilities. A route makes up part of a journey, " +
    "specifying departures and destinations.";
            // 
            // btnRouteLink
            // 
            this.btnRouteLink.Location = new System.Drawing.Point(12, 184);
            this.btnRouteLink.Name = "btnRouteLink";
            this.btnRouteLink.Size = new System.Drawing.Size(268, 40);
            this.btnRouteLink.TabIndex = 3;
            this.btnRouteLink.Text = "Route Manager";
            this.btnRouteLink.UseVisualStyleBackColor = true;
            this.btnRouteLink.Click += new System.EventHandler(this.btnRouteLink_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 365);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(268, 64);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // btnCoachLink
            // 
            this.btnCoachLink.Location = new System.Drawing.Point(12, 318);
            this.btnCoachLink.Name = "btnCoachLink";
            this.btnCoachLink.Size = new System.Drawing.Size(268, 40);
            this.btnCoachLink.TabIndex = 5;
            this.btnCoachLink.Text = "Coach Manager";
            this.btnCoachLink.UseVisualStyleBackColor = true;
            this.btnCoachLink.Click += new System.EventHandler(this.btnCoachLink_Click);
            // 
            // DataManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 440);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnCoachLink);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnRouteLink);
            this.Controls.Add(this.lblJourneyManager);
            this.Controls.Add(this.btnJourneyLink);
            this.Controls.Add(this.lblDataManager);
            this.Name = "DataManager";
            this.Text = "Data Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDataManager;
        private System.Windows.Forms.Button btnJourneyLink;
        private System.Windows.Forms.TextBox lblJourneyManager;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnRouteLink;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnCoachLink;
    }
}