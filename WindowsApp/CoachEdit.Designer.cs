namespace WindowsApp
{
    partial class CoachEdit
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
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lblHeader = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxOriginalID = new System.Windows.Forms.TextBox();
            this.txtboxOriginalSeatsPerRow = new System.Windows.Forms.TextBox();
            this.txtboxOriginalRowsOfSeats = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(70, 188);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Update Coach";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtboxRowsOfSeats
            // 
            this.txtboxRowsOfSeats.Location = new System.Drawing.Point(104, 162);
            this.txtboxRowsOfSeats.Name = "txtboxRowsOfSeats";
            this.txtboxRowsOfSeats.Size = new System.Drawing.Size(100, 20);
            this.txtboxRowsOfSeats.TabIndex = 21;
            // 
            // txtboxSeatsPerRow
            // 
            this.txtboxSeatsPerRow.Location = new System.Drawing.Point(104, 140);
            this.txtboxSeatsPerRow.Name = "txtboxSeatsPerRow";
            this.txtboxSeatsPerRow.Size = new System.Drawing.Size(100, 20);
            this.txtboxSeatsPerRow.TabIndex = 20;
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Location = new System.Drawing.Point(16, 165);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(82, 13);
            this.lblTown.TabIndex = 19;
            this.lblTown.Text = "Rows of Seats: ";
            // 
            // lblSeatsPerRow
            // 
            this.lblSeatsPerRow.AutoSize = true;
            this.lblSeatsPerRow.Location = new System.Drawing.Point(16, 143);
            this.lblSeatsPerRow.Name = "lblSeatsPerRow";
            this.lblSeatsPerRow.Size = new System.Drawing.Size(81, 13);
            this.lblSeatsPerRow.TabIndex = 18;
            this.lblSeatsPerRow.Text = "Seats Per Row:";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(221, 225);
            this.shapeContainer1.TabIndex = 23;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 18;
            this.lineShape1.X2 = 203;
            this.lineShape1.Y1 = 123;
            this.lineShape1.Y2 = 123;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Location = new System.Drawing.Point(16, 18);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(77, 13);
            this.lblHeader.TabIndex = 24;
            this.lblHeader.Text = "Original Values";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Coach ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Seats Per Row:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Rows of Seats: ";
            // 
            // txtboxOriginalID
            // 
            this.txtboxOriginalID.Location = new System.Drawing.Point(104, 38);
            this.txtboxOriginalID.Name = "txtboxOriginalID";
            this.txtboxOriginalID.ReadOnly = true;
            this.txtboxOriginalID.Size = new System.Drawing.Size(100, 20);
            this.txtboxOriginalID.TabIndex = 28;
            // 
            // txtboxOriginalSeatsPerRow
            // 
            this.txtboxOriginalSeatsPerRow.Location = new System.Drawing.Point(104, 61);
            this.txtboxOriginalSeatsPerRow.Name = "txtboxOriginalSeatsPerRow";
            this.txtboxOriginalSeatsPerRow.ReadOnly = true;
            this.txtboxOriginalSeatsPerRow.Size = new System.Drawing.Size(100, 20);
            this.txtboxOriginalSeatsPerRow.TabIndex = 29;
            // 
            // txtboxOriginalRowsOfSeats
            // 
            this.txtboxOriginalRowsOfSeats.Location = new System.Drawing.Point(104, 86);
            this.txtboxOriginalRowsOfSeats.Name = "txtboxOriginalRowsOfSeats";
            this.txtboxOriginalRowsOfSeats.ReadOnly = true;
            this.txtboxOriginalRowsOfSeats.Size = new System.Drawing.Size(100, 20);
            this.txtboxOriginalRowsOfSeats.TabIndex = 30;
            // 
            // CoachEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 225);
            this.Controls.Add(this.txtboxOriginalRowsOfSeats);
            this.Controls.Add(this.txtboxOriginalSeatsPerRow);
            this.Controls.Add(this.txtboxOriginalID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtboxRowsOfSeats);
            this.Controls.Add(this.txtboxSeatsPerRow);
            this.Controls.Add(this.lblTown);
            this.Controls.Add(this.lblSeatsPerRow);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "CoachEdit";
            this.Text = "CoachEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtboxRowsOfSeats;
        private System.Windows.Forms.TextBox txtboxSeatsPerRow;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.Label lblSeatsPerRow;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxOriginalID;
        private System.Windows.Forms.TextBox txtboxOriginalSeatsPerRow;
        private System.Windows.Forms.TextBox txtboxOriginalRowsOfSeats;
    }
}