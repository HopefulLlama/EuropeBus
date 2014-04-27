using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using SqlDb;

namespace Model
{
    public class Movie
    {
        int id;
        string title, genre;
        int yearPublished;
        string ageRating, directorName;
        List<String> actors;
        #region Accessors and mutators
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        public int YearPublished
        {
            get { return yearPublished; }
            set { yearPublished = value; }
        }

        public string AgeRating
        {
            get { return ageRating; }
            set { ageRating = value; }
        }

        public string DirectorName
        {
            get { return directorName; }
            set { directorName = value; }
        }

        public List<String> Actors
        {
            get { return actors; }
            set { actors = value; }
        }
        #endregion
        #region Constructors
        public Movie()
        {
        }

        public Movie(int movieID, string title, string genre, int yearPublished, string ageRating, string directorName)
        {
            this.id = movieID;
            this.title = title;
            this.genre = genre;
            this.yearPublished = yearPublished;
            this.ageRating = ageRating;
            this.directorName = directorName;
            this.actors = new List<String>(); ;
        }

        public Movie(int movieID, string title, string genre, int yearPublished, string ageRating, string directorName, List<String> actors)
        {
            this.id = movieID;
            this.title = title;
            this.genre = genre;
            this.yearPublished = yearPublished;
            this.ageRating = ageRating;
            this.directorName = directorName;
            this.actors = actors;
        }
        #endregion
        public static Movie getMovieByID(int id)
        {
            MovieSearcher.SearcherSoapClient searcher = new MovieSearcher.SearcherSoapClient("SearcherSoap");
            MovieSearcher.Movie movie = searcher.getMovieByID(id);
            Movie m = new Movie(movie.Id, movie.Title, movie.Genre, movie.YearPublished, movie.AgeRating, movie.DirectorName, movie.Actors.ToList<String>());
            return m;
        }

        public static List<Movie> getAllMoviesAsList()
        {
            MovieSearcher.SearcherSoapClient searcher = new MovieSearcher.SearcherSoapClient("SearcherSoap");
            List<MovieSearcher.Movie> movies = searcher.getAllMovies().ToList<MovieSearcher.Movie>();
            List<Movie> ms = new List<Movie>();
            foreach (MovieSearcher.Movie movie in movies)
            {
                Movie m = convertFromWebService(movie);
                ms.Add(m);
            }
            return ms;
        }


        public static List<Movie> getMoviesByTitle(string title)
        {
            MovieSearcher.SearcherSoapClient searcher = new MovieSearcher.SearcherSoapClient("SearcherSoap");
            List<MovieSearcher.Movie> movies = searcher.getMoviesByTitle(title).ToList<MovieSearcher.Movie>();
            List<Movie> ms = new List<Movie>();
            foreach (MovieSearcher.Movie movie in movies)
            {
                Movie m = convertFromWebService(movie);
                ms.Add(m);
            }
            return ms;
        }

        private static Movie convertFromWebService(MovieSearcher.Movie movie){
            return new Movie(movie.Id, movie.Title, movie.Genre, movie.YearPublished, movie.AgeRating, movie.DirectorName, movie.Actors.ToList<String>());

        }
    }
}