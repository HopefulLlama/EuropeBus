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
    public partial class JourneyEdit : Form
    {
        Journey journey;
        DataSet routeDS, timeDS, coachDS;

        public JourneyEdit()
        {
            InitializeComponent();
        }

        private void JourneyEdit_Load(object sender, EventArgs e)
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

        public void setOriginalValues(int originalRouteID, int originalTimeID, int originalCoachID)
        {
            journey = new Journey(originalRouteID, originalTimeID, originalCoachID);
            txtboxOriginalRoute.Text = "" + originalRouteID;
            txtboxOriginalTime.Text = "" + originalTimeID;
            txtboxOriginalCoach.Text = "" + originalCoachID;
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            journey.RouteID = int.Parse("" + cmbRoute.SelectedValue);
            journey.TimeID = int.Parse("" + cmbTime.SelectedValue);
            journey.CoachID = int.Parse("" + cmbCoach.SelectedValue);
            if (journey.updateInDb())
            {
                WindowsHandler.getInstance().getJourneyManager().refreshData();
                WindowsHandler.getInstance().getJourneyEdit().Close();
                MessageBox.Show("Record successfully edited.");
            }
            else
            {
                MessageBox.Show("Error in creating record. Please try again later and contact an administrator if problem persists.");
            }
        }
    }
}
