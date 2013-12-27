using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using KendoMovieTickets.WebAPI.BLL;
using KendoMovieTickets.WebAPI.BLL.BusinessObjects;

namespace KendoMovieTickets.WebAPI.Controllers
{
    public class MoviesController : ApiController
    {
        public List<MovieBO> Get(string id)
        {
            return MovieTicketsBLL.GetMovies(id);

        }
        public List<MovieBO> Get()
        {
            return MovieTicketsBLL.GetMovies("");
        }
    }
}
