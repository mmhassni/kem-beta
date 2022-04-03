using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Diagnostics.CodeAnalysis;

namespace KEM.Commun.Exceptions
{
    [Serializable]
    public class BrokerException : Exception
    {
        public HttpStatusCode CodeHttp { get; } = HttpStatusCode.InternalServerError;

        [ExcludeFromCodeCoverage]
        public int IdEvenement { get; } = 200;

        public BrokerException(HttpStatusCode codeHttp, string message) : base(message)
        {
            CodeHttp = codeHttp;
        }

        [ExcludeFromCodeCoverage]
        protected BrokerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public BrokerException() : base()
        {
        }

        public BrokerException(string? message) : base(message)
        {
        }

        public BrokerException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
