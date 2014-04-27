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
    public partial class CoachAdd : Form
    {
        public CoachAdd()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int seats, rows;
            if(int.TryParse(txtboxSeatsPerRow.Text, out seats) && int.TryParse(txtboxRowsOfSeats.Text, out rows))
            {
                Coach coach = new Coach(seats, rows);
                if (coach.insertToDb())
                {
                    MessageBox.Show("Coach added to system!");
                    WindowsHandler.getInstance().getCoachManager().refreshData();
                }
                else
                {
                    MessageBox.Show("Error occurred. Please try again!");
                }
            }
        }
    }
}
