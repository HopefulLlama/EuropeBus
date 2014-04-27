using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace MovieDb
{
    /// <summary>
    /// Summary description for MovieSearcher
    /// </summary>
//    [WebService(Namespace = "http://stuiis.cms.gre.ac.uk/lj048/EuropeBus/MovieDb/Searcher.asmx")]
    //[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    //[System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    [WebService]
    public class Searcher : System.Web.Services.WebService
    {
        [WebMethod]
        public Movie getMovieByID(int id)
        {
            return Movie.getMovieByID(id);
        }

        [WebMethod]
        public List<Movie> getAllMovies()
        {
            return Movie.getAllMovies();
        }

        [WebMethod]
        public List<Movie> getMoviesByTitle(string title)
        {
            return Movie.getMoviesByTitle(title);
        }
    }
}