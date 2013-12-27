using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KendoMovieTickets.WebAPI.BLL.BusinessObjects;

namespace KendoMovieTickets.WebAPI.BLL
{
    public class MovieTicketsBLL
    {
        public static List<MovieBO> GetMovies(string searchKeyword)
        {
            var moviesMasterList = MovieRepository.GetMoviesMasterList();

            if (!string.IsNullOrEmpty(searchKeyword))
            {
                return (from m in moviesMasterList
                        where m.Name.StartsWith(searchKeyword,
                       StringComparison.CurrentCultureIgnoreCase)
                        select m
                        ).ToList();
            }
            else
            {
                return moviesMasterList;
            }
        }
    }
}