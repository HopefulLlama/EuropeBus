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
    public partial class TimeListing : System.Web.UI.Page
    {
        Route route;
        protected void Page_Load(object sender, EventArgs e)
        {
            route = Route.getRouteByID(int.Parse(Request.QueryString["routeID"]));
            WebControlGenerator.showInfo(route, infoPanel, false);

            List<TimeOfWeek> schedule = TimeOfWeek.getTimesByRouteIDAsList(route.Id);
            foreach (TimeOfWeek t in schedule)
            {
                t.setNextOperations();
                WebControlGenerator.addTimesToPanel(route, t, timesPanel, true);
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