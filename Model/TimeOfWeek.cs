using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlDb;

namespace Model
{
    public class TimeOfWeek
    {
        private static int numberOfOperations = 4;
        private int id, dayOfWeek;
        private TimeSpan time;
        List<DateTime> nextOperations;

        #region Getters and Setters
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int DayOfWeek
        {
            get { return dayOfWeek; }
            set { dayOfWeek = value; }
        }

        public TimeSpan Time
        {
            get { return time; }
            set { time = value; }
        }

        public List<DateTime> NextOperations
        {
            get { return nextOperations; }
            set { }
        }
        #endregion

        public TimeOfWeek(int id, int dayOfWeek, TimeSpan time)
        {
            this.Id = id;
            this.DayOfWeek = dayOfWeek;
            this.Time = time;
            nextOperations = new List<DateTime>();
        }

        public void setNextOperations()
        {
            nextOperations = new List<DateTime>();
            DateTime today = DateTime.Today;
            int daysUntil = (this.dayOfWeek - (int)today.DayOfWeek + 7) % 7;
            DateTime operation = today.AddDays(daysUntil);
            operation = operation.AddHours(this.time.Hours);
            operation = operation.AddMinutes(this.time.Minutes);
            operation = operation.AddSeconds(this.time.Seconds);
            nextOperations.Add(operation);

            for (int i = 0; i < numberOfOperations - 1; i++)
            {
                DateTime nextOperation = nextOperations.Last<DateTime>().AddDays(7);
                nextOperations.Add(nextOperation);
            }
        }

        public static List<TimeOfWeek> getTimesByRouteIDAsList(int routeID)
        {
            List<TimeOfWeek> times = new List<TimeOfWeek>();
            string command = "SELECT ebTimeOfWeek.time_ID, ebTimeOfWeek.day_ID, ebTimeOfWeek.time " +
                "FROM ebTimeOfWeek, ebJourney " +
                "WHERE ebTimeOfWeek.time_ID = ebJourney.time_ID " + 
                "AND ebJourney.route_ID = "+routeID+";";
            SqlCommand sqlCommand = new SqlCommand(command, DbConn.getInstance().Conn);
            DbConn.getInstance().open();
            try
            {
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(reader.GetOrdinal("time_ID"));
                        int day = reader.GetInt32(reader.GetOrdinal("day_ID"));
                        TimeSpan time = reader.GetTimeSpan(reader.GetOrdinal("time"));
                        TimeOfWeek t = new TimeOfWeek(id, day, time);
                        times.Add(t);
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
            return times;
        }

        public static SqlDataAdapter getTimesByRouteIDAsSqlDataAdapter(int routeID)
        {
            string selectCommand = "SELECT ebTimeOfWeek.time_ID AS 'Time ID', ebDay.day AS 'Day', ebTimeOfWeek.time as 'Time' FROM ebTimeOfWeek, ebDay, ebJourney WHERE ebJourney.route_ID = " + routeID + " AND ebJourney.time_ID = ebTimeOfWeek.time_ID AND ebTimeOfWeek.day_ID = ebDay.day_ID";
            SqlDataAdapter adapter = new SqlDataAdapter(selectCommand, DbConn.getInstance().Conn.ConnectionString);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
            return adapter;
        }
    }
}
