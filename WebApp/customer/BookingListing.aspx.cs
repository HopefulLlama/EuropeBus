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
    public partial class BookingListing : System.Web.UI.Page
    {
        Movie m;
        protected void Page_Load(object sender, EventArgs e)
        {
            m = Movie.getMovieByID(int.Parse(Request.QueryString["movieID"]));
            if (Session["user"] != null)
            {
                Label helpText = new Label();
                helpText.Text = "Now that you have selected a movie, please select one of your bookings to attach it to. Please note that movie rentals are an additional £4 per movie.";
                summaryPanel.Controls.Add(helpText);
                WebControlGenerator.addMovieToPanel(m, infoPanel, false);

                Customer user = (Customer)Session["user"];
                List<Booking> bookings = Booking.getBookingsByCustomerID(user.Id);
                foreach (Booking b in bookings)
                {
                    WebControlGenerator.addBookingToPanel(m, b, mainContent, true);
                }
            }
            else
            {
                infoPanel.Visible = false;
                infoLinkPanel.Visible = false;
                Label logInPrompt = new Label();
                logInPrompt.Text = "To complete your booking, please use the log in control at the top of the page in order to authenticate your identity.";
                mainContent.Controls.Add(logInPrompt);
            }
        }

        protected void InfoLinkClicked(object sender, EventArgs e)
        {
            if (infoPanel.Visible == false)
            {
                infoPanel.Visible = true;
            }
            else
            {
                infoPanel.Visible = false;
            }
        }

    }
}