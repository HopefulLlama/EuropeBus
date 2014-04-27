namespace WindowsApp
{
    partial class RouteEdit
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
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtboxDestinationTown = new System.Windows.Forms.TextBox();
            this.txtboxDestinationCountry = new System.Windows.Forms.TextBox();
            this.txtboxDepartureTown = new System.Windows.Forms.TextBox();
            this.txtboxDepartureCountry = new System.Windows.Forms.TextBox();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblTown = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblDeparture = new System.Windows.Forms.Label();
            this.lblRouteNumberInfo = new System.Windows.Forms.Label();
            this.txtboxPrice = new PriceComponent.PriceComponent();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(133, 146);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 23;
            this.btnEdit.Text = "Save Details";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(23, 123);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 21;
            this.lblPrice.Text = "Price:";
            // 
            // txtboxDestinationTown
            // 
            this.txtboxDestinationTown.Location = new System.Drawing.Point(194, 73);
            this.txtboxDestinationTown.Name = "txtboxDestinationTown";
            this.txtboxDestinationTown.Size = new System.Drawing.Size(100, 20);
            this.txtboxDestinationTown.TabIndex = 20;
            // 
            // txtboxDestinationCountry
            // 
            this.txtboxDestinationCountry.Location = new System.Drawing.Point(194, 51);
            this.txtboxDestinationCountry.Name = "txtboxDestinationCountry";
            this.txtboxDestinationCountry.Size = new System.Drawing.Size(100, 20);
            this.txtboxDestinationCountry.TabIndex = 19;
            // 
            // txtboxDepartureTown
            // 
            this.txtboxDepartureTown.Location = new System.Drawing.Point(65, 73);
            this.txtboxDepartureTown.Name = "txtboxDepartureTown";
            this.txtboxDepartureTown.Size = new System.Drawing.Size(100, 20);
            this.txtboxDepartureTown.TabIndex = 18;
            // 
            // txtboxDepartureCountry
            // 
            this.txtboxDepartureCountry.Location = new System.Drawing.Point(65, 51);
            this.txtboxDepartureCountry.Name = "txtboxDepartureCountry";
            this.txtboxDepartureCountry.Size = new System.Drawing.Size(100, 20);
            this.txtboxDepartureCountry.TabIndex = 17;
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(214, 28);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(60, 13);
            this.lblDestination.TabIndex = 16;
            this.lblDestination.Text = "Destination";
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Location = new System.Drawing.Point(22, 76);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(37, 13);
            this.lblTown.TabIndex = 15;
            this.lblTown.Text = "Town:";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(13, 54);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(46, 13);
            this.lblCountry.TabIndex = 14;
            this.lblCountry.Text = "Country:";
            // 
            // lblDeparture
            // 
            this.lblDeparture.AutoSize = true;
            this.lblDeparture.Location = new System.Drawing.Point(87, 28);
            this.lblDeparture.Name = "lblDeparture";
            this.lblDeparture.Size = new System.Drawing.Size(54, 13);
            this.lblDeparture.TabIndex = 13;
            this.lblDeparture.Text = "Departure";
            // 
            // lblRouteNumberInfo
            // 
            this.lblRouteNumberInfo.AutoSize = true;
            this.lblRouteNumberInfo.Location = new System.Drawing.Point(15, 9);
            this.lblRouteNumberInfo.Name = "lblRouteNumberInfo";
            this.lblRouteNumberInfo.Size = new System.Drawing.Size(82, 13);
            this.lblRouteNumberInfo.TabIndex = 12;
            this.lblRouteNumberInfo.Text = "Route Number: ";
            // 
            // txtboxPrice
            // 
            this.txtboxPrice.ForeColor = System.Drawing.Color.Black;
            this.txtboxPrice.Location = new System.Drawing.Point(65, 120);
            this.txtboxPrice.Name = "txtboxPrice";
            this.txtboxPrice.Size = new System.Drawing.Size(100, 20);
            this.txtboxPrice.TabIndex = 24;
            // 
            // RouteEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 185);
            this.Controls.Add(this.txtboxPrice);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtboxDestinationTown);
            this.Controls.Add(this.txtboxDestinationCountry);
            this.Controls.Add(this.txtboxDepartureTown);
            this.Controls.Add(this.txtboxDepartureCountry);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.lblTown);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblDeparture);
            this.Controls.Add(this.lblRouteNumberInfo);
            this.Name = "RouteEdit";
            this.Text = "RouteEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtboxDestinationTown;
        private System.Windows.Forms.TextBox txtboxDestinationCountry;
        private System.Windows.Forms.TextBox txtboxDepartureTown;
        private System.Windows.Forms.TextBox txtboxDepartureCountry;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblDeparture;
        private System.Windows.Forms.Label lblRouteNumberInfo;
        private PriceComponent.PriceComponent txtboxPrice;
    }
}