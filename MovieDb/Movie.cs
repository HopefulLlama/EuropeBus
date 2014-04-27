using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace MovieDb
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

        public Movie(int id, string title, string genre, int yearPublished, string ageRating, string directorName)
        {
            this.id = id;
            this.title = title;
            this.genre = genre;
            this.yearPublished = yearPublished;
            this.ageRating = ageRating;
            this.directorName = directorName;
            this.actors = new List<String>(); ;
        }

        public Movie(int id, string title, string genre, int yearPublished, string ageRating, string directorName, List<String> actors)
        {
            this.id = id;
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
            int movieID = 0, yearPublished = 0;
            string title = "", genre= "", ageRating = "", directorName = "";
            List<String> actorNames = new List<String>();
            OleDbDataReader reader = null;
            OleDbCommand command = new OleDbCommand("SELECT Director.FirstName, Director.Surname, Genre.Genre,  Movie.Movie_ID, Movie.Title, Movie.Year_Published, Movie.Age_Rating FROM  Director, Genre, Movie " +
                "WHERE Genre.Genre_ID = Movie.FK_Genre_ID " + 
                "AND Director.Director_ID = Movie.FK_Director_ID " +
                "AND Movie.Movie_Id = " + id, DbConn.getInstance().Conn);
            DbConn.getInstance().Conn.Open();
            Movie movie = null;
            try
            {
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    movieID = int.Parse(reader["Movie_ID"].ToString());
                    title = reader["Title"].ToString();
                    genre = reader["Genre"].ToString();
                    yearPublished = int.Parse(reader["Year_Published"].ToString());
                    ageRating = reader["Age_Rating"].ToString();
                    directorName = reader["FirstName"].ToString() + " " + reader["Surname"].ToString();
                    movie = new Movie(movieID, title, genre, yearPublished, ageRating, directorName);
                }
            }
            catch (Exception e)
            {
            }
            finally{
                DbConn.getInstance().Conn.Close();
            }
            if(movie != null)
            {
                command = new OleDbCommand("SELECT Actor.FirstName, Actor.Surname FROM Actor, Actor_Movie " + 
                    "WHERE Actor.Actor_Id = Actor_Movie.FK_Actor_Id " +
                    "AND Actor_Movie.FK_Movie_Id = " + movieID, DbConn.getInstance().Conn);
                DbConn.getInstance().Conn.Open();
                try
                {
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string actorName = reader["FirstName"].ToString() + " " + reader["Surname"].ToString();
                        actorNames.Add(actorName);
                    }
                    movie.Actors = actorNames;
                }
                catch (Exception e)
                {
                }
                finally{
                    DbConn.getInstance().Conn.Close();
                }
            }
            return movie;
        }

        public static List<Movie> getAllMovies()
        {
            int movieID = 0, yearPublished = 0;
            string title = "", genre= "", ageRating = "", directorName = "";
            List<String> actorNames = new List<String>();
            OleDbDataReader reader = null;
            OleDbCommand command = new OleDbCommand("SELECT Director.FirstName, Director.Surname, Genre.Genre,  Movie.Movie_ID, Movie.Title, Movie.Year_Published, Movie.Age_Rating FROM  Director, Genre, Movie " +
                "WHERE Genre.Genre_ID = Movie.FK_Genre_ID " + 
                "AND Director.Director_ID = Movie.FK_Director_ID ", DbConn.getInstance().Conn);
            DbConn.getInstance().Conn.Open();
            List<Movie> movies = new List<Movie>();
            try
            {
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    movieID = int.Parse(reader["Movie_ID"].ToString());
                    title = reader["Title"].ToString();
                    genre = reader["Genre"].ToString();
                    yearPublished = int.Parse(reader["Year_Published"].ToString());
                    ageRating = reader["Age_Rating"].ToString();
                    directorName = reader["FirstName"].ToString() + " " + reader["Surname"].ToString();
                    Movie m = new Movie(movieID, title, genre, yearPublished, ageRating, directorName);
                    movies.Add(m);
                }
            }
            catch (Exception e)
            {
            }
            finally{
                DbConn.getInstance().Conn.Close();
            }
            foreach(Movie m in movies)
            {
                actorNames = new List<String>();
                command = new OleDbCommand("SELECT Actor.FirstName, Actor.Surname FROM Actor, Actor_Movie " + 
                    "WHERE Actor.Actor_Id = Actor_Movie.FK_Actor_Id " +
                    "AND Actor_Movie.FK_Movie_Id = " + m.Id, DbConn.getInstance().Conn);
                DbConn.getInstance().Conn.Open();
                try
                {
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string actorName = reader["FirstName"].ToString() + " " + reader["Surname"].ToString();
                        actorNames.Add(actorName);
                    }
                    m.Actors = actorNames;
                }
                catch (Exception e)
                {
                }
                finally{
                    DbConn.getInstance().Conn.Close();
                }
            }
            return movies;
        }

        public static List<Movie> getMoviesByTitle(string title)
        {
            int movieID = 0, yearPublished = 0;
            string movieTitle = "", genre = "", ageRating = "", directorName = "";
            List<String> actorNames = new List<String>();
            OleDbDataReader reader = null;
            OleDbCommand command = new OleDbCommand();
            command.Connection = DbConn.getInstance().Conn;
            command.CommandText= "SELECT Director.FirstName, Director.Surname, Genre.Genre,  Movie.Movie_ID, Movie.Title, Movie.Year_Published, Movie.Age_Rating FROM  Director, Genre, Movie " +
                "WHERE Genre.Genre_ID = Movie.FK_Genre_ID " +
                "AND Director.Director_ID = Movie.FK_Director_ID " +
                "AND Movie.Title LIKE ?";
            command.Parameters.Add("Title", OleDbType.VarChar, 50);
            command.Parameters["Title"].Value = "%" + title + "%";
            DbConn.getInstance().Conn.Open();

            command.Prepare();
            List<Movie> movies = new List<Movie>();
            try
            {
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    movieID = int.Parse(reader["Movie_ID"].ToString());
                    movieTitle = reader["Title"].ToString();
                    genre = reader["Genre"].ToString();
                    yearPublished = int.Parse(reader["Year_Published"].ToString());
                    ageRating = reader["Age_Rating"].ToString();
                    directorName = reader["FirstName"].ToString() + " " + reader["Surname"].ToString();
                    Movie m = new Movie(movieID, movieTitle, genre, yearPublished, ageRating, directorName);
                    movies.Add(m);
                }
            }
            catch (Exception e)
            {
            }
            finally
            {
                DbConn.getInstance().Conn.Close();
            }
            foreach (Movie m in movies)
            {
                actorNames = new List<String>();
                command = new OleDbCommand("SELECT Actor.FirstName, Actor.Surname FROM Actor, Actor_Movie " +
                    "WHERE Actor.Actor_Id = Actor_Movie.FK_Actor_Id " +
                    "AND Actor_Movie.FK_Movie_Id = " + m.Id, DbConn.getInstance().Conn);
                DbConn.getInstance().Conn.Open();
                try
                {
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string actorName = reader["FirstName"].ToString() + " " + reader["Surname"].ToString();
                        actorNames.Add(actorName);
                    }
                    m.Actors = actorNames;
                }
                catch (Exception e)
                {
                }
                finally
                {
                    DbConn.getInstance().Conn.Close();
                }
            }
            return movies;
        }
    }
}