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
    public class Coach
    {
        private int id, rowOfSeats, seatsPerRow, bookings;

        #region Getters and setters
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int RowOfSeats
        {
            get { return rowOfSeats; }
            set { rowOfSeats = value; }
        }

        public int SeatsPerRow
        {
            get { return seatsPerRow; }
            set { seatsPerRow = value; }
        }

        public int Capacity
        {
            get { return seatsPerRow * rowOfSeats; }
        }
        #endregion

        public Coach(int seatsPerRow, int rowOfSeats)
        {
            this.Id = 0;
            this.RowOfSeats = rowOfSeats;
            this.SeatsPerRow = seatsPerRow;
            this.bookings = 0;
        }

        public Coach(int id, int seatsPerRow, int rowOfSeats)
        {
            this.Id = id;
            this.RowOfSeats = rowOfSeats;
            this.SeatsPerRow = seatsPerRow;
            this.bookings = 0;
        }

        public static Coach getCoachByID(int id)
        {
            Coach c = null;
            string command = "SELECT coach_ID AS 'Coach ID', seats AS 'Seats per Row', rows AS 'Rows of Seats' FROM ebCoach WHERE ebCoach.coach_ID = " + id + ";";
            SqlCommand sqlCommand = new SqlCommand(command, DbConn.getInstance().Conn);
            DbConn.getInstance().open();
            try
            {
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int coachID = reader.GetInt32(reader.GetOrdinal("Coach ID"));
                        int seats = reader.GetInt32(reader.GetOrdinal("Seats per Row"));
                        int rows = reader.GetInt32(reader.GetOrdinal("Rows of Seats"));
                        c = new Coach(coachID, seats, rows);
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
            return c;
        }

        public static List<Coach> getCoachesByRouteAndTimeIDAsList(int routeID, int timeID)
        {
            List<Coach> coaches = new List<Coach>();
            string command = "SELECT ebCoach.coach_ID as 'Coach ID', ebCoach.seats AS 'Seats per Row', ebCoach.rows AS 'Rows of Seats' " +
                "FROM ebCoach, ebJourney " +
                "WHERE ebCoach.coach_ID = ebJourney.coach_ID " +
                "AND ebJourney.route_ID = " + routeID + " " +
                "AND ebJourney.time_ID = " + timeID + ";";
            SqlCommand sqlCommand = new SqlCommand(command, DbConn.getInstance().Conn);
            DbConn.getInstance().open();
            try
            {
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(reader.GetOrdinal("Coach ID"));
                        int seats = reader.GetInt32(reader.GetOrdinal("Seats per Row"));
                        int rows = reader.GetInt32(reader.GetOrdinal("Rows of Seats"));
                        Coach c = new Coach(id, seats, rows);
                        coaches.Add(c);
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
            return coaches;
        }

        public static SqlDataAdapter getCoachesByRouteAndTimeIDAsSqlDataAdapter(int routeID, int timeID)
        {
            string selectCommand = "SELECT ebCoach.coach_ID AS 'Coach', ebCoach.rows AS 'Rows of seats', ebCoach.seats AS 'Seats per row' FROM ebCoach, ebJourney WHERE ebJourney.route_ID = " + routeID + " AND ebJourney.time_ID = " + timeID + " AND ebJourney.coach_ID = ebCoach.coach_ID";
            SqlDataAdapter adapter = new SqlDataAdapter(selectCommand, DbConn.getInstance().Conn.ConnectionString);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
            return adapter;
        }

        public static SqlDataAdapter getAllCoachesAsDataAdapter()
        {
            string selectCommand = "SELECT coach_ID AS 'Coach ID', seats AS 'Seats per Row', rows AS 'Rows of Seats' FROM ebCoach";
            SqlDataAdapter adapter = new SqlDataAdapter(selectCommand, DbConn.getInstance().Conn.ConnectionString);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
            return adapter;
        }

        #region Db persistence methods
        public bool insertToDb()
        {
            string command = "INSERT INTO ebCoach(seats, rows) VALUES (@Seats, @Rows)";

            SqlCommand sqlCommand = new SqlCommand(command, DbConn.getInstance().Conn);
            sqlCommand.Parameters.Add("@Seats", SqlDbType.Int);
            sqlCommand.Parameters.Add("@Rows", SqlDbType.Int);

            sqlCommand.Parameters["@Seats"].Value = this.seatsPerRow;
            sqlCommand.Parameters["@Rows"].Value = this.rowOfSeats;

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

        public bool updateInDb()
        {
            string command = "UPDATE ebCoach SET seats = @Seats, rows = @Rows WHERE coach_ID=@CoachID";

            SqlCommand sqlCommand = new SqlCommand(command, DbConn.getInstance().Conn);
            sqlCommand.Parameters.Add("@CoachID", SqlDbType.Int);
            sqlCommand.Parameters.Add("@Seats", SqlDbType.Int);
            sqlCommand.Parameters.Add("@Rows", SqlDbType.Int);

            sqlCommand.Parameters["@CoachID"].Value = this.id;
            sqlCommand.Parameters["@Seats"].Value = this.seatsPerRow;
            sqlCommand.Parameters["@Rows"].Value = this.rowOfSeats;

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

        public bool deleteFromDb()
        {
            string command = "DELETE FROM ebCoach WHERE coach_ID=@CoachID";

            SqlCommand sqlCommand = new SqlCommand(command, DbConn.getInstance().Conn);
            sqlCommand.Parameters.Add("@CoachID", SqlDbType.Int);

            sqlCommand.Parameters["@CoachID"].Value = this.id;

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
        #endregion

    }
}
