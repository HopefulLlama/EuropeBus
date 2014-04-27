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
    public partial class MyBooking : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Customer user = (Customer)Session["user"];
                List<Booking> bookings = Booking.getBookingsByCustomerID(user.Id);
                foreach (Booking b in bookings)
                {
                    WebControlGenerator.addBookingToPanel(null, b, mainContent, false);
                }
            }
        }

    }
}