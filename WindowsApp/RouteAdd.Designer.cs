namespace WindowsApp
{
    partial class RouteAdd
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
            this.lblRouteNumberInfo = new System.Windows.Forms.Label();
            this.lblDeparture = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblTown = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.txtboxDepartureTown = new System.Windows.Forms.TextBox();
            this.txtboxDepartureCountry = new System.Windows.Forms.TextBox();
            this.txtboxDestinationTown = new System.Windows.Forms.TextBox();
            this.txtboxDestinationCountry = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtboxPrice = new PriceComponent.PriceComponent();
            this.SuspendLayout();
            // 
            // lblRouteNumberInfo
            // 
            this.lblRouteNumberInfo.AutoSize = true;
            this.lblRouteNumberInfo.Location = new System.Drawing.Point(57, 9);
            this.lblRouteNumberInfo.Name = "lblRouteNumberInfo";
            this.lblRouteNumberInfo.Size = new System.Drawing.Size(219, 13);
            this.lblRouteNumberInfo.TabIndex = 0;
            this.lblRouteNumberInfo.Text = "Route number will be automatically allocated.";
            // 
            // lblDeparture
            // 
            this.lblDeparture.AutoSize = true;
            this.lblDeparture.Location = new System.Drawing.Point(82, 37);
            this.lblDeparture.Name = "lblDeparture";
            this.lblDeparture.Size = new System.Drawing.Size(54, 13);
            this.lblDeparture.TabIndex = 1;
            this.lblDeparture.Text = "Departure";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(8, 63);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(46, 13);
            this.lblCountry.TabIndex = 2;
            this.lblCountry.Text = "Country:";
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Location = new System.Drawing.Point(17, 85);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(37, 13);
            this.lblTown.TabIndex = 3;
            this.lblTown.Text = "Town:";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(209, 37);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(60, 13);
            this.lblDestination.TabIndex = 4;
            this.lblDestination.Text = "Destination";
            // 
            // txtboxDepartureCountry
            // 
            this.txtboxDepartureCountry.Location = new System.Drawing.Point(60, 60);
            this.txtboxDepartureCountry.Name = "txtboxDepartureCountry";
            this.txtboxDepartureCountry.Size = new System.Drawing.Size(100, 20);
            this.txtboxDepartureCountry.TabIndex = 5;
            // 
            // txtboxDepartureTown
            // 
            this.txtboxDepartureTown.Location = new System.Drawing.Point(60, 82);
            this.txtboxDepartureTown.Name = "txtboxDepartureTown";
            this.txtboxDepartureTown.Size = new System.Drawing.Size(100, 20);
            this.txtboxDepartureTown.TabIndex = 6;
            // 
            // txtboxDestinationTown
            // 
            this.txtboxDestinationTown.Location = new System.Drawing.Point(189, 82);
            this.txtboxDestinationTown.Name = "txtboxDestinationTown";
            this.txtboxDestinationTown.Size = new System.Drawing.Size(100, 20);
            this.txtboxDestinationTown.TabIndex = 8;
            // 
            // txtboxDestinationCountry
            // 
            this.txtboxDestinationCountry.Location = new System.Drawing.Point(189, 60);
            this.txtboxDestinationCountry.Name = "txtboxDestinationCountry";
            this.txtboxDestinationCountry.Size = new System.Drawing.Size(100, 20);
            this.txtboxDestinationCountry.TabIndex = 7;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(18, 132);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Price:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(128, 155);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add Route";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtboxPrice
            // 
            this.txtboxPrice.Location = new System.Drawing.Point(60, 129);
            this.txtboxPrice.Name = "txtboxPrice";
            this.txtboxPrice.Size = new System.Drawing.Size(100, 20);
            this.txtboxPrice.TabIndex = 12;
            // 
            // RouteAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 189);
            this.Controls.Add(this.txtboxPrice);
            this.Controls.Add(this.btnAdd);
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
            this.Name = "RouteAdd";
            this.Text = "RouteAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRouteNumberInfo;
        private System.Windows.Forms.Label lblDeparture;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.TextBox txtboxDepartureCountry;
        private System.Windows.Forms.TextBox txtboxDepartureTown;
        private System.Windows.Forms.TextBox txtboxDestinationTown;
        private System.Windows.Forms.TextBox txtboxDestinationCountry;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnAdd;
        private PriceComponent.PriceComponent txtboxPrice;
    }
}