using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlDb;
using Model; 

namespace WindowsApp
{
    public partial class RouteManager : Form
    {
        private BindingSource bindingSourceRoutes = new BindingSource();
        private Route route;

        public RouteManager()
        {
            InitializeComponent();
        }

        private void RouteManager_Load(object sender, EventArgs e)
        {
            gridViewRoutes.DataSource = bindingSourceRoutes;
            refreshData();
        }

        public void refreshData()
        {
            getData(bindingSourceRoutes);
        }

        private void getData(BindingSource bindingSource)
        {
            try
            {
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                Route.getAllRoutesAsDataAdapter().Fill(table);

                bindingSource.DataSource = table;
            }
            catch (ArgumentOutOfRangeException aoorex)
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show("Probe 1: " + ex);
            }
        }

        private void gridViewRoutes_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int routeID = int.Parse("" + gridViewRoutes.SelectedRows[0].Cells[0].Value);
                string departureCountry = "" + gridViewRoutes.SelectedRows[0].Cells[1].Value;
                string departureTown = "" + gridViewRoutes.SelectedRows[0].Cells[2].Value;
                string destinationCountry = "" + gridViewRoutes.SelectedRows[0].Cells[3].Value;
                string destinationTown = "" + gridViewRoutes.SelectedRows[0].Cells[4].Value;
                decimal price = decimal.Parse("" + gridViewRoutes.SelectedRows[0].Cells[5].Value);

                route = new Route(routeID, departureCountry, departureTown, destinationCountry, destinationTown, price);
            }
            catch (ArgumentOutOfRangeException aoorex)
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show("Probe 1: " + ex);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            WindowsHandler.getInstance().getRouteAdd().Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult confirmDelete = MessageBox.Show("Are you sure you want to delete this record?", "Delete Warning!", MessageBoxButtons.YesNo);
            if (confirmDelete == DialogResult.Yes)
            {

                if (route.deleteFromDb())
                {
                    WindowsHandler.getInstance().getRouteManager().refreshData();
                    MessageBox.Show("Record successfully deleted.");
                }
                else
                {
                    MessageBox.Show("Error in deleting record. Please try again later and contact an administrator if problem persists.");
                }
            }
            else
            {
                MessageBox.Show("Deletion aborted.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            WindowsHandler.getInstance().getRouteEdit().setOriginalValues(route);
            WindowsHandler.getInstance().getRouteEdit().Show();
        }
    }
}
