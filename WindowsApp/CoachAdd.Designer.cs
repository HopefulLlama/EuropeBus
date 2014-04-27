namespace WindowsApp
{
    partial class CoachAdd
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtboxRowsOfSeats = new System.Windows.Forms.TextBox();
            this.txtboxSeatsPerRow = new System.Windows.Forms.TextBox();
            this.lblTown = new System.Windows.Forms.Label();
            this.lblSeatsPerRow = new System.Windows.Forms.Label();
            this.lblRouteNumberInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(99, 82);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add Coach";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtboxRowsOfSeats
            // 
            this.txtboxRowsOfSeats.Location = new System.Drawing.Point(133, 56);
            this.txtboxRowsOfSeats.Name = "txtboxRowsOfSeats";
            this.txtboxRowsOfSeats.Size = new System.Drawing.Size(100, 20);
            this.txtboxRowsOfSeats.TabIndex = 16;
            // 
            // txtboxSeatsPerRow
            // 
            this.txtboxSeatsPerRow.Location = new System.Drawing.Point(133, 34);
            this.txtboxSeatsPerRow.Name = "txtboxSeatsPerRow";
            this.txtboxSeatsPerRow.Size = new System.Drawing.Size(100, 20);
            this.txtboxSeatsPerRow.TabIndex = 15;
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Location = new System.Drawing.Point(45, 59);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(82, 13);
            this.lblTown.TabIndex = 14;
            this.lblTown.Text = "Rows of Seats: ";
            // 
            // lblSeatsPerRow
            // 
            this.lblSeatsPerRow.AutoSize = true;
            this.lblSeatsPerRow.Location = new System.Drawing.Point(45, 37);
            this.lblSeatsPerRow.Name = "lblSeatsPerRow";
            this.lblSeatsPerRow.Size = new System.Drawing.Size(81, 13);
            this.lblSeatsPerRow.TabIndex = 13;
            this.lblSeatsPerRow.Text = "Seats Per Row:";
            // 
            // lblRouteNumberInfo
            // 
            this.lblRouteNumberInfo.AutoSize = true;
            this.lblRouteNumberInfo.Location = new System.Drawing.Point(36, 9);
            this.lblRouteNumberInfo.Name = "lblRouteNumberInfo";
            this.lblRouteNumberInfo.Size = new System.Drawing.Size(221, 13);
            this.lblRouteNumberInfo.TabIndex = 12;
            this.lblRouteNumberInfo.Text = "Coach number will be automatically allocated.";
            // 
            // CoachAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 116);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtboxRowsOfSeats);
            this.Controls.Add(this.txtboxSeatsPerRow);
            this.Controls.Add(this.lblTown);
            this.Controls.Add(this.lblSeatsPerRow);
            this.Controls.Add(this.lblRouteNumberInfo);
            this.Name = "CoachAdd";
            this.Text = "CoachAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtboxRowsOfSeats;
        private System.Windows.Forms.TextBox txtboxSeatsPerRow;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.Label lblSeatsPerRow;
        private System.Windows.Forms.Label lblRouteNumberInfo;
    }
}