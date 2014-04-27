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
    public partial class JourneyAdd : Form
    {
        DataSet routeDS, timeDS, coachDS;
        public JourneyAdd()
        {
            InitializeComponent();
        }

        private void JourneyAdd_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adapterRoute = new SqlDataAdapter("SELECT * FROM ebRoute", DbConn.getInstance().Conn.ConnectionString);
            routeDS = new DataSet();
            adapterRoute.Fill(routeDS);
            cmbRoute.DataSource = routeDS.Tables[0];
            cmbRoute.ValueMember = "route_ID";
            cmbRoute.DisplayMember = "route_ID";

            SqlDataAdapter adapterTime = new SqlDataAdapter("SELECT ebTimeOfWeek.time_ID, ebTimeOfWeek.time, ebDay.day, CONCAT(ebDay.day, CONCAT(' - ', ebTimeOfWeek.time)) AS 'display' FROM ebTimeOfWeek, ebDay WHERE ebTimeOfWeek.day_ID = ebDay.day_ID", DbConn.getInstance().Conn.ConnectionString);
            timeDS = new DataSet();
            adapterTime.Fill(timeDS);
            cmbTime.DataSource = timeDS.Tables[0];
            cmbTime.ValueMember = "time_ID";
            cmbTime.DisplayMember = "display";

            SqlDataAdapter adapterCoach = new SqlDataAdapter("SELECT *, CONCAT(coach_ID,CONCAT(' - Seats: ', ( rows * seats))) AS 'display' FROM ebCoach", DbConn.getInstance().Conn.ConnectionString);
            coachDS = new DataSet();
            adapterCoach.Fill(coachDS);
            cmbCoach.DataSource = coachDS.Tables[0];
            cmbCoach.ValueMember = "coach_ID";
            cmbCoach.DisplayMember = "display";
        }

        private void cmbRoute_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow dr in routeDS.Tables[0].Rows)
                {
                    if (int.Parse("" + dr["route_ID"]) == int.Parse("" + cmbRoute.SelectedValue))
                    {
                        txtboxRoute.Text = "Departure: " + dr["departure_country"] + ", " + dr["departure_town"] + Environment.NewLine + 
                            "Destination: " + dr["destination_country"] + ", " + dr["destination_town"] + Environment.NewLine + 
                            "Price: " + dr["price"];
                    }
                }
            }
            catch (FormatException fe)
            {
            }
        }

        private void cmbTime_SelectedValueChanged(object sender, EventArgs e)
        {
            txtboxTime.Text = cmbTime.Text;
        }

        private void cmbCoach_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow dr in coachDS.Tables[0].Rows)
                {
                    if (int.Parse("" + dr["coach_ID"]) == int.Parse("" + cmbCoach.SelectedValue))
                    {
                        txtboxCoach.Text = "Coach Number: " + dr["coach_ID"] + Environment.NewLine + 
                            "Rows of Seats: " + dr["rows"] + Environment.NewLine + 
                            "Seats per Row: " + dr["seats"];
                    }
                }
            }
            catch (FormatException fe)
            {
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Journey journey = new Journey(int.Parse("" + cmbRoute.SelectedValue), int.Parse("" + cmbTime.SelectedValue), int.Parse("" + cmbCoach.SelectedValue));
            if (journey.insertToDb())
            {
                WindowsHandler.getInstance().getJourneyManager().refreshData();
                MessageBox.Show("Record successfully added.");
            }
            else
            {
                MessageBox.Show("Error in creating record. Please try again later and contact an administrator if problem persists.");
            }
        }
    }
}
