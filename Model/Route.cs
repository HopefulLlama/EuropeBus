using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SqlDb;

namespace Model
{
    public class Route
    {
        private int id;
        private string departureCountry, departureTown, destinationCountry, destinationTown;
        private decimal price;

        #region Getters and Setters
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string DepartureCountry
        {
            get { return departureCountry; }
            set { departureCountry = value; }
        }

        public string DepartureTown
        {
            get { return departureTown; }
            set { departureTown = value; }
        }

        public string DestinationCountry
        {
            get { return destinationCountry; }
            set { destinationCountry = value; }
        }

        public string DestinationTown
        {
            get { return destinationTown; }
            set { destinationTown = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        #endregion

        #region Constructors
        public Route(int id, string departureCountry, string departureTown, string destinationCountry, string destinationTown, decimal price)
        {
            this.id = id;
            this.departureCountry = departureCountry;
            this.departureTown = departureTown;
            this.destinationCountry = destinationCountry;
            this.destinationTown = destinationTown;
            this.price = price;
        }

        public Route(string departureCountry, string departureTown, string destinationCountry, string destinationTown, decimal price)
        {
            this.id = 0;
            this.departureCountry = departureCountry;
            this.departureTown = departureTown;
            this.destinationCountry = destinationCountry;
            this.destinationTown = destinationTown;
            this.price = price;
        }
        #endregion

        public static Route getRouteByID(int id)
        {
            string command = "SELECT ebRoute.route_ID AS 'Route', ebRoute.departure_country AS 'Departure Country', ebRoute.departure_town AS 'Departure Town', ebRoute.destination_country AS 'Destination Country', ebRoute.destination_town AS 'Destination Town', ebRoute.price AS 'Price' " +
                    "FROM ebRoute" +
                    " WHERE ebRoute.route_ID = " + id + ";";
            SqlCommand sqlCommand = new SqlCommand(command, DbConn.getInstance().Conn);
            DbConn.getInstance().open();
            try
            {
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return createRouteFromDbRow(reader);
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

        public static List<Route> getAllRoutesAsList()
        {
            List<Route> routes = new List<Route>();

            string command = "SELECT ebRoute.route_ID AS 'Route', ebRoute.departure_country AS 'Departure Country', ebRoute.departure_town AS 'Departure Town', ebRoute.destination_country AS 'Destination Country', ebRoute.destination_town AS 'Destination Town', ebRoute.price AS 'Price' " +
                    "FROM ebRoute;";
            SqlCommand sqlCommand = new SqlCommand(command, DbConn.getInstance().Conn);
            DbConn.getInstance().open();
            try
            {
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        routes.Add(createRouteFromDbRow(reader));
                    }
                }
                return routes;
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

        public static List<Route> getRoutesBySearchCriteria(string departureCountry, string departureTown, string destinationCountry, string destinationTown, DateTime dateOfDeparture, int numberOfPassengers)
        {
            //Build up command
            StringBuilder command = new StringBuilder();
            #region Building command
            command.Append("SELECT DISTINCT ebRoute.route_ID AS 'Route', ebRoute.departure_country AS 'Departure Country', ebRoute.departure_town AS 'Departure Town', ebRoute.destination_country AS 'Destination Country', ebRoute.destination_town AS 'Destination Town', ebRoute.price AS 'Price' FROM ebRoute, ebJourney, ebTimeOfWeek, ebCoach WHERE ebJourney.route_ID = ebRoute.route_ID AND ebJourney.time_ID = ebTimeOfWeek.time_ID AND ebJourney.coach_ID = ebCoach.coach_ID");
            if(departureCountry != "")
            {
                command.Append(" AND ebRoute.departure_country LIKE @DepartureCountry");
            }
            if(departureTown != "")
            {
                command.Append(" AND ebRoute.departure_town LIKE @DepartureTown");
            }
            if(destinationCountry != "")
            {
                command.Append(" AND ebRoute.destination_country LIKE @DestinationCountry");
            }
            if(destinationTown != "")
            {
                command.Append(" AND ebRoute.destination_town LIKE @DestinationTown");
            }
            DateTime date = DateTime.Parse("01/01/0001 00:00:00");
            if(dateOfDeparture != date)
            {
                command.Append(" AND ebTimeOfWeek.day_ID = @DayID");
            }
            if (numberOfPassengers != 0)
            {
                command.Append(" AND (ebCoach.seats*ebCoach.rows) > @Passengers");
            }
            #endregion
            SqlCommand sqlCommand = new SqlCommand(command.ToString(), DbConn.getInstance().Conn);

            if (departureCountry != "")
            {
                sqlCommand.Parameters.AddWithValue("@DepartureCountry", "%"+departureCountry+"%");
            }
            if (departureTown != "")
            {
                sqlCommand.Parameters.AddWithValue("@DepartureTown", "%" + departureTown + "%");
            }
            if (destinationCountry != "")
            {
                sqlCommand.Parameters.AddWithValue("@DestinationCountry", "%" + destinationCountry + "%");
            }
            if (destinationTown != "")
            {
                sqlCommand.Parameters.AddWithValue("@DestinationTown", "%" + destinationTown + "%");
            }
            if (dateOfDeparture != date)
            {
                int dayID = 0;
                #region Switch case to convert DayOfWeek to int;
                switch (dateOfDeparture.DayOfWeek.ToString())
                {
                    case "Sunday":
                        dayID = 0;
                        break;
                    case "Monday":
                        dayID = 1;
                        break;
                    case "Tuesday":
                        dayID = 2;
                        break;
                    case "Wednesday":
                        dayID = 3;
                        break;
                    case "Thursday":
                        dayID = 4;
                        break;
                    case "Friday":
                        dayID = 5;
                        break;
                    case "Saturday":
                        dayID = 6;
                        break;
                }
                #endregion
                sqlCommand.Parameters.AddWithValue("@DayID", dayID);
            }
            if (numberOfPassengers != 0)
            {
                sqlCommand.Parameters.AddWithValue("@Passengers", numberOfPassengers);
            }
            List<Route> routes = new List<Route>();

            DbConn.getInstance().open();
            try
            {
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        routes.Add(createRouteFromDbRow(reader));
                    }
                }
                return routes;
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

        public static SqlDataAdapter getAllRoutesAsDataAdapter()
        {
            string selectCommand = "SELECT ebRoute.route_ID AS 'Route', ebRoute.departure_country AS 'Departure Country', ebRoute.departure_town AS 'Departure Town', ebRoute.destination_country AS 'Destination Country', ebRoute.destination_town AS 'Town', ebRoute.price AS 'Price' " +
                    "FROM ebRoute;";
            SqlDataAdapter adapter = new SqlDataAdapter(selectCommand, DbConn.getInstance().Conn.ConnectionString);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
            return adapter;
        }

        private static Route createRouteFromDbRow(SqlDataReader reader)
        {
            int id = reader.GetInt32(reader.GetOrdinal("Route"));
            string departureCountry = reader.GetString(reader.GetOrdinal("Departure Country"));
            string departureTown = reader.GetString(reader.GetOrdinal("Departure Town"));
            string destinationCountry = reader.GetString(reader.GetOrdinal("Destination Country"));
            string destinationTown = reader.GetString(reader.GetOrdinal("Destination Town"));
            decimal price = reader.GetDecimal(reader.GetOrdinal("Price"));
            Route r = new Route(id, departureCountry, departureTown, destinationCountry, destinationTown, price);
            return r;
        }

        #region Db persistence methods
        public bool insertToDb()
        {
            string command = "INSERT INTO ebRoute(departure_country, departure_town, destination_country, destination_town, price) VALUES (@DepartureCountry, @DepartureTown, @DestinationCountry, @DestinationTown, @Price)";

            SqlCommand sqlCommand = new SqlCommand(command, DbConn.getInstance().Conn);
            sqlCommand.Parameters.Add("@DepartureCountry", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@DepartureTown", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@DestinationCountry", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@DestinationTown", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@Price", SqlDbType.Decimal);

            sqlCommand.Parameters["@DepartureCountry"].Value = this.departureCountry;
            sqlCommand.Parameters["@DepartureTown"].Value = this.departureTown;
            sqlCommand.Parameters["@DestinationCountry"].Value = this.destinationCountry;
            sqlCommand.Parameters["@DestinationTown"].Value = this.destinationTown;
            sqlCommand.Parameters["@Price"].Value = this.price;

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
            string command = "UPDATE ebRoute SET departure_country = '@DepartureCountry', departure_town = '@DepartureTown', destinationCountry = '@DestinationCountry', destinationTown = '@DestinationTown', price = @Price WHERE route_ID=@RouteID";

            SqlCommand sqlCommand = new SqlCommand(command, DbConn.getInstance().Conn);
            sqlCommand.Parameters.Add("@RouteID", SqlDbType.Int);
            sqlCommand.Parameters.Add("@DepartureCountry", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@DepartureTown", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@DestinationCountry", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@DestinationTown", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@Price", SqlDbType.Decimal);

            sqlCommand.Parameters["@RouteID"].Value = this.id;
            sqlCommand.Parameters["@DepartureCountry"].Value = this.departureCountry;
            sqlCommand.Parameters["@DepartureTown"].Value = this.departureTown;
            sqlCommand.Parameters["@DestinationCountry"].Value = this.destinationCountry;
            sqlCommand.Parameters["@DestinationTown"].Value = this.destinationTown;
            sqlCommand.Parameters["@Price"].Value = this.price;

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
            string command = "DELETE FROM ebRoute WHERE route_ID=@Route";

            SqlCommand sqlCommand = new SqlCommand(command, DbConn.getInstance().Conn);
            sqlCommand.Parameters.Add("@Route", SqlDbType.Int);

            sqlCommand.Parameters["@Route"].Value = this.id;

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
