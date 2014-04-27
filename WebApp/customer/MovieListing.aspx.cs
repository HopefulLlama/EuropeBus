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
    public partial class MovieListing : System.Web.UI.Page
    {
        List<Movie> movies;
        bool search;

        protected void Page_Load(object sender, EventArgs e)
        {
            search = (Request.QueryString["movieTitle"] != null);
            if (search)
            {
                movies = Movie.getMoviesByTitle(Request.QueryString["movieTitle"]);
            }
            else
            {
                movies = Movie.getAllMoviesAsList();
            }

            foreach (Movie m in movies)
            {
                WebControlGenerator.addMovieToPanel(m, moviesPanel, true);
            }
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
            if (MovieTitleTextbox.Text != "")
            {
                HttpContext.Current.Response.Redirect("../customer/MovieListing.aspx?movieTitle="+MovieTitleTextbox.Text.ToString());
            }
        }
    }
}