using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using SqlDb;

namespace Model
{
    public class Journey
    {
        private int id;
        private int routeID, timeID, coachID;
        private int initialRouteID, initialTimeID, initialCoachID;

        #region Getters and Setters
        public int Id
        {
            get { return id; }
        }

        public int RouteID
        {
          get { return routeID; }
          set { routeID = value; }
        }

        public int TimeID
        {
          get { return timeID; }
          set { timeID = value; }
        }

        public int CoachID
        {
            get { return coachID; }
            set { coachID = value; }
        }
        #endregion

        public Journey(int id, int routeID, int timeID, int coachID)
        {
            this.id = id;
            this.routeID = routeID;
            this.timeID = timeID;
            this.coachID = coachID;

            this.initialRouteID = routeID;
            this.initialTimeID = timeID;
            this.initialCoachID = coachID;
        }
        public Journey(int routeID, int timeID, int coachID)
        {
            this.id = 0;
            this.routeID = routeID;
            this.timeID = timeID;
            this.coachID = coachID;

            this.initialRouteID = routeID;
            this.initialTimeID = timeID;
            this.initialCoachID = coachID;

        }

        public void findIDFromDb()
        {
            string command = "SELECT * " +
                "FROM ebJourney " +
                "WHERE ebJourney.route_ID = " + this.routeID + " " +
                "AND ebJourney.time_ID = " + this.timeID + " " +
                "AND ebJourney.coach_ID = " + this.coachID + ";";
            SqlCommand sqlCommand = new SqlCommand(command, DbConn.getInstance().Conn);
            DbConn.getInstance().open();
            try
            {
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        this.id = reader.GetInt32(reader.GetOrdinal("journey_ID"));
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
        }

        public int getSeatsTaken(DateTime dateOfJourney)
        {
            int seatsTaken = 0;
            string command = "SELECT SUM(ebBooking.numberOfSeats) AS seatsTaken " +
                "FROM ebBooking " + 
                "WHERE ebBooking.journey_ID = "+this.id+ " "+ 
                "AND ebBooking.dateOfJourney = '"+dateOfJourney.ToString()+"';";
            SqlCommand sqlCommand = new SqlCommand(command, DbConn.getInstance().Conn);
            DbConn.getInstance().open();
            try
            {
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        seatsTaken = reader.GetInt32(reader.GetOrdinal("seatsTaken"));
                    }
                }
            }
            catch (ArgumentOutOfRangeException aoorex)
            {
                return 0;
            }
            catch (Exception ex)
            {
                return 0;
            }
            finally
            {
                DbConn.getInstance().close();
            }
            return seatsTaken;
        }

        public static Journey getJourneyByID(int id)
        {
            List<Route> routes = new List<Route>();

            string command = "SELECT * FROM ebJourney WHERE journey_ID = " + id + ";";
            SqlCommand sqlCommand = new SqlCommand(command, DbConn.getInstance().Conn);
            DbConn.getInstance().open();
            try
            {
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int journeyID = reader.GetInt32(reader.GetOrdinal("journey_ID"));
                        int routeID = reader.GetInt32(reader.GetOrdinal("route_ID"));
                        int timeID = reader.GetInt32(reader.GetOrdinal("time_ID"));
                        int coachID = reader.GetInt32(reader.GetOrdinal("coach_ID"));
                        Journey j = new Journey(journeyID, routeID, timeID, coachID);
                        return j;
                    }
                    else
                    {
                        return null;
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
        }

        public bool insertToDb()
        {
            string command = "INSERT INTO ebJourney(route_ID, time_ID, coach_ID) VALUES (@Route, @Time, @Coach)";

            SqlCommand sqlCommand = new SqlCommand(command, DbConn.getInstance().Conn);
            sqlCommand.Parameters.Add("@Route", SqlDbType.Int);
            sqlCommand.Parameters.Add("@Time", SqlDbType.Int);
            sqlCommand.Parameters.Add("@Coach", SqlDbType.Int);
            
            sqlCommand.Parameters["@Route"].Value = routeID;
            sqlCommand.Parameters["@Time"].Value = timeID;
            sqlCommand.Parameters["@Coach"].Value = coachID;

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
            string command = "UPDATE ebJourney SET route_ID = @NewRouteID, time_ID = @NewTimeID, coach_ID=@NewCoachID WHERE route_ID=@NewRouteID AND time_ID=@OldTimeID AND coach_ID=@OldCoachID";

            SqlCommand sqlCommand = new SqlCommand(command, DbConn.getInstance().Conn);
            sqlCommand.Parameters.Add("@NewRouteID", SqlDbType.Int);
            sqlCommand.Parameters.Add("@NewTimeID", SqlDbType.Int);
            sqlCommand.Parameters.Add("@NewCoachID", SqlDbType.Int);
            sqlCommand.Parameters.Add("@OldRouteID", SqlDbType.Int);
            sqlCommand.Parameters.Add("@OldTimeID", SqlDbType.Int);
            sqlCommand.Parameters.Add("@OldCoachID", SqlDbType.Int);

            sqlCommand.Parameters["@NewRouteID"].Value = this.routeID;
            sqlCommand.Parameters["@NewTimeID"].Value = this.timeID;
            sqlCommand.Parameters["@NewCoachID"].Value = this.coachID;
            sqlCommand.Parameters["@OldRouteID"].Value = this.initialRouteID;
            sqlCommand.Parameters["@OldTimeID"].Value = this.initialTimeID;
            sqlCommand.Parameters["@OldCoachID"].Value = this.initialCoachID;

            DbConn.getInstance().Conn.Open();
                int affectedRows = sqlCommand.ExecuteNonQuery();
            DbConn.getInstance().Conn.Close();
            
            if (affectedRows > 0)
            {
                this.initialRouteID = this.routeID;
                this.initialTimeID = this.timeID;
                this.initialCoachID = this.coachID;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool deleteFromDb()
        {
            string command = "DELETE FROM ebJourney WHERE route_ID=@Route AND time_ID=@Time AND coach_ID=@Coach";

            SqlCommand sqlCommand = new SqlCommand(command, DbConn.getInstance().Conn);
            sqlCommand.Parameters.Add("@Route", SqlDbType.Int);
            sqlCommand.Parameters.Add("@Time", SqlDbType.Int);
            sqlCommand.Parameters.Add("@Coach", SqlDbType.Int);
            
            sqlCommand.Parameters["@Route"].Value = this.routeID;
            sqlCommand.Parameters["@Time"].Value = this.timeID;
            sqlCommand.Parameters["@Coach"].Value = this.coachID;

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
