using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using WebApp.Controller;

namespace WebApp.customer
{
    public partial class ConfirmRental : System.Web.UI.Page
    {
        Booking booking;
        Movie movie;
        protected void Page_Load(object sender, EventArgs e)
        {
            movie = Movie.getMovieByID(int.Parse(Request.QueryString["movieID"]));

            if (Session["user"] != null)
            {
                Label helpText = new Label();
                helpText.Text = "Check below and confirm the booking.";
                mainContent.Controls.Add(helpText);
                Panel moviePanel = new Panel();
                mainContent.Controls.Add(moviePanel);
                WebControlGenerator.addMovieToPanel(movie, moviePanel, false);

                Customer user = (Customer)Session["user"];
                booking = Booking.getBookingByID(int.Parse(Request.QueryString["bookingID"].ToString()));
                Panel bookingPanel = new Panel();
                mainContent.Controls.Add(bookingPanel);
                WebControlGenerator.addBookingToPanel(movie, booking, bookingPanel, false);

                Button confirm = new Button();
                confirm.Text = "Confirm rental";
                confirm.Click += confirm_Click;
                mainContent.Controls.Add(confirm);
            }
            else
            {
                Label logInPrompt = new Label();
                logInPrompt.Text = "To complete your booking, please use the log in control at the top of the page in order to authenticate your identity.";
                mainContent.Controls.Add(logInPrompt);
            }
        }

        void confirm_Click(object sender, EventArgs e)
        {
            Rental rental = new Rental(booking.BookingID, movie.Id);
            if(rental.insertToDb())
            {
                HttpContext.Current.Response.Write("<SCRIPT LANGUAGE=\"\"JavaScript\"\">alert(\"Rental successful! You will now be redirected.\")</SCRIPT>");
                HttpContext.Current.Response.Redirect("../customer/RouteListing.aspx");
            }
            else
            {
                HttpContext.Current.Response.Write("<SCRIPT LANGUAGE=\"\"JavaScript\"\">alert(\"Rental failed. Please try again.\")</SCRIPT>");
            }
        }
    }
}