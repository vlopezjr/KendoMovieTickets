using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KendoMovieTickets.WebAPI.BLL.BusinessObjects;

namespace KendoMovieTickets.WebAPI.BLL
{
    public class MovieRepository
    {
        public static List<MovieBO> moviesMasterList;

        public static List<MovieBO> GetMoviesMasterList()
        {
            if (moviesMasterList == null
                || moviesMasterList.Count == 0)
            {
                CreateMoviesMasterList();
            }
            return moviesMasterList;
        }

        private static void CreateMoviesMasterList()
        {
            moviesMasterList = new List<MovieBO>()
            {
                new MovieBO(){
                    MovieId = 1,
                    Name = "The Great Gatsby (2013)",
                    Genre = "Drama",
                    Image = "http://images.kendomobilebook.com/movies/greatgatsby.jpg",
                    IsNowPlaying = true,
                    LeadStars = "Leonardo DiCaprio, Amitabh Bachchan",
                    Length = "143",                    
                    Rating = "PG-13"
                },
                new MovieBO(){
                    MovieId = 2,
                    Name= "Iron man 3",
                    Genre= "Sci-Fi",
                    Image = "http://images.kendomobilebook.com/movies/ironman3.jpg",
                    IsNowPlaying = true,
                    LeadStars = "Robert Downey Jr., Gwyneth Paltrow",
                    Length = "130",                    
                    Rating = "PG-13"
                }
            };
        }
    }
}