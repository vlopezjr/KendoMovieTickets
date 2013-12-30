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
    public class AccountController : ApiController
    {
        public UserBO Get()
        {
            return MovieTicketsBLL.GetLoggedInUserDetails("username1");
        }

        public bool Post(UserBO updateUserDetails)
        {
            return true;
        }
    }
}
