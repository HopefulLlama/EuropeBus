using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace WindowsApp
{
    public partial class RouteEdit : Form
    {
        Route route;

        public RouteEdit()
        {
            InitializeComponent();
        }

        public void setOriginalValues(Route r)
        {
            this.route = r;
            lblRouteNumberInfo.Text = "Route Number: " + route.Id;
            txtboxDepartureCountry.Text = route.DepartureCountry;
            txtboxDepartureTown.Text = route.DepartureTown;
            txtboxDestinationCountry.Text = route.DestinationCountry;
            txtboxDestinationTown.Text = route.DestinationTown;
            txtboxPrice.Text = "" + route.Price;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtboxDepartureCountry.Text != "" && txtboxDepartureTown.Text != "" && txtboxDestinationCountry.Text != "" && txtboxDestinationTown.Text != "" && txtboxPrice.Text != "")
            {
                try
                {
                    decimal price = decimal.Parse(txtboxPrice.Text);
                    route.DepartureCountry = txtboxDepartureCountry.Text;
                    route.DepartureTown = txtboxDepartureTown.Text;
                    route.DestinationCountry = txtboxDestinationCountry.Text;
                    route.DestinationTown = txtboxDestinationTown.Text;
                    route.Price = price;
                    if(route.updateInDb())
                    {
                        WindowsHandler.getInstance().getRouteManager().refreshData();
                        WindowsHandler.getInstance().getRouteEdit().Close();
                        MessageBox.Show("Edit successful!");
                    } else {
                        MessageBox.Show("Error in persisting changes. Please try again.");
                    }
                }
                catch(FormatException fex)
                {
                    MessageBox.Show("Price must be a valid value.");
                }
            }
            else
            {
                MessageBox.Show("All fields must be filled in. Please correct and try again.");
            }
        }
    }
}
