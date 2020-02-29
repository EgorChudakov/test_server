using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Controllers;
using System.Web.Http.Routing;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web.Http;
using BookingApp.Models;
using System.Data;


namespace BookingApp.Controllers
{
    public class myController : IHttpController
    {
        parserscontext db = new parserscontext();

        public IEnumerable<parser> Getparsers()
        {
            return db.parsers;
        }

        public Task<HttpResponseMessage> ExecuteAsync(HttpControllerContext context,
                                  CancellationToken cancellationToken)
        {
            return Task<HttpResponseMessage>.Run(() =>
            {
                //IHttpRouteData rd = context.RouteData;
                //string requestInfo = "Контроллер: " + context.ControllerDescriptor.ControllerName + ", ";
                //requestInfo += " Url: " + context.Request.RequestUri + ", " +
                //  " " + "Метод: " + context.Request.Method.Method;
                // double result = 1.3 * sum;
                //string output = String.Format(requestInfo); //В данном случае получаем название контроллера, запрошенный путь, а также метод http.
                /*string output = "Неверный запрос";
                if (rd.Values.ContainsKey("id"))
                {
                   // int sum;
                    if (int.TryParse((string)rd.Values["id"], out sum) && sum > 0)
                    {
                        string requestInfo = "Контроллер: " +context.ControllerDescriptor.ControllerName;
                        requestInfo += " Url: " + context.Request.RequestUri +
                            " " + context.Request.Method.Method;
                       // double result = 1.3 * sum;
                        output = String.Format(requestInfo); //В данном случае получаем название контроллера, запрошенный путь, а также метод http.
                    }
                }*/
                return context.Request.CreateResponse(HttpStatusCode.OK,Getparsers());//получаю данные с db parsers
            });
        }
    }
}