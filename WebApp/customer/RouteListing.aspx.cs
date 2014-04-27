using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using WebApp.Controller;

namespace WebApp.customer
{
    public partial class RouteListing : System.Web.UI.Page
    {
        List<Route> routes;
        bool search;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["departureCountry"] != null)
            {
                DepartureCountryTextbox.Text = Request.QueryString["departureCountry"];
                search = true;
            }
            if (Request.QueryString["departureTown"] != null)
            {
                DepartureTownTextbox.Text = Request.QueryString["departureTown"];
                search = true;
            }
            if (Request.QueryString["destinationCountry"] != null)
            {
                DestinationCountryTextbox.Text = Request.QueryString["destinationCountry"];
                search = true;
            }
            if (Request.QueryString["destinationTown"] != null)
            {
                DestinationTownTextbox.Text = Request.QueryString["destinationTown"];
                search = true;
            }
            if (Request.QueryString["dateOfJourney"] != null)
            {
                DateTime date = DateTime.Parse(Request.QueryString["dateOfJourney"]);
                DateOfDepartureCalendar.SelectedDate = date;
                search = true;
            }
            if (Request.QueryString["numberOfPassengers"] != null)
            {
                NumberOfPassengersTextbox.Text = Request.QueryString["numberOfPassengers"];
                search = true;
            }
            if (!Search)
            {
                Routes = Route.getAllRoutesAsList();
            }
            else
            {
                int passengers = 0;
                int.TryParse(NumberOfPassengersTextbox.Text, out passengers);
                Routes = Route.getRoutesBySearchCriteria(DepartureCountryTextbox.Text, DepartureTownTextbox.Text, DestinationCountryTextbox.Text, DestinationTownTextbox.Text, DateOfDepartureCalendar.SelectedDate, passengers);
            }
            foreach(Route r in Routes)
            {
                WebControlGenerator.addRouteToPanel(r, routesPanel, true);
            }
        }

        public bool Search
        {
            get { return this.search; }
            set { this.search = value; }
        }
        public List<Route> Routes
        {
            get { return this.routes; }
            set { this.routes = value; }
        }

        protected void SearchLinkClicked(object sender, EventArgs e)
        {
            if (SearchPanel.Visible == false)
            {
                SearchPanel.Visible = true;
            }
            else
            {
                SearchPanel.Visible = false;
            }
        }

        protected void SubmitButtonClicked(object sender, EventArgs e)
        {
            StringBuilder url = new StringBuilder();
            url.Append("./RouteListing.aspx?page=1");
            #region Building command
            if (Request.QueryString["departureCountry"] != "")
            {
                url.Append("&departureCountry=" + DepartureCountryTextbox.Text);
            }
            if (DepartureTownTextbox.Text != "")
            {
                url.Append("&departureTown="+DepartureTownTextbox.Text);
            }
            if (DestinationCountryTextbox.Text != "")
            {
                url.Append("&destinationCountry="+DestinationCountryTextbox.Text);
            }
            if (DestinationTownTextbox.Text != "")
            {
                url.Append("&destinationTown=" + DestinationTownTextbox.Text);
            }
            if (DateOfDepartureCalendar.SelectedDate != DateTime.Parse("01/01/0001"))
            {
                url.Append("&dateOfDepature="+DateOfDepartureCalendar.SelectedDate.ToString("dd/MM/yyyy"));
            }
            if (NumberOfPassengersTextbox.Text != "")
            {
                url.Append("&numberOfPassengers="+NumberOfPassengersTextbox.Text);
            }
            #endregion
            HttpContext.Current.Response.Redirect(url.ToString());
        }
    }
}