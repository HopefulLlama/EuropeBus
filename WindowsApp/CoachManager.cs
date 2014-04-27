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
    public partial class CoachManager : Form
    {
        private BindingSource bindingSourceCoaches= new BindingSource();
        private Coach coach;

        public CoachManager()
        {
            InitializeComponent();
        }

        private void CoachManager_Load(object sender, EventArgs e)
        {
            gridViewCoaches.DataSource = bindingSourceCoaches;
            refreshData();
        }

        public void refreshData()
        {
            getData(bindingSourceCoaches);
        }

        private void getData(BindingSource bindingSource)
        {
            try
            {
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                Coach.getAllCoachesAsDataAdapter().Fill(table);

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            WindowsHandler.getInstance().getCoachAdd().Show();
        }

        private void gridViewCoaches_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse("" + gridViewCoaches.SelectedRows[0].Cells[0].Value);
                int seats = int.Parse("" + gridViewCoaches.SelectedRows[0].Cells[1].Value);
                int rows = int.Parse("" + gridViewCoaches.SelectedRows[0].Cells[2].Value);

                coach = new Coach(id, seats, rows);
            }
            catch (ArgumentOutOfRangeException aoorex)
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show("Probe 1: " + ex);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            WindowsHandler.getInstance().getCoachEdit().setOriginalValues(coach);
            WindowsHandler.getInstance().getCoachEdit().Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult confirmDelete = MessageBox.Show("Are you sure you want to delete this record?", "Delete Warning!", MessageBoxButtons.YesNo);
            if (confirmDelete == DialogResult.Yes)
            {
                if (coach.deleteFromDb())
                {
                    refreshData();
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
