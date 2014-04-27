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
    public class Booking
    {
        int bookingID, customerID, journeyID, numberOfSeats;
        DateTime dateOfJourney;
        List<String> allocatedSeats;
        decimal totalPrice;
        List<Movie> movies;

        #region Getters and Setters

        public int BookingID
        {
            get { return bookingID; }
        }

        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }

        public int JourneyID
        {
            get { return journeyID; }
            set { journeyID = value; }
        }

        public DateTime DateOfJourney
        {
            get { return dateOfJourney; }
            set { dateOfJourney = value; }
        }

        public int NumberOfSeats
        {
            get { return numberOfSeats; }
            set { numberOfSeats = value; }
        }

        public List<String> AllocatedSeats
        {
            get { return allocatedSeats; }
            set { allocatedSeats = value; }
        }

        public decimal TotalPrice
        {
            get { return totalPrice; }
        }

        public List<Movie> Movies
        {
            get { return movies; }
        }
        #endregion

        public Booking(int bookingID, int customerID, int journeyID, DateTime dateOfJourney, int numberOfSeats)
        {
            this.bookingID = bookingID;
            this.customerID = customerID;
            this.journeyID = journeyID;
            this.dateOfJourney = dateOfJourney;
            this.numberOfSeats = numberOfSeats;
            this.allocatedSeats = new List<string>();
        }

        public Booking(int customerID, int journeyID, DateTime dateOfJourney, int numberOfSeats)
        {
            this.bookingID = 0;
            this.customerID = customerID;
            this.journeyID = journeyID;
            this.dateOfJourney = dateOfJourney;
            this.numberOfSeats = numberOfSeats;
            this.allocatedSeats = new List<string>();
        }

        private decimal setTotalPrice(){
            decimal totalPrice = 0;
            Journey j = Journey.getJourneyByID(journeyID);
            Route r = Route.getRouteByID(j.RouteID);
            totalPrice += this.numberOfSeats * r.Price;

            totalPrice += this.movies.Count * 4;

            this.totalPrice = totalPrice;
            return totalPrice;
        }

        private List<Movie> setMovies()
        {
            List<Movie> movies = new List<Movie>();
            List<int> movieIDs = new List<int>();
            if(bookingID != 0)
            {
                string command = "SELECT * FROM ebRental WHERE booking_ID = " + bookingID + ";";
                SqlCommand sqlCommand = new SqlCommand(command, DbConn.getInstance().Conn);
                DbConn.getInstance().open();
                try
                {
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            movieIDs.Add(reader.GetInt32(reader.GetOrdinal("movie_ID")));
                        }
                    }
                }
                catch (ArgumentOutOfRangeException aoorex)
                {
                }
                catch (Exception ex)
                {
                }
                finally
                {
                    DbConn.getInstance().close();
                }
                foreach(int id in movieIDs)
                {
                    movies.Add(Movie.getMovieByID(id));
                }
                this.movies = movies;
                return movies;
            }
            else {
                return null;
            }
        }

        public static Booking getBookingByID(int id)
        {
            Booking booking = null;
            string command = "SELECT booking_ID AS 'Booking ID', customer_ID AS 'Customer ID', journey_ID AS 'Journey ID', dateOfJourney AS 'Date of Journey', numberOfSeats AS 'Number of Seats' " +
                "FROM ebBooking " +
                "WHERE booking_ID = " + id;
            SqlCommand sqlCommand = new SqlCommand(command, DbConn.getInstance().Conn);
            DbConn.getInstance().open();
            try
            {
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int bookingID = reader.GetInt32(reader.GetOrdinal("Booking ID"));
                        int cID = reader.GetInt32(reader.GetOrdinal("Customer ID"));
                        int jID = reader.GetInt32(reader.GetOrdinal("Journey ID"));
                        DateTime dateOfJ = reader.GetDateTime(reader.GetOrdinal("Date of Journey"));
                        int numberOfSeats = reader.GetInt32(reader.GetOrdinal("Number of Seats"));
                        booking = new Booking(bookingID, cID, jID, dateOfJ, numberOfSeats);
                    }
                }
            }
            catch (ArgumentOutOfRangeException aoorex)
            {
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                DbConn.getInstance().close();
            }
            booking.setMovies();
            booking.setTotalPrice();
            return booking;
        }

        public static List<Booking> getBookingsByCustomerID(int customerID)
        {
            List<Booking> bookings = new List<Booking>();
            string command = "SELECT booking_ID AS 'Booking ID', customer_ID AS 'Customer ID', journey_ID AS 'Journey ID', dateOfJourney AS 'Date of Journey', numberOfSeats AS 'Number of Seats' " +
                "FROM ebBooking " +
                "WHERE customer_ID = " + customerID;
            SqlCommand sqlCommand = new SqlCommand(command, DbConn.getInstance().Conn);
            DbConn.getInstance().open();
            try
            {
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int bookingID = reader.GetInt32(reader.GetOrdinal("Booking ID"));
                        int cID = reader.GetInt32(reader.GetOrdinal("Customer ID"));
                        int jID = reader.GetInt32(reader.GetOrdinal("Journey ID"));
                        DateTime dateOfJ = reader.GetDateTime(reader.GetOrdinal("Date of Journey"));
                        int numberOfSeats = reader.GetInt32(reader.GetOrdinal("Number of Seats"));
                        Booking b = new Booking(bookingID, cID, jID, dateOfJ, numberOfSeats);
                        bookings.Add(b);
                    }
                }
            }
            catch (ArgumentOutOfRangeException aoorex)
            {
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                DbConn.getInstance().close();
            }
            foreach (Booking b in bookings)
            {
                b.setMovies();
                b.setTotalPrice();
            }
            return bookings;
        }

        public static List<Booking> getBookingsByJourneyIDAndDateAsList(int journeyID, DateTime dateOfJourney)
        {
            List<Booking> bookings = new List<Booking>();
            string command = "SELECT booking_ID AS 'Booking ID', customer_ID AS 'Customer ID', journey_ID AS 'Journey ID', dateOfJourney AS 'Date of Journey', numberOfSeats AS 'Number of Seats' " +
                "FROM ebBooking " + 
                "WHERE journey_ID = " + journeyID + " " +
                "AND dateOfJourney = '" + dateOfJourney.ToString("dd/MM/yyyy HH:mm:ss") + "'";
            SqlCommand sqlCommand = new SqlCommand(command, DbConn.getInstance().Conn);
            DbConn.getInstance().open();
            try
            {
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int bookingID = reader.GetInt32(reader.GetOrdinal("Booking ID"));
                        int customerID = reader.GetInt32(reader.GetOrdinal("Customer ID"));
                        int jID = reader.GetInt32(reader.GetOrdinal("Journey ID"));
                        DateTime dateOfJ = reader.GetDateTime(reader.GetOrdinal("Date of Journey"));
                        int numberOfSeats = reader.GetInt32(reader.GetOrdinal("Number of Seats"));
                        Booking b = new Booking(bookingID, customerID, jID, dateOfJ, numberOfSeats);
                        bookings.Add(b);
                    }
                }
            }
            catch (ArgumentOutOfRangeException aoorex)
            {
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                DbConn.getInstance().close();
            }
            return bookings;
        }

        public static SqlDataAdapter getAllocatedSeatsByJourneyIDAndDateAsDataAdapter(int journeyID, DateTime dateOfJourney)
        {
            string selectCommand = "SELECT * FROM ebSeatingAllocation WHERE booking_ID = ANY ( " +
                "SELECT booking_ID FROM ebBooking WHERE journey_ID = " + journeyID + " AND dateOfJourney = '" + dateOfJourney.ToString("dd/MM/yyyy HH:mm:ss") + "')";
            SqlDataAdapter adapter = new SqlDataAdapter(selectCommand, DbConn.getInstance().Conn.ConnectionString);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
            return adapter;
        }

        public static SqlDataAdapter getDistinctJourneyIDAndDateAsDataAdapter()
        {
            string selectCommand = "SELECT DISTINCT journey_ID AS 'Journey ID', dateOfJourney AS 'Date Of Journey' FROM ebBooking;";
            SqlDataAdapter adapter = new SqlDataAdapter(selectCommand, DbConn.getInstance().Conn.ConnectionString);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
            return adapter;
        }

        public bool insertToDb()
        {
            string command = "INSERT INTO ebBooking(customer_ID, journey_ID, dateOfJourney, numberOfSeats) VALUES (@customerID, @journeyID, @dateOfJourney, @numberOfSeats)";

            SqlCommand sqlCommand = new SqlCommand(command, DbConn.getInstance().Conn);
            sqlCommand.Parameters.Add("@customerID", SqlDbType.Int);
            sqlCommand.Parameters.Add("@journeyID", SqlDbType.Int);
            sqlCommand.Parameters.Add("@dateOfJourney", SqlDbType.DateTime);
            sqlCommand.Parameters.Add("@numberOfSeats", SqlDbType.Int);

            sqlCommand.Parameters["@customerID"].Value = this.customerID;
            sqlCommand.Parameters["@journeyID"].Value = this.journeyID;
            sqlCommand.Parameters["@dateOfJourney"].Value = this.dateOfJourney;
            sqlCommand.Parameters["@numberOfSeats"].Value = this.numberOfSeats;

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

        public bool insertAllocatedSeatsToDb()
        {
            bool noErrors = true;
            foreach (String seat in AllocatedSeats)
            {
                string command = "INSERT INTO ebSeatingAllocation(booking_ID, seat) VALUES (@BookingID, @Seat)";

                SqlCommand sqlCommand = new SqlCommand(command, DbConn.getInstance().Conn);
                sqlCommand.Parameters.Add("@BookingID", SqlDbType.Int);
                sqlCommand.Parameters.Add("@Seat", SqlDbType.VarChar);

                sqlCommand.Parameters["@BookingID"].Value = this.bookingID;
                sqlCommand.Parameters["@Seat"].Value = seat;

                DbConn.getInstance().Conn.Open();
                int affectedRows = sqlCommand.ExecuteNonQuery();
                DbConn.getInstance().Conn.Close();

                if (affectedRows > 0)
                {
                }
                else
                {
                    noErrors = false;
                }
            }
            return noErrors;
        }

        public bool deleteAllocatedSeatsFromDb()
        {
            string command = "DELETE FROM ebSeatingAllocation WHERE booking_ID=@BookingID";

            SqlCommand sqlCommand = new SqlCommand(command, DbConn.getInstance().Conn);
            sqlCommand.Parameters.Add("@BookingID", SqlDbType.Int);

            sqlCommand.Parameters["@BookingID"].Value = this.bookingID;

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
