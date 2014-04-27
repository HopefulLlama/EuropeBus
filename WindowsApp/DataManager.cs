using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class DataManager : Form
    {
        public DataManager()
        {
            InitializeComponent();
        }

        private void btnJourneyLink_Click(object sender, EventArgs e)
        {
            WindowsHandler.getInstance().getJourneyManager().Show();
        }

        private void btnRouteLink_Click(object sender, EventArgs e)
        {
            WindowsHandler.getInstance().getRouteManager().Show();
        }

        private void btnCoachLink_Click(object sender, EventArgs e)
        {
            WindowsHandler.getInstance().getCoachManager().Show();
        }
    }
}
