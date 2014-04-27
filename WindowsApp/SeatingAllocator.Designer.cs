namespace WindowsApp
{
    partial class SeatingAllocator
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
            this.btnReallocateSeats = new System.Windows.Forms.Button();
            this.lblSeats = new System.Windows.Forms.Label();
            this.lblArrow1 = new System.Windows.Forms.Label();
            this.gridViewSeats = new System.Windows.Forms.DataGridView();
            this.lblBookingHeader = new System.Windows.Forms.Label();
            this.lblOperationTimes = new System.Windows.Forms.Label();
            this.gridViewOperationTimes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOperationTimes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReallocateSeats
            // 
            this.btnReallocateSeats.Location = new System.Drawing.Point(14, 339);
            this.btnReallocateSeats.Name = "btnReallocateSeats";
            this.btnReallocateSeats.Size = new System.Drawing.Size(197, 23);
            this.btnReallocateSeats.TabIndex = 16;
            this.btnReallocateSeats.Text = "Re-allocate Seats";
            this.btnReallocateSeats.UseVisualStyleBackColor = true;
            this.btnReallocateSeats.Click += new System.EventHandler(this.btnReallocateSeats_Click);
            // 
            // lblSeats
            // 
            this.lblSeats.AutoSize = true;
            this.lblSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeats.Location = new System.Drawing.Point(475, 29);
            this.lblSeats.Name = "lblSeats";
            this.lblSeats.Size = new System.Drawing.Size(68, 26);
            this.lblSeats.TabIndex = 15;
            this.lblSeats.Text = "Seats";
            // 
            // lblArrow1
            // 
            this.lblArrow1.AutoSize = true;
            this.lblArrow1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrow1.Location = new System.Drawing.Point(320, 160);
            this.lblArrow1.Name = "lblArrow1";
            this.lblArrow1.Size = new System.Drawing.Size(32, 26);
            this.lblArrow1.TabIndex = 14;
            this.lblArrow1.Text = "->";
            // 
            // gridViewSeats
            // 
            this.gridViewSeats.AllowUserToAddRows = false;
            this.gridViewSeats.AllowUserToDeleteRows = false;
            this.gridViewSeats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewSeats.Location = new System.Drawing.Point(358, 58);
            this.gridViewSeats.MultiSelect = false;
            this.gridViewSeats.Name = "gridViewSeats";
            this.gridViewSeats.ReadOnly = true;
            this.gridViewSeats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewSeats.Size = new System.Drawing.Size(313, 260);
            this.gridViewSeats.TabIndex = 13;
            // 
            // lblBookingHeader
            // 
            this.lblBookingHeader.AutoSize = true;
            this.lblBookingHeader.Location = new System.Drawing.Point(12, 9);
            this.lblBookingHeader.Name = "lblBookingHeader";
            this.lblBookingHeader.Size = new System.Drawing.Size(521, 13);
            this.lblBookingHeader.TabIndex = 12;
            this.lblBookingHeader.Text = "Select an item to view sub-items (i.e. : Operation Times have operation times whi" +
    "ch have assigned Bookings).";
            // 
            // lblOperationTimes
            // 
            this.lblOperationTimes.AutoSize = true;
            this.lblOperationTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperationTimes.Location = new System.Drawing.Point(84, 29);
            this.lblOperationTimes.Name = "lblOperationTimes";
            this.lblOperationTimes.Size = new System.Drawing.Size(172, 26);
            this.lblOperationTimes.TabIndex = 11;
            this.lblOperationTimes.Text = "Operation Times";
            // 
            // gridViewOperationTimes
            // 
            this.gridViewOperationTimes.AllowUserToAddRows = false;
            this.gridViewOperationTimes.AllowUserToDeleteRows = false;
            this.gridViewOperationTimes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewOperationTimes.Location = new System.Drawing.Point(13, 58);
            this.gridViewOperationTimes.MultiSelect = false;
            this.gridViewOperationTimes.Name = "gridViewOperationTimes";
            this.gridViewOperationTimes.ReadOnly = true;
            this.gridViewOperationTimes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewOperationTimes.Size = new System.Drawing.Size(295, 260);
            this.gridViewOperationTimes.TabIndex = 10;
            this.gridViewOperationTimes.SelectionChanged += new System.EventHandler(this.gridViewOperationTimes_SelectionChanged);
            // 
            // SeatingAllocator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 382);
            this.Controls.Add(this.btnReallocateSeats);
            this.Controls.Add(this.lblSeats);
            this.Controls.Add(this.lblArrow1);
            this.Controls.Add(this.gridViewSeats);
            this.Controls.Add(this.lblBookingHeader);
            this.Controls.Add(this.lblOperationTimes);
            this.Controls.Add(this.gridViewOperationTimes);
            this.Name = "SeatingAllocator";
            this.Text = "SeatingAllocator";
            this.Load += new System.EventHandler(this.SeatingAllocator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOperationTimes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReallocateSeats;
        private System.Windows.Forms.Label lblSeats;
        private System.Windows.Forms.Label lblArrow1;
        private System.Windows.Forms.DataGridView gridViewSeats;
        private System.Windows.Forms.Label lblBookingHeader;
        private System.Windows.Forms.Label lblOperationTimes;
        private System.Windows.Forms.DataGridView gridViewOperationTimes;

    }
}