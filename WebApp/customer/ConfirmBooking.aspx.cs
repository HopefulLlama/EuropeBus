using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApp.Controller;
using Model;
using SeatingAllocationComponent;

namespace WebApp.customer
{
    public partial class ConfirmBooking : System.Web.UI.Page
    {
        Journey j;
        Route r;
        Coach c;
        DateTime operation;
        TextBox bookingAmountTextbox;

        protected void Page_Load(object sender, EventArgs e)
        {
            foreach (Control c in mainContent.Controls)
            {
                mainContent.Controls.Remove(c);
            }
            if (Session["user"] != null)
            {
                Panel infoPanel = new Panel();
                j = Journey.getJourneyByID(int.Parse(Request.QueryString["journeyID"]));
                r = Route.getRouteByID(j.RouteID);
                c = Coach.getCoachByID(j.CoachID);
                operation = DateTime.Parse(Request.QueryString["operation"]);
                WebControlGenerator.showInfo(r, operation, c, j, infoPanel, false);
                mainContent.Controls.Add(infoPanel);

                Label breakLine = new Label();
                breakLine.Text = "<br />";
                mainContent.Controls.Add(breakLine); 
                mainContent.Controls.Add(breakLine);

                Label bookingAmountLabel = new Label();
                bookingAmountLabel.Text = "Number of seats to be reserved: ";
                bookingAmountLabel.CssClass = "FormLabel";
                mainContent.Controls.Add(bookingAmountLabel);
                
                bookingAmountTextbox = new TextBox();
                bookingAmountTextbox.TextMode = TextBoxMode.Number;
                mainContent.Controls.Add(bookingAmountTextbox);

                mainContent.Controls.Add(breakLine);

                Button confirmBookingButton = new Button();
                confirmBookingButton.Text = "Confirm booking!";
                confirmBookingButton.Click += confirmBookingButton_Click;
                mainContent.Controls.Add(confirmBookingButton);
            }
            else
            {
                Label logInPrompt = new Label();
                logInPrompt.Text = "To complete your booking, please use the log in control at the top of the page in order to authenticate your identity.";
                mainContent.Controls.Add(logInPrompt);
            }
        }

        private void confirmBookingButton_Click(object sender, EventArgs e)
        {
            int bookingAmount = int.Parse(bookingAmountTextbox.Text);
            int seatsRemaining = c.Capacity - j.getSeatsTaken(operation);
            if (bookingAmount > 0)
            {
                if (bookingAmount < seatsRemaining)
                {
                    Customer user = (Customer)Session["user"];
                    Booking booking = new Booking(user.Id, j.Id, operation, bookingAmount);
                    if (booking.insertToDb())
                    {
                        SeatAllocator.allocateSeats(Booking.getBookingsByJourneyIDAndDateAsList(j.Id, operation), c);
                        HttpContext.Current.Response.Write("<SCRIPT LANGUAGE=\"\"JavaScript\"\">alert(\"Booking successful! You will now be redirected.\")</SCRIPT>");
                        HttpContext.Current.Response.Redirect("../customer/RouteListing.aspx");
                    }
                    else
                    {
                        HttpContext.Current.Response.Write("<SCRIPT LANGUAGE=\"\"JavaScript\"\">alert(\"Booking failed. Please try again.\")</SCRIPT>");
                    }
                }
                else
                {
                    HttpContext.Current.Response.Write("<SCRIPT LANGUAGE=\"\"JavaScript\"\">alert(\"Only " + seatsRemaining + " are remaining. Please enter a lower number.\")</SCRIPT>");
                }
            }
            else
            {
                HttpContext.Current.Response.Write("<SCRIPT LANGUAGE=\"\"JavaScript\"\">alert(\"Please enter a number higher than zero.\")</SCRIPT>");
            }
        }
    }
}