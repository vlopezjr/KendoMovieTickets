using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using KendoMovieTickets.WebAPI.Common;

namespace KendoMovieTickets.WebAPI.Handlers
{
    public class AuthMessageHandler : DelegatingHandler
    {
        private string _userName;

        //protected override System.Threading.Tasks.Task<HttpResponseMessage>SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        //{
        //    if(ValidateCredentials(request.Headers.Authorization))
        //    {
        //        Thread.CurrentPrincipal = new MoviewTicketsPrincipal(_userName);
        //        HttpContext.Current.User = new MoviewTicketsPrincipal(_userName);

        //        return base.SendAsync(request,cancellationToken).ContinueWith(task=>
        //            HttpResponseMessage response = task.result;

        //        if()
        //            )
        //    }
        //}
    }
}