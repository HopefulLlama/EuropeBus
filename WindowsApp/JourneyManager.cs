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
    public partial class JourneyManager : Form
    {
        private BindingSource bindingSourceRoutes = new BindingSource();
        private BindingSource bindingSourceTimes = new BindingSource();
        private BindingSource bindingSourceCoaches = new BindingSource();

        string routeID, timeID, coachID;

        public JourneyManager()
        {
            InitializeComponent();
        }

        private void getData(SqlDataAdapter adapter, BindingSource bindingSource)
        {
            try
            {
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);

                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.Fill(table);

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

        public void refreshData()
        {
            getData(Route.getAllRoutesAsDataAdapter(), bindingSourceRoutes);
        }

        private void RoutesManager_Load(object sender, EventArgs e)
        {
            gridViewRoutes.DataSource = bindingSourceRoutes;
            gridViewTimes.DataSource = bindingSourceTimes;
            gridViewCoaches.DataSource = bindingSourceCoaches;
            refreshData();
        }

        private void gridViewRoutes_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                routeID = "" + gridViewRoutes.SelectedRows[0].Cells[0].Value;
                getData(TimeOfWeek.getTimesByRouteIDAsSqlDataAdapter(int.Parse(routeID)), bindingSourceTimes);
            }
            catch (ArgumentOutOfRangeException aoorex)
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show("Probe 2: " + ex);
            }
        }

        private void gridViewTimes_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                timeID = "" + gridViewTimes.SelectedRows[0].Cells[0].Value;
                getData(Coach.getCoachesByRouteAndTimeIDAsSqlDataAdapter(int.Parse(routeID), int.Parse(timeID)), bindingSourceCoaches);
            }
            catch (ArgumentOutOfRangeException aoorex)
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show("Probe 3: " + ex);
            }
        }

        private void gridViewCoaches_SelectionChanged(object sender, EventArgs e)
        {
            coachID = "" + gridViewCoaches.SelectedRows[0].Cells[0].Value;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            WindowsHandler.getInstance().getJourneyAdd().Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            WindowsHandler.getInstance().getJourneyEdit().setOriginalValues(int.Parse(routeID), int.Parse(timeID), int.Parse(coachID));
            WindowsHandler.getInstance().getJourneyEdit().Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult confirmDelete = MessageBox.Show("Are you sure you want to delete this record?", "Delete Warning!", MessageBoxButtons.YesNo);
            if (confirmDelete == DialogResult.Yes)
            {
                Journey journey = new Journey(int.Parse(routeID), int.Parse(timeID), int.Parse(coachID));
                if (journey.deleteFromDb())
                {

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
    }
}
