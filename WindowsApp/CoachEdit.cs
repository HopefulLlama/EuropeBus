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
    public partial class CoachEdit : Form
    {
        Coach coach;

        public CoachEdit()
        {
            InitializeComponent();
        }

        public void setOriginalValues(Coach c)
        {
            this.coach = c;
            txtboxOriginalID.Text = "" + coach.Id;
            txtboxOriginalSeatsPerRow.Text = "" + coach.SeatsPerRow;
            txtboxOriginalRowsOfSeats.Text = "" + coach.RowOfSeats;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int seats, rows;
            if (int.TryParse(txtboxSeatsPerRow.Text, out seats) && int.TryParse(txtboxRowsOfSeats.Text, out rows))
            {
                coach.SeatsPerRow = seats;
                coach.RowOfSeats = rows;
                if (coach.updateInDb())
                {
                    MessageBox.Show("Coach updated in system!");
                    WindowsHandler.getInstance().getCoachManager().refreshData();
                    WindowsHandler.getInstance().getCoachEdit().Close();
                }
                else
                {
                    MessageBox.Show("Error occurred. Please try again!");
                }
            }
        }
    }
}
