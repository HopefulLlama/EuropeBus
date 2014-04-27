using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlDb;

namespace Model
{
    public class Rental
    {
        int bookingID, movieID;

        #region Accessors and mutators
        public int RentalID
        {
            get { return movieID; }
            set { movieID = value; }
        }

        public int BookingID
        {
            get { return bookingID; }
            set { bookingID = value; }
        }
        #endregion

        public Rental(int bookingID, int movieID)
        {
            this.bookingID = bookingID;
            this.movieID = movieID;
        }

        public bool insertToDb()
        {
            string command = "INSERT INTO ebRental(booking_ID, movie_ID) VALUES (@bookingID, @movieID)";

            SqlCommand sqlCommand = new SqlCommand(command, DbConn.getInstance().Conn);
            sqlCommand.Parameters.Add("@bookingID", SqlDbType.Int);
            sqlCommand.Parameters.Add("@movieID", SqlDbType.Int);

            sqlCommand.Parameters["@bookingID"].Value = this.bookingID;
            sqlCommand.Parameters["@movieID"].Value = this.movieID;

            DbConn.getInstance().Conn.Open();
            int affectedRows = sqlCommand.ExecuteNonQuery();
            DbConn.getInstance().Conn.Close();

            if (affectedRows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
