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
    public partial class CoachListing : System.Web.UI.Page
    {
        Route route;
        int timeID;
        DateTime operation;
        protected void Page_Load(object sender, EventArgs e)
        {
            timeID = int.Parse(Request.QueryString["timeID"]);
            operation = DateTime.Parse(Request.QueryString["operation"]);
            route = Route.getRouteByID(int.Parse(Request.QueryString["routeID"]));
            WebControlGenerator.showInfo(route, operation, infoPanel, false);

            List<Coach> coaches = Coach.getCoachesByRouteAndTimeIDAsList(route.Id, timeID);
            foreach (Coach c in coaches)
            {
                Journey j = new Journey(route.Id, timeID, c.Id);
                j.findIDFromDb();
                if(c.Capacity > j.getSeatsTaken(operation))
                {
                    WebControlGenerator.addCoachAndSeatInfoToPanel(operation, c, j, coachPanel, true);
                }
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