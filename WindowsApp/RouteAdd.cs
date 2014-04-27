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
    public partial class RouteAdd : Form
    {
        public RouteAdd()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtboxDepartureCountry.Text != "" && txtboxDepartureTown.Text != "" && txtboxDestinationCountry.Text != "" && txtboxDestinationTown.Text != "" && txtboxPrice.Text != "")
            {
                try
                {
                    decimal price = decimal.Parse(txtboxPrice.Text);
                    Route route = new Route(txtboxDepartureCountry.Text, txtboxDepartureTown.Text, txtboxDestinationCountry.Text, txtboxDestinationTown.Text, price);
                    if (route.insertToDb())
                    {
                        MessageBox.Show("Route added to system!");
                        WindowsHandler.getInstance().getRouteManager().refreshData();
                    }
                    else
                    {
                        MessageBox.Show("Error occurred. Please try again!");
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
