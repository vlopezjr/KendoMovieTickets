using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Principal;

namespace KendoMovieTickets.WebAPI.Common
{
    public class MoviewTicketsPrincipal : IPrincipal
    {
        public string UserName { get; set; }
        public IIdentity Identity { get; set; }
        

        public bool IsInRole(string role)
        {
            if(role.Equals("user"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public MoviewTicketsPrincipal(string userName)
        {
            UserName = userName;
            Identity = new GenericIdentity(userName);
        }
    }
}