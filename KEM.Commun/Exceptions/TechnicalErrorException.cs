using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace KEM.Commun.Exceptions
{
    public class TechnicalErrorException : Exception
    {
        public TechnicalErrorException()
        {
        }

        public TechnicalErrorException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        public TechnicalErrorException(string messageErreur) : base(messageErreur)
        {
        }

        [ExcludeFromCodeCoverage]
        private TechnicalErrorException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

    }
}
