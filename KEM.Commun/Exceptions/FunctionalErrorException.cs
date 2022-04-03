using KEM.Commun.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace KEM.Commun.Exceptions
{
    public class FunctionalErrorException : Exception
    {
        public ErrorDetail Detail { get; } = new ErrorDetail();
        public virtual int IdEvenement { get; } = 100;

        public FunctionalErrorException() : base()
        {
        }

        public FunctionalErrorException(string message) : base(message)
        {
            Detail.Description = message;
        }

        public FunctionalErrorException(string message, Exception? innerException) : base(message, innerException)
        {
            Detail.Description = message;
        }

        protected FunctionalErrorException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public FunctionalErrorException(ErrorDetail detail) : base()
        {
            Detail = detail;
        }

        public FunctionalErrorException(HttpStatusCode codeHttp, string codeMessage, params string[] parametres) :
            this(new ErrorDetail { CodeHttp = codeHttp, CodeMessage = codeMessage, Parametres = parametres })
        {
        }

    }
}
