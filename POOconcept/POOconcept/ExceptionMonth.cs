using System.Runtime.Serialization;

namespace POOconcept
{
    [Serializable]
    internal class ExceptionMonth : Exception
    {
        public ExceptionMonth()
        {
        }

        public ExceptionMonth(string? message) : base(message)
        {
        }

        public ExceptionMonth(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected ExceptionMonth(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}