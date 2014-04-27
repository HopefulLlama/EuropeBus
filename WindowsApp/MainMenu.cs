using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Model;
using SeatingAllocationComponent;

namespace WindowsApp
{
    public partial class MainMenu : Form
    {        
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnDataLink_Click(object sender, EventArgs e)
        {
            WindowsHandler.getInstance().getDataManager().Show();
        }

        private void btnSeatAllocator_Click(object sender, EventArgs e)
        {
            WindowsHandler.getInstance().getSeatingAllocator().Show();
        }
    }
}
