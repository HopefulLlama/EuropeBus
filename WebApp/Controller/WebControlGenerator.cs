using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;

namespace WebApp.Controller
{
    public class WebControlGenerator
    {
        public static void showInfo(Route r, Panel p, bool listing)
        {
            Panel routePanel = new Panel();
            addRouteToPanel(r, routePanel, listing);
            routePanel.Width = new Unit(350);

            p.Controls.Add(routePanel);
        }

        public static void showInfo(Route r, DateTime operation, Panel p, bool listing)
        {
            showInfo(r, p, listing);
            Panel date = new Panel();
            date.Width = new Unit(200);
            Label header = new Label();
            header.Text = "Departure<br />";
            date.Controls.Add(header);

            Label dateTime = new Label();
            dateTime.Text = operation.ToString("dd/MM HH:mm") + "<br />";
            date.Controls.Add(dateTime);

            p.Controls.Add(date);

            Label breakLine = new Label();
            breakLine.Text = "<br /><br />";
            p.Controls.Add(breakLine);

        }

        public static void showInfo(Route r, DateTime operation, Coach c, Journey j, Panel p, bool listing)
        {
            showInfo(r, operation, p, listing);
            addCoachAndSeatInfoToPanel(operation, c, j, p, listing);
        }

        public static void addRouteToPanel(Route r, Panel p, bool listing)
        {
            Label header = new Label();
            if (listing)
            {
                header.Text = "<h2>Route " + r.Id + "</h2>";
                HyperLink link = new HyperLink();
                link.NavigateUrl = "..\\customer\\TimeListing.aspx?routeID=" + r.Id;
                link.Controls.Add(header);
                p.Controls.Add(link);
            }
            else
            {
                header.Text = "Route " + r.Id + "<br />";
                p.Controls.Add(header);
            }

            Table table = new Table();
            TableRow row = new TableRow();
            TableCell cell = new TableCell();

            cell.Width = new Unit(100);
            row.Cells.Add(cell);

            cell = new TableCell();
            cell.Text = "Departure";
            cell.Width = new Unit(100);
            cell.HorizontalAlign = HorizontalAlign.Center;
            row.Cells.Add(cell);

            cell = new TableCell();
            cell.Text = "Destination";
            cell.Width = new Unit(100);
            cell.HorizontalAlign = HorizontalAlign.Center;
            row.Cells.Add(cell);

            table.Rows.Add(row);
            row = new TableRow();

            cell = new TableCell();
            cell.Text = "Country";
            cell.HorizontalAlign = HorizontalAlign.Center;
            row.Cells.Add(cell);

            cell = new TableCell();
            cell.Text = r.DepartureCountry;
            row.Cells.Add(cell);

            cell = new TableCell();
            cell.Text = r.DestinationCountry;
            row.Cells.Add(cell);

            table.Rows.Add(row);
            row = new TableRow();

            cell = new TableCell();
            cell.Text = "Town";
            cell.HorizontalAlign = HorizontalAlign.Center;
            row.Cells.Add(cell);

            cell = new TableCell();
            cell.Text = r.DepartureTown;
            row.Cells.Add(cell);

            cell = new TableCell();
            cell.Text = r.DestinationTown;
            row.Cells.Add(cell);

            table.Rows.Add(row);
            table.GridLines = GridLines.Both;

            p.Controls.Add(table);

            Label price = new Label();
            price.Text = "Priced at £" + r.Price;
            p.Controls.Add(price);
            Label breakLine = new Label();
            breakLine.Text = "<br /><br />";
            p.Controls.Add(breakLine);
        }

        public static void addTimesToPanel(Route r, TimeOfWeek t, Panel p, bool listing)
        {
            Panel operationPanel = new Panel();
            Label header = new Label();
            string day = "";
            #region Switch statement 
            switch (t.DayOfWeek){
                case 0:
                    day = "Sunday";
                    break;
                case 1:
                    day = "Monday";
                    break;
                case 2:
                    day = "Tuesday";
                    break;
                case 3:
                    day = "Wednesday";
                    break;
                case 4:
                    day = "Thursday";
                    break;
                case 5:
                    day = "Friday";
                    break;
                case 6:
                    day = "Sunday";
                    break;
            }
            #endregion

            header.Text = day + " - " + t.Time.ToString().Substring(0, 5) +"<br />";
            operationPanel.Controls.Add(header);
            
            foreach(DateTime dt in t.NextOperations)
            {
                Label label = new Label();
                label.Text = dt.ToString("dd/MM HH:mm");
                if (listing)
                {
                    HyperLink link = new HyperLink();
                    link.NavigateUrl = "..\\customer\\CoachListing.aspx?routeID=" + r.Id + "&timeID=" + t.Id + "&operation=" + dt.ToString("dd/MM/yyyy HH:mm");
                    link.Controls.Add(label);
                    link.Width = new Unit(200);
                    operationPanel.Controls.Add(link);
                }
                else
                {
                    operationPanel.Controls.Add(label);
                }

            }
            Label breakLine = new Label();
            breakLine.Text = "<br /><br />";
            operationPanel.Controls.Add(breakLine);
            p.Controls.Add(operationPanel);
        }

        public static void addCoachAndSeatInfoToPanel(DateTime date, Coach c, Journey j, Panel p, bool listing)
        {
            Label header = new Label();
            if (listing)
            {
                header.Text = "<h2>Coach " + c.Id + "</h2>";
                HyperLink confirmBookingLink = new HyperLink();
                confirmBookingLink.NavigateUrl = "..\\customer\\ConfirmBooking.aspx?journeyID=" + j.Id + "&operation=" + date.ToString("dd/MM/yyyy HH:mm");
                confirmBookingLink.Controls.Add(header);
                p.Controls.Add(confirmBookingLink);
            }
            else
            {
                header.Text = "Coach " + c.Id + "<br />";
                p.Controls.Add(header);
            }

            Label seatsTaken = new Label();
            seatsTaken.Text = "Seats Taken: " + j.getSeatsTaken(date) + "<br />";
            p.Controls.Add(seatsTaken);

            Label capacity = new Label();
            capacity.Text = "Capacity: " + c.Capacity;
            p.Controls.Add(capacity);

            Label breakLine = new Label();
            breakLine.Text = "<br /><br />";
            p.Controls.Add(breakLine);
        }

        public static void addMovieToPanel(Movie m, Panel p, bool listing)
        {
            Label header = new Label();
            if (listing)
            {
                header.Text = "<h2>" + m.Title + " (" + m.YearPublished + ")</h2>";
                HyperLink link = new HyperLink();
                link.NavigateUrl = "..\\customer\\BookingListing.aspx?movieID=" + m.Id;
                link.Controls.Add(header);
                p.Controls.Add(link);
            }
            else
            {
                header.Text = m.Title + " (" + m.YearPublished + ")<br />";
                p.Controls.Add(header);
            }
            Label ageRating = new Label();
            ageRating.Text = "Age Rating: " + m.AgeRating + "<br />";
            p.Controls.Add(ageRating);

            Label genre = new Label();
            genre.Text = "Genre: " + m.Genre + "<br />";
            p.Controls.Add(genre);

            Label director = new Label();
            director.Text = "Director: " + m.DirectorName + "<br />";
            p.Controls.Add(director);

            Label actors = new Label();
            actors.Text = "Actors: ";
            int counter = 0;
            foreach (String actor in m.Actors)
            {
                if (counter == 0)
                {
                    actors.Text += actor;
                    counter++;
                }
                else
                {
                    actors.Text += ", " + actor;
                }
            }
            p.Controls.Add(actors);
            Label breakLine = new Label();
            breakLine.Text = "<br /><br />";
            p.Controls.Add(breakLine);
        }

        public static void addBookingToPanel(Movie m, Booking b, Panel p, bool hyperlink)
        {
            Journey j = Journey.getJourneyByID(b.JourneyID);
            Route r = Route.getRouteByID(j.RouteID);
            Coach c = Coach.getCoachByID(j.CoachID);

            Label header = new Label();
            header.Text = "<h2>Booking ID: " + b.BookingID + "</h2>";

            if (hyperlink)
            {
                HyperLink link = new HyperLink();
                link.NavigateUrl = "..\\customer\\ConfirmRental.aspx?movieID=" + m.Id + "&bookingID=" +b.BookingID;
                link.Controls.Add(header);
                p.Controls.Add(link);
            }
            else
            {
                p.Controls.Add(header);
            }
            Label seats = new Label();
            seats.Text = "Seats booked: " + b.NumberOfSeats + " <br />";
            p.Controls.Add(seats);
            Label movies = new Label();
            movies.Text = "Movies rented: ";
            foreach (Movie movie in b.Movies)
            {
                movies.Text += movie.Title + "; ";
            }
            movies.Text += "<br />";
            p.Controls.Add(movies);
            Label totalPrice = new Label();
            totalPrice.Text = "Total price: £" + b.TotalPrice + " <br /><br /";
            p.Controls.Add(totalPrice);
            showInfo(r, b.DateOfJourney, c, j, p, false);
            Label breakLine = new Label();
            breakLine.Text = "<br /><br />";
            p.Controls.Add(breakLine);
        }
    }
}