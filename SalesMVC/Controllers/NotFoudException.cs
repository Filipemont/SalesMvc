using System;
using System.Runtime.Serialization;

namespace SalesMVC.Controllers
{
    [Serializable]
    internal class NotFoudException : Exception
    {
        public NotFoudException()
        {
        }

        public NotFoudException(string message) : base(message)
        {
        }

        public NotFoudException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotFoudException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}