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
using SeatingAllocationComponent;

namespace WindowsApp
{
    public partial class SeatingAllocator : Form
    {
        private BindingSource bindingSourceOperationTimes = new BindingSource();
        private BindingSource bindingSourceSeats = new BindingSource();

        int journeyID;
        DateTime date;

        public SeatingAllocator()
        {
            InitializeComponent();
        }

        private void refreshData()
        {
            getData(Booking.getDistinctJourneyIDAndDateAsDataAdapter(), bindingSourceOperationTimes);
        }

        private void SeatingAllocator_Load(object sender, EventArgs e)
        {
            gridViewOperationTimes.DataSource = bindingSourceOperationTimes;
            gridViewSeats.DataSource = bindingSourceSeats;
            refreshData();
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

        private void gridViewOperationTimes_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                journeyID = int.Parse(gridViewOperationTimes.SelectedRows[0].Cells[0].Value.ToString());
                date = DateTime.Parse(gridViewOperationTimes.SelectedRows[0].Cells[1].Value.ToString());
                getData(Booking.getAllocatedSeatsByJourneyIDAndDateAsDataAdapter(journeyID, date), bindingSourceSeats);
            }
            catch (ArgumentOutOfRangeException aoorex)
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show("Probe 2: " + ex);
            }
        }

        private void btnReallocateSeats_Click(object sender, EventArgs e)
        {
            List<Booking> bookings = Booking.getBookingsByJourneyIDAndDateAsList(journeyID, date);
            Journey j = Journey.getJourneyByID(journeyID);
            Coach c = Coach.getCoachByID(j.CoachID);
            SeatAllocator.allocateSeats(bookings, c);
            StringBuilder str = new StringBuilder();
            foreach (Booking b in bookings)
            {
                str.Append(b.BookingID.ToString()+": ");
                foreach (String s in b.AllocatedSeats)
                {
                    str.Append(s+" ");
                }
                str.Append("\n");
            }
            refreshData();
            MessageBox.Show("Seats reallocated");
        }

    }
}
