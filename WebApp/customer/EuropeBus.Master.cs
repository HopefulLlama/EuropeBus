using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using WebApp.Controller;

namespace WebApp.EuropeBus
{
    public partial class EuropeBus : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void LogIn_Click(object sender, EventArgs e)
        {
            if (txtboxLogInEmail.Text != null && txtboxLogInPassword != null)
            {
                Customer user = LogInHandler.logIn(txtboxLogInEmail.Text, txtboxLogInPassword.Text);
                if (user != null)
                {
                    Session["user"] = user;
                    HttpContext.Current.Response.Write("<SCRIPT LANGUAGE=\"\"JavaScript\"\">alert(\"Log in successful!\")</SCRIPT>");
                }
                else
                {
                    HttpContext.Current.Response.Write("<SCRIPT LANGUAGE=\"\"JavaScript\"\">alert(\"Log in failed due to incorrect credentials. Please try again.\")</SCRIPT>");
                }
            }
            else
            {
                HttpContext.Current.Response.Write("<SCRIPT LANGUAGE=\"\"JavaScript\"\">alert(\"Both E-mail and Password should be filled in.\")</SCRIPT>");
            }
        }

        protected void buttonLogOut_Click(object sender, EventArgs e)
        {
            Session["user"] = null;
            HttpContext.Current.Response.Write("<SCRIPT LANGUAGE=\"\"JavaScript\"\">alert(\"Log out successful!\")</SCRIPT>");
        }
    }
}