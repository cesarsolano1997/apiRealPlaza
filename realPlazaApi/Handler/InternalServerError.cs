using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace realPlazaApi.Handler
{
    public class InternalServerError : IHttpActionResult
    {
        Error _error;

        public InternalServerError()
        {

        }

        public InternalServerError(string message)
        {
            _error = new Error()
            {
                Message = message
            };
        }


        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            var response = new HttpResponseMessage(HttpStatusCode.InternalServerError)
            {
                Content = new ObjectContent<Error>(_error, new JsonMediaTypeFormatter())
            };
            var tsc = new TaskCompletionSource<HttpResponseMessage>();
            tsc.SetResult(response);
            return tsc.Task;

        }

        public class Error
        {
            public bool Valid { get; set; }
            public string Message { get; set; }
            public object Data { get; set; }

            public Error()
            {
                Valid = false;
            }
        }
    }
}